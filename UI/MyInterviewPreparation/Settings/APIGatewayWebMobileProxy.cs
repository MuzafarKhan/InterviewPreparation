using CommonEntities;
using static CommonEntities.Enums;

namespace MyInterviewPreparation.Settings
{
    public class APIGatewayWebMobileProxy
    {
        public ApiUrl apiUrl;

        public APIGatewayWebMobileProxy(IConfiguration _config, APIGatewayWebMobileClientMethodName aPIGatewayWebMobileClientMethodName)
        {
            this.apiUrl = new ApiUrl
            {
                BaseURL = _config.GetValue<string>("ClientUrls:APIGatewayWebMobileClient:BaseUrl"),
                MethodName = _config.GetValue<string>("ClientUrls:APIGatewayWebMobileClient:MethodName:" + Enum.GetName(aPIGatewayWebMobileClientMethodName))
            };
        }
    }
}
