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
        public Buildheadquarters Headquarters;
        public Buildhome[] Home;
        public Buildmarket Market;
        public BuildWall[] Wall;
        public Buildstorage[] Storage;
        public BuildBarn[] Barn;
        public BuildBarracks[] Barracks;
        public BuildGoldRec GoldRec;
        public BuildStoneRec StoneRec;
        public BuildWoodRec WoodRec;
        public BuildPort Port;
        public BuildSanctuary[] Sanctuary;
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
        public Buildheadquarters GetHeadquarters()
        {
            return Headquarters;
        }
        public Buildhome[] GetHome()
        {
            return Home;
        }
        public Buildmarket GetMarket()
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
        public BuildBarn[] GetBarn()
        {
            return Barn;
        }
        public BuildBarracks[] GetBarrracks()
        {
            return Barracks;
        }
        public BuildGoldRec GetGoldRec()
        {
            return GoldRec;
        }
        public BuildStoneRec GetStoneRec()
        {
            return StoneRec;
        }
        public BuildWoodRec GetWoodRec()
        {
            return WoodRec;
        }
        public BuildSanctuary[] GetSanctuary()
        {
            return Sanctuary;
        }
        public BuildPort GetPort()
        {
            return Port;
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
        public void SetHeadquarters(Buildheadquarters A)
        {
            Headquarters = A;
        }
        public void SetHome(Buildhome[] A)
        {
            Home = A;
        }
        public void SetMarket(Buildmarket A)
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
        public void SetBarn(BuildBarn[] A)
        {
            Barn = A;
        }
        public void SetBarracks(BuildBarracks[] A)
        {
            Barracks = A;
        }
        public void SetGoldRec(BuildGoldRec A)
        {
            GoldRec = A;
        }
        public void SetStoneRec(BuildStoneRec A)
        {
            StoneRec = A;
        }
        public void SetWoodRec(BuildWoodRec A)
        {
            WoodRec = A;
        }
        public void SetSanctuary(BuildSanctuary[] A)
        {
            Sanctuary = A;
        }
        public void SetPort(BuildPort A)
        {
            Port = A;
        }
    }
}
