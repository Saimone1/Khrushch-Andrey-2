using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTEST1
{
    class Platoon
    {
        private static void AddtoPlat1()
        {
            //                     Soldier(specialization, rank, armament)
            Soldier soldier1 = new Soldier("Driver-mechanic", "Corporal", "AKS-74", TankList);
            Soldier soldier2 = new Soldier("Charging", "Ranker", "PM pistol", TankList);
            Soldier soldier3 = new Soldier("Gunner-operator", "Сorporal", "machine gun", TankList);
            Soldier soldier4 = new Soldier("Tank Commander", "Sergeant", "PM pistol", TankList);

            Soldier soldier5 = new Soldier("Driver-mechanic", "Corporal", "AKS-74", TankList);
            Soldier soldier6 = new Soldier("Charging", "Ranker", "PM pistol", TankList);
            Soldier soldier7 = new Soldier("Gunner-operator", "Сorporal", "machine gun", TankList);
            Soldier soldier8 = new Soldier("Tank Commander", "Sergeant", "PM pistol", TankList);
        }

        private static void AddtoPlat2()
        {
            Soldier soldier9 = new Soldier("Senior driver", "Сorporal", "АК74", GrenadeList);
            Soldier soldier10 = new Soldier("Grenade launcher", "Sergeant", "machine gun", GrenadeList);
            Soldier soldier11 = new Soldier("Grenade launcher", "Ranker", "RPG-7", GrenadeList);
            Soldier soldier12 = new Soldier("BTR machine gunner", "Sergeant", "anti-tank systems", GrenadeList);
            Soldier soldier13 = new Soldier("Part-commander", "Сorporal", "", GrenadeList);

            Soldier soldier14 = new Soldier("Driver", "Ranker", "RPG-7", GrenadeList);
            Soldier soldier15 = new Soldier("Grenade launcher", "Ranker", "anti-tank systems", GrenadeList);
            Soldier soldier16 = new Soldier("Grenade launcher", "Sergeant", "АК74", GrenadeList);
            Soldier soldier17 = new Soldier("BTR machine gunner", "Ranker", "machine gun", GrenadeList);
            Soldier soldier18 = new Soldier("Part-commander", "Сorporal", "АК74", GrenadeList);
        }

        public static List<Soldier> TankList = new List<Soldier>();

        public static List<Soldier> GrenadeList = new List<Soldier>();

        static int count = 0;

        public static List<Soldier> ToList(Platoon plat)
        {
            if (count == 0)
            {
                count++;
                return TankList;
            }
            else
            {
                count = 0;
                return GrenadeList;
            }
        }

        public static Platoon Tank = new Platoon();

        public static Platoon Grenade = new Platoon();

        public static List<Soldier> GetTankList()
        {
            AddtoPlat1();
            ShowDescriptions(TankList);
            return TankList;
        }

        public static List<Soldier> GetGrenadeList()
        {
            AddtoPlat2();
            ShowDescriptions(GrenadeList);
            return GrenadeList;
        }

        public static Platoon GetTankPlat()
        {
            return Tank;
        }

        public static Platoon GetGrenadePlat()
        {
            return Grenade;
        }

        public static void ShowDescriptions<T>(List<T> PlatList) where T : Soldier
        {
            Console.WriteLine();
            Console.WriteLine("Кiлькiсть солдатiв у данному взводi " + PlatList.Count);
            Console.WriteLine();
            foreach (var soldier in PlatList)
                Console.WriteLine(soldier.GetDescription());
            Console.WriteLine();
        }

        public static void SpecSort<T>(List<T> List) where T : Soldier
        {
            string[] arr = new string[List.Count];
            string[] Value = new string[List.Count];
            Console.WriteLine();
            Console.WriteLine("Сортування за бойовою спецiальнiстю:");

            int i = 0, j = 0;
            foreach (Soldier soldier in List)
            {
                arr[i] = soldier.Specialization;
                Value[i] = soldier.GetSpec();
                i++;
            }
            Array.Sort(arr, Value);

            foreach (var soldier in arr)
            {
                Console.WriteLine(Value[j]);
                j++;
            }
        }

        public static void SameWeapon<T>(List<T> List) where T : Soldier
        {
            Console.WriteLine();
            Console.WriteLine("Списки вiйськових з однаковим озброєнням:");
            string[] Key = new string[List.Count];
            string[] Value = new string[List.Count];
            int i = 0;

            foreach (Soldier soldier in List)
            {
                Key[i] = soldier.Armament;
                Value[i] = soldier.GetArmament();
                i++;
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
    }
}
