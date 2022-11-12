using System.Collections.Generic;
using System.Windows;

namespace AshProjeto.Model
{
    public class Coord
    {
        public Point N => new Point(0, -1);
        public Point S => new Point(0, 1);
        public Point E => new Point(1, 0);
        public Point O => new Point(-1, 0);
        public Point ZERO => new Point(0, 0);
    }
}
