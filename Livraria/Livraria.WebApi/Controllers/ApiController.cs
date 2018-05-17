using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers.V1
{
    public abstract class ApiController : ControllerBase
    {
        protected new IActionResult Response(object result = null)
        {
            return Ok(new
            {
                success = true,
                data = result
            });
        }
    }
}