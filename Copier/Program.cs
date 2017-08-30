using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Copier
{
    class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 4)
              return;
            string dest = Path.Combine(ConfigurationManager.AppSettings["destinationFolder"], args[2] + args[3]);
            Console.WriteLine("Copying " + args[0] + " to "+dest);
            File.Copy(args[0], dest);
            Thread.Sleep(int.Parse(ConfigurationManager.AppSettings["timeout"]));
        }
    }
}
