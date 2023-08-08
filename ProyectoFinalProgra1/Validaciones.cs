using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ProyectoFinalProgra1
{
    class Validaciones
    {
<<<<<<< HEAD
        public static bool ValidarCedula(string cedula)
        {
            string patron = @"^\d{9}$";
            return Regex.IsMatch(cedula, patron);
        }

        public static bool ValidarCorreo(string correo)
        {
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(correo, patron);
        }





    }  

    
=======
        public static bool ValidarCedula(string cedula) // El metodo que valida si el usuario ingresa de manera correcta su cedula
        {
            string patron = @"^\d{9}$";//Define una variable llamada patron que contiene una expresión regular (cadena de 9 digitos)
            return Regex.IsMatch(cedula, patron);//Método IsMatch de la clase Regex valida si la cadena de texto almacenada en la variable cedula 
        }

        public static bool ValidarEmail(string email) // El metodo que valida si el usuario ingresa de manera correcta su correo
        {
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"; //La expresión regular @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"valida si cadena coincide con formato dirección email.
            return Regex.IsMatch(email, patron);//verificar si la cadena de texto almacenada en la variable email coincide con el patrón definido anteriormente.
        }


    }
>>>>>>> rama-prueba
}


