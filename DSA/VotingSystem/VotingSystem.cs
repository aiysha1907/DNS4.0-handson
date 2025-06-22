
using System;
using System.Collections.Generic;

public class VotingSystem
{
    private Queue<string> voterQueue = new Queue<string>();
    private Stack<string> voteStack = new Stack<string>();

    public void EnqueueVoter(string name)
    {
        voterQueue.Enqueue(name);
    }

    public void ProcessVotes()
    {
        Console.WriteLine("Voting Order:");
        while (voterQueue.Count > 0)
        {
            string voter = voterQueue.Dequeue();
            Console.WriteLine($"Voter: {voter}");
            voteStack.Push($"{voter} voted");
        }
    }

    public void PrintReverseVotes()
    {
        Console.WriteLine("\nVote Log (Most Recent First):");
        while (voteStack.Count > 0)
        {
            Console.WriteLine(voteStack.Pop());
        }
    }
}
