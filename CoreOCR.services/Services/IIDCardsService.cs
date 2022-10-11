using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Services
{
    public interface IIDCardsService
    {
        public Task<string> ReadIDCards(IFormFile file);

    }
    public class IDCardsService : BaseApiClient, IIDCardsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public IDCardsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadIDCards(IFormFile file)
        {
            var body = await AddAsync("extract/cmnd", file);
            return body;
        }
    }
}
