using System.Net.Http.Headers;
using System.Net.Http.Json;
namespace TestScraper
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
        //TIOBE   
        // https://api.brightdata.com/dca/trigger?collector=c_lv3l43x61hnemlo6b5&queue_next=1

        //Amazon
        // https://api.brightdata.com/dca/trigger?collector=c_lv6dn9c92fs2qhddkg&queue_next=1
           
            using HttpClient client = new HttpClient();

            client.DefaultRequestHeaders.Authorization =
                new AuthenticationHeaderValue("Bearer", "22f606a9-94ec-4aeb-a624-151a97519057");

            client.DefaultRequestHeaders
                .Accept
                .Add(new MediaTypeWithQualityHeaderValue("application/json"));

            //---TIOBE---
            //var requestUri = "https://api.brightdata.com/dca/trigger?collector=c_lv3l43x61hnemlo6b5&queue_next=1"; //TIOBE Scraper

            //var response = await client.PostAsync(requestUri, null);
            //------

            //---Amazon---
            var input = "C++";

            var requestUri = "https://api.brightdata.com/dca/trigger?collector=c_lv6dn9c92fs2qhddkg&queue_next=1"; // Amazon Scraper

            var response = await client.PostAsJsonAsync(requestUri, new {search=input});
            //------
            
            Console.WriteLine(response.StatusCode);

        }
    }
}
