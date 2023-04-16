using System;
using System.Collections.Generic;

namespace StokTakipUygulamasi
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Item> items = new List<Item>();

            while (true)
            {
                Console.WriteLine("1 - Urun ekle");
                Console.WriteLine("2 - Urun'leri listele");
                Console.WriteLine("3 - Urun sil");
                Console.WriteLine("4 - Çıkış");

                Console.Write("Seçiminiz: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        AddItem(items);
                        break;
                    case "2":
                        ListItems(items);
                        break;
                    case "3":
                        RemoveItem(items);
                        break;
                    case "4":
                        Console.WriteLine("Uygulamadan çıkılıyor...");
                        return;
                    default:
                        Console.WriteLine("Geçersiz seçim!");
                        break;
                }

                Console.WriteLine();
            }
        }

        static void AddItem(List<Item> items)
        {
            Console.Write("Urun adı: ");
            string name = Console.ReadLine();

            Console.Write("Urun fiyatı: ");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.Write("Urun stok adedi: ");
            int stockCount = Convert.ToInt32(Console.ReadLine());

            Item item = new Item(name, price, stockCount);
            items.Add(item);

            Console.WriteLine("Urun eklendi!");
        }

        static void ListItems(List<Item> items)
        {
            if (items.Count == 0)
            {
                Console.WriteLine("Kayıtlı urun yok!");
            }
            else
            {
                foreach (Item item in items)
                {
                    Console.WriteLine("{0} - {1} TL - Stok: {2}", item.Name, item.Price, item.StockCount);
                }
            }
        }

        static void RemoveItem(List<Item> items)
        {
            Console.Write("Silinecek urun adı: ");
            string name = Console.ReadLine();

            for (int i = 0; i < items.Count; i++)
            {
                if (items[i].Name == name)
                {
                    items.RemoveAt(i);
                    Console.WriteLine("Urun silindi!");
                    return;
                }
            }

            Console.WriteLine("Urun bulunamadı!");
        }
    }

    class Item
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public int StockCount { get; set; }

        public Item(string name, double price, int stockCount)
        {
            Name = name;
            Price = price;
            StockCount = stockCount;
        }
    }
}
