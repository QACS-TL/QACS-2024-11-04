using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemosOfSlides
{
    public class Book
    {
        public string Title { get; }
        public decimal Price { get; }
        public int YearPublished { get; }

        public Book(string title, decimal price, int yearPublished)
        {
            Title = title;
            Price = price;
            YearPublished = yearPublished;
        }

    }
}
