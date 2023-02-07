using CommonEntities.Auth;
using CommonEntities.Base;

namespace Auth.API.Repository
{
    public interface IAuthRepository
    {
        Task<UserInfo> GetUserInfoByEmailAndPassword(string email, string password);
        Task<UserInfo> SaveUserInfo(UserInfo userInfo);
    }
}
