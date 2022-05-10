using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class House
    {
        public void Print()
        {
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть вiкон у будинку - " + Windows.Num);
            Console.WriteLine("Кiлькiсть дверей у будинку - " + Doors.Num);
        }
        public void Add(Components component)
        {
            component.Add();
            Console.WriteLine("Доданий об'єкт " + component.ToString());    
        }
    }
    public abstract class Components
    {
        public abstract void Add();
    }
    public class Windows : Components
    {
        public static int Num;

        public override void Add()
        {
            Num++;
        }
    }
    public class Doors : Components
    {
        public static int Num = 0;
        private bool Lock1 = false;

        public override void Add()
        {
            Num++;
        }

        public bool Lock()
        {
            string answ;
            if (!this.Lock1)
            {
                Console.WriteLine();
                Console.WriteLine("Дверi " + "вiдчиненi");
                Console.WriteLine("Зачинити дверi?");
                answ = Console.ReadLine();
            }
            else
            {
                Console.WriteLine();
                Console.WriteLine("Дверi зачиненi");
                Console.WriteLine("Вiдчинити дверi?");
                answ = Console.ReadLine();

            }
            if (answ.ToUpper() == "YES")
            {
                Console.WriteLine("Дверi зачинились/вiдчинились!");
                return this.Lock1 = !this.Lock1;
            }
            else
            {
                Console.WriteLine("");
                return this.Lock1;
            }
        }
    }
}
