using System;
using System.Collections.Generic;
using System.Linq;

class Item
{
    public string Name { get; set; }
    public decimal Price { get; set; }
}

class Box
{
    public string SerialNumber { get; set; }
    public Item Item { get; set; }
    public int ItemQuantity { get; set; }

    public decimal BoxPrice => ItemQuantity * Item.Price;
}

class Program
{
    static void Main()
    {
        List<Box> boxes = new List<Box>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "end")
                break;

            string[] boxData = input.Split();
            string serialNumber = boxData[0];
            string itemName = boxData[1];
            int itemQuantity = int.Parse(boxData[2]);
            decimal itemPrice = decimal.Parse(boxData[3]);

            Item item = new Item
            {
                Name = itemName,
                Price = itemPrice
            };

            Box box = new Box
            {
                SerialNumber = serialNumber,
                Item = item,
                ItemQuantity = itemQuantity
            };

            boxes.Add(box);
        }

        // Order the boxes by price in descending order
        List<Box> orderedBoxes = boxes.OrderByDescending(b => b.BoxPrice).ToList();

        // Print the boxes
        foreach (Box box in orderedBoxes)
        {
            Console.WriteLine($"{box.SerialNumber}");
            Console.WriteLine($"-- {box.Item.Name} - ${box.Item.Price:F2}: {box.ItemQuantity}");
            Console.WriteLine($"-- ${box.BoxPrice:F2}");
        }
    }
}
