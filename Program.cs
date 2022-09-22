class Program
{
    static void Main(string[] args)
    {
        Shirt shirt_hm = new Shirt("H&M", "Skinni", 15.99M);
        Shirt shirt_guess = new Shirt("GUESS", "Large", 30.99M);

        //Console.WriteLine(shirt_hm.Make + shirt_hm.Model + shirt_hm.Price);
        Store storage = new Store();
        storage.Shoppinglist.Add(shirt_hm);
        storage.Shoppinglist.Add(shirt_guess);
        decimal total = storage.checkout();
        Console.WriteLine("store value is " + total);

    }
}
 