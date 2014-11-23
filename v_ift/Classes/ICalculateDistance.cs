using System.Collections.Generic;
using v_ift.Models;

namespace v_ift.Classes
{
    public interface ICalculateDistance
    {
         decimal GetDistanceBetween(List<Coordinate> coordinates);
    }
}