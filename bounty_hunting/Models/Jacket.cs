namespace bounty_hunting.Models
{
    public class Jacket
    { 
        public int Id { get; set; }
        public int BountyId { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set;}
        
        
        public ICollection<JacketAttachment> Attachments { get; set; }

        public Jacket()
        {
            Attachments = new HashSet<JacketAttachment>();
        }
    }
}
