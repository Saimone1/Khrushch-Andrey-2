using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    public class House
    {
        public House()
        {   
            Windows window1 = new Windows();
            Windows window2 = new Windows();
            Windows window3 = new Windows();
            Doors maindoor = new Doors();
            Doors door1 = new Doors();
            Console.WriteLine("Створений базовий дiм (3 вiкна, 2 дверi)");
            Console.WriteLine();
        }

        static House()
        {
            WindList = new List<Windows>();

            DoorList = new List<Doors>();
        }

        public static void CheckCount()
        {
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть вiкон у будинку - " + Windows.Num);
            Console.WriteLine("Кiлькiсть дверей у будинку - " + Doors.Num);
        }

        public static List<Windows> WindList;

        public static List<Doors> DoorList;

        public static List<Windows> GetWindList()
        {
            return WindList;
        }

        public static List<Doors> GetDoorList()
        {
            return DoorList;
        }
    }
}
