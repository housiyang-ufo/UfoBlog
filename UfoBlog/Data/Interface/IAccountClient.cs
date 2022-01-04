using Refit;
using UfoBlog.Domain.Model;
using System.Threading.Tasks;

namespace UfoBlog.Data.Interface
{
    public interface IAccountClient
    {
        [Post("/api/Account/Login")]
        Task<Request<string>> LoginAsync(string token);
    }
}
