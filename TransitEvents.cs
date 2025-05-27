using Microsoft.Extensions.Logging;

namespace WebhookListenerAPI
{
    public class TransitEvents
    {
        public string TrackingNumber { get; set; }
        public string EventDateTime { get; set; }
        public string EventDetails { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
    public class WebhookRequest
    {
        public List<TransitEvents> Events { get; set; }
    }
}
