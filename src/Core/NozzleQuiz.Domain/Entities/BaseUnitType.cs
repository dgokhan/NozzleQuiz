using NozzleQuiz.Domain.Common;

namespace NozzleQuiz.Domain.Entities
{
    public class BaseUnitType : BaseEntity
    {
        public string BaseUnitTypeID { get; set; }
        public string BaseUnitTypeDisplay { get; set; }
    }
}
