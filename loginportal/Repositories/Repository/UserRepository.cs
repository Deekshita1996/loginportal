using loginportal.AppDB_context;
using loginportal.Models;
using loginportal.Repositories.IRepository;

namespace loginportal.Repositories.Repository
{
    public class UserRepository : IUserRepository
    {
        private readonly LoginContext _context;
        public UserRepository(LoginContext context)
        {
            _context = context;
        }
        public void AddData(Registration registration)
        {
           
            _context.SaveChanges();
        }
    }
}
