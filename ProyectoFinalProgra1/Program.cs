﻿using System;

namespace ProyectoFinalProgra1
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion;
            Console.WriteLine("_______________DISTRIBUIDORA DEL NORTE_______________");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("          ~~~~~ MENU PRINCIPAL ~~~~~\n                 ");
            Console.WriteLine(" 1----- VER SALARIOS\n  ");
            Console.WriteLine(" 2----- AGREGAR EMPLEADOS\n ");
            Console.WriteLine(" 3---Salir\n ");
            Console.WriteLine("Digite una opcion mediante los numeros 1, 2 o 3 ");
            opcion = Convert.ToInt32(Console.ReadLine());
            switch (opcion)
            {
                case (1):
                    Console.Clear();
                    int submenu;
                    
                    Console.WriteLine("1---Todos los Salarios\n");
                    Console.WriteLine("2---Buscar salario por ID\n");
                    Console.WriteLine("3---Salir\n");
                    Console.WriteLine("Selecione 1, 2, o 3");
                    submenu = Convert.ToInt32(Console.ReadLine());
                    switch (submenu)
                         {
                            case (1):
                            Console.WriteLine("Todos los Salarios");

                            break;

                        case (2):
                            Console.WriteLine("Buscar Salario por ID ");

                            break;

                        case (3):
                            Environment.Exit(0);
                            break;

                    }

                    break;

                case (2):

                    break;

                case (3):

                    Environment.Exit(0);

                    break;
            }


        }
    }
}
