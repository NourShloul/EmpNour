using EmpNour.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EmpNour.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly ProcessStatus _processStatus = new ProcessStatus();

        [HttpGet("{nat}")]
        public IActionResult GetEmployeeStatus(int nat)
        {
            var result = _processStatus.GetEmpStatus(nat);
            if (result == null)
            {
                return NotFound(new { message = "Invalid National Number" });
            }
            return Ok(result);
        }
    }
}
