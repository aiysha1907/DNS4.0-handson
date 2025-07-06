// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Create a high-end computer
        Computer gamingPC = new Computer.Builder()
            .SetCPU("Intel i9")
            .SetRAM("32GB")
            .SetStorage("1TB SSD")
            .Build();

        // Create a budget computer
        Computer officePC = new Computer.Builder()
            .SetCPU("Intel i3")
            .SetRAM("8GB")
            .SetStorage("256GB SSD")
            .Build();

        Console.WriteLine("Gaming PC Specs:");
        gamingPC.ShowSpecs();

        Console.WriteLine("\nOffice PC Specs:");
        officePC.ShowSpecs();
    }
}
