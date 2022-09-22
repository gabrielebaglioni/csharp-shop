public class Shirt
{
    public string Make { get; set; }
    public string Model { get; set; }
    public decimal Price { get; set; }

    public Shirt()
    {
        Make = "";
        Model = "";
        Price = 0;

    }

    public Shirt(string make, string model, decimal price)
    {
        Make = make;
        Model = model;
        Price = price;
    }
    override public string ToString()
    {
        return "Make: " + Make + "Model " + Model + "Price $" + Price;
    }
}
