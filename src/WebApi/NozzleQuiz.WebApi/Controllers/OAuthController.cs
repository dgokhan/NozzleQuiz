using Microsoft.AspNetCore.Mvc;
using NozzleQuiz.Integrations.NozzleSoft;
using NozzleQuiz.Integrations.NozzleSoft.Models.Requests;
using System.Threading.Tasks;

namespace NozzleQuiz.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        /// <summary>
        /// Sign in with Integrations.NozzleSoft
        /// </summary>
        /// <param name="m">LoginRequestModel (username,password)</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> LoginAsync([FromQuery] LoginRequest m)
        {
            var provider = new NozzleClient();
            var result = await provider.Account.LoginAsync(m);

            return Ok(result);
        } 
    }
}
