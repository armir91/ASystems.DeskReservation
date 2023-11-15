namespace ASystems.DeskReservation.Web.Data;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid DeskId { get; set; }
    public DateTime ReservedTime { get; set; }
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public ReservationStatus Status { get; set; }

    public User User { get; set; }
    public Desk Desk { get; set; }
}

public enum ReservationStatus 
{
    Pending,
    Approved
}
