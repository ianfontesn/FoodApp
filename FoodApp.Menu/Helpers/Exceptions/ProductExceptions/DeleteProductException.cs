namespace FoodApp.Menu.Helpers.Exceptions.ProductExceptions
{
    public class DeleteProductException : Exception
    {
        public DeleteProductException(int id = -1, string name = "")
            : base($"Falha ao deletar a produto de id/name: {id}/{name}") { }
    }
}
