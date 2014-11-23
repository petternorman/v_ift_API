﻿using System.Collections.Generic;
using System.Linq;
using v_ift.Classes;
using v_ift.Classes.Repositories;
using v_ift.Models;
using Nancy;
using Nancy.ModelBinding;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
    public class Position : NancyModule
    {
        public Position(Repository repository, ICalculateDistance calculateDistance)
        {
            Post["/position", true] = async (x, ct) =>
            {
                var request = this.Bind<PositionModel>();

                if (request == null)
                {
                    return null;
                }

                var lobby = repository.GetLobby(request.LobbyId);
                var player = lobby.Players.FirstOrDefault(arg => arg.Id == request.PlayerId);

                if (player.Coordinates == null)
                {
                    player.Coordinates = new List<Coordinate>();
                }

                player.Coordinates.Add(new Coordinate(request.Lat, request.Lng));

                var distance = calculateDistance.GetDistanceBetween(player.Coordinates);
                player.Distance = distance;

                player.IsWinner = distance >= lobby.Distance;

                lobby.Status = this.IsFinsh(lobby.Players, distance) ? Enums.Status.Finish : Enums.Status.Ongoing;

                repository.SaveLobby(lobby);

                return this.Response.AsJson(new Lobby(lobby, player.Id));
            };
        }

        private bool IsFinsh(IEnumerable<PlayerDataModel> players, decimal distance)
        {
            var isFinsh = false;
            foreach (var player in players)
            {
                if (player.Distance >= distance)
                {
                    isFinsh = player.Distance >= distance;
                }

                else
                {
                    return false;
                }
            }
            return isFinsh;
        }
    }
}