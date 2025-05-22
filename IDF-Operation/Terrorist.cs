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
        
    }
    

}
