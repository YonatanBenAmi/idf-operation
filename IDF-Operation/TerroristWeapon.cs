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
        public string Knife;
        public string Gun;
        public string M16;
        public string AK47;

        public TerroristWeapon(string knife, string gun, string m16, string aK47)
        {
            Knife = knife;
            Gun = gun;
            M16 = m16;
            AK47 = aK47;
        }

        public Dictionary<string, int> WeaponPoint()
        {
            Dictionary<string, int> weaponPoint = new Dictionary<string, int>();

            weaponPoint["knife"] = 1;
            weaponPoint["gun"] = 2;
            weaponPoint["m16"] = 3;
            weaponPoint["ak47"] = 3;

            return weaponPoint;
        }
    }
}
