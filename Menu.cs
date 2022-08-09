class Menu {

public string? Title{get;private set;}


public List<MenuItem> Items {get;}

public Menu( string title, List<MenuItem> items){

    Title = title;
    Items = items;
}
public Menu( string title){

    Title = title;
    Items = new List<MenuItem>();
}


}