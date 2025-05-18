class Exercicio12
{
    public static void Main(string[] args)
    {

        Random Ran = new Random();

        int ran_Num = Ran.Next(100);

        int user_Num = 0;

        Console.WriteLine("Digite um número para advinhar (dica: é um inteiro entre 0 e 100)");

        do
        {
            

            try
            {
                user_Num = int.Parse(Console.ReadLine());

                if (user_Num < ran_Num)
                {

                    Console.WriteLine("Número é maior que o digitado");
                }
                else if (user_Num > ran_Num)
                {
                    Console.WriteLine("Número é menor que o digitado");
                }
                else
                {
                    Console.WriteLine("parabéns você acertou!");
                }
            }
            catch (Exception e)
            {

                Console.WriteLine("\nDigite um numero inteiro\n");
                continue;
            }
        }
        while (user_Num != ran_Num);
    }
}