using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string archivo;
            char op = 's';
            int o = 1;


            while (op == 's')
            {
                Console.Clear();
                Console.WriteLine("Qué Desea Hacer:\n 1.Crear texto \n 2.Salir");
                o = int.Parse(Console.ReadLine());


                if (o == 1)
                {
                    Console.Clear();
                    StreamWriter ar;
                    archivo = Console.ReadLine();
                    Console.WriteLine("Ingrese nombre del archivo: ");
                    ar = File.AppendText(Console.ReadLine() + ".txt");
                    ar.Close();

                }

                if (o == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Desea salir presione n");
                    op = char.Parse(Console.ReadLine());
                    Console.Clear();
                }
            }

        }
    }
}

