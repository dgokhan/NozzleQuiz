using Microsoft.AspNetCore.Mvc;
using NozzleQuiz.Integrations.NozzleSoft;
using NozzleQuiz.Integrations.NozzleSoft.Models.Requests;
using System.Threading.Tasks;

namespace NozzleQuiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromQuery] LoginRequest m)
        {
            var provider = new NozzleClient();
            var result = await provider.AccountApi.LoginAsync(m);

            return Ok(result);
        }
    }
}
