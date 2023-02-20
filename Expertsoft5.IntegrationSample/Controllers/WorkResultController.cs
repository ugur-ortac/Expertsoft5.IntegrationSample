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
        public Response<string> GetWorkResult(WorkResultRequest request)
        {
            Response<string> response = new Response<string>();

            if (request.CustomNumber != null)
            {
                response.Result = "Save Success";

                response.Status = true;
            }
            else
            {
                response.ErrorMessage = "Invalid Custom Number";
            }

            return response;
        }
    }
}