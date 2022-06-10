using NozzleQuiz.Integrations.NozzleSoft.Api;
using NozzleQuiz.Integrations.NozzleSoft.Models.Responses;
using System.Threading.Tasks;

namespace NozzleQuiz.Integrations.NozzleSoft.Client.InventoryManagement
{

    public interface IMaterialCategory
    {
        Task<MaterialCategoryGetAllResponse> GetAllMaterialCategory();
    }
    public partial class MaterialCategory : IMaterialCategory
    {
        #region | CTOR |
        private readonly IMaterialCategoryApi materialCategoryApi;

        public MaterialCategory(IMaterialCategoryApi materialCategoryApi)
        {
            this.materialCategoryApi = materialCategoryApi;
        }
        #endregion

        public async Task<MaterialCategoryGetAllResponse> GetAllMaterialCategory()
        {
            return await materialCategoryApi.GetAllMaterialCategory();
        }

    }
}
