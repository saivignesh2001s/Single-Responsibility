using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Single_Responsibility
{
    internal static class Errorlog
    {
        public static void Writelog(string[] message)
        {
            File.WriteAllLines("Error.txt", message);
        }
    }
}
