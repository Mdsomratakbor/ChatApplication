using System;

namespace ChatApplication.ViewModels
{
    public class MessageViewModels
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
