﻿using System;
using System.Collections.Generic;

namespace ProyectoFinalProgra1
{
    class Program
    {
<<<<<<< HEAD
        //declaracion de campos que contienen string path para enviar por parámetro
        static string pathEmp = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Empleados.txt";
        static string pathPlan = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Planilla.txt";
        static string pathTodos = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Planilla_del_mes.txt";

=======
        static string pathEmp = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Empleados.txt";
        static  string pathPlan = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Planilla.txt";
        static string pathTodos = @"C:\Users\Fabián\Desktop\ProyectoProgramacion1Final\ProyectoFinalProgra1\Archivos\Planilla_del_mes.txt";
>>>>>>> 7e05bcd227c23c9efdff06012415063458fad551
        static void Main(string[] args)
        {
            //Instancias de Listas para almecenar datos de los txt leidos y nuevos datos mixtos
            List<string> datosEmp = new List<string>(); 
            List<string> datosPlan = new List<string>();
            List<string> datosFun = new List<string>();



            LeerDatos lectura = new LeerDatos(pathEmp, pathPlan, pathTodos); //Instancia de la Clase leer Datos para llamar sus metodos.
            EscribirDatos escritura = new EscribirDatos(pathEmp, pathPlan);

            datosEmp = lectura.LeerArchivo(pathEmp); //Almacenar en las listas los datos leidos por metodo LeerArchivo segun path enviado
            datosPlan = lectura.LeerArchivo(pathPlan);

            List<string> datosMixtos = new List<string>();
            //Cilco for recorre lista, se almacena en arreglos separado por espacios y rellena nueva lista datos mixtos.
            for (int i = 0; i < datosEmp.Count; i++)
            {
                string[] arregloEmp = datosEmp[i].Split(" ");
                string[] arregloPlan = datosPlan[i].Split(" ");
                int salaB = Convert.ToInt32(arregloPlan[2]) * Convert.ToInt32(arregloPlan[3]);
                string valorRebajo = arregloPlan[4].Replace("%", " ");
                double rebajo = (double.Parse(valorRebajo) / 100) * salaB;
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

                 );
            }




         //Etiqueta para retorno a menu principal
        MainMenu:
            bool continua = true;
            do
            {
                Console.Clear();
                int opcion;
                Console.WriteLine("_______________DISTRIBUIDORA DEL NORTE_______________");
                Console.WriteLine(" ");
                Console.WriteLine("          ~~~~~ MENU PRINCIPAL ~~~~~\n                 ");
                Console.WriteLine(" 1----- VER SALARIOS\n  ");
                Console.WriteLine(" 2----- AGREGAR EMPLEADOS\n ");
                Console.WriteLine(" 3---Salir\n ");
                Console.WriteLine("Digite una opcion mediante los numeros 1, 2 o 3 ");
                opcion = Convert.ToInt32(Console.ReadLine());

<<<<<<< HEAD
                //Estructura Switch para manejo de opciones de menu y sub menu anidado
                switch (opcion)
                {
                    case (1):
=======

                switch (opcion)
                {

                    case (1):

>>>>>>> 7e05bcd227c23c9efdff06012415063458fad551
                        Console.Clear();
                        int submenu;
                        Console.WriteLine("1---Todos los Salarios\n");
                        Console.WriteLine("2---Buscar salario por ID\n");
                        Console.WriteLine("3---Salir\n");
                        Console.WriteLine("Selecione 1, 2, o 3");
                        submenu = Convert.ToInt32(Console.ReadLine());

                        switch (submenu)
                        {

<<<<<<< HEAD
                            case (1): //Muestra todos los salario

                                Console.Clear();
                                Console.WriteLine("________________Todos los Salarios______________");
                                string[] tabla = { "Nombre", "Apellidos", "Horas Trabajadas", "Salario/Hora", "Salario Bruto", "Rebajos", "Salario Neto" };
                                Console.WriteLine($"{tabla[0]} {tabla[1],2} {tabla[2],2} {tabla[3],2} {tabla[4],2} {tabla[5],2} {tabla[6],2}");
                                foreach (var Lista in datosMixtos) //Impresion detos de lista
=======
                            case (1):
                                Console.Clear();
                                Console.WriteLine("________________Todos los Salarios______________");
                                string[] tabla = { "Nombre", "Apellidos", "Horas Trabajadas", "Salario/Hora", "Salario Bruto", "Rebajos", "Salario Neto" };
                                Console.WriteLine($"{tabla[0]} {tabla[1],2} {tabla[2],2} {tabla[3],2} {tabla[4],2} {tabla[5],2} {tabla[6],2}");

                                foreach (var Lista in datosMixtos)
>>>>>>> 7e05bcd227c23c9efdff06012415063458fad551
                                {
                                    Console.WriteLine(Lista);
                                }
                                Console.WriteLine("¿Desea Imprimir Reporte?\n Presione (S) Generar reporte o (N) Retorno a menu principal");
                                char desicion = Convert.ToChar(Console.ReadLine());
<<<<<<< HEAD

                                if (desicion == 'S' || desicion == 's')//Segun desicion en pantalla se llama al metodo que genera reporte
                                {
                                    lectura.CrearArchivo(pathTodos, datosMixtos);
                                }
                                else if (desicion == 'N' || desicion == 'n')
                                {
                                    goto MainMenu;
                                }
                                break;


                            case (2)://Buscar por ID
                                Console.Clear();
                                string ced;
                                Console.WriteLine("Ingrese el numero de cedula");
                                ced = Console.ReadLine();
                                datosEmp.Find(x => x.Contains(ced));
                                if (ced == null)
                                {
                                    Console.WriteLine("Cédula no encontrada");
                                }
                                else
                                {
                                    foreach (var v in datosEmp) //recorre la lista ya creada, subdivide y almacena en arreglos
                                    {
                                        string funcionario = datosEmp.Find(x => x.Contains(ced));
                                        string informacion = datosPlan.Find(x => x.Contains(ced));
                                        string[] arregloFun = funcionario.Split(" ");
                                        string[] arregloInf = informacion.Split(" ");
                                        int salB = Convert.ToInt32(arregloInf[2]) * Convert.ToInt32(arregloInf[3]);
                                        string vRebajo = arregloInf[4].Replace("%", " ");
                                        double deduccion = (double.Parse(vRebajo) / 100) * salB;
                                        double sNeto = salB - deduccion;
                                        datosFun.Add
                                            (
                                            arregloFun[1] + " " +
                                            arregloFun[2] + " " +
                                            arregloFun[3] + " " +
                                            arregloInf[3] + " " +
                                            arregloInf[2] + " " +
                                            salB.ToString() + " " +
                                            deduccion.ToString() + " " +
                                            sNeto.ToString()

                                            );


                                        break;
                                    }

                                }

                                foreach (var list in datosFun)
                                {
                                    Console.WriteLine(list);
                                }
                                Console.WriteLine("Desea Generar Reporte\n Presione (S) Si o (N) No");
                                char elegir = Convert.ToChar(Console.ReadLine());

                                if (elegir == 'S' || elegir == 's')
                                {
                                    string pathFun = $@"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\{ced}.txt";
                                    lectura.CrearArchivo(pathFun, datosFun);
                                }
                                else if (elegir == 'N' || elegir == 'n')
                                {
                                    goto MainMenu;
                                }
                                break;

                            case (3): //Sale completamente del programa
                                Environment.Exit(0);
                                break;

                        }
                        break;

                    case (2): //Switch principal Agregar empleado                                

=======
                                if (desicion == 'S' || desicion == 's')
                                {
                                    lectura.CrearArchivo(pathTodos, datosMixtos);
                                }
                                else if (desicion == 'N' || desicion == 'n')
                                {
                                    goto MainMenu;

                                }
                                break;

                            case (2):
                                Console.Clear();
                                string ced;
                                Console.WriteLine("Ingrese el numero de cedula");
                                ced = Console.ReadLine();
                                datosEmp.Find(x => x.Contains(ced));
                                if (ced == null)
                                {
                                    Console.WriteLine("Cédula no encontrada");
                                }
                                else
                                {
                                    foreach (var v in datosEmp)
                                    {
                                        string funcionario = datosEmp.Find(x => x.Contains(ced));
                                        string informacion = datosPlan.Find(x => x.Contains(ced));
                                        string[] arregloFun = funcionario.Split(" ");
                                        string[] arregloInf = informacion.Split(" ");
                                        int salB = Convert.ToInt32(arregloInf[2]) * Convert.ToInt32(arregloInf[3]);
                                        string vRebajo = arregloInf[4].Replace("%", " ");
                                        double deduccion = (double.Parse(vRebajo) / 100) * salB;
                                        double sNeto = salB - deduccion;
                                        datosFun.Add
                                            (
                                            arregloFun[1] + " " +
                                            arregloFun[2] + " " +
                                            arregloFun[3] + " " +
                                            arregloInf[3] + " " +
                                            arregloInf[2] + " " +
                                            salB.ToString() + " " +
                                            deduccion.ToString() + " " +
                                            sNeto.ToString()

                                            );


                                        break;
                                    }

                                }

                                foreach (var list in datosFun)
                                {
                                    Console.WriteLine(list);
                                }
                                Console.WriteLine("Desea Generar Reporte\n Presione (S) Si o (N) No");
                                char elegir = Convert.ToChar(Console.ReadLine());

                                if (elegir == 'S' || elegir == 's')
                                {
                                    string pathFun = $@"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\{ced}.txt";
                                    lectura.CrearArchivo(pathFun, datosFun);
                                }
                                else if (elegir == 'N' || elegir == 'n')
                                {
                                    goto MainMenu;
                                }


                                break;

                            case (3):
                                Environment.Exit(0);
                                break;

                            default:
                                Console.WriteLine("Opcion novalida");
                                break;

                        }

                        break;




                    case (2):

>>>>>>> 7e05bcd227c23c9efdff06012415063458fad551
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
                        while (!double.TryParse(Console.ReadLine(), out salarioHora) || salarioHora <= 0)
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
<<<<<<< HEAD
                        continua = false;
                        Environment.Exit(0);

                        break;


                }

            } while (continua);

        }
=======

                        Environment.Exit(0);

                        break;

                    default:
                        Console.WriteLine("Opcion no valida");
                        break;
                }
            } while (continua);
        }       
>>>>>>> 7e05bcd227c23c9efdff06012415063458fad551
    }
}
       
    

