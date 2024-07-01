using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMS.Core.Interfaces.Services;

namespace SMS.Api.V1.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ParentController : ControllerBase
    {
        private readonly IParentService parentService;

        public ParentController(IParentService parentService)
        {
            this.parentService = parentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var result = await this.parentService.GetAll();
            return Ok(result);
        }
    }
}
