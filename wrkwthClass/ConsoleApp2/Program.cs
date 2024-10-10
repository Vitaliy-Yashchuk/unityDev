using ConsoleApp2;
using System;

class Program
{
    private static void Main(string[] args)
    {
        Book book = new Book();
        book.displayInfo("nameBook", "Richard", 2022);
        Person person = new Person(20,"Vitalik");
        Rectangle rectangle = new Rectangle(10,22);
    }
}