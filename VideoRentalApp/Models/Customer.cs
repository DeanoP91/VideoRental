using System.ComponentModel.DataAnnotations;

namespace VideoRentalApp.Models
{
    public class Customer
    {
        public int Id { get; set; }
        // Overriding the default conventions
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }
    }
}