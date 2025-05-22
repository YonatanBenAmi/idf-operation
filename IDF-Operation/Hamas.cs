using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IdfOperation.Models;


namespace IdfOperation.Models
{
    class Hamas
    {
        public string DateEstablishment;
        public string CurrentCommander;

        public List<Terrorist> MyTerrorist;



        public Hamas(string date, string commander)
        {
            DateEstablishment = date;
            CurrentCommander = commander;
        }

        public Terrorist CrateTerrorist()
        {
            Random random = new Random();
            List<bool> isAlive = new List<bool> { true, false };
            List<string> weaponRandom = new List<string> { "knife", "gon", "m16", "ak47" };

            Terrorist ter = new Terrorist("Hachmad", random.Next(1, 5), isAlive[random.Next(0, 1)], weaponRandom[random.Next(0, 3)]);
            return ter;
        }

        public List<Terrorist> TerroristList(int num)
        {
            List<Terrorist> terroristList = new List<Terrorist>();

            for (int i = 0; i < num; i++)
            {
                Terrorist terrorist = CrateTerrorist();
                terrorist.Name = $"Terrorist{i + 1}";
                terroristList.Append(terrorist);
            }
            return terroristList;
        }
    }
}
