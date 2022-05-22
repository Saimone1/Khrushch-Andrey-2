using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class Doors
    {
        private int ID { get; set; }
        public static int Num;
        private bool Lock1 = false;

        public Doors()
        {
            House.DoorList.Add(this);
            Console.WriteLine("Доданий об'єкт " + this.ToString());
            Num++;
            this.ID = Num;
        }

        public bool Lock()
        {
            if (this.ID <= Num)
            {
                string answ;
                if (!this.Lock1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Дверi вiдчиненi");
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
                if (answ.ToUpper() == "YES" && !this.Lock1)
                {
                    Console.WriteLine("Дверi зачинились!");
                    return this.Lock1 = !this.Lock1;
                }
                else if (answ.ToUpper() == "YES" && this.Lock1)
                {
                    Console.WriteLine("Дверi вiдчинились!");
                    return this.Lock1 = !this.Lock1;
                }
                else
                {
                    Console.WriteLine();
                    return this.Lock1;
                }
            }
            else
            {
                return Lock1;
            }
        }
    }
}
