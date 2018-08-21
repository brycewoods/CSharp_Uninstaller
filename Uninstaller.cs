using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;

namespace Uninstaller
{
    abstract class Uninstaller
    {



        // Unistall method that removes multiple programs.
        public static Hashtable MultipleUninstall(List<string> programArray)
        {
            // Returned hashtable of whether programs were sucessfully uninstalled.
            Hashtable successHash = new Hashtable();

            foreach(string program in programArray)
            {

                Hashtable result = Uninstall(program);

                foreach(DictionaryEntry entry in result)
                {
                    successHash.Add(entry.Key, entry.Value);
                }
            }

            return successHash;
        }


        // Uninstall method that removes a single program.
        public static Hashtable Uninstall(string programName)
        {
            Boolean found = false;

            try
            {
                string query = "SELECT * FROM Win32_Product WHERE name='" + programName + "'";
                ManagementObjectSearcher searcher = new ManagementObjectSearcher(query);

                foreach (ManagementObject obj in searcher.Get())
                {
                    try
                    {
                        if (obj["Name"].ToString().ToLower() == programName.ToLower())
                        {
                            obj.InvokeMethod("Uninstall", null);
                            found = true;
                        }
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error: ", e.ToString());
                    }

                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Error: ", e.ToString());
            }

            Hashtable result = new Hashtable();
            result.Add(programName, found);

            return result;
        }
    }
}
