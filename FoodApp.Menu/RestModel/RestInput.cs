namespace FoodApp.Menu.RestModel
{
    public class RestInput<T> where T : class
    {
        public IList<string> Header { get; set; } = [];
        public required T Body { get; set; }
    }
}