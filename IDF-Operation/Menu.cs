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
            Console.WriteLine("2. Strike Availability:");
            Console.WriteLine("3. Target Priorization:");
            Console.WriteLine("4. Strike Execution:");
            
            Console.WriteLine("Choose exercise number: ");
            string yourChoice = Console.ReadLine();
            int choose = int.Parse(yourChoice);

            return choose;
        }
        
    }
}
