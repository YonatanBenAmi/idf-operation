namespace IdfOperation.Models
{
    public class AttackTool : StrikeOption
    {
        public StrikeOption F16 = new StrikeOption("F16", 8, 10427, ["Terrorist", "Buildings", "Underground"]);
        public StrikeOption Zik = new StrikeOption("Zik", 3, 145, ["Terrorist", "Buildings"]);
        public StrikeOption Artillery = new StrikeOption("Artillery", 40, 1400, ["Buildings"]);


        public AttackTool(string toolName, int capacity, double fuel, List<string> typeTarget) : base(toolName, capacity, fuel, typeTarget)
        {

        }

    }
}