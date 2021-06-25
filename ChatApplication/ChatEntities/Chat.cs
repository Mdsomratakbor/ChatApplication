using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChatApplication.ViewModels
{
    public class Chat
    {
        public int Id { get; set; }
        public ICollection<Message> Messages { get; set; }
        public ICollection<User> Usrs { get; set; }
        public ChatTypeEnums Type { get; set; }
    }
}
