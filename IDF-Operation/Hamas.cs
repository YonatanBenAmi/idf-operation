using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfOperation.Models
{
    class Hamas
    {
        public string DateEstablishment;
        public string CurrentCommander;

        //public List<Dictionary<string, List<Dictionary<string, string>>>> ListOfTerrorist { get; set; }
        //List OfTerrorist

        public Hamas(string Date, string Commander)
        {
            DateEstablishment = Date;
            CurrentCommander = Commander;
        }
    }
}
