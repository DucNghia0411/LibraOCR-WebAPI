using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services.Services
{
    public interface IVehicleRegistrationsService
    {
        public Task<string> ReadVehicleRegistration(IFormFile file);

    }
    public class VehicleRegistrationsService : BaseApiClient, IVehicleRegistrationsService
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public VehicleRegistrationsService(IHttpClientFactory httpClientFactory) : base(httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        public async Task<string> ReadVehicleRegistration(IFormFile file)
        {
            var body = await AddFileVehicleRegisAsync("gtcn_img", file);

            return body;
        }
    }
}
