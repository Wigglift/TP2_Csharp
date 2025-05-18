using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class Exercicio8
{
    public static void Main(string[] args)
    {
        bool error = false;

        double num = 0; 

        do
        {
            try
            {
                Console.WriteLine("Digite uma nota de 0 a 10");
                num = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;

            }

            if (num < 0 || num > 10) error = true;

        } while (error);

        Console.WriteLine("A classificação da sua nota é: {0}",nivelNota(num));
    }

    static string nivelNota(double nota)
    {
        if (nota < 5)
        {
            return "Insuficiente";
        }
        else if (nota >= 5 && nota < 7)
        {
            return "Regular";
        }
        else if (nota >= 7 && nota < 9)
        {
            return "Bom";
        }
        else
        {
            return "Excelente";
        }

    }
}