using APIGateway.Web.Client;
using CommonEntities;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using System.Reflection;
using static CommonEntities.Enums;

namespace Admin.WebUI.Settings
{
    public class APIGatewayWebClientProxy
    {
        public ApiUrl apiUrl;

        public APIGatewayWebClientProxy(IConfiguration _config , APIGatewayWebClientMethodName aPIGatewayWebClientMethodName)
        {
            this.apiUrl = new ApiUrl
            {
                BaseURL = _config.GetValue<string>("ClientUrls:APIGatewayWebClient:BaseUrl"),
                MethodName = _config.GetValue<string>("ClientUrls:APIGatewayWebClient:MethodName:" + Enum.GetName(aPIGatewayWebClientMethodName))
            };
        }
       
    }
}
