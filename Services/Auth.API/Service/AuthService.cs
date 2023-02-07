using Auth.API.Repository;
using CommonEntities.Auth;
using CommonEntities.Result;
using CommonUtil;
using static CommonEntities.Enums;

namespace Auth.API.Service
{
    public class AuthService : BaseService.BaseService,IAuthService 
    {
        public IAuthRepository _authRepository;

        public AuthService(IAuthRepository authRepository) 
        {
            _authRepository = authRepository;
        }
        public async Task<ServiceResultWithData<CreateTokenResponse>> CreateToken(UserInfo _userData)
        {
            var result = new ServiceResultWithData<CreateTokenResponse>( );
            result.Data = new CreateTokenResponse();
            result.Data.UserInfo = new UserInfo();
            result.Data.UserInfo = await _authRepository.GetUserInfoByEmailAndPassword(_userData.Email, _userData.Password);
            
            var JwtKey = this.GetConfigurationSetting<string>("JwtKey", "Yh2k7QSu4l8CZg5p6X3Pna9L0Miy4D3Bvt0JVr87UcOj69Kqw5R2Nmf4FWs03Hdx");
            var JwtIssuer = this.GetConfigurationSetting<string>("JwtIssuer", "JWTAuthenticationServer");
            var JwtAudience = this.GetConfigurationSetting<string>("JwtAudience", "JWTServicePostmanClient");
            var JwtSubject = this.GetConfigurationSetting<string>("JwtSubject", "JWTServiceAccessToken");


            result.Data.Token = GetToken(result.Data.UserInfo, JwtKey, JwtIssuer, JwtAudience, JwtSubject);
            return result;
        }

       

        public async Task<ServiceResultWithData<RegisterResponse>> RegisterUser(UserInfo _userData)
        {
            var result = new ServiceResultWithData<RegisterResponse>();
            result.Data.UserInfo = await _authRepository.SaveUserInfo(_userData);
            return result;
        }

       
    }
}
