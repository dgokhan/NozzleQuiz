using Newtonsoft.Json;
using NozzleQuiz.Integrations.NozzleSoft.Models;
using NozzleQuiz.Integrations.NozzleSoft.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Integrations.NozzleSoft.Api.Materials
{
    public class MaterialCategoryApi : BaseApi
    {
        public async Task<MaterialCategoryGetAllResponse> GetAllMaterialCategoryAsync()
        {
            var response = await BaseApi.GetMethodAsync(
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

        public async Task<SearchMaterialCategoryResponse> SearchMaterialCategoryAsync(object requestObject)
        {
            var response = await BaseApi.PostMethodAsync(
                requestObject : JsonConvert.DeserializeObject<dynamic>(requestObject.ToString()),
                uri: NozzleApiSettings.ApiUrl + "InventoryManagement/MaterialCategory/Search",
                headers: new Dictionary<string, string> 
                {
                    { "X-Authorization", NozzleApiSettings.AuthorizationKey },
                    { "Accept", "application/json"},
                });

            var categoryList = new List<MaterialCategory>();
            foreach (var item in response.Data.SelectToken("materialCategories"))
            {
                categoryList.Add(new MaterialCategory
                {
                    id = item.Value<string>("id"),
                    parentMaterialCategoryID = item.Value<string>("parentMaterialCategoryID"),
                    code = item.Value<string>("code"),
                    name = item.Value<string>("name")
                });
            }

            return new SearchMaterialCategoryResponse { materialCategories = categoryList };
        }
    }
}
