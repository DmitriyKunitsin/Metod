using System.Runtime.CompilerServices;

namespace Домашнее_задание___Методы
{
    // написать метод который выводит на экран строку.
    // Символы из которых состоит строка и их колличество вводятся пользователем.
    internal class Program
    {
        
        static void Main(string[] args)
        {
            int  quantity ;
            string Znak , resault ;

             Znak = Console.ReadLine();
             quantity = int.Parse(Console.ReadLine());
            resault = Quantity(Znak, quantity);
             PrintResault(resault);

        }

        static string Quantity ( string Znak, int A)
        {
            return string.Concat(Enumerable.Repeat(Znak, A));
        }
       static void PrintResault (string resault) 
        {
            Console.WriteLine(resault + "\t");
        }

    }
}