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

            List<Windows> windows = House.GetWindList();
            List<Doors> doors = House.GetDoorList();
            Doors maindoor = doors[0];

            windows.Add(new Windows());
            doors.Add(new Doors());

            House.CheckCount();

            maindoor.Lock();
            maindoor.Lock();
        }
    }
}
