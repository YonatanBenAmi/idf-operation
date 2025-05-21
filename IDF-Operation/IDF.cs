using Microsoft.VisualBasic;
using IdfOperation.Models;

namespace IdfOperation.Models
{
    public class IDF
    {
        public string CurrentCommander;
        public string DateEstablishment;
        public Dictionary<string, StrikeOption> AttackToolDetails;


        public IDF(string Commander, string date)
        {
            CurrentCommander = Commander;
            DateEstablishment = date;
        }

        public void SetAttackToolDetails(StrikeOption[] tools)
        {
            foreach (var item in tools)
            {
                AttackToolDetails.Add($"{item.ToolName}", item);
            }
        }

        
        
    }
}