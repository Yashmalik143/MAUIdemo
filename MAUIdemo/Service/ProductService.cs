using MAUIdemo.Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MAUIdemo.Service
{
    public class ProductService : IProductService
    {
        private string _baseUrl = "https://rdtecommerce.azurewebsites.net";
        public async Task<List<Product>> GetAllProduct()
        {
            var returnResponse = new List<Product>();
            try
            {
                using (var client = new HttpClient())
                {
                    string url = $"{_baseUrl}/api/Product/view-all-products";
                    var apiResponse = await client.GetAsync(url);
                    var str = apiResponse;

                        var response = await apiResponse.Content.ReadAsStringAsync();
                        var deserilizeResponse = JsonConvert.DeserializeObject<MainResponseModel>(response);

                        if (deserilizeResponse.IsSuccess)
                        {
                            returnResponse = JsonConvert.DeserializeObject<List<Product>>(deserilizeResponse.Content.ToString());
                        }
                    
                }
            }
            catch (Exception ex)
            {
                string msg = ex.Message;
            }
            return returnResponse;
        }
    }
}
