using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Chapter11.EventExample.Classes
{
    class OrderRow
    {
        private Product Product { get; set; }

        public int Id { get; private set; }
        public string Title { get { return Product.Title; } }
        public double Price { get { return Product.Price; } }

        public int Qty { get; private set; }
        public double Total { get { return Product.Price * Qty; } }

        public OrderRow(Product product, int quantity)
        {
            Product = product;
            Qty = quantity;
            Id = new Random().Next(1000);
        }

    }
}
