using System;

namespace P02_Book_Shop.Models
{
    internal class Book
    {
        private string _title;
        private string _author;
        private decimal _price;

        public string Author
        {
            get => _author;
            set
            {
                var tokens = value.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (tokens.Length > 1 && char.IsDigit(tokens[1][0]))
                {
                    throw new ArgumentException("Author not valid!");
                }
                _author = value;
            }
        }

        public string Title
        {
            get => _title;
            set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException("Title not valid!");
                }
                _title = value;
            }
        }

        public decimal Price
        {
            get => _price;
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Price not valid!");
                }
                _price = value;
            }
        }

        public Book(string author, string title, decimal price)
        {
            Title = title;
            Author = author;
            Price = price;
        }

        public override string ToString()
        {
            return $"Type: {GetType().Name}" +
                   $"\nTitle: {Title}" +
                   $"\nAuthor: {Author}" +
                   $"\nPrice: {Price:F2}";
        }
    }
}