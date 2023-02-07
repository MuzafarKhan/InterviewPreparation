using CommonEntities;
using CommonEntities.Base;

namespace BaseClient
{
    public class BaseClient
    {
        public  static void SetUrls(ApiUrl apiUrl, BaseRequest obj)
        {
            obj.BaseURL = apiUrl.BaseURL;
            obj.MethodName = apiUrl.MethodName;
        }
    }
}