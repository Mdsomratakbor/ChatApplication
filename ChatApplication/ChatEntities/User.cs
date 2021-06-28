using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;

namespace ChatEntities.Entity
{
    public class User : IdentityUser
    {
        public ICollection<ChatUser> Chats { get; set; }
    }
}
