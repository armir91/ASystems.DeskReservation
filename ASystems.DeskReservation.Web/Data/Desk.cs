namespace ASystems.DeskReservation.Web.Data;

public class Desk
{
    public Guid Id { get; set; }
    public string Name { get; set; }

    public ICollection<Reservation> Reservations { get; set; }
}
