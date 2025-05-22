using IdfOperation.Models;

namespace IdfOperation
{
    public class Program
    {
        static void Main(string[] args)
        {
            Hamas h = new Hamas("1972", "Muchamad");
            List<Terrorist> t1 = h.TerroristList(10);

            foreach (var item in t1)
            {
                Console.WriteLine(item.Name, item.Rank, item.Status, item.Weapon + "ok");
            }




            // Menu menu = new Menu();
            // switch (menu)
            // {
            //     case 1:

            //         break;
            // }

        }
    }
}