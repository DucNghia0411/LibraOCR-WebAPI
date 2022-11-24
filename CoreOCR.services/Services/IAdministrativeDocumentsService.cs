using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Services
{
    public interface IAdministrativeDocumentsService
    {
        public Task<string> ReadAdministrativeDocuments(IFormFile file);
        public Task<string> ReadAdministrativeDocumentsPDF(IFormFile file);

    }
    public class AdministrativeDocumentsService : BaseApiClient, IAdministrativeDocumentsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public AdministrativeDocumentsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadAdministrativeDocuments(IFormFile file)
        {
            var body = await AddFileAdministrativeDocumentsAsync("gthc_img", file);

            return body;
        }
        public async Task<string> ReadAdministrativeDocumentsPDF(IFormFile file)
        {
            var body = await AddFileAdministrativeDocumentsAsync("gthc_pdf", file);

            return body;
        }
    }

}
