using NozzleQuiz.Integrations.NozzleSoft.Api;

namespace NozzleQuiz.Integrations.NozzleSoft.Models.Requests
{
    public class LoginRequest
    {
        public string Username { get; set; } = NozzleApiSettings.Username;
        public string Password { get; set; } = NozzleApiSettings.Password;
    }
}
