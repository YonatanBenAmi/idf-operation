using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace IdfOperation.Models
{
    class TerroristWeapon
    {
        public string Name;
        public string Gun;
        public string M16;
        public string AK47;

        public TerroristWeapon(string name, string gun, string m16, string aK47)
        {
            Name = name;
            Gun = gun;
            M16 = m16;
            AK47 = aK47;
        }
    }
}
