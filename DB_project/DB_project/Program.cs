using DB_project;
using System;
internal class Program
{
    private static async Task Main(string[] args)
    {
        DB db = new DB();
        await db.Connect();
    }
}