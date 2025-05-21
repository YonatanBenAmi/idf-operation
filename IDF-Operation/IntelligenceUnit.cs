using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfOperation.Models
{
    class IntelligenceUnit
    {
        public string TerroristName;
        public string LastLocation;
        public string InfromationCollectionTime;

        public IntelligenceUnit(string terroristName, string lastLoction, string inCollTime)
        {
            TerroristName = terroristName;
            LastLocation = lastLoction;
            InfromationCollectionTime = inCollTime;
        }
    }
}
