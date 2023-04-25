using System;

namespace PPuke6
{
    internal class Vehicle
    {
        private string _regNum;
        private int _power;

        public Vehicle(string regNum, int power)
        {
            _regNum = regNum;
            _power = power;
        }

        public virtual void Show()
        {
            Console.WriteLine($"Registreringsnummer: {_regNum}");
            Console.WriteLine($"Effekt: {_power}kw");
        }

        public string GetRegNum()
        {
            return _regNum;
        }

        public int GetPower()
        {
            return _power;
        }
    }
}
