using NozzleQuiz.Integrations.NozzleSoft.Models;
using NozzleQuiz.Integrations.NozzleSoft.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Integrations.NozzleSoft.Api
{
    public interface IMaterialCategoryApi
    {
        Task<MaterialCategoryGetAllResponse> GetAllMaterialCategory();
    }

    public class MaterialCategoryApi : IMaterialCategoryApi
    {
        private readonly IBaseApi baseApi;

        public MaterialCategoryApi(IBaseApi baseApi)
        {
            this.baseApi = baseApi;
        }

        public async Task<MaterialCategoryGetAllResponse> GetAllMaterialCategory()
        {
            var response = await baseApi.GetMethodAsync(
                uri: NozzleApiSettings.ApiUrl + "InventoryManagement/MaterialCategory/GetAll",
                headers: new Dictionary<string, string> {
                    { "X-Authorization", NozzleApiSettings.AuthorizationKey },
                    { "Accept", "application/json"},
                });

            var categoryList = new List<MaterialCategory>();
            foreach (var item in response.Data.SelectToken(""))
            {
                categoryList.Add(new MaterialCategory
                {
                    id = item.Value<string>("id"),
                    parentMaterialCategoryID = item.Value<string>("parentMaterialCategoryID"),
                    code = item.Value<string>("code"),
                    name = item.Value<string>("name")
                });
            }

            return new MaterialCategoryGetAllResponse { materialCategories = categoryList };
        }
    }
}
