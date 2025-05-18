class Exercicio11
{
    public static void Main(string[] args)
    {
        bool error = false;

        double num = 0;


        do
        {
            try
            {
                Console.WriteLine("Digite um número para mostrar a tabuada:");
                num = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;
            }

        } while (error);

        for (int i = 0; i <= 10; i++)
        {
            Console.WriteLine("{0}x{1}={2}",num,i,i*num);

        }
    }
}
