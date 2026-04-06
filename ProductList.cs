
using System;
using System.Collections.Generic;
using System.Text;

namespace Etkinlik
{
    public class ProductsList
    {
        public static List<Products> products = new List<Products>();

        public void ProductList()
        {
            for (int i = 1; i <= 50; i++)
            {
                Products product = new Products();
                product.SetProductId(i);
                product.SetProductName($"Product {i}");
                product.SetDescription($"Description for Product {i}");
                product.SetPrice(100 + i);
                product.SetStock(10 + i);
                products.Add(product);
            }
        }


        public void AddProduct(Products product)
        {
            if (product != null)
            {
                products.Add(product);
            }
        }

        public void RemoveProduct(Products product)
        {
            if (product != null)
            {
                products.Remove(product);
            }
        }

        public void Clear()
        {
            products.Clear();
        }

        public void ShowAllProduct()
        {
            ProductList();
            foreach (var product in products)
            {
                Console.WriteLine($"ID: {product.Id}, Name: {product.Name}, Description: {product.Description}, Price: {product.Price}, Stock: {product.Stock}");
            }
        }

        public Products GetProductWithId(int id)
        {
            foreach (Products product in products)
            {
                if (product.Id == id)
                {
                    return product;
                }
            }
            return null;
        }
    

    public string ProductText(Products product)
        {
            if (product != null)
            {
                return $"ID: {product.Id}, Name: {product.Name}, Description: {product.Description}, Price: {product.Price}, Stock: {product.Stock}";
            }
            return "Bulunamadı.";
        }
    }
}
