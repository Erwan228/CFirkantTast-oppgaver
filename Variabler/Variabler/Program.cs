namespace Variabler
{
    internal class Program
    {


        static void Main(string[] args)
        {
            int number = 69;
        long lNumber = 1222222222;
        float flyte = 6.9f;
        decimal dessi = 6.9M;
        double ddeessii = 6.9;
        string streng = "Jeg elsker hamburger";
        char kara = 'C';
        bool om = true;
            Console.WriteLine($"Jeg liker {number}");
            Console.WriteLine($"Jeg vil ha {lNumber} pølser");
            Console.WriteLine($"Nå noen dumme tall: {flyte} {dessi} {ddeessii}");
            Console.WriteLine($"Alle vet at {streng} med mye {kara}. Yes thats {om}");

            int a = 5;
            decimal b = 3.0M;
            decimal sum = a + b;
            Console.WriteLine($"{sum}");
        }
    }
}