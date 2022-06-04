using moneyboss_user_service.Modals;

namespace moneyboss_user_service.Repositories
{
    public class IUserRepository
    {
        bool RegisterUser(User user);
        bool LoginUser(User user);
    }
}
