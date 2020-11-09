using System;

namespace LibreriaMatematica
{
    public class Matematica


    {
        /// <summary>
        /// Questa funzione esegue la somma tra due numeri decimali
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Somma(double n1, double n2)
        {
            return n1 + n2;
        }
        /// <summary>
        /// questa funzione esegue la somma tra due numeri interi
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>

        public static int Somma(int n1, int n2)
        {
            return n1 + n2;
        }
        /// <summary>
        /// Questa funzione esegue la moltiplicazione tra 2 numeri
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Moltiplicazione(double n1, double n2)
        {
            return n1 * n2;

        }
        /// <summary>
        /// Questa funzione esegue la sottrazione tra 2 numeri
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Differenza(double n1, double n2)
        {
            return n1 - n2;

        }
        /// <summary>
        /// Questa funzione esegue la divisione tra 2 numeri
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <returns></returns>
        public static double Divisione(double n1, double n2)
        {
            return n1 / n2;

        }/// <summary>
         /// Questa funzione esegue la potenza di un numero
         /// </summary>
         /// <param name="n1"></param>
         /// <param name="n2"></param>
         /// <returns></returns>
        public static long Potenza(int n1, int n2)
        {
            long potenza = 1;
            int contatore = 0;
            for (; contatore < n2; contatore++)
            {
                potenza = potenza * n1;
            }
            return potenza;
        }
        /// <summary>
        /// Questa funzione esegue il calcolo fattoriale di un numero
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static long CalcoloFattoriale(int n1)
        {
            long fattoriale = 1;
            int contatore = 1;
            for (; contatore <= n1; contatore++)
            {
                fattoriale = fattoriale * contatore;
            }
            return fattoriale;
        }
        /// <summary>
        /// Questa funzione trova il minore tra 3 numeri
        /// </summary>
        /// <param name="n1"></param>
        /// <param name="n2"></param>
        /// <param name="n3"></param>
        /// <returns></returns>
        public static int MinoreTra(int n1, int n2, int n3)
        {
            int min;
            if (n1 < n2 && n1 < n3)
            {
                min = n1;
            }
            else if (n2 < n1 && n2 < n3)
            {
                min = n2;
            }
            else
            {
                min = n3;
            }
            return min;
        }

        /// <summary>
        /// Questa funzione inverte un numero
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static double Inverso(int n1)
        {
            return n1 = n1 * -1;
        }
        /// <summary>
        /// Questa funzione dichiara se un numero é pari
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static bool IsPari(int n1)
        {
            bool IsPari;
            if (n1 % 2 == 0)
            {
                IsPari = true;
            }
            else
            {
                IsPari = false;
            }

            return IsPari;
        }
        /// <summary>
        /// Questa funzione dichiara se un numero é dispari
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static bool IsDispari(int n1)
        {
            bool IsDispari;
            if (n1 % 2 == 0)
            {
                IsDispari = false;
            }
            else
            {
                IsDispari = true;
            }
            return IsDispari;
        }
        /// <summary>
        /// Questa funzione dichiara se un numero é positivo
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static bool IsPositivo(int n1)
        {
            bool IsPositivo;
            if (n1 > 0)
            {
                IsPositivo = true;
            }
            else
            {
                IsPositivo = false;
            }
            return IsPositivo;
        }
        /// <summary>
        /// Questa funzione dichiara se un numero é negativo
        /// </summary>
        /// <param name="n1"></param>
        /// <returns></returns>
        public static bool IsNegativo(int n1)
        {
            bool IsNegativo;
            if (n1 < 0)
            {
                IsNegativo = true;
            }
            else
            {
                IsNegativo = false;
            }
            return IsNegativo;
        }
    }

}

