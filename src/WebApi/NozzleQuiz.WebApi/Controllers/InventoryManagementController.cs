using Microsoft.AspNetCore.Mvc;
using NozzleQuiz.Integrations.NozzleSoft;
using System;
using System.Threading.Tasks;

namespace NozzleQuiz.WebApi.Controllers
{    
    /// <summary>
    /// This project use the API operations! Your data is not saved in database..
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class InventoryManagementController : ControllerBase
    { 
        /// <summary>
        /// Fetch data by Integrations.NozzleSoft.MaterialCategoryApi
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> GetAllMaterialCategoryAsync()
        {
            try
            {
                var provider = new NozzleClient();
                var result = await provider.MaterialCategory.GetAllMaterialCategoryAsync();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Fetch data by Integrations.NozzleSoft.MaterialCategoryApi
        /// </summary>
        /// <param name="o">Filter query</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SearchMaterialCategoryAsync(object o)
        {
            try
            {
                var provider = new NozzleClient();
                var result = await provider.MaterialCategory.SearchMaterialCategoryAsync(o);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Fetch data by Integrations.NozzleSoft.MaterialApi
        /// </summary>
        /// <param name="o">Filter query</param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> SearchMaterialAsync(object o)
        {
            try
            {
                var provider = new NozzleClient();
                var result = await provider.Material.SearchMaterialAsync(o);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
    }
}
