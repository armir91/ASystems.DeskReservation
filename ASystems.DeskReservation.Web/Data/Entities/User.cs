using Microsoft.AspNetCore.Identity;

namespace ASystems.DeskReservation.Web.Data.Entities;

public class User : IdentityUser<Guid>
{
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public ICollection<Reservation> Reservations { get; set; }
}
