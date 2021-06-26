using ChatApplication.ViewModels;
using ChatDataBase;
using ChatEntities.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _ctx;

        public HomeController(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IActionResult Index()
        {
            return View();
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
            _ctx.Chats.Add(new Chat
            {
                Name = name,
                Type = ChatTypeEnums.Room
            });
           await  _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessage(int chatId, string message)
        {
            var msg = new Message
            {
                ChatId = chatId,
                Text = message,
                Name = "Default",
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
