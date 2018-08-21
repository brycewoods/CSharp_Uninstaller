using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uninstaller
{
    class Program
    {
        static void Main(string[] args)
        {
            UninstallManager manager = new UninstallManager(new ConsoleHandler());
            manager.BeginUninstall(args);
        }
    }
}
