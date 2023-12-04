using System.ComponentModel.DataAnnotations;

namespace ASystems.DeskReservation.Web.Data.Entities;

public class Desk
{
    public Guid Id { get; set; }

    [Required]
    [StringLength(6, ErrorMessage = "Name cannot be longer than 6 characters")]
    [RegularExpression(@"^[a-zA-Z0-9]+$", ErrorMessage = "Special characters are not allowed.")]
    public string Name { get; set; }

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
