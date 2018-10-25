﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Vik
{
    class Buildgoldmine : Build
    {
        private byte distance;// растояние 
        private byte ID = 11;// индефикатор объекта 


        public Buildgoldmine(byte X, byte Y, byte Distance) : base(X, Y)
        {
            x = X;
            y = Y;
            distance = Distance;
        }
        public Buildgoldmine()
        {
        }

        public void SetImage()
        {
            Form2.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\builds\\images\\tree_279.png");
        }

        public void SetDeleteImage()
        {
            Form2.arr[x, y].BackgroundImage = Image.FromFile("D:\\01Programms\\PHCS6\\Project\\Vikings\\images\\tree_03.png");
        }

        //геттеры

        public byte GetX()
        {
            return x;
        }
        public byte GetY()
        {
            return y;
        }
        public ushort GetHealth()
        {
            return health;
        }
        public byte GetDistance()
        {
            return distance;
        }
        public byte GetID()
        {
            return ID;
        }

        //сеттеры

        public void SetX(byte A)
        {
            x = A;
        }
        public void SetY(byte A)
        {
            y = A;
        }
        public void SetHealth(ushort A)
        {
            health = A;
        }
        public void SetDistance(byte A)
        {
            distance = A;
        }
    }
}
