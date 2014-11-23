using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Nancy;
using Nancy.ModelBinding;
using v_ift.Models;
using v_ift.ResponseModels;

namespace v_ift.NancyModules
{
    public class Ready : NancyModule
    {
        public Ready()
        {
            Post["/ready", true] = async (x, ct) =>
            {
                var currentPlayerReady = this.Bind<ReadyModel>();

                if (currentPlayerReady == null)
                {
                    return null;
                }

                // hämta upp rummet. 
                var lobby = new Lobby();
                var players = new List<Player>();

                // sätt spelaren till ready
                var currentPlayer = new Player();
                currentPlayer.IsReady = true; 

                // spara ner spelaren 
                // spara ner lobbyn med ny status kanske 


                var countReadyPlayers = players.Count(arg => arg.IsReady);
                var newStatus = lobby.Count == countReadyPlayers ? Enums.Status.Ongoing : Enums.Status.Waiting; 

                var status = new Lobby()
                {
                    Status = newStatus,
                    LobbyGuid = new Guid(),
                    Players = players
                };

                return this.Response.AsJson(status);
            };
        }
    }
}