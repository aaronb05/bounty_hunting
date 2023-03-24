using System.Net.Mail;

namespace bounty_hunting.Models
{
    public class BountyComment
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int BountyId { get; set; }
        public string Body { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Created { get; set; }


        public virtual ApplicationUser User { get; set; }
    }
}
