using System;
using System.Text;

namespace IndexatorOOP_Shop
{
    class Article
    {


        private string productname;
        private string name;
        private double price;

        public Article(string productname, string name ,double price)
        {
            this.productname = productname;
            this.name = name;
            this.price = price;
        }
        public string Productname
        {
            get { return productname; }
        }
        public string Name
        {
            get { return name; }
        }
        public double Price
        {
            get { return price; }
        }

        public void ShowInfo()
        {
            Console.WriteLine("Назва товару:" + productname);
            Console.WriteLine("Назва магазину:" + name);
            Console.WriteLine("Ціна товару:" + price + "ГРН");
        }

    }

    class Store
    {
        

        private Article[] articles;

        public Store(Article[] articles)
        {
            this.articles = articles;
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
        }

        public void SearchByName(string productname)
        {
            bool found = false;

            for (int i = 0; i < articles.Length; i++)
            {
                if (articles[i].Productname == productname)
                {
                    articles[i].ShowInfo();
                    found = true;
                    
                }
                    
               
 
            }
            if (!found)
                Console.WriteLine("Невідомий продукт");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;

            Article[] articles = new Article[]
            {
                new Article("Печиво","АТБ",29.50),
                new Article("Мандарин","Сільпо",49.99)
            };

            Store store = new Store(articles);



            Console.WriteLine("Інформація товару за індексом:");
            for(int i = 0;i < 2; i++)
            {
                Article article = store[i];
                if (article != null)
                    article.ShowInfo();
            }

            Console.WriteLine("Пошук товару за назвою");
            string searchProduct = Console.ReadLine();
            store.SearchByName(searchProduct);


        }
    }
}
