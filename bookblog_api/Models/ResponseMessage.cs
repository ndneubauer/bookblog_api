namespace bookblog_api.Models
{
    public class ResponseMessage
    {
        public ResponseType Type { get; set; }

        public string Message { get; set; }
    }

    public enum ResponseType
    {
        Success,
        Error,
        Information
    }
}
