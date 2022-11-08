using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebasUnitarias
{
    public class MisMetodos
    {


        public static int sumar(int a, int b)
        {
            return a + b;
        }

        public static bool par(int a)
        {
            if (a % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static string Nombre()
        {
            return "Eimer";
        }

        public static bool Loging(string usuario, string password) =>
            usuario == "Eimer22" && password == "2020" ? true : false;
        

        

    }
}
