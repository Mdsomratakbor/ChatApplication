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
            Usrs = new List<User>();
        }
        public int Id { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> Usrs { get; set; }
        public ChatTypeEnums Type { get; set; }
        public string Name { get; set; }
    }
}
