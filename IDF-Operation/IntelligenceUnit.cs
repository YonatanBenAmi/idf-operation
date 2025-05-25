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

        public int RiskPoints(Dictionary<string, string> report)
        {
            int knife = 1;
            int gon = 2;
            int m16 = 3;
            int ak47 = 3;
            int totalSum = 0;

            



        }

        public Dictionary<string, string> IntelligenceReport(Terrorist ter) 
        {
            List<string> loction = new List<string>();
            loction.Add("building");
            loction.Add("open space");
            loction.Add("car");
            Random random = new Random();

            Dictionary<string, string> report = new Dictionary<string, string>();
            report["name:"] = ter.Name;
            report["loction:"] = loction[random.Next(0,2)];
            report["time report:"] = $"{DateTime.Now.ToString("HH:mm")}";
            return report;
        }

    }
}
