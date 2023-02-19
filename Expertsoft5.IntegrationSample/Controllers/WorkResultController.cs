using Expertsoft5.IntegrationSample.Request;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Expertsoft5.IntegrationSample.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkResultController : ControllerBase
    {
        private readonly ILogger<WorkResultController> _logger;

        public WorkResultController(ILogger<WorkResultController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        [Authorize]
        public Response<WorkResponse> GetWorkResult(WorkRequest request)
        {
            Response<WorkResponse> response = new Response<WorkResponse>();

            if (request.Plate?.ToString().ToUpper() == "34TR34" || request.ChassisNumber?.ToString().ToUpper() == "9348903485" || request.WorkNumber?.ToString().ToUpper() == "00049359")
            {
                response.Result = new WorkResponse()
                {

                };

                response.Status = true;
            }
            else
            {
                response.ErrorMessage = "Server Work Not Found";
            }

            return response;
        }
    }
}