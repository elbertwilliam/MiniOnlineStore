using System;

namespace OnlineStoreProjectApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Welcome();
            PurchaseItem();
        }

        static void Welcome()
        {
            Console.WriteLine("Welcome to our store! Here are the lists of items that are available to buy!");
            Console.WriteLine("Phone");
            Console.WriteLine("Camera");
            Console.WriteLine("Laptop");
            Console.WriteLine("Which item would you like to buy?");
        }
        
        static void PurchaseItem()
        {
            var item = Console.ReadLine();

            switch (item)
            {
                case "Phone":
                var phone = new Phone();
                phone.origin = "North America";
                phone.Title = "Iphone";
                phone.Price = 1299.99;
                Console.WriteLine($"You purchase an {phone.Title} from {phone.origin} for {phone.Price}");
                break;
                case "Camera":
                var camera = new Camera();
                camera.lense = "Normal lens";
                camera.Title = "Canon";
                camera.Price = 919.99;
                Console.WriteLine($"You purchase a {camera.Title} with {camera.lense} for {camera.Price}");
                break;
                case "Laptop":
                var laptop = new Laptop();
                laptop.type = "Gaming";
                laptop.Title = "MSI";
                laptop.Price = 1749.99;
                Console.WriteLine($"You purchase a {laptop.Title} {laptop.type} for {laptop.Price}");
                break;
                default:
                break;
            } 
            
        }

    }
    class BaseItem
        {
            public string Title { get; set;}
            public double Price { get; set;}
        }

        class Phone : BaseItem
        {
            public string origin { get; set;}
        }
        class Camera : BaseItem
        {
            public string lense { get; set;}
        }
        class Laptop : BaseItem
        {
            public string type { get; set;}
        }
}
