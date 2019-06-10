using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimaWork1
{
    class Program
    {

        public static Book[] books = new Book[1000];
        public static int Lenght = 0;

        static void Main(string[] args)
        {

            int choose = 0;
            while (choose != 6)
            {
                ShowMassenge.MassengeShow();
                 choose = int.Parse(Console.ReadLine());

                 if (choose == 1)
                 {
                     Console.Write(" Введiть жанр - ");
                     string gener = Console.ReadLine(); 
                     Console.Write(" Введiть автора - ");
                     string avtor = Console.ReadLine();
                     Console.Write(" Введiть рiк видавництва - ");
                     int yearOfPopulation = int.Parse(Console.ReadLine());

                     books.AddBook(new Book(gener,avtor,yearOfPopulation), Lenght++ );

                 }

                 else if (choose == 2)
                 {

                    Console.Write(" Введiть index - ");
                    int index = int.Parse(Console.ReadLine());

                    books.RemoveBook(index, Lenght--);

                 }

                 else if (choose == 3)
                 {

                    Console.Write("Введiть новий жанр - ");
                    string newgener = Console.ReadLine();
                    Console.Write("Введiть нового автора - ");
                    string newavtor = Console.ReadLine();
                    Console.Write("Введiть новий рiк видавництва - ");
                    int newyearofpopulation = int.Parse(Console.ReadLine());
                    Console.Write("Index - ");
                    int index = int.Parse(Console.ReadLine());

                    books.BookUpData(newgener,newavtor,newyearofpopulation,index);

                 }

                 else if (choose == 4)
                 {
                     int subchoose = 0;
                    ShowMassenge.SearchData();
                    subchoose = int.Parse(Console.ReadLine());

                    if (subchoose == 1)
                    {
                        Console.Write(" Жанр - ");
                        string searchgener = Console.ReadLine();

                        Console.WriteLine(books.SearchGener(searchgener).GenerToString());

                    }

                    else if (subchoose == 2)
                    {
                        int next = 0;

                        do
                        {
                            Console.Write(" Автор - ");
                            
                            string searchavtor = Console.ReadLine();

                            Console.WriteLine(books.SearchAvtor(searchavtor).AvtorToString());
                            Console.WriteLine("Якщо не бажаєте шукати далi по авторам нажмiть 1");
                            Console.WriteLine("Продовжити любе iнше число");
                            next = int.Parse(Console.ReadLine());

                        } while (next != 1);
                    }

                    else if (subchoose == 3)
                    {

                        Console.Write(" Рiк видавництва - ");
                        int searchyearofpopulation = int.Parse(Console.ReadLine());

                        Console.WriteLine(books.SearchYearOfPopulation(searchyearofpopulation).YearOfPopulationToString());
                    }

                 }

                 else if (choose == 5)
                 {

                    books.PrintAll();

                 }

            }


        }
    }
}
