namespace FoodApp.Menu.Helpers.Exceptions.ProductExceptions
{
    public class DeleteProductException : Exception
    {
        public DeleteProductException(int id)
            : base($"Falha ao deletar a produto de id: {id}") { }
    }
}
