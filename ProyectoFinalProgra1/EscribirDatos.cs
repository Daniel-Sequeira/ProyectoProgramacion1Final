using System;
using System.Collections.Generic;
using System.Text;

namespace ProyectoFinalProgra1
{
    public class EscribirDatos
    {
<<<<<<< HEAD
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
=======

>>>>>>> e4d52fa49d360937c594ae9d713df75249ef22ac
    }
}
