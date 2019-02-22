using System.Collections.Generic;

namespace bookblog_api.Models
{
    public class Response<T> where T : new()
    {
        public T Data { get; set; }

        public bool Success { get; set; }

        public List<ResponseMessage> Messages { get; set; } = new List<ResponseMessage>();

        public List<Documentation> Documentation { get; set; } = new List<Documentation>();
    }
}
