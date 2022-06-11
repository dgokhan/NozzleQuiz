using Newtonsoft.Json;
using NozzleQuiz.Integrations.NozzleSoft.Models;
using NozzleQuiz.Integrations.NozzleSoft.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Integrations.NozzleSoft.Api.Materials
{
    public class MaterialApi : BaseApi
    {
        public async Task<SearchMaterialResponse> SearchMaterialAsync(object requestObject)
        {
            var response = await BaseApi.PostMethodAsync(
                requestObject: JsonConvert.DeserializeObject<dynamic>(requestObject.ToString()),
                uri: NozzleApiSettings.ApiUrl + "InventoryManagement/Material/Search",
                headers: new Dictionary<string, string>
                {
                    { "X-Authorization", NozzleApiSettings.AuthorizationKey },
                    { "Accept", "application/json"},
                });

            var materialList = new List<Material>();
            foreach (var item in response.Data.SelectToken("materials"))
            {
                materialList.Add(new Material
                {
                    id = item.Value<string>("id"),
                    materialCategoryID = item.Value<string>("materialCategoryID"),
                    code = item.Value<string>("code"),
                    name = item.Value<string>("name"),
                    baseUnitTypeID = item.Value<string>("baseUnitTypeID"),
                    stockQuantity = item.Value<double>("stockQuantity")
                });
            }

            return new SearchMaterialResponse { materials = materialList };
        }
    }
}
