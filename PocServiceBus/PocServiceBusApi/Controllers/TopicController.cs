using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PocServiceBusApi.Model;
using PocServiceBusApi.Service;

namespace PocServiceBusApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TopicController : ControllerBase
    {
        private readonly IMessagePublisher _messagePublisher;
        public TopicController(IMessagePublisher messagePublisher)
        {
            _messagePublisher = messagePublisher;
        }
        // POST api/values  
        [HttpPost(template: "product")]
        public async Task SendToProduct([FromBody] Product product)
        {
            await _messagePublisher.PublisherAsync(product);
        }
        [HttpPost(template: "order")]
        public async Task SentToOrder([FromBody] Order order)
        {
            await _messagePublisher.PublisherAsync(order);
        }
    }
}
