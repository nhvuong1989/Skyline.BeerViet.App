namespace Skyline.BeerViet.App
{
    public class ApiRespone<T>
    {
        public int Id { get; set; }
        public string Message { get; set; }
        public T Data { get; set; }
    }
}
