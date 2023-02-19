using Expertsoft5.IntegrationSample.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expertsoft5.IntegrationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfigController : ControllerBase
    {
        private readonly ILogger<ConfigController> _logger;

        public ConfigController(ILogger<ConfigController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Authorize]
        public Response<ConfigResponse> GetConfig(ConfigRequest request)
        {
            Response<ConfigResponse> response = new Response<ConfigResponse>();

            if (request.CompanyId.ToString().ToUpper() == "27283A43-F307-4143-AF42-115946C308FD")
            {
                response.Result = new ConfigResponse()
                {
                    Adress = "TEST124",
                    AutomaticMeasurementStart = false,
                    BannerImage = "https://cdn.pixabay.com/photo/2012/05/29/00/43/car-49278_960_720.jpg",
                    Email = "bayi@test.com",
                    FullAccess = false,
                    HardwareIndex = 2,
                    LanguageIndex = 0, //0 TURKISH 1 ENGLISH 2 FRENCH
                    LogoImage = "https://cdn.pixabay.com/photo/2015/01/19/13/51/car-604019_960_720.jpg",
                    PhoneNumber = "0555 555 55 55",
                    QueueeCount = 5,
                    SoundNotification = false,
                    TSECode = "TSE-HYB 9852093",
                    TSEMode = false,
                    WorkRestrict = false,
                    WorkWarning = false,
                    WorkWarningText = "Ödenmemiş 1000 TL bakiye Mevcut Hemen Ödemek İçin Evet Basınız",
                    WorkWarningUrl = "https://test.com/payment"
                };

                response.Status = true;
            }
            else {
                response.ErrorMessage = "Server Company Not Found";
            }

            return response;
        }
    }
}