namespace NozzleQuiz.Integrations.NozzleSoft.Models.Responses
{
    public class LoginResponse
    {
        public string userId { get; set; }
        public string tokenBearer { get; set; }
        public bool shouldResetPassword { get; set; }
        public object passwordResetCode { get; set; }
        public bool requiresTwoFactorVerification { get; set; }
        public object twoFactorAuthProviders { get; set; }
    }
}
