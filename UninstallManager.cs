using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Uninstaller
{
    class UninstallManager
    {

        private UI outputObj;


        public UninstallManager()
        {
            outputObj = new ConsoleHandler();
        }

        public UninstallManager(UI uiObject)
        {
            outputObj = uiObject;
        }

        public void BeginUninstall(string[] inputArgs)
        {
            outputObj.ShowStartingScreen();
            Hashtable results = new Hashtable();

            // Batch uninstall if run through the command line.
            if (inputArgs.Length > 0)
            {
                List<string> programs = inputArgs.ToList<string>();
                results = Uninstaller.MultipleUninstall(programs);
            }
            else
            {
                string programName = outputObj.ShowGetProgramNameScreen();
                results = Uninstaller.Uninstall(programName);
            }

            // Show results.
            outputObj.ShowUninstallResults(results);
        }
    }
}
