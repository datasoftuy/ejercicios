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
            string otravez,opcion = "";
            int[] numeros = new int[51];
            


            while (salir != true)
            {
                Console.Clear();
                Console.WriteLine("1 Cargar los vectores");
                Console.WriteLine("2 Mostrar de forma decendente");
                opcion = Console.ReadLine();
                switch (opcion)
                {

                    case "1":

                            Console.WriteLine("Se carga el vector numeros del 1 al 50");
                           
                            for (int i = 0;  i  <  51  ; i++){

                            numeros[i] = i;
                    
                            }


                        break;


                    case"2":

                        Console.WriteLine("Mostrar en orden decendente");


                            for (int i = 50; i >= 0; i--){
                
                             Console.WriteLine("" + numeros[i]);
                            
                             }
                            Console.ReadLine();
                            
                            break;

                }


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