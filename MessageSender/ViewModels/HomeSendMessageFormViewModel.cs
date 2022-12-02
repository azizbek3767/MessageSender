using MessageSender.Models;
using System.Collections.Generic;

namespace MessageSender.ViewModels
{
    public class HomeSendMessageFormViewModel
    {
        public User User { get; set; }
        public IEnumerable<User> Users { get; set; }
        public string MessageTitle { get; set; }
        public string MessageRecepientName { get; set; }
        public string MessageBody { get; set; }
        public IEnumerable<Message> Messages { get; set; }
        public int UserId { get; set; }
    }
}
