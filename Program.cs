using System;
using System.IO;
class Program
{

    static string Task1 = "";
    static string Task2 = "";
    static string Task3 = "";

    static string filePath1 = "Task1.txt";
    static string filePath2 = "Task2.txt";
    static string filePath3 = "Task3.txt";

    public static void Main(string[] args)
    {
        Load();
        start();
    }

    static void save()
    {
        File.WriteAllText(filePath1, Task1);
        File.WriteAllText(filePath2, Task2);
        File.WriteAllText(filePath3, Task3);
    }

    static void Load()
    {
        if (File.Exists(filePath1)) Task1 = File.ReadAllText(filePath1);
        if (File.Exists(filePath2)) Task2 = File.ReadAllText(filePath2);
        if (File.Exists(filePath3)) Task3 = File.ReadAllText(filePath3);
    }
    static void start()
    {
        Console.WriteLine("To-Do-List:");
        Console.WriteLine("1. " + Task1);
        Console.WriteLine("2. " + Task2);
        Console.WriteLine("3. " + Task3);
        Console.WriteLine("(Enter line number to edit that line)");
        Edit();
    }

    static void Edit()
    {
        ConsoleKeyInfo key = Console.ReadKey();

        if (key.KeyChar == '1')
        {
            Console.Clear();
            Console.WriteLine("Edit line one:");
            Task1 = Console.ReadLine();
            Console.Clear();
            save();
            start();
        }
        else if (key.KeyChar == '2')
        {
            Console.Clear();
            Console.WriteLine("Edit line two:");
            Task2 = Console.ReadLine();
            Console.Clear();
            save();
            start();
        }
        else if (key.KeyChar == '3')
        {
            Console.Clear();
            Console.WriteLine("Edit line three:");
            Task3 = Console.ReadLine();
            Console.Clear();
            save();
            start();
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Invalid input. Please pick a line that exists.");
            start();
        }
    }

}