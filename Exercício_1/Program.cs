public class Program { 
public static void Main(string[] args)
    {
        DateTime data = pegarData();

        apresentarIdade(tempoDeVida(data));
    }
    public static DateTime pegarData()
    {
        Console.WriteLine("Digite o dia de nascimento");
        int data_nasc_dia = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o mês de nascimento");
        int data_nasc_mes = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o ano de nascimento");
        int data_nasc_ano = int.Parse(Console.ReadLine());

        return new DateTime(data_nasc_ano,data_nasc_mes,data_nasc_dia);
    }

    public static DateTime tempoDeVida(DateTime data)
    {
        DateTime hoje = DateTime.Today;

        int anos = hoje.Year - data.Year;
        int meses = hoje.Month - data.Month;
        int dias = hoje.Day - data.Day;

        // Ajustes do dia e do mês

        if (dias <= 0)
        {
            meses--;
            dias += DateTime.DaysInMonth(hoje.Year, (hoje.Month == 1 ? 12 : hoje.Month - 1));
        }

        if (meses <= 0)
        {
            anos--;
            meses += 12;
        }

        return new DateTime(anos, meses, dias);

    }

    public static void apresentarIdade(DateTime data)
    {
        Console.WriteLine("Você tem {0} anos, {1} meses e {2} dias de vida", data.Year, data.Month, data.Day);
    }

}

