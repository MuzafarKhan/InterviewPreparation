using BaseClient;
using CommonEntities;
using CommonEntities.Auth;
using CommonEntities.Base;
using GenericApi;

namespace APIGateway.Web.Client
{
    public class APIGatewayWebClient : BaseClient.BaseClient
    {
        public static async Task<string> CreateToken(ApiUrl apiUrl, UserInfo userInfo)
        {
            SetUrls(apiUrl,userInfo);
            return await Api.CallAsync(userInfo);
        }

        public static async Task<string> WeatherForecast(ApiUrl apiUrl, EmptyRequest emptyRequest)
        {
            SetUrls(apiUrl, emptyRequest);
            return await Api.CallAsync(emptyRequest);
        }

        public static async Task<string> Register(ApiUrl apiUrl, UserInfo userInfo)
        {
            SetUrls(apiUrl, userInfo);
            return await Api.CallAsync(userInfo);
        }
    }
}