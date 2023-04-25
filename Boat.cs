using System;

namespace PPuke6
{
    internal class Boat : Vehicle
    {
        private int _maxSpeed;
        private int _grossWeight;

        public Boat(string regNum, int power, int maxSpeed, int grossWeight)
            : base(regNum, power)
        {
            _maxSpeed = maxSpeed;
            _grossWeight = grossWeight;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Hastighet: {_maxSpeed} knop");
            Console.WriteLine($"Bruttotonnasje: {_grossWeight} tonn");
        }
    }
}
