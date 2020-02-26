using System;

namespace Classes
{
    class Product
    {
        public string Title { get; set; }
        public int Amount { get; set; }
        public double Price { get; set; }
        public double StorageLife { get; set; }

        public override string ToString()
        {
            string info = $"Prodeuct's title: {Title} " +
                          $"Amount of products: {Amount} " +
                          $"Price: {Price} " +
                          $"Storage life: {StorageLife} ";

            return info;
        }

        public Product(int amount = 0, string title = "Noname", double price = 0, double storageLife = 0)
        {
            Title = title;
            Amount = amount;
            Price = price;
            StorageLife = storageLife;
        }
    }
}
