using System;
using System.Reflection.Metadata;

class Sample
{

    //Main methond that execution find to execute first
    static void Main()
    {
        Console.WriteLine("Any new write line will come after it");
        Console.Write("I ");
        Console.Write("Won't be coming on");
        Console.Write("Next Line");

        Console.ReadKey();
        //Take value
        string value = Console.ReadLine();

        if(value != null)
        {
            Console.Write(value);
        }
    }
}