using ChatApplication.ViewModels;
using ChatDataBase;
using ChatEntities;
using ChatEntities.Entity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace ChatApplication.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var chats = _ctx.Chats.Include(x=>x.Users).ToList().Where(x=>!x.Users.Any(y=>y.UserId == userId));

            return View(chats);
        }
        [HttpGet("id")]
        public IActionResult Chat(int id)
        {
            var chat = _ctx.Chats.Include(x=>x.Messages).FirstOrDefault(x => x.Id == id);
            return View(chat);
        }
       
        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            var chat = new Chat
            {
                Name = name,
                Type = ChatTypeEnums.Room
            };
            chat.Users.Add(new ChatUser {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                Role = UserRole.Admin
            });
            _ctx.Chats.Add(chat);
           await  _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            var chatUser = new ChatUser {
                ChatId = id,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                Role = UserRole.Member
            
            };
            _ctx.ChatUsers.Add(chatUser);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Chat","Home", new { id = id });
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(int chatId, string message)
        {
            var msg = new Message
            {
                ChatId = chatId,
                Text = message,
                Name = User.Identity.Name,
                Timestamp = DateTime.Now
            };
            _ctx.Messages.Add(msg);

            await _ctx.SaveChangesAsync();
            return RedirectToAction("Chat", new {id = chatId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
