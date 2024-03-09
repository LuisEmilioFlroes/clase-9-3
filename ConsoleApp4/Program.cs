using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Suma(string[] args)


        {
             
            //ej1

            int respuesta, val1, val2 = 0;
            int valor = 10;
            Console.WriteLine("ingrese el valor 1");
            val1 =  Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese el valor 2");
            val2 = Convert.ToInt32(Console.ReadLine());
            respuesta = val1 + val2;
            Console.WriteLine("suma = " + respuesta);
            }
              
 

            static void Datos() 
            //ej2
            { 
            Console.Write("cual es su nombre");
            string nombre = Console.ReadLine();
            Console.WriteLine("mucho gusto " + nombre);
             }

            static void Edad()
            { 
            //ej3
            Console.WriteLine("ingrese su fecha de nacimiento");
            int yearborn = Convert.ToInt32(Console.ReadLine());
            int edad = yearborn - 2024;
            Console.WriteLine("su edad es " + edad);
             }


         static int Suma1(int val1, int val2);

        {  
         int resultado = val1 + val2;
        Return resultado;

         }



        

    }
}


 
    



