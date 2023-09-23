using Cards.Classes;
using System.Security.Principal;

internal class Program
{
    private static void Main(string[] args)
    {
        UserInterface UI = new UserInterface();

        UI.Run();

        Deck deck1 = new Deck();
        deck1.Shuffle();
        for (int i = 0; i < 52; i++)
        {
            Console.Write("{0, -19}", deck1.DealCard());
            if ((i + 1) % 4 == 0)
            {
                Console.WriteLine();
            }
        }
        Console.ReadLine();
    }
}