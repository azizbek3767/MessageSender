namespace MessageSender.Models
{
    public class Message
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Recipient { get; set; }
        public string Title { get; set; }
        public string MessageBody { get; set; }
    }
}
