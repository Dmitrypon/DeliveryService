using DeliveryService.Delivery.BusinessLogic.Enums;
using DeliveryService.Delivery.Domain.Entities.DeliveryEntities;

namespace DeliveryService.Delivery.Core.Models.Responses
{
    public class CreateDeliveryResponse
    {
        public Guid Id { get; set; }
        public required Guid UserGuid { get; set; }
        public Guid OrderId { get; set; }
        public OrderState OrderStatus { get; set; }
        public DeliveryStatus DeliveryStatus { get; set; }
        public int TotalQuantity { get; set; }
        public decimal TotalPrice { get; set; }
        public PaymentType PaymentType { get; set; }
        public required string ShippingAddress { get; set; }
        public Guid? CourierId { get; set; }        
        public DateTime EstimatedDeliveryTime { get; set; }
        public DateTime ActualDeliveryTime { get; set; }
    }
}
