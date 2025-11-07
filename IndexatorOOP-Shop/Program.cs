using System;

namespace IndexatorOOP_Shop
{
    class Article
    {
        private string product;
        private string shop;
        private double price;

        public Article(string product, string shop, double price)
        {
            this.product = product;
            this.shop = shop;
            this.price = price;
        }

        public string Product {  get { return product; } }
        public string Shop {  get { return shop; } }
        public double Price { get { return price; } }

        public void ShowInfo()
        {
            Console.WriteLine("Product :" + product);
            Console.WriteLine("Shop :" + shop);
            Console.WriteLine("Price:" + price + "UAH");
        }
    }

    class Store 
    {
        private Article[] articles;

        public Store(Article[] goods)
        {
            articles = goods;
        }

        public Article this[int index]
        {
            get
            {
                if (index >= 0 && index < articles.Length) 
                    return articles[index];
                else
                    return null;
            }
            set
            {
                if (index >= 0 && index < articles.Length)
                    articles[index] = value;
                else
                    Console.WriteLine("Спроба запису за межи масива");
            }

        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
