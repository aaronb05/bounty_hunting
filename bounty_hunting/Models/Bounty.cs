namespace bounty_hunting.Models
{
    public class Bounty
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string? PhoneNumber { get; set; }
        public string AddressLine1 { get; set; }
        public string? AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }


        public virtual ICollection<Jacket>? Jackets { get; set; }
        public virtual ICollection<BountyComment>? BountyComments { get; set; }


        public Bounty() 
        {
            Jackets= new HashSet<Jacket>();     
        }       
    }
}
