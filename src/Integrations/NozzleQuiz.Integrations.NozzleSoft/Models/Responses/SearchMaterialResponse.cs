using System.Collections.Generic;

namespace NozzleQuiz.Integrations.NozzleSoft.Models.Responses
{
    public class SearchMaterialResponse
    {
        public List<Material> materials { get; set; }
        public int currentPage { get; set; }
        public long pageSize { get; set; }
        public int rowCount { get; set; }
    }
}
