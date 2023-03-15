namespace Konsollapplikasjon
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Skriv inn noe og trykk enter ");
            var rTekst = Console.ReadLine();
            Console.WriteLine(rTekst);
            Console.Write(rTekst);
            Console.WriteLine(rTekst);

            Console.WriteLine("Hei, hva heter du?");
            var real = Console.ReadLine();
            Console.WriteLine("Velkommen " + real);
        }
    }
}