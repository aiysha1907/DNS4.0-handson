using System;
using System.Collections.Generic;

public class PathTracker
{
    private Stack<string> backStack = new Stack<string>();
    private Stack<string> forwardStack = new Stack<string>();
    private string currentPage = "Home";

    public void Visit(string page)
    {
        backStack.Push(currentPage);
        currentPage = page;
        forwardStack.Clear(); // forward history is cleared
        Console.WriteLine($"Visited: {currentPage}");
    }

    public void Back()
    {
        if (backStack.Count > 0)
        {
            forwardStack.Push(currentPage);
            currentPage = backStack.Pop();
            Console.WriteLine($"Back to: {currentPage}");
        }
        else
        {
            Console.WriteLine("No pages in back history.");
        }
    }

    public void Forward()
    {
        if (forwardStack.Count > 0)
        {
            backStack.Push(currentPage);
            currentPage = forwardStack.Pop();
            Console.WriteLine($"Forward to: {currentPage}");
        }
        else
        {
            Console.WriteLine("No pages in forward history.");
        }
    }

    public void Current()
    {
        Console.WriteLine($"Current Page: {currentPage}");
    }
}
