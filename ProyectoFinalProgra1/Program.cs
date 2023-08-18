using System;
using System.Collections.Generic;

namespace ProyectoFinalProgra1
{
    class Program
    {
        static string pathEmp = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Empleados.txt";
        static  string pathPlan = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Planilla.txt";
        static string pathTodos = @"C:\Users\danie\source\repos\ProFinProg1\ProyectoFinalProgra1\Archivos\Planilla_del_mes.txt";
        static void Main(string[] args)
        {
            //Instancias de Listas para almecenar datos de los txt leidos y nuevos datos mixtos
            List<string> datosEmp = new List<string>(); 
            List<string> datosPlan = new List<string>();
            List<string> datosFun = new List<string>();



            LeerDatos lectura = new LeerDatos(pathEmp, pathPlan, pathTodos); //Instancia de la Clase leer Datos para llamar sus metodos.
            EscribirDatos escritura = new EscribirDatos(pathEmp, pathPlan); // Instancia de la Clase Escribir Datos para llamar sus metodos.

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



            try
            { //Try Catch para que el programa no se cierre si se ingresa una opcion tipo string o char
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
                                Console.WriteLine("¿Desea Imprimir Reporte?\n Presione (S) Generar reporte o (N) Retorno a menu principal");
                                char desicion = Convert.ToChar(Console.ReadLine());
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
                                string buscador = datosEmp.Find(x => x.Contains(ced));

                                if (buscador == null)
                                {
                                    Console.WriteLine("Cédula no encontrada");
                                    Console.WriteLine("Presione cualquier tecla para volver a Menu Principal");
                                    Console.ReadKey();
                                    goto MainMenu;

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




                    case (2): //Formulario para agregar un nuevo empleado a los archivos
                        Console.Clear();
                        Console.WriteLine("Ingrese la cédula del empleado"); //Se ingresa en este caso la cedula y se llama a la clase validaciones para verificar los datos
                        string cedula = Console.ReadLine();                  //El proceso se repite en cada una de los datos con sus respectivas validaciones para cada caso
                        while (!Validaciones.ValidarCedula(cedula))
                        {
                            Console.WriteLine("Formato Invalido, ingrese un formato valido");
                            cedula = Console.ReadLine();
                        }

                        Console.WriteLine("Ingrese el nombre y apellidos del empleado"); //Ingreso del nombre
                        string nombre = Console.ReadLine();
                        while (!Validaciones.CamposVacios(nombre))
                        {
                            Console.WriteLine("Este campo no puede estar vacio");
                            nombre = Console.ReadLine();
                        }

                        Console.WriteLine("Ingrese el email del empleado"); //Ingreso del email
                        string email = Console.ReadLine();
                        while (!Validaciones.ValidarCorreo(email))
                        {
                            Console.WriteLine("Formato Invalido, ingrese un formato valido");
                            email = Console.ReadLine();
                        }

                        string id = "";
                        do
                        {
                            Console.WriteLine("Ingrese el ID del empleado en planilla"); //Ingreso del ID
                            id = Console.ReadLine();
                            while (!Validaciones.CamposVacios(id)) //Verifica que el ID no se encuentre vacio
                            {
                                Console.WriteLine("Formato Invalido, ingrese un formato valido");
                                id = Console.ReadLine();
                            }

                            if (!Validaciones.CedulaIdIguales(cedula, id)) //Aca se llama al metodo de la clase validaciones y se verifica que sean iguales tanto cedula como ID
                            {
                                Console.WriteLine("La cedula y el ID no coinciden");

                            }
                        } while (!Validaciones.CedulaIdIguales(cedula, id));


                        Console.WriteLine("Ingrese la profesión del empleado"); //Se ingresa la profesion
                        string profesion = Console.ReadLine();
                        while (!Validaciones.CamposVacios(profesion))
                        {
                            Console.WriteLine("Este campo no puede estar vacio");
                            profesion = Console.ReadLine();
                        }

                        Console.WriteLine("Ingrese el salario por hora del empleado"); //Ingreso del salario por hora
                        double salarioHora;
                        while (!double.TryParse(Console.ReadLine(), out salarioHora) || salarioHora <= 0) //utilizo la funcion TryParse para verificar que el dato ingresado sea tipo numerico
                        {                                                                                 // Al mismo tiempo verifico que sea mayor que cero
                            Console.WriteLine("Dato invalido, por favor ingrese un valor numerico");
                        }

                        Console.WriteLine("Ingrese las horas trabajadas del empleado"); //Ingreso de las horas trabajadas
                        double horasTrabajadas;
                        while (!double.TryParse(Console.ReadLine(), out horasTrabajadas) || horasTrabajadas <= 0)
                        {
                            Console.WriteLine("Dato invalido, por favor ingrese un valor numerico");
                        }

                        Console.WriteLine("Ingrese el porcentaje de rebajos del salario (ejemplo 12%)");
                        string porcentajeRebajos = Console.ReadLine();
                        double rebajos;
                        while (!double.TryParse(porcentajeRebajos.TrimEnd('%'), out rebajos) || rebajos <= 0) //En este caso es similar a los metodos anteriores pero este permite ingresar un "%"
                        {
                            Console.WriteLine("Dato invalido, por favor ingrese un valor numerico");
                            porcentajeRebajos = Console.ReadLine();
                        }

                        Console.WriteLine("¿Desea guardar los datos? (S) Sí / (N) No"); //Pregunto si deseo guardar los datos
                        char guardarDecision = Convert.ToChar(Console.ReadLine());

                        if (guardarDecision == 'S' || guardarDecision == 's')
                        {
                            escritura.AgregarEmpleado(cedula, nombre, email, id, profesion, salarioHora, horasTrabajadas, rebajos); //LLamo al metodo que agrega los datos de los archivos por parametros
                        }
                        else if (guardarDecision == 'N' || guardarDecision == 'n')
                        {
                            Environment.Exit(0);
                        }
                        else
                        {
                            Console.WriteLine("Opción inválida. El programa se cerrará.");
                            Environment.Exit(0);
                        }

                        break;

                    case (3):

                        Environment.Exit(0);

                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Por favor ingrese un digito valido \nPresione cualquier tecla para volver a Menu Principal");
                        Console.ReadKey();
                        goto MainMenu;
                        
                }


            }
            catch (FormatException)
            {
                Console.Clear();
                Console.WriteLine("Por favor ingrese un digito valido \nPresione cualquier tecla para volver a Menu Principal");
                Console.ReadKey();
                goto MainMenu;
            }
            
        }       
    }
}
       
    

