using CommonEntities.Auth;
using System.Data;
using Dapper;
using Microsoft.Data.SqlClient;

namespace Auth.API.Repository
{
    public class AuthRepository : BaseRepositoryService, IAuthRepository
    {
        public AuthRepository(IConfiguration config) : base(config)
        {
        }

        public async Task<UserInfo> GetUserInfoByEmailAndPassword(string email, string password)
        {
            UserInfo userInfo;
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userInfo = await connection.QueryFirstOrDefaultAsync<UserInfo>("GetUserInfoByEmailAndPassword",
                                    new { email = email, password = password },
                                    commandType: CommandType.StoredProcedure);
                }
                return userInfo;
            }
            catch (Exception ex)
            {

            }
            return null;
        }

        public async Task<UserInfo> SaveUserInfo(UserInfo userInfo)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    await connection.OpenAsync();

                    userInfo = await connection.QueryFirstOrDefaultAsync<UserInfo>("SaveUserInfo",
                                    new { Email = userInfo.Email, Password = userInfo.Password },
                                    commandType: CommandType.StoredProcedure);
                }
                return userInfo;
            }
            catch (Exception ex)
            {

            }
            return null;
        }
    }
}
