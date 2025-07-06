// See https://aka.ms/new-console-template for more information
using System;

public class Program
{
    public static void Main(string[] args)
    {
        TextEditor editor = new TextEditor();

        editor.AddText("Hello");
        editor.ShowText();

        editor.AddText(" World!");
        editor.ShowText();

        Console.WriteLine("Undoing...");
        editor.Undo();
        editor.ShowText();

        Console.WriteLine("Undoing...");
        editor.Undo();
        editor.ShowText();

        Console.WriteLine("Undoing again...");
        editor.Undo(); // Should say "Nothing to undo."
    }
}

