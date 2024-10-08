namespace FoodApp.Menu.Models;

public class Product : BaseModel
{

    public decimal?             Price       { get; set; } = 0;
                          
    public IList<Category>      Category    { get; set; } = [];

    public Product() { }

  

}
