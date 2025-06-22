// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        IImage image1 = new ProxyImage("photo1.jpg");
        IImage image2 = new ProxyImage("photo2.jpg");

        Console.WriteLine("Accessing first image:");
        image1.Display();

        Console.WriteLine("\nAccessing first image again:");
        image1.Display();

        Console.WriteLine("\nAccessing second image:");
        image2.Display();
    }
}

