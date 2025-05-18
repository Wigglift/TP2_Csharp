using static System.Runtime.InteropServices.JavaScript.JSType;
using System;

class Exercicio9
{
    public static void Main(string[] args)
    {
        bool error = false;

        double salario = 0;

        string[] resultados;

        do
        {
            try
            {
                Console.WriteLine("Digite seu salário: (Ex: 1440,87)");
                salario = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;
            }

        } while (error);

        resultados = calcImposto(salario);

        Console.WriteLine("Salário total = {0}\n\nDescontos = {1}\n\nSalário líquido = {2}", resultados[0], resultados[1], resultados[2]);
    }

    static string[] calcImposto(double salario)
    {
        double percImposto;

        double salarioLiq;

        double descontos;

        string[] resultados = new string[3];



        if (salario <= 3036)
        {
            percImposto = 0;

        }
        else if (salario > 3036 && salario <= 3533.31)
        {
            percImposto = 0.925;

        }
        else if (salario > 3533.31 && salario <= 4688.85)
        {
            percImposto = 0.85;

        }
        else if (salario > 4688.85 && salario <= 5830.85)
        {
            percImposto = 0.775;

        }
        else
        {
            percImposto = 0.725;
        
        }

        if (percImposto == 0)
        {

            resultados[0] = salario.ToString("C");
            resultados[1] = "Não há impostos a pagar";
            resultados[2] = salario.ToString("C");

        }
        else
        {

            salarioLiq = salario * percImposto;

            descontos = salario - salarioLiq;

            resultados[0] = salario.ToString("C");
            resultados[1] = descontos.ToString("C");
            resultados[2] = salarioLiq.ToString("C");
        }

        return resultados;
    }
}