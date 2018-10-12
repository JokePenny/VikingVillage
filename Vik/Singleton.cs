using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vik
{
    public sealed class Singleton
    {
        static Singleton() { }

        private Singleton() { }

        private static readonly Singleton source = new Singleton();

        public static Singleton Source
        {
            get
            {
                return source;
            }
        }
    }
}
