class Exercicio4
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite seu nome:");
        string nome = Console.ReadLine();
        Console.WriteLine("Digite sua idade:");
        string idade = Console.ReadLine();
        Console.WriteLine("Digite seu telefone:");
        string telefone = Console.ReadLine();
        Console.WriteLine("Digite seu email:");
        string email = Console.ReadLine();

        apresentarInfo(nome, idade, telefone, email);

    }

    static void apresentarInfo(string nome, string idade, string telefone, string email)
    {
        Console.WriteLine("\nSeu nome é:\n{0}\n\nSua idade é:\n{1}\n\nSeu telefone é:\n{2}\n\nSeu email é:\n{3}\n", nome,idade,telefone,email);
    }
}