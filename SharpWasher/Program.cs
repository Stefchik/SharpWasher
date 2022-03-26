using System;

namespace SharpWasher
{
    class Program
    {
        public static void Wash(Car car)
        {
            Console.WriteLine($"Машина {car.Name} помыта");
        }
        static void Main()
        {
            var toyota = new Car("Toyota", 2010);
            var bmw = new Car("BMW", 2014);
            var garage = new Garage<Car>() { toyota, bmw };
            foreach (var item in garage)
            {
                var washer = new Washer(Wash);
                washer(item);
            }
        }
    }
}
