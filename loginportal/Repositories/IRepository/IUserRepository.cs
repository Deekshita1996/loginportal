using loginportal.Models;
using loginportal.Services.IService;

namespace loginportal.Repositories.IRepository
{
    public interface IUserRepository 
    {
        void AddData(Registration registration);
    }
}
