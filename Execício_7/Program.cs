using static System.Runtime.InteropServices.JavaScript.JSType;

class Exercicio7
{
    public static void Main(string[] args)
    {
        double num = 0;
        bool error = false;

        do
        {
            try
            {
                Console.WriteLine("Digite um número para verificar se é impar ou par");
                num = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;

            }
        } while (error);

        if (verifPar(num))
        {
            Console.WriteLine("Este número é par");
        } else {
            Console.WriteLine("este número é impar");
        }
    }

    static bool verifPar(double num)
    {
        if (num % 2 == 0)
        {
            return true;
        }
        else
        {
            return false;
        }
    } 
}