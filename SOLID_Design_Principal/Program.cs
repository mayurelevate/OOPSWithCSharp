using SOLID_Design_Principal.DIP;
using SOLID_Design_Principal.ISP;
using SOLID_Design_Principal.LSP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID_Design_Principal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region LSP - Liskov Subtitution Principle

            var rec = new Rectangle();
            rec.Height = 4;
            rec.Width = 5;

            Console.WriteLine($"Actual Area Rectangle : {rec.Area}");

            var sq = new Square();
            sq.SideLength = 5;


            Console.WriteLine($"Actual Area of SQuare : {sq.Area}");

            #endregion

            #region ISP - Interface Segrgation Principle 

            // For 2D 
            var circle = new Circle();
            circle.Radius = 5;
            circle.Area();

            // For 3D
            var sph = new Sphere();
            sph.Radius = 5;
            sph.Area();
            sph.volume();

            #endregion

            #region DIP - Dependency Inversion Principle
            // High level module should not depends on low-level module,
            // Both should depends on abstraction.

            //var car = new Car(new Engine());

            //IDatabase db = new SqlDatabase(); // Can easily switch to SQL DB
            IDatabase db = new MongoDatabase(); // Can easily switch to Mongo DB
            DataProcessor dp = new DataProcessor(db);

            dp.Process("Mayur Rock Data Passed");


            #endregion
        }
    }
}
