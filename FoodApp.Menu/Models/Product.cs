namespace FoodApp.Menu.Models;

public class Product
{
    private int            Id          { get; set; }
                           
    private string?        Name        { get; set; }
                           
    private string?        Description { get; set; }
                                                 
    private string?        Price       { get; set; }
                          
    private IList<string>? Items       { get; set; }

    private Category?      Category    { get; set; }

    private int?           CategoryId  { get; set; }



}
