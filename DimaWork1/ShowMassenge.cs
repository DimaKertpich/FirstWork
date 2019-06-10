using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimaWork1
{
    public static class ShowMassenge
    {

        public static void MassengeShow()
        {
            Console.WriteLine("1. Додати книгу");
            Console.WriteLine("2. Видалення книги");
            Console.WriteLine("3. Оновити iнформацiю про книги");
            Console.WriteLine("4. Шукати книгу за жанро, aвтором, роком видавництва");
            Console.WriteLine("5. Вивести книги");
            Console.WriteLine("6. Вихiд");
        }

        public static void SearchData()
        {

            Console.WriteLine("1. Шукати за жанром");
            Console.WriteLine("2. Шукати за автором");
            Console.WriteLine("3. Шукати за роком видавництва");

        }

    }
}
