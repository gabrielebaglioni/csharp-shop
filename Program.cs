class Program
{
    static void Main(string[] args)
    {

        //WELCOME
        Console.WriteLine("Hi welcome to myStore, first of all you have to create a invetory. Then you have to add" +
                           "some product to the shopping cart. After you may wont to precede to checkout ");
        //STORE
        Store storage = new Store();

        //ACTION
        int action = chooseAction();
        while(action != 0)
        {
            Console.WriteLine("you chose" + action);
            action = chooseAction();

            switch (action)
            {
                //ADD TO THE INVENTORY
                case 1:
                    Console.WriteLine("you chose to add product to the inventory");
                    string shirtMake = "";
                    string shirttModel = "";
                    int shirttPrice = 0;

                    Console.WriteLine("what is the product make?"); 
                    shirtMake = Console.ReadLine();

                    Console.WriteLine("what is the product model?");
                    shirttModel = Console.ReadLine();

                    Console.WriteLine("what is the product price?");
                    shirttPrice = int.Parse(Console.ReadLine());

                    Shirt newShirt = new Shirt(shirtMake, shirttModel, shirttPrice);
                    storage.ShirtList.Add(newShirt);

                    printStorage(storage);
                    break;

                //ADD TO CART
                case 2:
                    Console.WriteLine("you chose to add product to the cart");
                    printStorage(storage);

                    Console.WriteLine("what product do you wont to buy");
                    int shirtChosen = int.Parse(Console.ReadLine());
                    storage.Shoppinglist.Add(storage.ShirtList[shirtChosen]);
                    break;
                case 3:
                    printShoppingCart(storage);
                    Console.WriteLine("the total cost is" + " " + storage.checkout());
                    break;

                default:
                    break;
            } 

        }
         
         
    }

    private static void printShoppingCart(Store storage)
    {
        Console.WriteLine("Product that you have chosen");
        for (int i = 0; i < storage.Shoppinglist.Count; i++)
        {
            Console.WriteLine("shirt # " + i + " " + storage.Shoppinglist[i]);
        }
    }

    private static void printStorage(Store storage)
    {
        for( int i = 0; i < storage.ShirtList.Count; i++)
        {
            Console.WriteLine("shirt # " + i + " " + storage.ShirtList[i]);
        }
    }

    static public int chooseAction()
    {
        int choice = 0;
        Console.WriteLine("chose an action (0) to quit, (1) to add a new product to the inventory, (2) add to cart (3) to the checkout ");
        choice = int.Parse(Console.ReadLine());
        return choice;
    }
}
 