namespace ConditionsOppgave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Oppgave 1*/
            Console.WriteLine("Oppgave 1");
            Console.WriteLine();
            int liteTall = 5;
            int stortTall = 5;
            if (liteTall == stortTall)
            {
                Console.WriteLine(true);
            }
            else
            {
                Console.WriteLine(false);
            }
            Console.WriteLine();
            Console.WriteLine("Oppgave 2");
            Console.WriteLine();
            int tall1 = 90;
            int tall2 = 90;
            int tall3 = 0;
            if (tall1 == tall2)
            {
                tall3 = tall1 * tall2;
            }
            else
            {
                tall3 = tall1 + tall2;
            }
            Console.WriteLine(tall3);
            Console.WriteLine();
            Console.WriteLine("Oppgave 3");
            Console.WriteLine();
            int numme1 = 25;
            int numme2 = 14;
            if ((numme1 + numme2) >= 30)
            {
                Console.WriteLine(is30());
            }
            else { Console.WriteLine(isn30());  }

        }
        static bool is30()
        { return true; }
        static bool isn30() { return false; }
    }
}