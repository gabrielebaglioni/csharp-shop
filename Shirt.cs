public class Shirt
{
    public string Make { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }

    

    public Shirt(string make, string model, decimal price)
    {
        Make = make;
        Model = model;
        Price = price;
    }
}
