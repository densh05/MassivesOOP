using System;
using System.Net.Http.Headers;
using System.Text;

namespace IndexatorOOP_Shop
{
    class Article
    {

        private string productname; //Приватні поля класу Article
        private string name;
        private double price;

        public Article(string productname, string name ,double price) //Користувальницький конструктор
        {
            this.productname = productname;
            this.name = name;
            this.price = price;
        }
        public string Productname //Властивості на читання
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

        public void ShowInfo() //Вивід інформації
        {
            Console.WriteLine("Назва товару:" + productname);
            Console.WriteLine("Назва магазину:" + name);
            Console.WriteLine("Ціна товару:" + price + "ГРН");
            Console.WriteLine();
        }

    }

    class Store
    {
        

        private Article[] articles; //Приватне поле типу Article[]

        public Store(Article[] articles) //Конструктор з параметрами
        {
            this.articles = articles;
        }

        public string this[int index] //Індексатор  32 рядок повертає інформацію
        {
            get
            {
                if (index >= 0 && index < articles.Length)
                {
                    Article article = articles[index];
                    return $"Назва товару {article.Productname}\n" +
                        $"Назва магазину {article.Name}\n" + 
                        $"Ціна {article.Price}\n";
                }
                else
                {
                    return ("Такого товару немає");
                }
                  
                
            }
        }

        public void SearchByName(string productname) //Метод пошуку товару у магазині
        {
            bool found = false;

            for (int i = 0; i < articles.Length; i++) //Циклічна конструкція
            {
                if (articles[i].Productname == productname) //Якщо знайдено товар який передали в метод,визивається інформація
                {
                    articles[i].ShowInfo();
                    found = true;
                    
                }
                    
            }
            if (!found) //Якщо нічого не знайдено,викликається наступна строка
                Console.WriteLine("Невідомий продукт");
        }

    }


    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Article[] articles = new Article[] //Єкземпляр класу Article
            {
                new Article("Печиво","АТБ",29.50),
                new Article("Мандарин","Сільпо",49.99)
            };

             Store store = new Store(articles); //Єкземпляр класу Store,articles передається в конструктор



            Console.WriteLine("Інформація товару за індексом:");
            for(int i = 0;i < articles.Length; i++)
            {
                Console.WriteLine(store[i]);
            }

            Console.WriteLine("Пошук товару за назвою");
            string searchProduct = Console.ReadLine();
            store.SearchByName(searchProduct);
            
            Console.ReadKey();

        }
    }
}
