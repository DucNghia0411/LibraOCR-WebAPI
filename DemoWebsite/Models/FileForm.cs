using Microsoft.AspNetCore.Http;

namespace LibraOCR.WebAPI.Models
{
    public class FileForm
    {
        public IFormFile File { get; set; }
    }
}
