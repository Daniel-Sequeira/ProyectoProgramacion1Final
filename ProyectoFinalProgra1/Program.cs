using System;
using System.Collections.Generic;

namespace ProyectoFinalProgra1
{
    class Program
    {
        static void Main(string[] args)
        {
            string __path = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Planilla.txt";

            EscribirDatos escribirDatos = new EscribirDatos(__path);

            string pathEmp = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Empleados.txt";
          
            LeerDatos lectura = new LeerDatos(pathEmp); //Instancia de la Clase leer Datos para llamar sus metodos.

            int opcion;
            Console.WriteLine("_______________DISTRIBUIDORA DEL NORTE_______________");
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
                            Console.Clear();
                            Console.WriteLine("________________Todos los Salarios______________");
                            string[] tabla = { "Cedula","Nombre", "Apellidos", "Horas Trabajadas", "Salario/Hora", "Salario Bruto", "Deducciones","Salario Neto" };
                            Console.WriteLine($"{tabla[0]} {tabla[1],9} {tabla[2],10} {tabla[3],15} {tabla[4],15} {tabla[5],15} {tabla[6],15}");

                            foreach (var todos in lectura.LeerTodos()) 
                            {
                                Console.WriteLine(todos);
                            }
                            Console.WriteLine("¿Desea Generar Reporte? S o N");

                            break;

                        case (2):
                            lectura.BuscarSalarioID();

                            break;

                        case (3):
                            Environment.Exit(0);
                            break;

                    }

                    break;

                case (2):
                    Console.WriteLine("Ingrese el nombre del empleado");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese el salario del empleado");
                    double salario = Convert.ToDouble(Console.ReadLine());
                    escribirDatos.AgregarEmpleado(nombre, salario);
                    Console.WriteLine("Empleado agregado y datos guardados. ");
                    break;

                case (3):

                    Environment.Exit(0);

                    break;
            }

          

        }
    }
}
