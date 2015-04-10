using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;

namespace MassiveIpFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader file =
               new System.IO.StreamReader(args[0]);

            string line = null;

            while ((line = file.ReadLine()) != null)
            {
                IPAddress[] addresslist = null;

                try
                { addresslist = Dns.GetHostAddresses(line); }
                catch { }

                if (addresslist != null)
                {
                    foreach (IPAddress theaddress in addresslist)
                    {
                        Console.WriteLine(theaddress.ToString());
                    }
                    line = null;
                }
            }
        }
    }
}
