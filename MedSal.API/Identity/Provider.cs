namespace MedSal.API.Identity;

internal class Provider : ApplicationUser
{
    internal required string BusinessName { get; set; }
    internal required string BankName { get; set; }
    internal required string IBAN { get; set; }
    internal required string SwiftCode { get; set; }
    internal required string TradeLicenseNumber { get; set; }
    internal required DateOnly TradeExpDate { get; set; }
    internal required ProviderType Type { get; set; }
    internal required Guid CreatorId { get; init; }
}
