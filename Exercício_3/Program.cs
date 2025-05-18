using System.Diagnostics.Metrics;
using System.Globalization;

class Exercicio3
{
    public static void Main(string[] args)
    {
       

        Console.WriteLine("digite a primeira data");
        DateTime p_data = pegarData();

        Console.WriteLine("digite a segunda data");
        DateTime s_data = pegarData();

        apresentarDiferenca(diferencaData(p_data, s_data));


    }

    public static int[] diferencaData(DateTime data1, DateTime data2)
    
    {
        TimeSpan data_span = (data1 - data2) < TimeSpan.Zero ? data2 - data1 : data1 - data2;

        int[] dif_data = new int[3];

        if (data_span.TotalDays > 396)
        {

            //preparando a variável de dias para somar com o datetime, como ele começa 01/01/0001 para ter a diferença exata precisamos tirar esses dias do total

            TimeSpan add_span = TimeSpan.FromDays(data_span.TotalDays - 396);

            DateTime dif_data_dt = new DateTime().AddDays(add_span.Days);

            dif_data[0] = dif_data_dt.Year;
            dif_data[1] = dif_data_dt.Month;
            dif_data[2] = dif_data_dt.Day;

        }
        else
        {
            int dia_mes_1 = DateTime.DaysInMonth(data1.Year, data1.Month);
            int dia_mes_2 = DateTime.DaysInMonth(data2.Year, data2.Month);

            int anos = (data1.Year - data2.Year) < 0 ? (data1.Year - data2.Year) * -1 : (data1.Year - data2.Year);
            int meses = (data1.Month - data2.Month) < 0 ? (data1.Month - data2.Month) * -1 : (data1.Month - data2.Month);
            int dias = (dia_mes_1 - dia_mes_2) < 0 ? (dia_mes_1 - dia_mes_2) * -1 : (dia_mes_1 - dia_mes_2);

            //atribuído número das datas para um array
            //o tipo DateTime padrão vem como 01/01/0001 e não aceita datas menores
            //por isso o timespan geraria problemas para demonstrar datas com 0 de diferença entre elas

            dif_data[0] = anos;
            dif_data[1] = meses;
            dif_data[2] = dias;

            
        }

        return dif_data;

    }

    public static DateTime pegarData()
    {
        do
        {
            try
            {
                DateTime data = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy", CultureInfo.InvariantCulture);

                return data;
            }
            catch (Exception ex)
            {
                Console.Error.WriteLine("Digite a data no formato certo e com informações válidas\n");
            }
        } while (true);
    }

    static void apresentarDiferenca(int[] data)
    {
        Console.WriteLine("há uma diferença de {0}, {1} meses e {2} dias entre as datas informadas", data[0], data[1], data[2]);
    }

}