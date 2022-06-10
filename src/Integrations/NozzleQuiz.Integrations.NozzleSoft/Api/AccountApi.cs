using NozzleQuiz.Integrations.NozzleSoft.Models.Requests;
using NozzleQuiz.Integrations.NozzleSoft.Models.Responses;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NozzleQuiz.Integrations.NozzleSoft.Api
{
    public class AccountApi : BaseApi
    {
        public async Task<IResult<LoginResponse>> LoginAsync(LoginRequest m)
        {
            var response = await BaseApi.PostMethodAsync(
                requestObject: new { username = m.Username, password = m.Password },
                uri: NozzleApiSettings.ApiUrl + "Account/Login",
                headers: new Dictionary<string, string> {
                    { "X-Authorization", NozzleApiSettings.GuestAuthorizationKey },
                    { "Accept", "application/json"},
                });

            return Result.Func(new LoginResponse
            {
                userId = response.Data.Value<string>("userId"),
                passwordResetCode = response.Data.Value<string>("passwordResetCode"),
                requiresTwoFactorVerification = response.Data.Value<bool>("requiresTwoFactorVerification"),
                shouldResetPassword = response.Data.Value<bool>("shouldResetPassword"),
                tokenBearer = response.Data.Value<string>("tokenBearer"),
                twoFactorAuthProviders = response.Data.Value<string>("twoFactorAuthProviders")
            });
        }
    }
}
