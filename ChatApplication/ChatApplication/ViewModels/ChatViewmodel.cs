using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ChatEntities.Entity;

namespace ChatApplication.ViewModels
{
    public class ChatViewmodel
    {
        public int Id { get; set; }
        public ICollection<MessageViewModels> Messages { get; set; }
        public ICollection<UserViewModels> Usrs { get; set; }
        public ChatTypeEnums Type { get; set; }
        public string Name { get; set; }
    }
}
