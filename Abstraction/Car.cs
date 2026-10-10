using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    public class Car
    {
        private string _CarName = "BMW";
        private string _CarColor = "RED";


        public string CarName 
        {
            get 
            {
                return _CarName;
            } 
            set
            {
                this._CarName = value;
            }
        }

        public string CarColor 
        {
            get
            {
                return _CarColor;
            }
            set
            {
                this._CarColor = value;
                
            }
        
        }


        public void Steering()
        {
            Console.WriteLine("Streering of Car");
        }

        public void Break()
        {
            Console.WriteLine("Break of Car");
        }

        public void Gear()
        {
            Console.WriteLine("Gear of Car");
        }

        public void Start()
        {
            this.CarEngine();
            this.DiesalEngine();
            this.Silencer();
        }


        private void CarEngine()
        {
            Console.WriteLine("CarEngine of Car");
        }

        private void DiesalEngine()
        {
            Console.WriteLine("DiesalEngine of the Car");
        }

        private void Silencer()
        {
            Console.WriteLine("Silencer of the Car");
        }
    }
}
