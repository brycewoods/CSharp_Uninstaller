using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Uninstaller
{
    // Class that handles input and output to the console.
    class ConsoleHandler : UI
    {
        // Starts the console UI. Retrieves the users desired program. 
        public string ShowGetProgramNameScreen()
        {
            Console.WriteLine("Please enter in the name of the program you wish to uninstall");
            string programName = Console.ReadLine();

            return programName;
        }

        public void ShowStartingScreen()
        {
            Console.WriteLine("Welcome to the Uninstall Manager. Beginning uninstall operation...");
        }

        public void ShowUninstallResults(Hashtable results)
        {
            Console.WriteLine("Results:");
            foreach (string key in results.Keys)
            {
                Console.WriteLine($"Name: {key} , Found: {results[key]}");
            }

            Console.Write("Operation Completed. Press any key to exit");
            Console.ReadKey();
        }
    }
}
