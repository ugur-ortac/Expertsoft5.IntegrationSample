using Expertsoft5.IntegrationSample.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expertsoft5.IntegrationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkController : ControllerBase
    {
        private readonly ILogger<WorkController> _logger;

        public WorkController(ILogger<WorkController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Authorize]
        public Response<WorkResponse> GetWork(WorkRequest request)
        {
            Response<WorkResponse> response = new Response<WorkResponse>();

            if (request.Plate?.ToString().ToUpper() == "34TR34" || request.ChassisNumber?.ToString().ToUpper()=="9348903485" || request.WorkNumber?.ToString().ToUpper() == "00049359")
            {
                response.Result = new WorkResponse()
                {
                    Brand = null,
                    CarCase = null,
                    CarKm = 0,
                    CarType = Enums.CarType.CAR_4X2,
                    ChassisNumber = null,
                    CustomNumber = null,
                    EngineHP = 0,
                    EngineNumber = null,
                    FuelType = Enums.EngineType.TURBO_DIESEL,
                    Image1 = null, 
                    Image2 = null,
                    Model = null,
                    PackageContent = null,
                    PackageName = null,
                    PackagePay = 0,
                    ParentCompany = null,
                    ParentName = null,
                    ParentPhone = null,
                    Plate = "34TR34",
                    RecipientCompany = null,
                    RecipientName = null,
                    RecipientPhone = null,
                    SellerCompany = null,
                    SellerName = null,
                    SellerPhone = null,
                    TransmissionType = Enums.GearType.AUTOMATIC,
                    Year = 0

                };

                response.Status = true;
            }
            else {
                response.ErrorMessage = "Server Work Not Found";
            }

            return response;
        }
    }
}