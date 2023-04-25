using System;

namespace PPuke6
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var car1 = new Car("NF123456", 147, 200, "grønn", "lett kjøretøy");
            var car2 = new Car("NF654321", 150, 195, "blå", "lett kjøretøy");
            var plane = new Airplane("LN1234", 1000, 30, 2, 10, "jetfly");
            var boat = new Boat("ABC123", 100, 30, 500);

            car1.Show();
            car2.Show();
            car1.Equals(car2);
            plane.Show();
            plane.Drive();
            car1.Drive();
            boat.Show();

            Console.ReadKey(true);
        }
    }
}
