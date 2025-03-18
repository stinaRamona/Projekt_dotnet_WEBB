using System.Collections.Generic;
using Projekt_dotnet_WEBB.Pages;
using Projekt_dotnet_WEBB.Shared;

public class CartService 
{
    public List<Product> CartItems { get; private set; } = new(); 

    public void AddToCart(Product product) 
    {
        CartItems.Add(product); 
        Console.WriteLine("Produkt tillagd:" + product.Name + "Antal i varukorgen:" + CartItems.Count);
    }

    public List<Product> GetCartItems()
    {
        Console.WriteLine("Produkter i varukorgen:" + CartItems.Count); 
        return CartItems;
    }

    public void ClearCart()
    {
        CartItems.Clear(); 
    }

    public int TotalPrice()
    {
        int totalPrice = 0; 
        foreach (var product in CartItems)
        {
            totalPrice += product.Price;
        }

        return totalPrice;
    }
}