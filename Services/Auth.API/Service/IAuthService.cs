using CommonEntities.Auth;
using CommonEntities.Result;
using Microsoft.AspNetCore.Mvc;

namespace Auth.API.Service
{
    public interface IAuthService
    {
        Task<ServiceResultWithData<CreateTokenResponse>> CreateToken(UserInfo _userData);
        Task<ServiceResultWithData<RegisterResponse>> RegisterUser(UserInfo _userData);
    }
}
