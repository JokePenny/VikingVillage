namespace Vik
{
    public class Calculation
    {
        static public byte DistanceCalc(byte userPointX, byte userPointY, byte coordBuildX, byte coordBuildY, byte coordBaseX, byte coordBaseY)
        {
            byte x = 0;
            for (byte i = 0; i < x + 1; i++)
            {
                if (userPointY > coordBuildY)
                    userPointY--;
                else if (userPointY < coordBuildY)
                    userPointY++;
                if (userPointX > coordBuildX)
                    userPointX--;
                else if (userPointX < coordBuildX)
                    userPointX++;
                if (userPointY == coordBuildY && userPointX == coordBuildX)
                {
                    x++;
                    i = 254;
                }
                else
                {
                    x++;
                }
            }

            for (int i = 0; i < x; i++)
            {
                if (userPointY > coordBaseY)
                    userPointY--;
                else if (userPointY < coordBaseY)
                    userPointY++;
                if (userPointX > coordBaseX)
                    userPointX--;
                else if (userPointX < coordBaseX)
                    userPointX++;
                if (userPointY == coordBaseY && userPointX == coordBaseX)
                {
                    x++;
                    i = 254;
                }
                else
                    x++;
            }
            return x;
        }

        static public byte DistanceCalc(byte userPointX, byte userPointY, byte coordBaseX, byte coordBaseY)
        {
            byte x = 0;
            for (int i = 0; i < x + 1; i++)
            {
                if (userPointY > coordBaseY)
                    userPointY--;
                else if (userPointY < coordBaseY)
                    userPointY++;
                if (userPointX > coordBaseX)
                    userPointX--;
                else if (userPointX < coordBaseX)
                    userPointX++;
                if (userPointY == coordBaseY && userPointX == coordBaseX)
                {
                    x++;
                    i = 254;
                }
                else
                    x++;
            }
            return x;
        }

        static public void Filling(byte coordx, byte coordy, ushort health, byte distance)
        {
            coordx = 254;
            coordy = 254;
            health = 0;
            distance = 254;
        }

        static public string ReligionChoose(byte relig)
        {
            if (relig == 0)
                return "Язычник";
            else
                return "Христьянин";
        }

        // магазин

        static public sbyte CoeffCalcul(sbyte coef)
        {
            if (coef > 50)
                return 1;
            else if (coef <= 50 && coef >= 0)
                return 2;
            else if (coef > -50 && coef < 0)
                return 3;
            else
                return 4;
        }

        static public string Price(ushort price1, ushort price2, ushort price3, double money)
        {
            if (price1 + price2 + price3 > money)
                return "Недостаточно денег!";
            else
                return "";
        }

        static public string Price(ushort price1, ushort price2, double money)
        {
            if (price1 + price2 > money)
                return "Недостаточно денег!";
            else
                return "";
        }
    }
}
