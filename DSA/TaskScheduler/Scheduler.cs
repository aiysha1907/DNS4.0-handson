using System;
using System.Collections.Generic;

public class Scheduler
{
    private SortedDictionary<int, Queue<string>> taskHeap = new SortedDictionary<int, Queue<string>>();

    public void AddTask(string task, int priority)
    {
        if (!taskHeap.ContainsKey(priority))
            taskHeap[priority] = new Queue<string>();

        taskHeap[priority].Enqueue(task);
        Console.WriteLine($"Task added: {task} (Priority {priority})");
    }

    public void RunNext()
    {
        foreach (var entry in taskHeap)
        {
            if (entry.Value.Count > 0)
            {
                string task = entry.Value.Dequeue();
                Console.WriteLine($"Running Task: {task} (Priority {entry.Key})");
                if (entry.Value.Count == 0)
                    taskHeap.Remove(entry.Key);
                return;
            }
        }

        Console.WriteLine("No tasks to run.");
    }

    public void ShowAllTasks()
    {
        Console.WriteLine("\nAll Scheduled Tasks:");
        foreach (var pair in taskHeap)
        {
            foreach (var task in pair.Value)
                Console.WriteLine($"- {task} (Priority {pair.Key})");
        }
    }
}
