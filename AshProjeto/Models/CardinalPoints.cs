using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Models
{
    public sealed class CardinalPoints
    {
        public static Point N 
        {
            get
            {
                return new Point(0, -1);
            }
        } 

        public static Point S 
        { 
            get 
            { 
                return new Point(0, 1); 
            } 
        }

        public static Point E
        {
            get
            {
                return new Point(1, 0);
            }
        }

        public static Point O
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

        public static Dictionary<string, Point> ToDictionary() 
        {
            return new Dictionary<string, Point>()
            {
                {"N", CardinalPoints.N },
                {"S", CardinalPoints.S },
                {"E", CardinalPoints.E },
                {"O", CardinalPoints.O }
            };
        }
    }
}
