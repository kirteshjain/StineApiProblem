using Newtonsoft.Json;
using StineApi.Models;
using System.Net;
namespace StineApi.Services
{
    public class InventoryRequestsService : IInventoryRequestsService
    {        
        public Task<InventoryRequests> GetInventoryRequest()
        {

            var webClient = new WebClient();
            var json = webClient.DownloadString(@"https://mocki.io/v1/0077e191-c3ae-47f6-bbbd-3b3b905e4a60");

            var requestInventory = JsonConvert.DeserializeObject<InventoryRequests>(json);
           
            return Task.FromResult(requestInventory);
        }
    }
}
