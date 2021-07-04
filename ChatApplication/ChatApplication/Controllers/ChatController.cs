using ChatApplication.Hubs;
using ChatDataBase;
using ChatEntities.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class ChatController : Controller
    {
        private IHubContext<ChatHub> _chat;
        public ChatController(IHubContext<ChatHub> chat)
        {
            _chat = chat;
        }
        [HttpPost("[action]/{connectionId}/{roomName}")]
        public async Task<IActionResult> JoinRoom(string connectionId, string roomName)
        {
           await _chat.Groups.AddToGroupAsync(connectionId, roomName);
            return Ok();
        }
        [HttpPost("[action]/{connectionId}/{roomName}")]
        public async Task<IActionResult> LeaveRoom(string connectionId, string roomName)
        {
            await _chat.Groups.RemoveFromGroupAsync(connectionId, roomName);
            return Ok();
        }
        [HttpPost("[action]")]
        public async Task<IActionResult> SendMessage(string message, int chatId, string roomName, [FromServices] AppDbContext ctx)
        {
            var msg = new Message
            {
                ChatId = chatId,
                Text = message,
                Name = User.Identity.Name,
                Timestamp = DateTime.Now
            };
            ctx.Messages.Add(msg);
            await ctx.SaveChangesAsync();
            await _chat.Clients.Group(roomName).SendAsync("RecieveMessage", new
            {
                Text = msg.Text,
                Name = msg.Name,
                Timestamp = msg.Timestamp.ToString("dd/MM/yyyyy hh:mm:ss")

            }); ;
            return Ok();
        }
    }
}
