using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    class ResourceVillage
    {
        private ushort eat = 0;
        private ushort stone = 0;
        private ushort gold = 0;
        private ushort forest = 0;
        private short population = 5;
        private ushort boards = 0;
        private ushort brick = 0;
        private ushort passedDay = 0;
        private byte clock = 0;

        // максимальные значения ресурсов
        private ushort eatMax = 100;
        private ushort stoneMax = 10;
        private ushort goldMax = 0;
        private ushort forestMax = 10;
        private short populationMax = 10;
        private ushort boardsMax = 0;
        private ushort brickMax = 0;

        //геттеры

        public ushort GetEat()
        {
            return eat;
        }
        public ushort GetStone()
        {
            return stone;
        }
        public ushort GetGold()
        {
            return gold;
        }
        public ushort GetForest()
        {
            return forest;
        }
        public short GetPopulation()
        {
            return population;
        }
        public ushort GetBoards()
        {
            return boards;
        }
        public ushort GetBrick()
        {
            return brick;
        }
        public ushort GetPassedDay()
        {
            return passedDay;
        }
        public byte GetClock()
        {
            return clock;
        }

        //макс
        public ushort GetEatMax()
        {
            return eatMax;
        }
        public ushort GetStoneMax()
        {
            return stoneMax;
        }
        public ushort GetGoldMax()
        {
            return goldMax;
        }
        public ushort GetForestMax()
        {
            return forestMax;
        }
        public short GetPopulationMax()
        {
            return populationMax;
        }
        public ushort GetBoardsMax()
        {
            return boardsMax;
        }
        public ushort GetBrickMax()
        {
            return brick;
        }


        //сеттеры

        public void SetEat(ushort A)
        {
            eat = A;
        }
        public void SetStone(ushort A)
        {
            stone = A;
        }
        public void SetGold(ushort A)
        {
            gold = A;
        }
        public void SetForest(ushort A)
        {
            forest = A;
        }
        public void SetPopulation(short A)
        {
            population = A;
        }
        public void SetBoards(ushort A)
        {
            boards = A;
        }
        public void SetBrick(ushort A)
        {
            brick = A;
        }
        public void SetPassedDay(ushort A)
        {
            passedDay = A;
        }
        public void SetClock(byte A)
        {
            clock = A;
        }

        //макс

        public void SetEatMax(ushort A)
        {
            eatMax = A;
        }
        public void SetStoneMax(ushort A)
        {
            stoneMax = A;
        }
        public void SetGoldMax(ushort A)
        {
            goldMax = A;
        }
        public void SetForestMax(ushort A)
        {
            forestMax = A;
        }
        public void SetPopulationMax(short A)
        {
            populationMax = A;
        }
        public void SetBoardsMax(ushort A)
        {
            boardsMax = A;
        }
        public void SetBrickMax(ushort A)
        {
            brickMax = A;
        }

    }
}
