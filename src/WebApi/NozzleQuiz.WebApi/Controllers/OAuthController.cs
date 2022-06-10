using Microsoft.AspNetCore.Mvc;
using NozzleQuiz.Integrations.NozzleSoft.Client.InventoryManagement;
using System.Threading.Tasks;

namespace NozzleQuiz.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OAuthController : ControllerBase
    {
        private readonly IMaterialCategory materialCategory;

        public OAuthController(IMaterialCategory materialCategory)
        {
            this.materialCategory = materialCategory;
        }

        [HttpPost]
        public async Task<IActionResult> Get()
        {
            var result = await materialCategory.GetAllMaterialCategory();
            return Ok(result);
        }
    }
}
