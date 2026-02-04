using System;

namespace EjerciciosCSharp
{
    public class Ejercicios
    {
       /// Ejercicio 1: Tabla de Multiplicar 
        public static string TablaDeMultiplicar(int numero)
        {
            string resultado = "";

            for (int i = 1; i <= 12; i++)
            {
                resultado += $"{numero} x {i} = {numero * i}\n";
            }

            return resultado;
        }
        /// Ejercicio 2: Validador de Contraseña

        public static int ValidarContrasena(Func<string> obtenerInput)
        {
            
            string claveSecreta = "1234";
            int intentos = 0;
            string entrada;
            do
            {
                entrada = obtenerInput();
                intentos++;

            } while (entrada != claveSecreta);    
            return intentos;
        }

        /// Ejercicio 3: Suma Acumulativa
        public static int SumaAcumulativa(int[] numeros)
        {        
            int suma = 0;   
            foreach (int numero in numeros)
            {
                if (numero == 0)
                    break;
                suma += numero;
            } 
            return suma;
        }
        public static string ContadorDePares()
        {  
            string resultado = "";
            
            for (int i = 0; i <= 50; i += 2)
            {
                if (i == 50)
                    resultado += i;
                else
                    resultado += i + ", ";
            }   
            return resultado;
        }
    }
}
