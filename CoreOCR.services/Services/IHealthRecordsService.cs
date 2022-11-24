using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Services
{
    public interface IHealthRecordsService
    {
        public Task<string> ReadHealthRecords(IFormFile file);

    }
    public class HealthRecordsService : BaseApiClient, IHealthRecordsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public HealthRecordsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadHealthRecords(IFormFile file)
        {
            var body = await AddFileHealthRecordsAsync("hssk_img", file);

            return body;
        }
    }
}
