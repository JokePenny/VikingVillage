using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                    i = 255;
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
                    i = 255;
                }
                else
                    x++;
            }
            return x;
        }
    }
}
