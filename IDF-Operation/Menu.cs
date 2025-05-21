using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdfOperation.Models
{
    public class Menu
    {

        public int MenuChoose()
        {

            Console.WriteLine("1. Intel Analysis:");
            Console.WriteLine("(Identify the terrorist with the most intelligence reports)");
            Console.WriteLine("2. Strike Availability:");
            Console.WriteLine("(Show all currently available strike units and their remaining capacity)");
            Console.WriteLine("3. Target Priorization:");
            Console.WriteLine("(Determine the most dangerous terrorist based on a quality rank)");
            Console.WriteLine("4. Strike Execution:");
            Console.WriteLine("(Based on the terrorist's location and type, choose an appropriate strike unit)");
            
            Console.WriteLine("Choose exercise number: ");
            string yourChoice = Console.ReadLine();
            int choose = int.Parse(yourChoice);

            return choose;
        }
        
    }
}
