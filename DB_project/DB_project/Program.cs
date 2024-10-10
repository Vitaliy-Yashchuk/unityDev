using DB_project;
using System;
internal class Program
{
    private static async Task Main(string[] args)
    {
        DB db = new DB();
        Console.WriteLine("Enter title:");
        string? title = Console.ReadLine();
        Console.WriteLine("Enter text:");
        string? text = Console.ReadLine();
        Console.WriteLine("Enter date:");
        string? date = Console.ReadLine();
        Console.WriteLine("Enter author:");
        string? author = Console.ReadLine();

        await db.InsertData(title,text,date,author);
    }
}