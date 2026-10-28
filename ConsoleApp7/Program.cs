using System;
using System.Text.Json;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}

class Program
{
    static void Main()
    {
        Product laptop = new Product
        {
            Id = 1,
            Name = "Ноутбук",
            Price = 25000.50m,
            Quantity = 3
        };

        var options = new JsonSerializerOptions { WriteIndented = true }; 
        string jsonString = JsonSerializer.Serialize(laptop, options);

        Console.WriteLine("--- Завдання 1: Серіалізований JSON ---");
        Console.WriteLine(jsonString);

        Product deserializedProduct = JsonSerializer.Deserialize<Product>(jsonString);

        Console.WriteLine("\n--- Завдання 2: Властивості десеріалізованого об'єкта ---");
        Console.WriteLine($"ID: {deserializedProduct.Id}");
        Console.WriteLine($"Назва: {deserializedProduct.Name}");
        Console.WriteLine($"Ціна: {deserializedProduct.Price} грн");
        Console.WriteLine($"Кількість: {deserializedProduct.Quantity}");
    }
}