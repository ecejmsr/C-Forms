using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using Resturant.Data;
using Resturant.Infrastructure;
using Resturant.Infrastructure.Common;


namespace Resturant
{
    class GUIMenu : ApplicationBase
    {
        public GUIMenu() : base(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType) { }
        public void StartUp()
        {
            Console.WriteLine("\t\t\t\t Welcome to my App");
            Console.WriteLine("\tPlease make a selection by entering the correspoding number for a command.");
        }

        public void Selection()
        {
            Console.WriteLine("1) View Top 3 resturants");
            Console.WriteLine("2) Display all resturants");    
            Console.WriteLine("3) Search for a resturant");
            Console.WriteLine("4) !!QUIT!!");
        }

        public void Execution()
        {
            var libHelper = new TsqlCrud();
            int intSelection = CheckInput();

            while (intSelection != 4)
            {
                switch (intSelection)
                {
                    case 1:
                        Console.Clear();
                        IEnumerable<resturant_info> sortedList3 = libHelper.SortingByName();
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine(sortedList3.ElementAt(i).rest_name);
                        }
                        Console.WriteLine("Press Enter to return to Menu");
                        Console.ReadLine();
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("How would you like to display the Resturants?");
                        Console.WriteLine("1) Display as: A-Z");
                        Console.WriteLine("2) Display as: Z-A");
                        Console.WriteLine("3) Display by: Rating");
                        intSelection = CheckInput();
                        Console.Clear();
                        if (intSelection == 1)
                        {
                            IEnumerable<resturant_info> sortedList = libHelper.SortingByName();
                            foreach (var x in sortedList)
                            {
                                Console.WriteLine(x.rest_name);
                            }
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadKey();
                        }
                        else if (intSelection == 2)
                        {
                            IEnumerable<resturant_info> sortedListDesc = libHelper.SortingByNameDesc();
                            foreach (var x in sortedListDesc)
                            {
                                Console.WriteLine(x.rest_name);
                            }
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadKey();
                        }

                        else if (intSelection == 3)
                        {
                            Console.Clear();
                            IEnumerable<resturant_info> sortedList = libHelper.SortingByRating().Reverse();
                            foreach (var x in sortedList)
                            {
                                Console.WriteLine(x.rest_name + " ||  Rating:" + x.rest_rating);
                            }
                            Console.WriteLine("Press Enter to Continue");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Command Not Recognized");
                        }
                        break;

                    case 3:
                        //WORK ON SEARCHING THROUGH WITH CASE INSESITIVE
                        Console.Clear();
                        Console.WriteLine("Enter resturant name to view information");
                        string lookUpResturant = Console.ReadLine();
                        Log.Info(lookUpResturant);
                        IEnumerable<resturant_info> sortedLookUp = libHelper.SortingByName();
                        IEnumerable<resturant_info> restruantFound= sortedLookUp.Where(x => x.rest_name.Contains(lookUpResturant));
                        Console.Clear();
                        foreach (var rest in restruantFound)
                        {
                            Console.WriteLine(rest.rest_name);
                            Console.WriteLine(rest.rest_address);
                            Console.WriteLine(rest.city);
                            Console.WriteLine(rest.rest_zipcode);
                            Console.WriteLine(rest.state);
                            Console.WriteLine(rest.rest_phoneNumber);
                            Console.WriteLine("=========================================");
                        }
                        Console.WriteLine("Press Enter to Continue.");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine("Should end...");
                        break;
                    default:
                        Console.WriteLine("Command not recognized.");
                        break;
                }
                Console.Clear();
                Selection();
                intSelection = CheckInput();

            }
        }

        public int CheckInput()
        {
            string Selection = Console.ReadLine();
            Log.Info(Selection);
            int intSelection = 0;
            if (Selection != "")
            {
                return intSelection = Convert.ToInt32(Selection);
            }
            else if (Selection.Length > 1)
            {
                Console.WriteLine("Too many characters entered...");
                return intSelection;
            }
            else
            {
                return intSelection;
            }
        
    }

    }
}
