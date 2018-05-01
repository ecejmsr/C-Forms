using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Resturant.Data;

namespace Resturant
{
    class Client
    {
        static void Main(string[] args)
        {
            GUIMenu app = new GUIMenu();
            app.StartUp();
            
            app.Selection();
            app.Execution();
            Console.Clear();

            Console.WriteLine("Thanks for playing!");
            Console.ReadKey();

        }
    }
}
