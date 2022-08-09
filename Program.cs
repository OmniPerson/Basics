
//Homework
//make 3 lists all containing diffrent items, from whisc tasks, groceries and whatever {check}
//allow user imput to determine which list gets selected 
// if-else or switch  statements
//bonus: include join function

//HW-07-08-22

List<string> tasks = new List<string>() { "publish", "rectify", "endorse" };
List<string> groceries = new List<string>() { "apple", "flour", "eggs" };
List<string> whatevers = new List<string>() { "pen", "book", "crayons" };
var taskarray = String.Join(",", tasks);
var groceriesarray = String.Join(",", groceries);
var whateversarray = String.Join(",", whatevers);
Menu menu = new Menu("Main Menu");
MenuItem item1 = new MenuItem("Tasks");
MenuItem item2 = new MenuItem("Groceries");
MenuItem item3 = new MenuItem("Whatevers");
menu.Items.Add(item1);
menu.Items.Add(item2);
menu.Items.Add(item3);


Menu menu2 = new Menu("Which list do you wish to display?", new List<MenuItem>(){
  item1,
  item2,
  item3
});



while (true)
{
    Console.WriteLine(menu2.Title);
//TASK: display each menu item from menu 2
//TASK2 : get rid of the joins , print each item on a new line
//Foreach loop -> display items
    string? choice = Console.ReadLine();

    switch (choice)
    {

        case "tasks":
            Console.WriteLine($"The list contains the following items: {taskarray} ;");
            break;

        case "groceries":
            Console.WriteLine($"The list contains the following items: {groceriesarray} ;");
            break;

        case "whatevers":
            Console.WriteLine($"The list contains the following items: {whateversarray} ;");
            break;

        default:
            Console.WriteLine("There is no such item in the list category");
            break;


    }

}


