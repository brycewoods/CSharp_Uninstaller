using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Uninstaller
{

    interface UI
    {
        // Ui screen to getd esired program name.
        string ShowGetProgramNameScreen();

        // Welcome message screen.
        void ShowStartingScreen();

        // Ending Screen
        void ShowUninstallResults(Hashtable results);

    }
}
