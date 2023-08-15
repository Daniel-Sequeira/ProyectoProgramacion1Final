using System;
using System.Collections.Generic;

namespace ProyectoFinalProgra1
{
    class Program
    {
        static string pathEmp = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Empleados.txt";
        static  string pathPlan = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Planilla.txt";

        static void Main(string[] args)
        {

            List<string> datosEmp = new List<string>(); //Instancias de Listas 
            List<string> datosPlan = new List<string>();
            List<string> subEmp = new List<string>();
            List<string> subPlan = new List<string>();

            LeerDatos lectura = new LeerDatos(pathEmp,pathPlan); //Instancia de la Clase leer Datos para llamar sus metodos.
            EscribirDatos escritura = new EscribirDatos();

            datosEmp = lectura.LeerArchivo(pathEmp); //Almaacenar en las listas los datos leidos por metodo LeerArchivo segun path enviado
            datosPlan = lectura.LeerArchivo(pathPlan);
            subEmp = datosEmp.GetRange(1,3);
            subPlan = datosPlan.GetRange(2,3);



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
                            foreach (var item in subEmp)
                            {
                                Console.WriteLine(item);
                            }

                            
                         

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
                    escritura.AgregarEmpleado( nombre, salario);
                    Console.WriteLine("Empleado agregado y datos guardados. ");
                    break;

                case (3):

                    Environment.Exit(0);

                    break;
            }

          

        }
    }
}
