using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vik
{
    public class Build
    {
        protected byte x;
        protected byte y;
        protected ushort health;// здоровье

        public Buildgoldmine[] Goldmine;
        public Buildquarry[] Quarry;
        public Buildsawmill[] Sawmill;
        public Buildfield[] Field;
        public Buildheadquarters[] Headquarters;
        public Buildhome[] Home;
        public Buildmarket[] Market;
        public BuildWall[] Wall;
        public Buildstorage[] Storage;
/*
        public Build(byte x, byte y, ushort Health)
    : base(x,y)
        {
            health = Health;
        }
        */

        // геттеры
        public Buildgoldmine[] GetGoldmine()
        {
            return Goldmine;
        }
        public Buildquarry[] GetQuarry()
        {
            return Quarry;
        }
        public Buildsawmill[] GetSawmill()
        {
            return Sawmill;
        }
        public Buildfield[] GetField()
        {
            return Field;
        }
        public Buildheadquarters[] GetHeadquarters()
        {
            return Headquarters;
        }
        public Buildhome[] GetHome()
        {
            return Home;
        }
        public Buildmarket[] GetMarket()
        {
            return Market;
        }
        public BuildWall[] GetWall()
        {
            return Wall;
        }
        public Buildstorage[] GetStorage()
        {
            return Storage;
        }

        //сеттеры

        public void SetGoldmine(Buildgoldmine[] A)
        {
            Goldmine = A;
        }
        public void SetQuarry(Buildquarry[] A)
        {
            Quarry = A;
        }
        public void SetSawmill(Buildsawmill[] A)
        {
            Sawmill = A;
        }
        public void SetField(Buildfield[] A)
        {
            Field = A;
        }
        public void SetHeadquarters(Buildheadquarters[] A)
        {
            Headquarters = A;
        }
        public void SetHome(Buildhome[] A)
        {
            Home = A;
        }
        public void SetMarket(Buildmarket[] A)
        {
            Market = A;
        }
        public void SetWall(BuildWall[] A)
        {
            Wall = A;
        }
        public void SetStorage(Buildstorage[] A)
        {
            Storage = A;
        }
    }
}
