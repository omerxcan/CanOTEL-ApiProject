using HotelProject.BusinessLayer.Abstract;
using HotelProject.EntityLayer;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HotelProject.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SendMessageController : ControllerBase
    {
        private readonly ISendMessageService _sendService;

        public SendMessageController(ISendMessageService sendService)
        {
            _sendService = sendService;
        }

        [HttpGet]
        public IActionResult SendMessageList()
        {
            var values = _sendService.TGetList();
            return Ok(values);
        }
        [HttpPost]
        public IActionResult AddMessage(SendMessage sendMessage)
        {
            _sendService.TInsert(sendMessage);
            return Ok();
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _sendService.TGetByID(id);
            _sendService.TDelete(value);
            return Ok();
        }
        [HttpPut]
        public IActionResult UpdateMessage(SendMessage sendMessage)
        {
            _sendService.TUpdate(sendMessage);
            return Ok();
        }
        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _sendService.TGetByID(id);
            return Ok(value);
        }
        [HttpGet("GetSendMessageCount")]
        public IActionResult GetSendMessageCount()
        {
            return Ok(_sendService.TGetSendMessageCount());
        }

    }
}
