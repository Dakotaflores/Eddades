// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Ingrese la edad:");
        int edad = Convert.ToInt32(Console.ReadLine());

        if (edad <= 0)
        {
            Console.WriteLine("La edad debe ser mayor a 0.");
        }
        else
        {
            if (edad <= 3)
            {
                Console.WriteLine("La persona es un recién nacido.");
            }
            else if (edad <= 9)
            {
                Console.WriteLine("La persona es un puberto.");
            }
            else if (edad <= 19)
            {
                Console.WriteLine("La persona es un adolescente.");
            }
            else if (edad <= 29)
            {
                Console.WriteLine("La persona es un joven.");
            }
            else if (edad <= 49)
            {
                Console.WriteLine("La persona es un adulto.");
            }
            else if (edad <= 59)
            {
                Console.WriteLine("La persona es un adulto mayor.");
            }
            else
            {
                Console.WriteLine("La persona es un anciano.");
            }
        }
    }
}
