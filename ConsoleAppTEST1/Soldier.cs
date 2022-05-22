using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppTEST1
{
    class Soldier
    {
        public string Rank { get; set; }

        public string Armament { get; set; }

        public string Specialization { get; set; }

        public int ID { get; set; }

        private static int i;

        public Soldier(string specialization, string rank, string armament, List<Soldier> list)
        {
            Rank = rank;
            Armament = armament;
            Specialization = specialization;
            i++;
            ID = i;
            list.Add(this);    
        }

        public string GetDescription()
        {
            return "Soldier" + this.ID + " -- Specialization: " + this.Specialization + ", Rank: " + this.Rank + ", Armament: " + this.Armament;
        }

        public string GetSpec()
        {
            return "Soldier" + this.ID + " -- " + this.Specialization;
        }

        public string GetArmament()
        {
            return "soldier" + this.ID + " - armament: " + this.Armament;
        }
    }
}
