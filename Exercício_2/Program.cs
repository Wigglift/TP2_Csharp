using System.Globalization;

class Exercicio2
{
    public static void Main(string[] args)
    {
        DateTime Data_nasc = pegarData();

        apresentarProxDias(proxAniversario(Data_nasc));
    }
    static DateTime pegarData()
    {
        do
        {
            try
            {

                Console.WriteLine("Digite a data de nascimento no formado dd/mm/aaaa");
                DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                return data;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Digite a data no formato certo e com informações válidas\n");
            }
        } while (true);
    }

    static int proxAniversario(DateTime data)
    {
        int prox_ano = DateTime.Today.Year + 1;


        DateTime prox_niver = new DateTime(prox_ano, data.Month, data.Day);

        TimeSpan dias = prox_niver - DateTime.Today;

        return (int)dias.TotalDays;

    }

    static void apresentarProxDias(int dias)
    {
        Console.WriteLine("Faltam {0} dias para o seu aniversário", dias);
    }
    }
