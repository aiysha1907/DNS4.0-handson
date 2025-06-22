// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        PathTracker tracker = new PathTracker();

        tracker.Current();

        tracker.Visit("Page1");
        tracker.Visit("Page2");
        tracker.Visit("Page3");

        tracker.Back();
        tracker.Back();

        tracker.Forward();
        tracker.Visit("Page4");

        tracker.Back();
        tracker.Current();
    }
}

