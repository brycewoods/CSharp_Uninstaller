# CSharp_Uninstaller

# Description
Uninstaller created in C#. Uses the ManagemenObjectSearcher and invokes the uninstall method.

# Usage
Command Line:
From the command line simply call 'Uninstaller' and place any number of programs you would like to uninstall seperated by a space.<br/>
E.g. <br/>
C:\ > Uninstaller program1 program2 "program three"

Console:<br/>
Simply follow the prompts.

# Notes
1. Ensure you run the application or your command line application as admin.
2. Console usage only allows you to uninstall one program at a time. Use command line to uninstall multiple programs.
3. Classes should be extendable enough if you wanted to create a GUI. Simply extend the UI interface and overide the following functions:

    ShowGetProgramNameScreen();<br/>
    ShowStartingScreen();<br/>
    ShowUninstallResults(Hashtable results);<br/>
