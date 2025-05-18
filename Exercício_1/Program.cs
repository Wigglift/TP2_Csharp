using System.Globalization;

class Exercicio1 { 
public static void Main(string[] args)
    {
        DateTime data = pegarData();

        apresentarIdade(tempoDeVida(data));
    }
    public static DateTime pegarData()
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

    public static int[] tempoDeVida(DateTime data)
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

        int[] data_arr = new int[3];

        //atribuído número das datas para um array, por causa do tipo DateTime começar com o ano 1

        data_arr[0] = anos;
        data_arr[1] = meses;
        data_arr[2] = dias;

        return data_arr;

    }

    public static void apresentarIdade(int[] data)
    {
        Console.WriteLine("Você tem {0} anos, {1} meses e {2} dias de vida", data[0], data[1], data[2]);
    }

}

