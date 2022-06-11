using NozzleQuiz.Integrations.NozzleSoft.Api.Materials;
using NozzleQuiz.Integrations.NozzleSoft.Api.Account;

namespace NozzleQuiz.Integrations.NozzleSoft
{
    public class NozzleClient
    {
        public AccountApi Account { get; protected set; }
        public MaterialCategoryApi MaterialCategory { get; protected set; }
        public MaterialApi Material { get; protected set; }

        public NozzleClient()
        {
            MaterialCategory = new MaterialCategoryApi();
            Account = new AccountApi();
            Material = new MaterialApi();
        }
    }
}
