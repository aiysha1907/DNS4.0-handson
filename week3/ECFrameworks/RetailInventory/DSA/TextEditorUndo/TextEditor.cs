using System;
using System.Collections.Generic;

public class TextEditor
{
    private Stack<string> history = new Stack<string>();
    private string currentText = "";

    public void AddText(string newText)
    {
        history.Push(currentText); // save current state
        currentText += newText;
    }

    public void Undo()
    {
        if (history.Count > 0)
        {
            currentText = history.Pop();
        }
        else
        {
            Console.WriteLine("Nothing to undo.");
        }
    }

    public void ShowText()
    {
        Console.WriteLine("Current Text: " + currentText);
    }
}
