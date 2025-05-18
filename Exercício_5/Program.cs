class Exercicio5
{
    public static void Main(string[] args)
    {
        double celsius = 0.0;
        bool error = false;

        do
        {
            try
            {
                Console.WriteLine("Digite a temperatura em graus Celsius para ser convertida em Fahrenheit e Kelvin:");
                celsius = double.Parse(Console.ReadLine());
                error = false;
            }
            catch (Exception e)
            {
                Console.Error.WriteLine("Digite um nùmero válido\n");
                error = true;

            }
        } while (error);


        Console.WriteLine("{0}° é {1}F", celsius, convFahrenheit(celsius));

        Console.WriteLine("{0}° é {1}K", celsius, convKelvin(celsius));

    }

    static double convFahrenheit(double celsius) {
        double fahrenheit = celsius * 9 / 5 + 32;
        return fahrenheit;
    }

    static double convKelvin(double celsius)
    {

        double Kelvin = celsius + 273.15;
        return Kelvin;
    }
}