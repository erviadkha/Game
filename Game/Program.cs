// See https://aka.ms/new-console-template for more information

using System;

namespace Game
{
    class Program 
    {
        static void Main(string[] args)
        {
                 Console.WriteLine("Welcome to Game");
                 Console.WriteLine(" Siapa namamu? ");
                 var name = Console.ReadLine();
                 Console.WriteLine("Welcome" +name);
                 Console.WriteLine("hantu: Saat ini kamu ada di dalam rumah hantu");
                 Console.WriteLine(name + ": Suara siapa itu?");
                 Console.WriteLine("hantu : kamu tidak perlu tau siapa saya");
                 Console.WriteLine("hantu : saat ini kamu sedang di datangi beberapa penghuni rumah ini !!");

                 Permainan permainan = new Permainan();
                 Pemain pemain= new Pemain();
        }
        

    }
}

