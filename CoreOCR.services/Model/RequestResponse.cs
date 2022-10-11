using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Model
{
    public class RequestResponse
    {
        public ErrorCode Status { get; set; }
        public string Content { get; set; }
        public string Message { get; set; }
    }
    public enum ErrorCode
    {
        Success = 0,
        GeneralFailure = 1,
        NotFound = 2,
        InvalidFile = 3,
        InternalServerError = 4,
        OutResource = 5
    }
}
