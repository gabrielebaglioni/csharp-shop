class Store
{
    public List<Shirt> ShirtList { get; set; }
    public List<Shirt> Shoppinglist { get; set; }

    public Store()
    {
        ShirtList = new List<Shirt>();
        Shoppinglist = new List<Shirt>(); 

    }
    public decimal checkout()
    {
        decimal totalCost = 0;

        foreach(var shirt_hm in Shoppinglist)
        {
            totalCost += shirt_hm.Price; 
        }

        Shoppinglist.Clear();
        return totalCost;
    }


}