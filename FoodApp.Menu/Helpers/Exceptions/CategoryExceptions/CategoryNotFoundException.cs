namespace FoodApp.Menu.Helpers.Exceptions.CategoryExceptions
{
    public class CategoryNotFoundException : Exception
    {
        public CategoryNotFoundException(int id = -1, string name = "")
            : base($"Categoria de id/name: {id}/{name} não encontrada.") { }
    }
}
