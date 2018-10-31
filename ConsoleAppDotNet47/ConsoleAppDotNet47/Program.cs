using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConsoleAppDotNet47
{
    class Program
    {
        static int Main(string[] args)
        {
            //Set up Console UI (CUI)
            Console.Title = "My Rocking App";
            //Console.ForegroundColor = ConsoleColor.Yellow;
            //Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("***********************************");
            Console.WriteLine("**** Welcome to My Rocking App ****");
            Console.WriteLine("***********************************");

            // Helper method within the Program class.
            ShowEnvironmentDetails();


            //foreach(string arg in args)
            //    Console.WriteLine("Arg: {0}", arg);

            //Wait for Enter key to be pressed.
            Console.ReadLine();

            //MessageBox.Show("All done!");

            return -1;
        }

        static void ShowEnvironmentDetails()
        {
            // Print out the drives on this machine,
            // and other interesting details.
            foreach (string drive in Environment.GetLogicalDrives())
                Console.WriteLine("Drive: {0}", drive);
            Console.WriteLine("OS: {0}", Environment.OSVersion);
            Console.WriteLine("Number of Processors: {0}", Environment.ProcessorCount);
            Console.WriteLine(".NET Version: {0}", Environment.Version);
        }
    }
}
