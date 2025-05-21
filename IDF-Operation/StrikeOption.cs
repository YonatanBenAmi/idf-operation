namespace IdfOperation.Models
{
    public class StrikeOption
    {
        public int AmmunitionCapacity;
        public string ToolName;
        public double FuelSupply;
        public List<string> TypeTarget;

        public StrikeOption(string toolName,int capacity, double fuel, List<string> typeTarget)
        {
            ToolName = toolName;
            AmmunitionCapacity = capacity;
            FuelSupply = fuel;
            TypeTarget = typeTarget;
        }

    }
}