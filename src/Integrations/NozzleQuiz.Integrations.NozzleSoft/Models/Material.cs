namespace NozzleQuiz.Integrations.NozzleSoft.Models
{
    public class Material
    {
        public string id { get; set; }
        public string materialCategoryID { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public double stockQuantity { get; set; }
        public string baseUnitTypeID { get; set; }
        public string baseUnitTypeDisplay { get; set; }
    }
}
