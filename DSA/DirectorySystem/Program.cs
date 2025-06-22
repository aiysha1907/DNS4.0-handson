// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");


using System;

public class Program
{
    public static void Main(string[] args)
    {
        DirectoryNode root = new DirectoryNode("root", false);
        DirectoryNode docs = new DirectoryNode("Documents", false);
        DirectoryNode pics = new DirectoryNode("Pictures", false);
        DirectoryNode file1 = new DirectoryNode("resume.pdf", true);
        DirectoryNode file2 = new DirectoryNode("project.docx", true);
        DirectoryNode img1 = new DirectoryNode("vacation.jpg", true);

        docs.AddChild(file1);
        docs.AddChild(file2);
        pics.AddChild(img1);

        root.AddChild(docs);
        root.AddChild(pics);

        Console.WriteLine("Directory Structure:");
        root.PrintStructure();
    }
}
