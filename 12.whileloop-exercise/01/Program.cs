using System;

namespace _01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string book = Console.ReadLine();
            int bookCount = 0;
            bool isFound = false;
            string currentBook = Console.ReadLine();

            while (currentBook != "No More Books") 
            { 
                if (currentBook == book) { isFound = true; break; }
                bookCount++;
                currentBook = Console.ReadLine();
                
            }
            if (isFound)
            {
                Console.WriteLine($"You checked {bookCount} books and found it.");
            }
            else { Console.WriteLine("The book you search is not here!"); Console.WriteLine($"You checked {bookCount} books."); }
        }
    }
}
