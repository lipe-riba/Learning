using System.Windows;

namespace AshProjeto.Model
{
    public class Coord
    {
        private Point point;

        public Coord()
        {
            this.point = new Point(0, 0);
        }

        public Point N => new Point(0, -1);
        public Point S => new Point(0, 1);
        public Point E => new Point(1, 0);
        public Point O => new Point(-1, 0);

        private Point StringToPoint(char cardinal)
        {
            if (cardinal == 'N')
                return this.N;
            if (cardinal == 'S')
                return this.S;
            if (cardinal == 'E')
                return this.E;
            if (cardinal == 'O')
                return this.O;
            return new Point(0, 0);
        }

        public void MoveTo(char cardinal)
        {
            Point p = StringToPoint(cardinal);
            point.X += p.X;
            point.Y += p.Y;
        }

        public override string ToString()
        {
            return string.Format("{0}:{1}", this.point.X.ToString(), this.point.Y.ToString());
        }
    }
}
