﻿using System;
using System.Collections.Generic;

namespace ProyectoFinalProgra1
{
    class Program
    {
        static string pathEmp = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Empleados.txt";
        static  string pathPlan = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Planilla.txt";
        static string pathTodos = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Planilla_del_mes.txt";
        static void Main(string[] args)
        {

            List<string> datosEmp = new List<string>(); //Instancias de Listas 
            List<string> datosPlan = new List<string>();
           
           
           
            LeerDatos lectura = new LeerDatos(pathEmp,pathPlan,pathTodos); //Instancia de la Clase leer Datos para llamar sus metodos.
            EscribirDatos escritura = new EscribirDatos(pathEmp,pathPlan);

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
                        case (1)://Mostrar salarios en pantalla y pregunta si desea generar reporte de estos.
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
                                lectura.CrearArchivo(pathTodos,datosMixtos);
                                }
                                 else { }
                            
                            break;
                            

                        case (2)://Buscar salario por ID y reporte de un funcionario
                            

                            break;

                        case (3): //Sale completamente del programa
                            Environment.Exit(0);
                            break;

                    }

                    break;

                case (2):                                 
                                                    
                     Console.WriteLine("Ingrese la cédula del empleado");
                     string cedula = Console.ReadLine();
                     while (!Validaciones.ValidarCedula(cedula))
                     {
                        Console.WriteLine("Formato Invalido, ingrese un formato valido");
                        cedula = Console.ReadLine();
                     }

                     Console.WriteLine("Ingrese el nombre y apellidos del empleado");
                     string nombre = Console.ReadLine();
                     while (!Validaciones.CamposVacios(nombre))
                     {
                        Console.WriteLine("Este campo no puede estar vacio");
                        nombre = Console.ReadLine();
                     }

                     Console.WriteLine("Ingrese el email del empleado");
                     string email = Console.ReadLine();
                     while (!Validaciones.ValidarCorreo(email))
                     {
                        Console.WriteLine("Formato Invalido, ingrese un formato valido");
                        email = Console.ReadLine();
                     }

                    string id = ""; 
                    do
                    {
                        Console.WriteLine("Ingrese el ID del empleado en planilla");
                         id = Console.ReadLine();
                        while (!Validaciones.CamposVacios(id))
                        {
                            Console.WriteLine("Formato Invalido, ingrese un formato valido");
                            id = Console.ReadLine();
                        }

                        if (!Validaciones.CedulaIdIguales(cedula, id))
                        {
                            Console.WriteLine("La cedula y el ID no coinciden");

                        }
                    } while (!Validaciones.CedulaIdIguales(cedula, id));   


                        Console.WriteLine("Ingrese la profesión del empleado");
                     string profesion = Console.ReadLine();
                     while (!Validaciones.CamposVacios(profesion))
                     {
                        Console.WriteLine("Este campo no puede estar vacio");
                        profesion = Console.ReadLine();
                     }

                     Console.WriteLine("Ingrese el salario por hora del empleado");
                    double salarioHora;
                     while (!double.TryParse(Console.ReadLine(), out salarioHora) || salarioHora <=0)
                     {
                        Console.WriteLine("Dato invalido, por favor ingrese un valor numerico");                       
                     }

                     Console.WriteLine("Ingrese las horas trabajadas del empleado");
                     double horasTrabajadas;
                     while (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas <= 0)
                     {
                        Console.WriteLine("Dato invalido, por favor ingrese un valor numerico");                       
                     }

                     Console.WriteLine("Ingrese el porcentaje de rebajos del salario (ejemplo 12%)");
                     string porcentajeRebajos = Console.ReadLine();
                     double rebajos;
                     while (!double.TryParse(porcentajeRebajos.TrimEnd('%'), out rebajos) || rebajos <= 0) 
                     {
                        Console.WriteLine("Dato invalido, por favor ingrese un valor numerico");
                        porcentajeRebajos = Console.ReadLine();
                     }
                    escritura.AgregarEmpleado(cedula, nombre, email, id, profesion, salarioHora, horasTrabajadas, rebajos);   
                     Console.WriteLine("Empleado agregado y datos guardados.");                                 
                    
                    break;

                case (3):

                    Environment.Exit(0);

                    break;

                default:
                    Console.WriteLine("Opcion no valida");
                    break;
            }

          

        }
       
    }
}
