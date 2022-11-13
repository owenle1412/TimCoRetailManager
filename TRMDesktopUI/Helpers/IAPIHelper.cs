using System.Net.Http;
using System.Threading.Tasks;
using TRMDesktopUI.Models;

namespace TRMDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        HttpClient apiClient { get; set; }

        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}