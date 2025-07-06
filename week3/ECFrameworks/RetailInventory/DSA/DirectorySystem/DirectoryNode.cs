using System;
using System.Collections.Generic;

public class DirectoryNode
{
    public string Name { get; set; }
    public bool IsFile { get; set; }
    public List<DirectoryNode> Children { get; set; }

    public DirectoryNode(string name, bool isFile)
    {
        Name = name;
        IsFile = isFile;
        Children = new List<DirectoryNode>();
    }

    public void AddChild(DirectoryNode node)
    {
        if (!IsFile)
            Children.Add(node);
    }

    public void PrintStructure(int depth = 0)
    {
        string indent = new string(' ', depth * 2);
        Console.WriteLine($"{indent}{(IsFile ? "- " : "+ ")}{Name}");

        foreach (var child in Children)
        {
            child.PrintStructure(depth + 1);
        }
    }
}
