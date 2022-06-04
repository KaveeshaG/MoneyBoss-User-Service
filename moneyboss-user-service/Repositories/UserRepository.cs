using moneyboss_user_service.Db;
using moneyboss_user_service.Modals;

namespace moneyboss_user_service.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly DbConnection _dbConnection = new DbConnection(
        );

        public bool RegisterUser(User user)
        {
            _dbConnection.Users.Add(user);
            _dbConnection.SaveChanges();
            return true;
        }

        public User LoginUser(User user)
        {
            return _dbConnection.Users.Find(user);
        }
    }
}
