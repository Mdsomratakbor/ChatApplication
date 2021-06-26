using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using ChatDataBase;
using ChatEntities.Entity;

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
           
            var chats = _ctx.Chats.ToList();
            return View(chats);
        }
    }
}
