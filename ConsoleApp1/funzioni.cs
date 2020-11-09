using System;

namespace Funzioni
{
    public static double Somma(double n1, double n2)
    {
        return  n1 + n2;
    }
    public static  int Somma(int n1, int n2)
    {
        return  n1 + n2;
    }
    public static  double Moltiplicazione(double n1, double n2)
    {
        return  n1 * n2;

    }
    public static  double Differenza(double n1, double n2)
    {
        return  n1 - n2;

    }
    public static  double Divisione(double n1, double n2)
    {
        return  n1 / n2;

    }
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
    

        public static double Inverso(int n1)
        {
            return n1 = n1 * -1;
        }
    }





