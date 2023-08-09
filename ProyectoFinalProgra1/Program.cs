using System;

namespace ProyectoFinalProgra1
{
    class Program
    {
        static void Main(string[] args)
        {
            string __path = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Planilla.txt";
            string path = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Empleados.txt";
            EscribirDatos escribirDatos = new EscribirDatos(__path);
            LeerDatos leerDatos = new LeerDatos(path);
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
                            leerDatos.LeerEmpleados();

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
