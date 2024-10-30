namespace FoodApp.Menu.Models;

public class BaseModel
{

    public int              Id          { get; set; } = 0;

    public string?          Name        { get; set; } = String.Empty;

    public string?          Description { get; set; } = String.Empty;

    public string?          ImageUrl    { get; set; } = String.Empty;


    public BaseModel() { }

}

