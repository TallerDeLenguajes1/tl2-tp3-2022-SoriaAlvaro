using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class_MethodExtra
{
    public class Extra
    {
        public static string setString(string? mensaje)
        {
            Console.WriteLine(mensaje);
            string? str = Console.ReadLine();
            return str;
        }
        public static int setInt(string? mensaje)
        {
            Console.WriteLine(mensaje);
            int n = Convert.ToInt32(Console.ReadLine());
            return n;
        }
    }
}
