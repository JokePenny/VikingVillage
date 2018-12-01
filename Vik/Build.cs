namespace Vik
{
    abstract class Build
    {
        public byte x;
        public byte y;
        public ushort health;// здоровье
        public Build(byte X, byte Y, ushort Health)
        {
            x = X;
            y = Y;
            health = Health;
        }
        public Build(byte X, byte Y)
        {
            x = X;
            y = Y;
        }
        public Build()
        {
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
	}
}
