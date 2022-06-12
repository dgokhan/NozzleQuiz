using NozzleQuiz.Domain.Common;

namespace NozzleQuiz.Domain.Entities
{
    public class MaterialCategory : BaseEntity
    {
        public string ParentMaterialCategoryId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
    }
}
