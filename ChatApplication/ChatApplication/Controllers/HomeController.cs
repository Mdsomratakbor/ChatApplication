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
using System.Dynamic;

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
            var chats = _ctx.Chats.Include(x => x.Users).ToList().Where(x => !x.Users.Any(y => y.UserId == userId));

            return View(chats);
        }

        public IActionResult Find()
        {
            var users = _ctx.Users.Where(x => x.Id != User.FindFirst(ClaimTypes.NameIdentifier).Value).ToList();
            return View(users);
        }

        public IActionResult Private()
        {
            var chats = _ctx.Chats
                .Include(x => x.Users)
                .ThenInclude(x => x.User)
                .Where(x => x.Type == ChatTypeEnums.Private && x.Users.Any(y => y.UserId == User.FindFirst(ClaimTypes.NameIdentifier).Value))
                .ToList();
            return View(chats);
        }
        public async Task<IActionResult> CreatePrivateRoom(string userId)
        {
            var chat = new Chat
            {
                Type = ChatTypeEnums.Private,

            };
            chat.Users.Add(new ChatUser
            {
                UserId = userId
            });
            chat.Users.Add(new ChatUser
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value
            });
            _ctx.Chats.Add(chat);
            await _ctx.SaveChangesAsync();

            return RedirectToAction("Chat", new { id = chat.Id });
        }

        [HttpGet("id")]
        public IActionResult Chat(int id)
        {
            int pageSize = 10;
            var totalMessages = _ctx.Messages.Where(x => x.ChatId == id).Count();
            var totalPages = (int)Math.Ceiling((decimal)totalMessages / (decimal)pageSize);
            var chat = MessageData(id, totalPages);
            ViewBag.Users = _ctx.ChatUsers.Include(x => x.User).Where(x => x.ChatId == id).ToList();
            ViewBag.TotalPage = totalPages;
            ViewBag.RoomName = _ctx.Chats.Where(x => x.Id == id).Select(x => x.Name).SingleOrDefault();

            return View(chat);
        }


        [HttpGet]
        public Chat MessageData(int chatId, int totalPages)
        {
            var data =  _ctx.Chats
                .Include(x => x.Messages
            .Skip((totalPages - 1) * 10)
            .Take(10))
            .FirstOrDefault(x => x.Id == chatId);
            return data;
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoom(string name)
        {
            var chat = new Chat
            {
                Name = name,
                Type = ChatTypeEnums.Room
            };
            chat.Users.Add(new ChatUser
            {
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                Role = UserRole.Admin
            });
            _ctx.Chats.Add(chat);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public async Task<IActionResult> JoinRoom(int id)
        {
            var chatUser = new ChatUser
            {
                ChatId = id,
                UserId = User.FindFirst(ClaimTypes.NameIdentifier).Value,
                Role = UserRole.Member

            };
            _ctx.ChatUsers.Add(chatUser);
            await _ctx.SaveChangesAsync();
            return RedirectToAction("Chat", "Home", new { id = id });
        }

        [HttpPost()]
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
            return RedirectToAction("Chat", new { id = chatId });
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }




    }
}
