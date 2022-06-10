namespace NozzleQuiz.Integrations.NozzleSoft.Models
{
    public class MaterialCategory
    {
        public string id { get; set; }
        public string parentMaterialCategoryID { get; set; }
        public object materialCategoryTypeID { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string materialCategoryTypeDisplay { get; set; }
        public string parentMaterialCategoryDisplay { get; set; }
        public object enableAutoStockOut { get; set; }
        public int stockTrackingTypeEnum { get; set; }
        public string stockTrackingTypeDisplay { get; set; }
        public object vesselDisplay { get; set; }
        public bool hasChild { get; set; }
        public object isVesselSpecific { get; set; }
    }
}
