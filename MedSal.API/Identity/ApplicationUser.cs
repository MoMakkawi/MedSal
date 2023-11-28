namespace MedSal.API.Identity;

internal class ApplicationUser
{
    internal required string LocationText { get; set; }
    internal bool IsActive { get; set; } = true;

}
