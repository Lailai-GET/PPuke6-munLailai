using System;

namespace PPuke6
{
    internal class Car : Vehicle
    {
        private int _maxSpeed;
        private string _color;
        private string _type;
        private bool _driving;

        public Car(string regNum, int power, int maxSpeed, string color, string typeOfVehicle)
            : base(regNum, power)
        {
            _maxSpeed = maxSpeed;
            _color = color;
            _type = typeOfVehicle;
        }

        public override void Show()
        {
            base.Show();
            Console.WriteLine($"Maksfart: {_maxSpeed}km/t");
            Console.WriteLine($"Farge: meget fin {_color}");
            Console.WriteLine($"Type: {_type}");
        }

        public virtual void Drive()
        {
            _driving = !_driving;
            Status();
        }

        public virtual void Status()
        {
            if (_driving)
            {
                Console.WriteLine($"Dette {_type}et er på kjøretur");
            }
            else Console.WriteLine($"{_type}et er parkert");
        }

        public override bool Equals(object obj)
        {
            var otherCar = obj as Car;

            if (GetRegNum() == otherCar.GetRegNum() &&
                GetPower() == otherCar.GetPower() &&
                _maxSpeed == otherCar._maxSpeed &&
                _color == otherCar._color &&
                _type == otherCar._type)
            {
                return true;
            }
            return false;
        }
    }
}
