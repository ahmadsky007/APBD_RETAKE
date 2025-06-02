namespace AppointmentsApi.DTOs;

public class AppointmentDto
{
    public DateTime Date { get; set; }
    public PatientDto Patient { get; set; } = null!;
    public DoctorDto Doctor { get; set; } = null!;
    public List<AppointmentServiceDto> AppointmentServices { get; set; } = new();
}