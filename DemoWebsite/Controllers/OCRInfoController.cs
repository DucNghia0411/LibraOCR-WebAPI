using CoreOCR.Services.Model;
using CoreOCR.Services.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace LibraOCR.WebAPI.Controllers
{
    [Route("api/ocr_info")]
    [ApiController]
    public class OCRInfoController : Controller
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IAdministrativeDocumentsService _administrativeDocumentsService;
        private readonly IHealthRecordsService _healthRecordsService;
        private readonly IIDCardsService _iDCardsService;
        private readonly IVehicleRegistrationsService _vehicleRegistrationsService;
        private readonly ITransferPaperService _transferPaperService;

        public OCRInfoController(IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IConfiguration configuration,
            IAdministrativeDocumentsService administrativeDocumentsService,
            IHealthRecordsService healthRecordsService,
            IIDCardsService iDCardsService,
            IVehicleRegistrationsService vehicleRegistrationsService,
            ITransferPaperService transferPaperService)
        {
            _configuration = configuration;
            _httpContextAccessor = httpContextAccessor;
            _httpClientFactory = httpClientFactory;
            _administrativeDocumentsService = administrativeDocumentsService;
            _healthRecordsService = healthRecordsService;
            _vehicleRegistrationsService = vehicleRegistrationsService;
            _iDCardsService = iDCardsService;
            _transferPaperService = transferPaperService;
        }
        [Authorize]
        [HttpPost("gthc")]
        public async Task<RequestResponse> GetInfoAdministrativeDocuments(IFormFile file)
        {
            try
            {
                if (CheckFileType(file.FileName))
                {
                    string result = await this._administrativeDocumentsService.ReadAdministrativeDocuments(file);
                    if (result != null && result.Any())
                    {
                        return new RequestResponse
                        {
                            Status = ErrorCode.Success,
                            Content = result,
                            Message = "Success"
                        };
                    }
                }
                else
                {
                    return new RequestResponse
                    {
                        Status = ErrorCode.InvalidFile,
                        Content = string.Empty,
                        Message = "Invalid File"
                    };
                }
                return new RequestResponse
                {
                    Status = ErrorCode.OutResource,
                    Content = string.Empty,
                    Message = "Resource is not available"
                };
            }
            catch (Exception ex)
            {
                string errorDetail = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString();
                return new RequestResponse
                {
                    Status = ErrorCode.GeneralFailure,
                    Content = errorDetail,
                    Message = "General Failure"
                };
            }
        }
        [Authorize]
        [HttpPost("gthcpdf")]
        public async Task<RequestResponse> GetInfoAdministrativeDocumentsPDF(IFormFile file)
        {
            try
            {
                if (CheckPdfType(file.FileName))
                {
                    string result = await this._administrativeDocumentsService.ReadAdministrativeDocumentsPDF(file);
                    if (result != null && result.Any())
                    {
                        return new RequestResponse
                        {
                            Status = ErrorCode.Success,
                            Content = result,
                            Message = "Success"
                        };
                    }
                }
                else
                {
                    return new RequestResponse
                    {
                        Status = ErrorCode.InvalidFile,
                        Content = string.Empty,
                        Message = "Invalid File"
                    };
                }
                return new RequestResponse
                {
                    Status = ErrorCode.OutResource,
                    Content = string.Empty,
                    Message = "Resource is not available"
                };
            }
            catch (Exception ex)
            {
                string errorDetail = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString();
                return new RequestResponse
                {
                    Status = ErrorCode.GeneralFailure,
                    Content = errorDetail,
                    Message = "General Failure"
                };
            }
        }
        [Authorize]
        [HttpPost("hssk")]
        public async Task<RequestResponse> GetInfoHealthRecords(IFormFile file)
        {
            try
            {
                if (CheckFileType(file.FileName))
                {
                    string result = await this._healthRecordsService.ReadHealthRecords(file);
                    if (result != null && result.Any())
                    {
                        return new RequestResponse
                        {
                            Status = ErrorCode.Success,
                            Content = result,
                            Message = "Success"
                        };
                    }
                }
                else
                {
                    return new RequestResponse
                    {
                        Status = ErrorCode.InvalidFile,
                        Content = string.Empty,
                        Message = "Invalid File"
                    };
                }
                return new RequestResponse
                {
                    Status = ErrorCode.OutResource,
                    Content = string.Empty,
                    Message = "Resource is not available"
                };
            }
            catch (Exception ex)
            {
                string errorDetail = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString();
                return new RequestResponse
                {
                    Status = ErrorCode.GeneralFailure,
                    Content = errorDetail,
                    Message = "General Failure"
                };
            }
        }
        [Authorize]
        [HttpPost("cmnd")]
        public async Task<RequestResponse> GetInfoIDCards(IFormFile file)
        {
            try
            {
                if (CheckFileType(file.FileName))
                {
                    string result = await this._iDCardsService.ReadIDCards(file);
                    if (result != null && result.Any())
                    {
                        return new RequestResponse
                        {
                            Status = ErrorCode.Success,
                            Content = result,
                            Message = "Success"
                        };
                    }
                }
                else
                {
                    return new RequestResponse
                    {
                        Status = ErrorCode.InvalidFile,
                        Content = string.Empty,
                        Message = "Invalid File"
                    };
                }
                return new RequestResponse
                {
                    Status = ErrorCode.OutResource,
                    Content = string.Empty,
                    Message = "Resource is not available"
                };
            }
            catch (Exception ex)
            {
                string errorDetail = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString();
                return new RequestResponse
                {
                    Status = ErrorCode.GeneralFailure,
                    Content = errorDetail,
                    Message = "General Failure"
                };
            }
        }
        [Authorize]
        [HttpPost("gtcn")]
        public async Task<RequestResponse> GetInfoVehicleRegistration(IFormFile file)
        {
            try
            {
                if (CheckFileType(file.FileName))
                {
                    string result = await this._vehicleRegistrationsService.ReadVehicleRegistration(file);
                    if (result != null && result.Any())
                    {
                        return new RequestResponse
                        {
                            Status = ErrorCode.Success,
                            Content = result,
                            Message = "Success"
                        };
                    }
                }
                else
                {
                    return new RequestResponse
                    {
                        Status = ErrorCode.InvalidFile,
                        Content = string.Empty,
                        Message = "Invalid File"
                    };
                }
                return new RequestResponse
                {
                    Status = ErrorCode.OutResource,
                    Content = string.Empty,
                    Message = "Resource is not available"
                };
            }
            catch (Exception ex)
            {
                string errorDetail = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString();
                return new RequestResponse
                {
                    Status = ErrorCode.GeneralFailure,
                    Content = errorDetail,
                    Message = "General Failure"
                };
            }
        }
        [Authorize]
        [HttpPost("gctpdf")]
        public async Task<RequestResponse> GetInfoTransferPaperPDF(IFormFile file)
        {
            try
            {
                if (CheckPdfType(file.FileName))
                {
                    string result = await this._transferPaperService.ReadTransferPaper(file);
                    if (result != null && result.Any())
                    {
                        return new RequestResponse
                        {
                            Status = ErrorCode.Success,
                            Content = result,
                            Message = "Success"
                        };
                    }
                }
                else
                {
                    return new RequestResponse
                    {
                        Status = ErrorCode.InvalidFile,
                        Content = string.Empty,
                        Message = "Invalid File"
                    };
                }
                return new RequestResponse
                {
                    Status = ErrorCode.OutResource,
                    Content = string.Empty,
                    Message = "Resource is not available"
                };
            }
            catch (Exception ex)
            {
                string errorDetail = ex.InnerException != null ? ex.InnerException.ToString() : ex.Message.ToString();
                return new RequestResponse
                {
                    Status = ErrorCode.GeneralFailure,
                    Content = errorDetail,
                    Message = "General Failure"
                };
            }
        }
        bool CheckFileType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".jpg":
                    return true;
                case ".jpeg":
                    return true;
                case ".png":
                    return true;
                default:
                    return false;
            }
        }
        bool CheckPdfType(string fileName)
        {
            string ext = Path.GetExtension(fileName);
            switch (ext.ToLower())
            {
                case ".pdf":
                    return true;
                default:
                    return false;
            }
        }
    }
}
