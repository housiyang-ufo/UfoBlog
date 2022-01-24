using Refit;
using UfoBlog.Domain.Model;
using System.Threading.Tasks;

namespace UfoBlog.Domain.Interface
{
    public interface IAccountClient
    {
        [Post("/api/Account/Login")]
        Task<Request<string>> Login(string token);
    }
}
