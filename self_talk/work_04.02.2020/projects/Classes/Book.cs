using System;

namespace Classes
{
    class Book
    {
        private double price;
        public string Title { get; set; }
        public string[] Authors { get; set; }
        public double Price
        {
            get => price;

            set
            {
                if (value < 0)
                    throw (new Exception("Enter invalid value"));
                else
                    price = value;
            }
        }

        public override string ToString()
        {
            string info = $"Title: {Title} " +
                          $"Price: {price} " +
                          "Authors: ";
            foreach (string author in Authors)
                info += author;

            return info;
        }

        public Book(string[] authors, double price = 0, string title = "Noname")
        {
            Authors = authors;
            Price = price;
            Title = title;
        }
    }
}
