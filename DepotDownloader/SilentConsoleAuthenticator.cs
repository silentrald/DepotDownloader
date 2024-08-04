using System.Threading.Tasks;
using SteamKit2.Authentication;

namespace DepotDownloader
{
    class SilentConsoleAuthenticator : IAuthenticator
    {
        public Task<string> GetDeviceCodeAsync(bool previousCodeWasIncorrect)
        {
            return Task.FromResult("");
        }

        public Task<string> GetEmailCodeAsync(string email, bool previousCodeWasIncorrect)
        {
            return Task.FromResult("");
        }

        public Task<bool> AcceptDeviceConfirmationAsync()
        {
            return Task.FromResult(true);
        }
    }
}
