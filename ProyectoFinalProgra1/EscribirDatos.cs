using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class EscribirDatos
    {
        private string _pathEmp; //Campo de la clase 
        private string _pathPlan;


        private List<string> info;//Lista que contiene datos mixtos de ambos txt

            public static void AgregarEmpleado()
        {
            Console.WriteLine("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el salario del empleado: ");
            double salario = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Datos del empleado:");
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Salario: " + salario);

            Console.WriteLine("Desea guardar los datos? (S/N)");
            string opcion = Console.ReadLine();
            if (opcion.ToUpper() == "S")
            {
                Console.WriteLine("Datos guardados exitosamente");
            }
            else
            {
                Console.WriteLine("Los datos no han sido guardados");
            }

        }

        public void GenerarArchivoTodos(string _pathEmp, List<string> info)
        {
            using (StreamWriter swf = File.CreateText(_pathEmp))
            {
                swf.WriteLine("hola");

                swf.Close();

            }


        }


    }
}
