namespace MedSal.API.Entities;

internal class Appointment : Service
{
    internal DateOnly Date { get; set; }
    internal required string DrName { get; set; }
    internal required string DrSpecialty { get; set; }

}
