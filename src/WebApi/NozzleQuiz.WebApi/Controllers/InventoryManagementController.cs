using Microsoft.AspNetCore.Mvc;
using NozzleQuiz.Integrations.NozzleSoft;
using System;
using System.Threading.Tasks;

namespace NozzleQuiz.WebApi.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventoryManagementController : ControllerBase
    {
        [Obsolete]
        /// <summary>
        /// Fetch data by Integrations.NozzleSoft.MaterialCategoryApi
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetAllMaterialCategoryAsync()
        {
            var provider = new NozzleClient();
            var result = await provider.MaterialCategory.GetAllMaterialCategoryAsync();

            return Ok(result);
        }

        /// <summary>
        /// Fetch data by Integrations.NozzleSoft.MaterialCategoryApi
        /// </summary>
        /// <param name="o">Filter query</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SearchMaterialCategoryAsync(object o)
        {
            var provider = new NozzleClient();
            var result = await provider.MaterialCategory.SearchMaterialCategoryAsync(o);

            return Ok(result);
        }

        /// <summary>
        /// Fetch data by Integrations.NozzleSoft.MaterialApi
        /// </summary>
        /// <param name="o">Filter query</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SearchMaterialAsync(object o)
        {
            var provider = new NozzleClient();
            var result = await provider.Material.SearchMaterialAsync(o);

            return Ok(result);
        }
    }
}
