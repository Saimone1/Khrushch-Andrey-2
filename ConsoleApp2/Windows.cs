using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Windows
    {
        public static int Num;

        public Windows()
        {
            House.WindList.Add(this);
            Console.WriteLine("Доданий об'єкт " + this.ToString());
            Num++;
        }
    }
}
