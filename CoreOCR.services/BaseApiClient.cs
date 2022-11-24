using CoreOCR.Services.Utilities;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace CoreOCR.Services
{
    public class BaseApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        public string _HealthRecordsAddress = SettingUrl.GetHealthRecordsAddress();
        public string _IDCAddress = SettingUrl.GetIDCAddress();
        public string _VehicleRegisAddress = SettingUrl.GetVehicleRegisAddress();
        public string _AdministrativeDocumentsAddress = SettingUrl.GetAdministrativeDocumentsAddress();
        public string _TransferPaperAddress = SettingUrl.GetTransferPaperAddress();
        public string _Address = SettingUrl.GetAddress();

        public BaseApiClient(IHttpClientFactory httpClientFactory)
        {
            this._httpClientFactory = httpClientFactory;
        }
        protected async Task<string> AddAsync(string url, IFormFile file)
        {

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_Address);
            var tokenAPI = "eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6ImxpYnJhc29mdCJ9.x7yur8vNxXlDXRVGA8RDrP8mTJTznmVBVtl5L4QGrnU";
            client.DefaultRequestHeaders.Add("X-Access-Token", tokenAPI);
            string body;
            HttpResponseMessage response;
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    //Get the file steam from the multiform data uploaded from the browser
                    await file.CopyToAsync(memoryStream);

                    //Build an multipart/form-data request to upload the file to Web API
                    using var form = new MultipartFormDataContent();
                    using var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, "file", file.FileName);

                    response = await client.PostAsync(url, form);

                    body = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                }
            }
            return null;
        }
        protected async Task<string> AddFileHealthRecordsAsync(string url, IFormFile file)
        {
            //var sessions = _httpContextAccessor
            //    .HttpContext
            //    .Session
            //    .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_HealthRecordsAddress);
            string body;
            HttpResponseMessage response;
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    //Get the file steam from the multiform data uploaded from the browser
                    await file.CopyToAsync(memoryStream);

                    //Build an multipart/form-data request to upload the file to Web API
                    using var form = new MultipartFormDataContent();
                    using var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, "file", file.FileName);

                    response = await client.PostAsync(url, form);

                    body = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                }
            }
            return null;
        }
        protected async Task<string> AddFileIDCAsync(string url, IFormFile file)
        {
            //var sessions = _httpContextAccessor
            //    .HttpContext
            //    .Session
            //    .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_IDCAddress);
            string body;
            HttpResponseMessage response;
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    //Get the file steam from the multiform data uploaded from the browser
                    await file.CopyToAsync(memoryStream);

                    //Build an multipart/form-data request to upload the file to Web API
                    using var form = new MultipartFormDataContent();
                    using var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, "file", file.FileName);

                    response = await client.PostAsync(url, form);

                    body = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                }
            }
            return null;
        }
        protected async Task<string> AddFileVehicleRegisAsync(string url, IFormFile file)
        {
            //var sessions = _httpContextAccessor
            //    .HttpContext
            //    .Session
            //    .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_VehicleRegisAddress);
            string body;
            HttpResponseMessage response;
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    //Get the file steam from the multiform data uploaded from the browser
                    await file.CopyToAsync(memoryStream);

                    //Build an multipart/form-data request to upload the file to Web API
                    using var form = new MultipartFormDataContent();
                    using var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, "file", file.FileName);

                    response = await client.PostAsync(url, form);

                    body = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                }
            }
            return null;
        }
        protected async Task<string> AddFileAdministrativeDocumentsAsync(string url, IFormFile file)
        {
            //var sessions = _httpContextAccessor
            //    .HttpContext
            //    .Session
            //    .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_AdministrativeDocumentsAddress);
            string body;
            HttpResponseMessage response;
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    //Get the file steam from the multiform data uploaded from the browser
                    await file.CopyToAsync(memoryStream);

                    //Build an multipart/form-data request to upload the file to Web API
                    using var form = new MultipartFormDataContent();
                    using var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, "file", file.FileName);

                    response = await client.PostAsync(url, form);

                    body = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                }
            }
            return null;
        }
        protected async Task<string> AddFileTransferPaperAsync(string url, IFormFile file)
        {
            //var sessions = _httpContextAccessor
            //    .HttpContext
            //    .Session
            //    .GetString(SystemConstants.AppSettings.Token);

            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_TransferPaperAddress);
            string body;
            HttpResponseMessage response;
            if (file.Length > 0)
            {
                using (var memoryStream = new MemoryStream())
                {
                    //Get the file steam from the multiform data uploaded from the browser
                    await file.CopyToAsync(memoryStream);

                    //Build an multipart/form-data request to upload the file to Web API
                    using var form = new MultipartFormDataContent();
                    using var fileContent = new ByteArrayContent(memoryStream.ToArray());
                    fileContent.Headers.ContentType = MediaTypeHeaderValue.Parse("multipart/form-data");
                    form.Add(fileContent, "file", file.FileName);

                    response = await client.PostAsync(url, form);

                    body = await response.Content.ReadAsStringAsync();

                    if (response.IsSuccessStatusCode)
                    {
                        return body;
                    }
                }
            }
            return null;
        }

    }
}
