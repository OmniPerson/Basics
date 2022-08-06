List<string> legumeTEST = new List<string>(){ "onions", "cucumber", "harbuz", "apples"};

var items = String.Join("," , legumeTEST);
//Homework
//make 3 lists all containing diffrent items, from whisc tasks, groceries and whatever {check}
//allow user imput to determine which list gets selected 
// if-else or switch  statements
//bonus: include join function

//HW-07-08-22

List<string> tasks = new List<string>(){ "publish", "rectify", "endorse"};
List<string> groceries = new List<string>(){ "apple", "flour", "eggs"};
List<string> whatevers = new List<string>(){ "pen", "book", "crayons"};
var taskarray = String.Join(",", tasks);
var groceriesarray = String.Join(",", groceries);
var whateversarray = String.Join(",", whatevers);
Console.WriteLine("Which list do you wish to display?");

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
  
  if (choice == "tasks"){
    Console.WriteLine( $"The list contains the following items: {taskarray} ;" ) ;
  }
else if (choice == "groceries"){
    Console.WriteLine($"The list contains the following items: {groceriesarray} ;");

}
else if (choice == "whatevers"){
    Console.WriteLine($"The list contains the following items: {whateversarray} ;");
}
else {
Console.WriteLine("There are no items matching your choice!");
}
