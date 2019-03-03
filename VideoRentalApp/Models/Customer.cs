using System;
using System.ComponentModel.DataAnnotations;
using System.Web.UI;

namespace VideoRentalApp.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Full Name")]

        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        public DateTime? BirthDate { get; set; }
    }
}