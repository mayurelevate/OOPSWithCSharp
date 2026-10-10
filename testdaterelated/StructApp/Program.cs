using System;

namespace StructApp
{
    public struct Car
    {

        // Declaring different data types
        public string Brand;
        public string Model;
        public string Color;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Declare c1 of type Car
            // no need to create an 
            // instance using 'new' keyword
            Car c1;

            // c1's data
            c1.Brand = "Bugatti";
            c1.Model = "Bugatti Veyron EB 16.4";
            c1.Color = "Gray";

            // Displaying the values
            Console.WriteLine("Name of brand: " + c1.Brand +
                              "\nModel name: " + c1.Model +
                              "\nColor of car: " + c1.Color);
        }
    }
}
