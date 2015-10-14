using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson08_Part1
{
    class Program
    {
        static void Main ( string [] args )
        {
            int selection = 0;
            do
            {
                Console.WriteLine( "+++++++++++++++++++++++++++" );
                Console.WriteLine( "1. First Choice");
                Console.WriteLine( "2. Second Choice");
                Console.WriteLine( "3. Exit");
                Console.WriteLine( "+++++++++++++++++++++++++++");
                Console.Write( "Please make your selection" );
                selection = Convert.ToInt32( Console.ReadLine() );
                Console.WriteLine( );
                Console.WriteLine( "++++++++++++++++++++++++++++++" );

                switch (selection)
                {
                    case 1:
                        Console.WriteLine( "You chose 1." );
                        break;
                    case 2:
                        Console.WriteLine("You chose 2.");
                        break;
                    case 3:
                        Console.WriteLine("");
                        break;
                    default:
                        Console.WriteLine("Incorrect Entry - Try Again!");
                        break;
                }

            } while (selection != 3);
            Console.WriteLine(  );
            Console.WriteLine("+++++++++++++++++++++++++++++++++");
            Console.WriteLine( "Press any key to continue..." );
            Console.ReadKey();
            Console.Clear();
        }
    }
}
