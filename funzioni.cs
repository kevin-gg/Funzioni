using System;

namespace Funzioni
{
    public static void double somma(double n1, double n2)
    {
        return = n1 + n2
    }
    public static void int somma(int n1, int n2)
    {
        return = n1 + n2
    }
    public static void double moltiplicazione(double n1, double n2)
    {
        return = n1 * n2

    }
    public static void double differenza(double n1, double n2)
    {
        return = n1 - n2

    }
    public static void double divisione(double n1, double n2)
    {
        return = n1 / n2

    }
    public static long potenza(int n1, int n2)
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
        public static double inverso(int n1)
        {
            return n1 = n1 * -1;
        }
    }





