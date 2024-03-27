using loginportal.Models;
using loginportal.Repositories.IRepository;
using loginportal.Services.IService;

namespace loginportal.Services.Service
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _userRepository;
        public UserService(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        public void insertData(Registration registration)
        {
            _userRepository.AddData(registration);

        }       
    }
}
