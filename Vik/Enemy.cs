using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    public class Enemy
    {
        protected byte x;// координата горизонтали
        protected byte y;// координата вертикали

        private EnemyEasy[] EnEasy;
        private EnemyMedium[] EnMedium;
        private EnemyHeavy[] EnHeavy;

        // геттеры
        public EnemyEasy[] GetEnEasy()
        {
            return EnEasy;
        }

        public EnemyMedium[] GetEnMedium()
        {
            return EnMedium;
        }

        public EnemyHeavy[] GetEnHeavy()
        {
            return EnHeavy;
        }
        //сеттеры

        public void SetEnEasy(EnemyEasy[] A)
        {
            EnEasy = A;
        }

        public void SetEnMedium(EnemyMedium[] A)
        {
            EnMedium = A;
        }

        public void SetEnHeavy(EnemyHeavy[] A)
        {
            EnHeavy = A;
        }
    }
}
