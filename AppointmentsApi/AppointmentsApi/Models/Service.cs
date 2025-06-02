namespace AppointmentsApi.Models;

public class Service
{
    public int ServiceId { get; set; }
    public string Name { get; set; } = null!;

    public ICollection<AppointmentService> AppointmentServices { get; set; } = new List<AppointmentService>();
}