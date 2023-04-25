using System;

namespace PPuke6
{
    internal class Airplane : Vehicle
    {

        private int _wingspan;
        private int _loadingCapacity;
        private int _specificWeight;
        private string _type;
        private bool _driving;

        public Airplane(string regnum, int power, int wingspan, int loadingCapacity, int specificWeight, string type)
            : base(regnum, power)
        {
            _wingspan = wingspan;
            _loadingCapacity = loadingCapacity;
            _specificWeight = specificWeight;
            _type = type;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Vingespenn: {_wingspan}m");
            Console.WriteLine($"Lasteevne: {_loadingCapacity} tonn");
            Console.WriteLine($"Egenvekt: {_specificWeight} tonn");
            Console.WriteLine($"Type: {_type}");
        }

        public void Drive()
        {
            _driving = !_driving;
            Status();
        }

        public void Status()
        {
            if (_driving)
            {
                Console.WriteLine($"Dette {_type}et er på flytur");
            }
            else Console.WriteLine($"{_type}et har landa");
        }
    }
}
