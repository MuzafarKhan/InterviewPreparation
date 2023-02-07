using CommonEntities.Base;
using System.Text;

namespace GenericApi
{
    public class Api
    {
        public static async Task<string> CallAsync(BaseRequest obj)
        {
            string submitOut;
            try
            {
                using (var client = new System.Net.Http.HttpClient())
            {
                var url = obj.BaseURL + obj.MethodName;
                string jsonString = Newtonsoft.Json.JsonConvert.SerializeObject(obj);
                var content = new StringContent(jsonString, Encoding.UTF8, "application/json");
                
                var response = await client.PostAsync(url, content);
                
                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStringAsync();
                    submitOut = responseBody;
                }
                else
                {
                    submitOut = string.Format("Bad Response {0} \n", response.StatusCode.ToString());
                    submitOut = submitOut + response;
                }
            }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }

            return submitOut;
        }

    }
}