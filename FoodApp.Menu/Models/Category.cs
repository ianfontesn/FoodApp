namespace FoodApp.Menu.Models
{
    public class Category : BaseModel
    {
        
        public IList<Product>? Products { get; set; }

        public Category()
        {
            
        }


    }

     

}
