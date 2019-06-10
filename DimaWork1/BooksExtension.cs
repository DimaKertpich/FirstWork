using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace DimaWork1
{
    public static class BooksExtension
    {

        public static string GenerToString(this Book book)
        {
            return "Жанр - " + book.Gener;
        }

        public static string AvtorToString(this Book book)
        {
            return "Автор - " + book.Avtor;
        }

        public static string YearOfPopulationToString(this Book book)
        {
            return "Рiк видавництва - " + book.YearOfPopulation;
        }

        // Quest 1
        public static void AddBook(this Book[] books, Book book, int lenght )
        {

            books[lenght] = book;

        }

        //Quest 2 
        public static void RemoveBook(this Book[] books, int index, int lenght)
        {

            for (int i = index; i < books.Length - 1; i++)
            {
                books[i] = books[i + 1];

                books[books.Length - 1].Gener = null;
                books[books.Length - 1].Avtor = null;
                books[books.Length - 1].YearOfPopulation = 0;


            }

        }

        //Quest 3 

        public static void BookUpData(this Book [] books, string gener, string avtor, int yearsofpopulation, int index)
        {

            books[index].Avtor = avtor;
            books[index].Gener = gener;
            books[index].YearOfPopulation = yearsofpopulation;

        }

        //Quest 4 

        public static Book SearchGener(this Book[] books, string gener)
        {
            return books.FirstOrDefault(t => t.Gener == gener);
        }

        public static Book SearchAvtor(this Book[] books, string avtor)
        {
            return books.FirstOrDefault(t => t.Avtor == avtor);
        }

        public static Book SearchYearOfPopulation(this Book[] books, int yearofpopulation)
        {
            return books.FirstOrDefault(t => t.YearOfPopulation == yearofpopulation);
        }

        //Quest 5

        public static void PrintAll(this Book [] books)
        {
            for (int i = 0; i < books.Length; i++)
            {
                if (books[i].Avtor != null && books[i].Gener != null && books[i].YearOfPopulation != 0)
                {
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("Жанр - " + books[i].Gener + "\tАвтор - " + books[i].Avtor + "\tРiк видавництва - " + books[i].YearOfPopulation + "\tindex " + i);
                    Console.WriteLine("------------------------------------------------------------------");
                }
            }


        }

    }
}
