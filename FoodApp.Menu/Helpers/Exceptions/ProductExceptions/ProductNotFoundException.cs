namespace FoodApp.Menu.Helpers.Exceptions.ProductExceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(int id = -1, string name = "")
            : base($"Produto de id/name: {id}/{name} não encontrada.") { }
    }
}
