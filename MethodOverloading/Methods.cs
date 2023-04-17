using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class Methods
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal c, decimal d)
        {
            return c + d;
        }

        public static string Add(int a, int b, bool e)
        {
            if (e == false)
            {
                return "1 dollar";
            }
            else
            {
                int sum = a + b;
                string sumText = "";
                sumText = sum.ToString();
                return ($"{ sumText} dollars");
            }
        }
    }
}

