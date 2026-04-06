
using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace Etkinlik
{
    public class Products
    {
        public string Name { get; private set; }
        public decimal Price { get; private  set; }

        public string Description { get; private set; }
        public int Id { get; private set; }
        public int Stock { get; private set; }


        public void SetProductId(int id)
        {
            if (id > 0)
                Id = id;
        }

        public void SetProductName(string name)
        {
            if (!string.IsNullOrWhiteSpace(name))
            {
                Name = name;
            }
        }

        public void SetDescription(string description)
        {
            if (!string.IsNullOrWhiteSpace(description))
            {
                Description = description;
            }
        }

        public void SetPrice(decimal price)
        {
            if (price > 0)
                Price = price;
        }

        public void SetStock(int stock)
        {
            if (stock > 0)
                Stock = stock;
        }
    }
}
