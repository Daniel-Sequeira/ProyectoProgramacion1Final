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
           
           
           
            LeerDatos lectura = new LeerDatos(pathEmp,pathPlan); //Instancia de la Clase leer Datos para llamar sus metodos.
            EscribirDatos escritura = new EscribirDatos();

            datosEmp = lectura.LeerArchivo(pathEmp); //Almacenar en las listas los datos leidos por metodo LeerArchivo segun path enviado
            datosPlan = lectura.LeerArchivo(pathPlan);

            List<string> datosMixtos = new List<string>();
           
            for (int i = 0; i < datosEmp.Count; i++)
            {
                string[] arregloEmp = datosEmp[i].Split(" ");
                string[] arregloPlan = datosPlan[i].Split(" ");
                int salaB = Convert.ToInt32(arregloPlan[2])* Convert.ToInt32(arregloPlan[3]);
                string valorRebajo = arregloPlan[4].Replace("%", " ");
                double rebajo = (double.Parse(valorRebajo)/100) * salaB;
                double salNet = salaB - rebajo;
                datosMixtos.Add
                (
                  arregloEmp[1] + " " +
                  arregloEmp[2] + " " +
                  arregloEmp[3] + " " +
                  arregloPlan[3] + " " +
                  arregloPlan[2] + " " +
                  salaB.ToString() + " " +
                  rebajo.ToString() + " " +
                  salNet.ToString()

                 ) ;
            }

         

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
                            string[] tabla = { "Nombre", "Apellidos", "Horas Trabajadas", "Salario/Hora", "Salario Bruto", "Rebajos", "Salario Neto" };
                            Console.WriteLine($"{tabla[0]} {tabla[1],2} {tabla[2],2} {tabla[3],2} {tabla[4],2} {tabla[5],2} {tabla[6],2}");

                            foreach (var Lista in datosMixtos)
                            {
                                Console.WriteLine(Lista);
                            }
                               Console.WriteLine("¿Desea Imprimir Reporte?\n Presione (S) Si o (N) No");
                               char desicion = Convert.ToChar(Console.ReadLine());
                                if (desicion == 'S' || desicion == 's')
                                {
                                lectura.CrearArchivo(pathEmp,datosMixtos);
                                }
                                 else { }
                            
                            break;
                            

                        case (2):
                            

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
