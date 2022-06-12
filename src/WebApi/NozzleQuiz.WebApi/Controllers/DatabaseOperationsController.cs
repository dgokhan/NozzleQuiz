using MediatR;
using Microsoft.AspNetCore.Mvc;
using NozzleQuiz.Application.Features.Commands.BaseUnitType;
using NozzleQuiz.Application.Features.Commands.MaterialCategory;
using NozzleQuiz.Application.Features.Queries.Material;
using NozzleQuiz.Application.Features.Queries.MaterialCategory;
using NozzleQuiz.Application.Wrappers;
using NozzleQuiz.Integrations.NozzleSoft;
using System;
using System.Threading.Tasks;

namespace NozzleQuiz.WebApi.Controllers
{
    /// <summary>
    /// This project use the database operations (CRUD)
    /// </summary>
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class DatabaseOperationsController : ControllerBase
    {
        private readonly IMediator mediator;

        public DatabaseOperationsController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        /// <summary>
        /// Fetch data by [NozzleQuizDb.MaterialCategory]
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllMaterialCategory()
        {
            var query = new GetAllMaterialCategoryQuery();
            return Ok(await mediator.Send(query));
        }

        /// <summary>
        /// Adds data to [NozzleQuizDb.MaterialCategory]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateMaterialCategory()
        {
            try
            {
                var provider = new NozzleClient();
                var result = await provider.MaterialCategory.GetAllMaterialCategoryAsync();

                foreach (var item in result.materialCategories)
                {
                    await mediator.Send(new CreateMaterialCategoryCommand
                    {
                        Id = item.id,
                        Code = item.code,
                        Name = item.name,
                        ParentMaterialCategoryId = item.parentMaterialCategoryID
                    });
                }

                return Ok(Result.Func($"{result.materialCategories.Count} items added successfully!"));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }

        /// <summary>
        /// Adds the filtered data to [NozzleQuizDb.MaterialCategory]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateMaterialCategoryWithFilter(object o)
        {
            try
            {
                var provider = new NozzleClient();
                var result = await provider.MaterialCategory.SearchMaterialCategoryAsync(o);

                foreach (var item in result.materialCategories)
                {
                    await mediator.Send(new CreateMaterialCategoryCommand
                    {
                        Id = item.id,
                        Code = item.code,
                        Name = item.name,
                        ParentMaterialCategoryId = item.parentMaterialCategoryID
                    });
                }

                return Ok(Result.Func($"{result.materialCategories.Count} items added successfully!"));
            }
            catch (Exception ex)
            {
                return Problem(ex.Message);
            }
        }
         
        /// <summary>
        /// Fetch data by [NozzleQuizDb.Material] 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllMaterial()
        {
            var query = new GetAllMaterialQuery();
            return Ok(await mediator.Send(query));
        }

        /// <summary>
        /// Fetch data by [NozzleQuizDb.BaseUnitType] 
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> GetAllBaseUnitType()
        {
            var query = new GetAllBaseUnitTypeQuery();
            return Ok(await mediator.Send(query));
        }

        /// <summary>
        /// Adds data to [NozzleQuizDb.BaseUnitType]
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateBaseUnitType(CreateBaseUnitTypeCommand command)
        {
            return Ok(await mediator.Send(command));
        }
        
    }
}
