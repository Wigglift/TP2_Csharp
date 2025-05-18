using static System.Runtime.InteropServices.JavaScript.JSType;

class Exercicio6
{
    public static void Main(string[] args)
    {
        double altura = 0;
        double peso = 0;
        bool error = false;

        do
        {
            try
            {
                Console.WriteLine("Digite sua altura (ex: 1,76):");
                altura = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;

            }
        } while (error);

        do
        {
            try
            {
                Console.WriteLine("Digite seu peso (ex: 89,4):");
                peso = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;

            }
        } while (error);

        double imc = calcularImc(altura, peso);

        Console.WriteLine("Seu imc é de: {0}\nSua categoria é: {1}", imc, faixaImc(imc));

    }

    static double calcularImc(double altura, double peso)
    {
        double imc = peso / (altura * altura);
        return imc;

    }

    static string faixaImc(double imc)
    {
        if (imc <= 18.5)
        {
            return "Baixo peso";
        }
        else if (imc > 18.5 && imc <= 24.9)
        {
            return "Normal";
        }
        else if (imc > 24.9 && imc <= 29.9)
        {
            return "Sobrepeso";
        }
        else if (imc > 29.9 && imc <= 34.9)
        {
            return "Obesidade";
        }
        else if (imc > 34.9 && imc <= 39.9)
        {
            return "Obesidade Mórbida Grave";
        }
        else
        {
            return "Obesidade Mórbida Muito Grave";
        }
    }
}