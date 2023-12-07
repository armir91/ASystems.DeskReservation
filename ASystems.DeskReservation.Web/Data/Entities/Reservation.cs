using System.ComponentModel.DataAnnotations;

namespace ASystems.DeskReservation.Web.Data.Entities;

public class Reservation
{
    public Guid Id { get; set; }
    public Guid UserId { get; set; }
    public Guid DeskId { get; set; }
    [DataType(DataType.Date)]
    public DateTime ReservedTime { get; set; }
    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }
    [DataType(DataType.Date)]
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
