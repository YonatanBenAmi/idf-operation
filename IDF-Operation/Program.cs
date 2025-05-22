using IdfOperation.Models;

namespace IdfOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hamas h = new Hamas("1972", "Muchamad");
            List<Terrorist> t1 = h.TerroristList(10);

        }
    }
}