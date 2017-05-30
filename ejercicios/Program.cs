using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace leapyear
{
    class Program
    {
        static void Main(string[] args)
        {

            bool salir = false;
            string otravez;
            while (salir != true)
            {
                Console.WriteLine("OK    while    ");

                Console.WriteLine("Presione s para salir");
                otravez = Console.ReadLine().ToLower();

                if (otravez == "s")
                {
                    salir = true;
                
                
                }


            }
              

        }
    }
}