using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace IdfOperation.Models
{
    class Terrorist
    {
        public string Name;
        public int Rank;
        public bool Status;
        public string Weapon;

        public Terrorist(string name, int rank, bool status, string weapon)
        {
            Name = name;
            Rank = rank;
            Status = status;
            Weapon = weapon;
        }

        public Terrorist CrateTerrorist()
        {
            Random random = new Random();
            List<bool> isAlive = new List<bool> { true, false };
            List<string> weaponRandom = new List<string> { "knife", "gon", "m16", "ak47" };

            Terrorist ter = new Terrorist("Hachmad", random.Next(1, 5), isAlive[random.Next(0, 1)], weaponRandom[random.Next(0, 3)]);
            return ter;
        }
        
    }
    

}
