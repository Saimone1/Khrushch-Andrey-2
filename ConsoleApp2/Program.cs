using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            House house = new House();

            Windows window1 = new Windows();
            Windows window2 = new Windows();
            Windows window3 = new Windows();
            house.Add(window1);
            house.Add(window2);

            house.Print();

            Doors maindoor = new Doors();
            Doors door1 = new Doors();
            house.Add(maindoor);
            house.Add(door1);
            house.Add(window3);

            house.Print();

            maindoor.Lock();
            maindoor.Lock();

            Console.WriteLine("Наступні двері:");
            door1.Lock();
            door1.Lock();
        }
    }
}
