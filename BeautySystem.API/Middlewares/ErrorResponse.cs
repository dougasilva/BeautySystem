namespace BeautySystem.API.Middlewares
{
    public class ErrorResponse
    {
        public int StatusCode { get; set; }
        public string Message { get; set; }
        public string Detalhes { get; set; }
    }
}
