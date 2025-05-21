namespace IdfOperation.Models
{
    public class IDF
    {
        public string CurrentCommander;
        public string DateEstablishment;
        //Strike option


        public IDF(string Commander, string date)
        {
            CurrentCommander = Commander;
            DateEstablishment = date;
        }
        
    }
}