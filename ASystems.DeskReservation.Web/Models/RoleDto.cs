using System.ComponentModel.DataAnnotations;

namespace ASystems.DeskReservation.Web.Models;

public class RoleDto
{
    public Guid Id { get; set; }
    [Required]
    [StringLength(15, ErrorMessage = "Name cannot be longer than 15 characters")]
    [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special characters are not allowed.")]
    public string Name { get; set; }
}
