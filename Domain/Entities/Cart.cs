using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Cart
    {
        private List<CartLine> lineCollection = new List<CartLine>();

        public IEnumerable<CartLine> Lines { get { return lineCollection; } }  // властивість для звернення до вмісту корзини

        public void AddItem(Book book, int quantity)  // метод додавання елемента в Корзину
        {
            CartLine line = lineCollection
                .Where(b => b.Book.BookId == book.BookId)
                .FirstOrDefault();

            if (line == null)
            {
                lineCollection.Add(new CartLine { Book = book, Quantity = quantity });
            }
            else
            {
                line.Quantity += quantity;
            }
        }  

        public void RemoveLine(Book book) // метод видалення ел. з корзини
        {
            lineCollection.RemoveAll(l => l.Book.BookId == book.BookId);
        }

        public decimal ComputeTotalValue()  // метод обчислення загальної вартості товарів в корзині
        {
            return lineCollection.Sum(e => e.Book.Price * e.Quantity);
        }

        public void Clear()  // метод очистки корзини - видалення всії ел.
        {
            lineCollection.Clear();
        }  

    }

    public class CartLine
    {
        public Book Book { get; set; }
        public int Quantity { get; set; }
    }

}
