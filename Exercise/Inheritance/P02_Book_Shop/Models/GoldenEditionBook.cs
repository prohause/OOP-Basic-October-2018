namespace P02_Book_Shop.Models
{
    internal class GoldenEditionBook : Book
    {
        public GoldenEditionBook(string author, string title, decimal price) : base(author, title, price)
        {
            base.Price *= 1.3m;
        }
    }
}