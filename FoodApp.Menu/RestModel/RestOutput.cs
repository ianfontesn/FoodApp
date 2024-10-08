namespace FoodApp.Menu.RestModel
{
    public class RestOutput<T> where T : class
    {
        public IList<string> Header { get; set; } = [];
        public T Body { get; set; }
        public IList<string> Messagens { get; set; } = [];
        
        public RestOutput(T p_data)
        {
            Body = p_data;
        }

        public RestOutput(
            T p_data,
            IList<string> p_Messagens)
        {
            Body = p_data;
            Messagens = p_Messagens;
        }

    }
}
