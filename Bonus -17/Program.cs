using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus__17
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int numberOfCars;
            Console.WriteLine("Welcome to the Grand Circus admin console");
            Console.WriteLine("How many cars are you entering?");
            numberOfCars = int.Parse(Console.ReadLine());

            Car[] newCar = new Car[numberOfCars];

            for (int i = 0; i < newCar.Length; i++)
            {
                newCar[i] = new Car();
            }

            for (int i = 0; i < newCar.Length; i++)
            {
                Console.WriteLine("Enter car #{0} Make: ", i +1);
                newCar[i].Make = Console.ReadLine();

                Console.WriteLine("Enter car #{0} Model: ", i + 1);
                newCar[i].Model = Console.ReadLine();

                Console.WriteLine("Enter car #{0} Year: ", i + 1);
                newCar[i].Year = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter car #{0} Price: ", i + 1);
                newCar[i].Price = double.Parse(Console.ReadLine());


              
                




            }


                Console.WriteLine("Current Inventory");

                Console.WriteLine("Make".PadRight(15,' ') + "\t" + "Model".PadRight(15,' ') + "\t" + "Year" + "\t" +  "Price" + );

                foreach (Car Ba in newCar)
                {
                    Console.WriteLine($"{Ba.Make.PadRight(15, ' ')} \t {Ba.Model.PadRight(15,' ')} \t {Ba.Year.ToString().PadRight(15,' ')} \t {Ba.Price.ToString("N2").PadRight(15,' ')}");
                }


        }  

    }
}
