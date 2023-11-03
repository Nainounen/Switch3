using System;

class Program
{
    static void Main()


    {

        int Entscheidung;
        Console.WriteLine("Wollen Sie Ihre Zahlen mit einer normalen Operation rechnen oder eine Wurzel Rechnung?\n1=Operation\n2=Wurzel");
        Entscheidung = int.Parse(Console.ReadLine());

        switch (Entscheidung)
        {
            case 1:
                Console.WriteLine("Bitte geben Sie die erste Zahl:  ");
                double zahl1 = double.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie die zweite Zahl:  ");
                double zahl2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Bitte geben Sie eine Rechenoperation ( +, -, *, /");
                char operation = Console.ReadKey().KeyChar;

                double Ergebnis = 0;

                switch (operation)
                {
                    case '+':
                        Ergebnis = zahl1 + zahl2;
                        break;
                    case '-':
                        Ergebnis = zahl1 - zahl2;
                        break;
                    case '*':
                        Ergebnis = zahl1 * zahl2;
                        break;
                    case '/':
                        Ergebnis = zahl1 / zahl2;
                        break;

                }
                Console.WriteLine($"\nErgebnis: {zahl1} {operation} {zahl2} = {Ergebnis}");

                break;

            case 2:

                Console.WriteLine("Geben Sie eine Zahl ein: ");
                double zahl3 = double.Parse(Console.ReadLine());
                double wurzel = Math.Sqrt(zahl3);

                Console.WriteLine($"Die Wurzel von {zahl3} ist {wurzel}");
                break;


        }


    }
}