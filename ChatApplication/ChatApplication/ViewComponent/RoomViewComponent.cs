using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ChatDataBase;
using ChatEntities.Entity;
using System.Security.Claims;
using Microsoft.EntityFrameworkCore;

namespace ChatEntities.ViewComponents
{
    public class RoomViewComponent:ViewComponent
    {
        private readonly AppDbContext _ctx;

        public RoomViewComponent(AppDbContext ctx)
        {
            _ctx = ctx;
        }

        public IViewComponentResult Invoke()
        {
         
            var userId = HttpContext.User.FindFirst(ClaimTypes.NameIdentifier).Value;
            var chats = _ctx.ChatUsers.Include(x=>x.Chat).Where(x=>x.UserId == userId).Select(x=>x.Chat).ToList();
            return View(chats);
        }
    }
}
