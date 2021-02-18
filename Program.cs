using System;

namespace Elephant
{
    class Program
    {
        static void Main(string[] args)
        {
            Elephant lloyd = new Elephant() { Name = "Lloyd", EarSize = 40};
            Elephant lucinda = new Elephant() { Name = "Lucinda", EarSize = 33};
            Console.WriteLine("Press 1 for Lloyd, 2 for Lucinda, 3 for swap");

            while (true)
            {
                char input = Console.ReadKey(true).KeyChar;
                Console.WriteLine("You pressed " + input);

                if (input == '1')
                {
                    Console.WriteLine("Calling lloyd.WhoAmI()");
                    lloyd.WhoAmI();
                }
                else if (input == '2')
                {
                    Console.WriteLine("Calling lucinda.WhoAmI()");
                    lucinda.WhoAmI();
                }
                else if (input == '3')
                {
                    Elephant holder;
                    holder = lloyd;
                    lloyd = lucinda;
                    lucinda = holder;
                    Console.WriteLine("References have been swaped");
                }
                else if (input == '4')
                {
                    // this will revome reference to lloyd object and breaks program logic
                    // press 4 only for understanding what it will to do
                    lloyd = lucinda;
                    lloyd.EarSize = 4321;
                    lloyd.WhoAmI();
                }
                else if (input == '5')
                {
                    lucinda.SpeakTo(lloyd, "Hi, Lloyd!");
                    lloyd.SpeakTo(lucinda, "Hi, Lucinda!");
                }
                else 
                {
                    return;
                }

                Console.WriteLine();
            }
        }
    }
}
