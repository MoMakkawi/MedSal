namespace MedSal.API.Entities;

internal class Service
{
    internal Guid Id { get; set; }
    internal required string Name { get; set; }
    internal string? Description { get; set; }
    internal required ServiceType Type { get; set; }
    internal required decimal Price { get; set; }
    internal byte[]? Picture { get; set; }
}
