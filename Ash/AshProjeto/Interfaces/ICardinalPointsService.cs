using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Interfaces
{
    public interface ICardinalPointsService
    {
        int GetTotalPokemonsByCardinalPoint(IList<Point> cardinalPoint);
        IList<Point> ToPoints(string cardinalPoints);
    }
}
