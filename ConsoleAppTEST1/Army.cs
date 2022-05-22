using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTEST1
{
    class Army : Platoon
    {
        public Army()
        {
            Console.WriteLine("Створена армiя");
            Platoon Tank = GetTankPlat();
            Platoon Grenade = GetGrenadePlat();

            ArmyList.Add(Tank);
            ArmyList.Add(Grenade);
        }

        public static List<Platoon> GetArmyList()
        {
            return ArmyList;
        }

        public static List<Platoon> ArmyList = new List<Platoon>();

        public static void ShowArmyDescriptions<T>(List<T> PlatList) where T : Platoon
        {
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть взводiв у армiї " + PlatList.Count);
            Console.WriteLine();
            foreach (Platoon platoon in PlatList)
            {
                foreach (Soldier soldier in ToList(platoon))
                {
                    Console.WriteLine(soldier.GetDescription());
                }
                Console.WriteLine();
            }
        }

        public static void PlatSort<T>(List<T> List) where T : Platoon
        {
            int i = 0;
            Console.WriteLine();
            Console.WriteLine("Сортування за кiлькiстю солдатiв у взводi:");
            int[] Key = new int[List.Count];
            List<Soldier>[] Value = new List<Soldier>[List.Count];

            foreach (Platoon platoon in List)
            {
                Key[i] = ToList(platoon).Count;
                ToList(platoon);
                Value[i] = ToList(platoon);               
                i++;
            }

            Array.Sort(Key, Value);

            for (int j = Key.Length - 1; j >= 0; j--)
            {
                foreach (Soldier soldier in Value[j])
                {
                    Console.WriteLine(soldier.GetDescription());
                }
                Console.WriteLine();
            }
        }

        public static void SameWeapon<T>(List<T> List) where T : Platoon
        {
            Console.WriteLine();
            Console.WriteLine("Списки вiйськових з однаковим озброєнням:");
            int i = 0, sum = 0;

            foreach (Platoon platoon in List)
            {
                sum = sum + ToList(platoon).Count;
            }

            string[] Key = new string[sum];
            string[] Value = new string[sum];

            foreach (Platoon platoon in List)
            {
                foreach (Soldier soldier in ToList(platoon))
                {
                    Key[i] = soldier.Armament;
                    Value[i] = soldier.GetArmament();
                    i++;
                }
            }

            Array.Sort(Key, Value);

            for (int j = 0; j < Key.Length; j++)
            {
                Console.WriteLine(Value[j]);
                if (j + 1 < Key.Length && Key[j] != Key[j + 1])
                {
                    Console.WriteLine();
                }
            }
            Console.WriteLine();
        }

        public static void SpecSort<T>(List<T> List) where T : Platoon
        {
            Console.WriteLine();
            Console.WriteLine("Сортування за бойовою спецiальнiстю:");
            int i = 0, j = 0, sum = 0;

            foreach (Platoon platoon in List)
            {
                sum = sum + ToList(platoon).Count;
            }

            string[] arr = new string[sum];
            string[] Value = new string[sum];

            foreach (Platoon platoon in List)
            {
                foreach (Soldier soldier in ToList(platoon))
                {
                    arr[i] = soldier.Specialization;
                    Value[i] = soldier.GetSpec();
                    i++;
                }
            }

            Array.Sort(arr, Value);

            foreach (var soldier in arr)
            {
                Console.WriteLine(Value[j]);
                j++;
            }
        }
    }
}
