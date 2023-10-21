namespace WebAppDemoAPI
{
    public class QueryResult<T> where T : class
    {
        public IEnumerable<T>? Items { get; set; }
        public int Count { get; set; }
    }
}
