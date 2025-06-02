namespace AppointmentsApi.Models;

public class Appointment
{
    public int AppointmentId { get; set; }
    public DateTime Date { get; set; }

    public int PatientId { get; set; }
    public Patient Patient { get; set; } = null!;

    public int DoctorId { get; set; }
    public Doctor Doctor { get; set; } = null!;

    public ICollection<AppointmentService> AppointmentServices { get; set; } = new List<AppointmentService>();
}