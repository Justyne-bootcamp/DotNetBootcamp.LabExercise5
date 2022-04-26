using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.LabExercise5.Number4
{
    class Exercise4
    {
        interface IVehicle
        {
            public void Drive();
            public bool Refuel(int amountOfGasolineRefuel);
        }
        class Car : IVehicle
        {
            public int InitialGasolineAmount { get; set; }

            public Car(){}
            public void Drive()
            {
                Console.WriteLine("The car is driving");
            }

            public bool Refuel(int amountOfGasolineRefuel)
            {
                if(amountOfGasolineRefuel > 0)
                {
                    this.InitialGasolineAmount += amountOfGasolineRefuel;
                    return true;
                }
                return false;
            }
        }
        static void Main(string[] args)
        {
            Car car = new Car()
            {
                InitialGasolineAmount = 0
            };
            Console.WriteLine(car.Refuel(0));
            Console.WriteLine("Gasoline amount is {0}", car.InitialGasolineAmount);
            car.Drive();
        }
    }
}
