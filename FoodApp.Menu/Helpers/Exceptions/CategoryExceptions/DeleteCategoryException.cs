
namespace FoodApp.Menu.Helpers.Exceptions.CategoryExceptions;

public class DeleteCategoryException : Exception
{
    public DeleteCategoryException(int id = -1, string name = "")
        : base($"Falha ao deletar a categoria de id/name: {id}/{name}") { }
}
