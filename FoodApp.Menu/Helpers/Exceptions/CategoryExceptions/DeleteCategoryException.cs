using FoodApp.Menu.Models;

namespace FoodApp.Menu.Helpers.Exceptions.CategoryExceptions
{
    public class DeleteProductException : Exception
    {
        public DeleteProductException(int id)
            : base($"Falha ao deletar a categoria de id: {id}") { }
    }
}
