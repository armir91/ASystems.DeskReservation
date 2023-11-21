namespace ASystems.DeskReservation.Web.Data.Entities;

public class Desk
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<Reservation> Reservations { get; set; } = new List<Reservation>();
}
