using AshProjeto.Interfaces;
using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Models
{
    public sealed class CardinalPoints : ICardinalPoints
    {
        public Point N 
        {
            get
            {
                return new Point(0, -1);
            }
        } 

        public Point S 
        { 
            get 
            { 
                return new Point(0, 1); 
            } 
        }

        public Point E
        {
            get
            {
                return new Point(1, 0);
            }
        }

        public Point O
        {
            get
            {
                return new Point(-1, 0);
            }
        }

        public static Point ZERO
        {
            get
            {
                return new Point(0, 0);
            }
        }
        
        public Dictionary<string, Point> ToDictionary() 
        {
            return new Dictionary<string, Point>()
            {
                {"N", N },
                {"S", S },
                {"E", E },
                {"O", O }
            };
        }
    }
}
