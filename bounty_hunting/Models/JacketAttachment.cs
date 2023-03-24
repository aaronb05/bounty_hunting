namespace bounty_hunting.Models
{
    public class JacketAttachment
    {
        public int Id { get; set; }
        public int JacketId { get; set; }
        public string Title { get; set; }
        public string AttachmentUrl { get; set; }
        public DateTime CreatedDate { get; set; }


        public virtual Jacket Jacket { get; set; }
        public virtual ApplicationUser User { get; set; }
    }
}
