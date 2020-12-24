namespace BlazorMovie.Entities.Core
{
    public class PaginatedResponse<T>
    {
        public T Response { get; set; }
        public int TotalAmountPages { get; set; }
    }
}