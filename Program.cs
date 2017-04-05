using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using System.Diagnostics;
using Mono.Options;

namespace reflect
{
    class Program
    {
        static void Main(string[] args)
        {
            var versionInfo = FileVersionInfo.GetVersionInfo((Assembly.GetEntryAssembly().Location));

            var companyName = versionInfo.CompanyName;

            Console.WriteLine();
            Console.WriteLine(".NET Reflect tool version " +
                Assembly.GetExecutingAssembly().GetName().Version.ToString());
            Console.WriteLine("Copyright @ Dr. Suresh Ramasamy <suresh@drsuresh.net> 2017\n");
            
            if (string.IsNullOrEmpty(args[0]))
            {
                Console.WriteLine("No .NET binaries to reflect");
            }
            else
            {
                Console.WriteLine("Filename: " + args[0] + " - "
                + AssemblyName.GetAssemblyName(args[0]).FullName);
            }
        }
    }
}
