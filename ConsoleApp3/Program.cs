using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(DateTime.Now);
        Console.WriteLine(DateTime.Now.ToString());
        Console.WriteLine(DateTime.Now.ToShortTimeString ());
        Console.WriteLine(DateTime.Now.ToLongTimeString ());
        Console.WriteLine(DateTime.Now.ToLongDateString ());
        Console.WriteLine(DateTime.Now.ToString ("d"));
        Console.WriteLine(DateTime.Now.ToString("D"));
        Console.WriteLine(DateTime.Now.ToString("f"));
        Console.WriteLine(DateTime.Now.ToString("F"));
        Console.WriteLine(DateTime.Now.ToString("g"));
        Console.WriteLine(DateTime.Now.ToString("D"));
        Console.WriteLine(DateTime.Now.ToString("m"));
        Console.WriteLine(DateTime.Now.ToString("r"));
        Console.WriteLine(DateTime.Now.ToString("s"));
        Console.WriteLine(DateTime.Now.ToString("t"));
        Console.WriteLine(DateTime.Now.ToString("T"));
        Console.WriteLine(DateTime.Now.ToString("u"));
        Console.WriteLine(DateTime.Now.ToString("U"));
        Console.WriteLine(DateTime.Now.ToString("y"));
        Console.WriteLine(DateTime.Now.ToString("dddd , MMMM dd yyyy"));
        Console.WriteLine(DateTime.Now.ToString("dddd , MMM dd"));
        Console.WriteLine(DateTime.Now.ToString("M/yy"));
        Console.WriteLine(DateTime.Now.ToString("dd-MM-yy"));  
    }
}