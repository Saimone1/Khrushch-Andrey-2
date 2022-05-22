using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTEST1
{
    class Program
    {
        static void Main(string[] args)
        {
            Army army = new Army();

            List<Soldier> Tanklist = GetTankList();

            List<Soldier> Grenadelist = GetGrenadeList();

            List<Platoon> Armylist = Army.GetArmyList();

            SpecSort(Armylist);
            Platoon.SpecSort(Tanklist);

            SameWeapon(Armylist);
            Platoon.SameWeapon(Tanklist);

            PlatSort(Armylist);        
        }
    }     
}

