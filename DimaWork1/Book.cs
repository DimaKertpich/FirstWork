using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DimaWork1
{
    public struct Book
    {

        public string Gener { get; set; }
        public string Avtor { get; set; }
        public int YearOfPopulation { get; set; }

        public Book(string gener, string avtor, int yearOfPopulation)
        {

            Gener = gener;
            Avtor = avtor;
            YearOfPopulation = yearOfPopulation;

        }

    }
}
