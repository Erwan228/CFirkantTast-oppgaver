namespace Variabler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Terjes undervisning*/
            Console.Write("Hei, hva heter du? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hei {name}!");

            Console.Write("I hvilket år ble du født? ");
            string yearStr = Console.ReadLine();
            int year = Convert.ToInt32(yearStr);
            int age = 2023 - year;
            Console.WriteLine($"Da blir du {age} år gammel i år.");
        }
    }
}