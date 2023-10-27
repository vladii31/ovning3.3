using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hej, hur länge vill du hyra bilen?");
        Console.WriteLine("Svara i hela timmar");

        string tid = Console.ReadLine();
        int timmar = int.Parse(tid);


        int pris = timmar * 85;

        if (pris < 950)
        {
            Console.WriteLine("Din kostnad blir " + pris + " kr!");
        }

        else
        {
            Console.WriteLine("Din kostnad blir 950 kr!");
        }

        Console.ReadKey();
    }
}