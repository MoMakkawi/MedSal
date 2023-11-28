namespace MedSal.API.Entities;

internal class Order
{
    internal required Guid Id { get; set; }
    internal required int Amount {  get; set; }
    internal required DateOnly Date {  get; set; }
    internal OrderStatus Status { get; set; } = OrderStatus.Pend;
}
