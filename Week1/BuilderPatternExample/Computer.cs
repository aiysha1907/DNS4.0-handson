using System;

public class Computer
{
    public string CPU { get; }
    public string RAM { get; }
    public string Storage { get; }

    private Computer(Builder builder)
    {
        CPU = builder.CPU;
        RAM = builder.RAM;
        Storage = builder.Storage;
    }

    public void ShowSpecs()
    {
        Console.WriteLine($"CPU: {CPU}, RAM: {RAM}, Storage: {Storage}");
    }

    public class Builder
    {
        public string CPU { get; private set; }
        public string RAM { get; private set; }
        public string Storage { get; private set; }

        public Builder SetCPU(string cpu)
        {
            CPU = cpu;
            return this;
        }

        public Builder SetRAM(string ram)
        {
            RAM = ram;
            return this;
        }

        public Builder SetStorage(string storage)
        {
            Storage = storage;
            return this;
        }

        public Computer Build()
        {
            return new Computer(this);
        }
    }
}
