using System;
using System.IO;

namespace myShoppingList

{
    class Program
    {
        static void Main(string[] args)
        {
            string rootDirectory = @"C:\Users\37253\samples";
            Console.WriteLine("Pane kirja kausta nimi:");
            string newDirectory = Console.ReadLine();
            Console.WriteLine("Pane kirja faili nimi:");
            string fileName = Console.ReadLine();


            if (Directory.Exists($"{rootDirectory}\\{newDirectory}") && File.Exists($"{rootDirectory}\\{newDirectory}\\{fileName}"))
            {
                Console.WriteLine($"Directory and File exist.");
            }
            else
            {
                Directory.CreateDirectory($"{rootDirectory}\\{newDirectory}");
                File.Create($"{rootDirectory}\\{newDirectory}\\{fileName}");
            }
        }
    }
}