namespace AppointmentsApi.Models;

public class Doctor
{
    public int DoctorId { get; set; }
    public string Pwz { get; set; } = null!;

    public ICollection<Appointment> Appointments { get; set; } = new List<Appointment>();
}