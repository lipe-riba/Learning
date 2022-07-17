namespace AshProjeto.Model
{
    public class Coord
    {
        private int posX;
        private int posY;

        public void move(char position)
        {
            switch (position)
            {
                case 'N': //North
                    posX -= 1;
                    break;
                case 'S': //South
                    posX += 1;
                    break;
                case 'E': //East
                    posY += 1;
                    break;
                case 'O': //West
                    posY -= 1;
                    break;
            }
            return;
        }

        public override string ToString()
        {
            return posX.ToString() + ":" + posY.ToString();
        }
    }
}
