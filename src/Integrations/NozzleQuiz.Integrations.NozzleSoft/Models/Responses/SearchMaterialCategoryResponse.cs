using System.Collections.Generic;

namespace NozzleQuiz.Integrations.NozzleSoft.Models.Responses
{
    public class SearchMaterialCategoryResponse
    {
        public List<MaterialCategory> materialCategories { get; set; }
        public int currentPage { get; set; }
        public int pageSize { get; set; }
        public int rowCount { get; set; }
    }
}
