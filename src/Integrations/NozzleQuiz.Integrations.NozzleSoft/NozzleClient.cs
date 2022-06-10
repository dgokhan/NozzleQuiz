using NozzleQuiz.Integrations.NozzleSoft.Api;

namespace NozzleQuiz.Integrations.NozzleSoft
{
    public class NozzleClient
    {
        public MaterialCategoryApi MaterialCategory { get; protected set; }
        public AccountApi AccountApi { get; protected set; }

        public NozzleClient()
        {
            MaterialCategory = new MaterialCategoryApi();
            AccountApi = new AccountApi();
        }
    }
}
