using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatEntities.Entity
{
    public class Chat
    {
        public Chat()
        {
            Messages = new List<Message>();
            User = new List<User>();
            Users = new List<ChatUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public ChatTypeEnums Type { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> User { get; set; }
        public ICollection<ChatUser> Users { get; set; }
       
        
    }
}
