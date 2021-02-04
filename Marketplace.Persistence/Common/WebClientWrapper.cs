using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Marketplace.Infrastucture.Common
{
    public class WebClientWrapper
    {
        public static async Task<TResult> GetAsync<TResult>(Uri url)
        {
            string response = await WebClientSingleton.Instance.GetStringAsync(url);
            TResult result = JsonConvert.DeserializeObject<TResult>(response);
            return result;
        }
    }
}
