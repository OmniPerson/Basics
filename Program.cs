

List<string> tasks = new List<string>() { "publish", "rectify", "endorse" };
List<string> groceries = new List<string>() { "apple", "flour", "eggs" };
List<string> whatevers = new List<string>() { "pen", "book", "crayons" };


Menu menu = new Menu("Which list do you wish to display?", new List<MenuItem>(){
  new MenuItem("Tasks"),
  new MenuItem("Groceries"),
  new MenuItem("Whatevers")
});


while (true)
{

    for (int i = 0; i <= 20; i++)
    {
        Console.Write("-");
    }

    Console.WriteLine();
    Console.WriteLine(menu.Title);
    
    foreach (MenuItem item in menu.Items)
    {
        
        Console.WriteLine($"Type '{item.Label.ToLower()}' to display the items contained in the -{item.Label}- list!");
    }

    string? choice = Console.ReadLine();

    switch (choice)
    {

        case "tasks":
            Console.WriteLine("The list contains the following items:  ");
            foreach (var task in tasks)
            {
                Console.WriteLine(task);
            }
            break;

        case "groceries":
            //Console.WriteLine($"The list contains the following items: {item2.Label} ;");
            foreach (var grocery in groceries)
            {
                Console.WriteLine(grocery);
            }
            break;

        case "whatevers":
            //Console.WriteLine($"The list contains the following items: {item3.Label} ;");
            foreach (var whatever in whatevers)
            {
                Console.WriteLine(whatever);
            }
            break;

        default:
            Console.WriteLine("There is no such item in the list category");
            break;


    }

}


