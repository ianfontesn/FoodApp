namespace FoodApp.Menu.Helpers.Exceptions.CategoryExceptions
{
    public class ProductNotFoundException : Exception
    {
        public ProductNotFoundException(int id)
            : base($"Categoria de id: {id} não encontrada.") { }
    }
}
