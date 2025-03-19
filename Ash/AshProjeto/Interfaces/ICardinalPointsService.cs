using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Interfaces
{
    public interface ICardinalPointsService
    {
        int GetTotalPokemons(IList<Point> points);
        IList<Point> ToPoints(string cardinalPoints);
    }
}
