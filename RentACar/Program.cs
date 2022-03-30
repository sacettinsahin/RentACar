using System;

namespace RentACar
{
    class Program
    {
        static void Main(string[] args)
        {
            Car vehicle1 = new Car();
            vehicle1.Brand = "BMW";
            vehicle1.Model = "i5x20";
            vehicle1.Year = 2018;
            vehicle1.Price = 450000;

            Car vehicle2 = new Car();
            vehicle2.Brand = "Mercedes";
            vehicle2.Model = "CLA200";
            vehicle2.Year = 2015;
            vehicle2.Price = 350000;

            Car[] cars = new Car[] { vehicle1, vehicle2 };

            foreach (var car in cars)
            {
                Console.WriteLine(car.Brand);
                Console.WriteLine(car.Model);
                Console.WriteLine(car.Year);
                Console.WriteLine(car.Price);
                Console.WriteLine("-------------------");
            }
        }
    }
}
