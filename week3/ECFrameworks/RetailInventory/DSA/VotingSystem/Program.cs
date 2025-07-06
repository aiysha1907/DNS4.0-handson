// See https://aka.ms/new-console-template for more information

using System;

public class Program
{
    public static void Main(string[] args)
    {
        VotingSystem system = new VotingSystem();

        system.EnqueueVoter("Alice");
        system.EnqueueVoter("Bob");
        system.EnqueueVoter("Charlie");
        system.EnqueueVoter("Diana");

        system.ProcessVotes();
        system.PrintReverseVotes();
    }
}

