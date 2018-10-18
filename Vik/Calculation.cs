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

        static public byte CheckBuildCreate(byte coordBuildX, byte numberBuild)
        {
            if (coordBuildX == 254)
                return numberBuild;
            else return 254;
        }

        static public byte SearchDeleteBuild(byte coordx1, byte coordy1, byte coordx2, byte coordy2)
        {
            if (coordx1 == coordx2 && coordy1 == coordy2)
                return 1;
            else return 0;
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
    }
}
