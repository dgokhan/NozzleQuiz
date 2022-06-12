using NozzleQuiz.Domain.Common;

namespace NozzleQuiz.Domain.Entities
{
    public class Material : BaseEntity
    { 
        public string MaterialCategoryId { get; set; }
        public string BaseUnitTypeId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public double StockQuantity { get; set; }
    }
}
