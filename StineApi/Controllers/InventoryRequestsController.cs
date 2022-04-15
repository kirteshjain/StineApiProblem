using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using StineApi.Models;
using StineApi.Services;

namespace StineApi.Controllers
{
    [Route("/[controller]")]
    [ApiController]
    public class InventoryRequestsController : ControllerBase
    {
        private readonly IInventoryRequestsService _inventoryRequestsService;
        public InventoryRequestsController(IInventoryRequestsService inventoryRequestsService)
        {
            _inventoryRequestsService = inventoryRequestsService;
        }

        [HttpGet("getInventoryRequests")]
        public async Task<IActionResult> GetRequestInventory()
        {

            return Ok(await _inventoryRequestsService.GetInventoryRequest());
        }
    }
}
