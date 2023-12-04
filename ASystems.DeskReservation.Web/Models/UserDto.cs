using System.ComponentModel.DataAnnotations;

namespace ASystems.DeskReservation.Web.Models
{
    public class UserDto
    {
        public Guid Id { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Name cannot be longer than 15 characters")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special characters are not allowed.")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15, ErrorMessage = "Name cannot be longer than 15 characters")]
        [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special characters are not allowed.")]
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string RoleName { get; set; }
        public bool CheckedIn { get; set; }
    }
}
