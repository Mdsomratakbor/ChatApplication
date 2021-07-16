using System;
using System.ComponentModel.DataAnnotations;

namespace ChatEntities.Entity
{
    public class Message
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Text { get; set; }
        [DisplayFormat(DataFormatString = "{dd/MM/yyyyy hh:mm:ss}")]
        public DateTime Timestamp { get; set; }
        public int ChatId { get; set; }
        public Chat Chat { get; set; }
    }
}
