// See https://aka.ms/new-console-template for more information

int random;
Random randm = new Random();
random = randm.Next(1, 101);

Console.WriteLine("Willkommen beim Randomnumber Game, drücken sie Enter um zu beginnen");
Console.ReadLine();



Console.WriteLine("Versuchen sie die Zahl zwischen 1 bis 100 zu errraten");

bool durchgang = true;
int versuch = 1;


    while (durchgang == true)
    {
        try
        {

            int grandom = Convert.ToInt32(Console.ReadLine());

            while (grandom != random)
            {

                while (grandom < 1 | grandom > 100)
                {
                    Console.WriteLine("Bitte geben sie eine Gültige zahl ein");
                }

                if (grandom < random)
                {
                    Console.WriteLine("Zu tief, raten sie höher");
                }

                else if (grandom > random)
                {
                    Console.WriteLine("Zu hoch, raten sie tiefer");
                }
                versuch++;
                grandom = Convert.ToInt32(Console.ReadLine());

            }
            if (grandom == random)
            {
                Console.WriteLine("WOW, super sie haben die Zahl erraten");
                durchgang = false;
                Console.WriteLine("Sie brauchten " + versuch + " Versuche um die Zahl zu finden");
            }
        }
        catch
        {
            Console.WriteLine("Hoppala!, versuchen sie nur Zahlen von 1 bis 100 einzugeben");
        }
    }












