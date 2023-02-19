namespace Expertsoft5.IntegrationSample
{
    public class Response<T> where T : class
    {
        public bool Status { get; set; }

        public T? Result { get; set; }

        public string? ErrorMessage { get; set; }
    }
}
