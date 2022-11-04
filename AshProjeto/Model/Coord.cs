using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Model
{
    public class Coord
    {
        private Dictionary<string, Point> _points;

        public Coord()
        {
            _points = new Dictionary<string, Point>()
            {
                {"N", N },
                {"S", S },
                {"E", E },
                {"O", O }
            };
        }

        public static Point N => new Point(0, -1);
        public static Point S => new Point(0, 1);
        public static Point E => new Point(1, 0);
        public static Point O => new Point(-1, 0);

        public static Point ZERO => new Point(0, 0);

        public bool Valid(char cardinal)
        {
            return _points.ContainsKey(cardinal.ToString());
        }

        public Point ToPoint(char cardinal)
        {
            return _points[cardinal.ToString()];
        }
    }
}
