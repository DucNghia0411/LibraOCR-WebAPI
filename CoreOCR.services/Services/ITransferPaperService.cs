using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Services
{
    public interface ITransferPaperService
    {
        Task<string> ReadTransferPaper(IFormFile file);
    }

    public class TransferPaperService : BaseApiClient, ITransferPaperService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public TransferPaperService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            _httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadTransferPaper(IFormFile file)
        {
            var body = await AddFileTransferPaperAsync("giay_chuyen_truong_pdf", file);
            return body;
        }
    }
}
