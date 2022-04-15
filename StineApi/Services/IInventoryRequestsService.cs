using StineApi.Models;

namespace StineApi.Services
{
    public interface IInventoryRequestsService
    {
        Task<InventoryRequests> GetInventoryRequest();
    }
}
