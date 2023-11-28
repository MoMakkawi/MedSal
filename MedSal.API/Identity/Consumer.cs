namespace MedSal.API.Identity;

internal class Consumer : ApplicationUser
{
    internal required string Nationality { get; set; }
    internal required string CardNumber { get; set; }
    internal required DateOnly CardExpDate { get; set; }
}
