using static System.Runtime.InteropServices.JavaScript.JSType;

class Exercicio10
{
    public static void Main(string[] args) {

        int num = 0;

        bool error;

        do
        {
            try
            {
                Console.WriteLine("Digite um número inteiro pra uma contagem regressiva");
                num = int.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;
            }

        } while (error);

        for (int i = num; i >= 0; i--)
        {

            if (i == 0) Console.Write("{0}", i); else Console.Write("{0},", i);
        }

    }


}