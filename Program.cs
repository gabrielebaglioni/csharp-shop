class Program
{
    static void Main(string[] args)
    {

        //WELCOME
        Console.WriteLine("Hi welcome to myStore, first of all you have to create a invetory. Then you have to add" +
                           "some product to the shopping cart. After you may wont to precede to checkout ");

        //ACTION
        int action = chooseAction();
        while(action != 0)
        {
            Console.WriteLine("you chose" + action);
            action = chooseAction();
        }
         






        //Shirt shirt_hm = new Shirt("H&M", "Skinni", 15.99M);
        //Shirt shirt_guess = new Shirt("GUESS", "Large", 30.99M);

        ////Console.WriteLine(shirt_hm.Make + shirt_hm.Model + shirt_hm.Price);
        //Store storage = new Store();
        //storage.Shoppinglist.Add(shirt_hm);
        //storage.Shoppinglist.Add(shirt_guess);
        //decimal total = storage.checkout();
        //Console.WriteLine("store value is " + total);
         
    }
    static public int chooseAction()
    {
        int choice = 0;
        Console.WriteLine("chose an action (0) to quit, (1) to add a new product to the inventory, (2) add to cart (3) to the checkout ");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
}
 