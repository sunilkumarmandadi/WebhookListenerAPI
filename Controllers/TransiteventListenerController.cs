using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebhookListenerAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TransiteventListenerController : ControllerBase
    {
        public static WebhookRequest _dataStore = new WebhookRequest();
        [HttpPost]
        public IActionResult Receive([FromBody] WebhookRequest request)
        {
            // Save the shipment or trigger processing logic
            
            _dataStore.Events = request.Events;
            return Ok(new { message = "Shipment received" });
        }
        [HttpGet]
        public IActionResult Get()
        {
            if (_dataStore.Events == null)
            {
                return NotFound(new { message = "No shipment data found" });
            }
            return Ok(_dataStore.Events);
        }
    }
}
