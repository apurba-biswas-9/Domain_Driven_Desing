using Domain.Aggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Events
{
    public class OrderStatusChangedToAwaitingValidationDomainEvent
         : INotification
    {
        public int OrderId { get; }
        public IEnumerable<OrderItem> OrderItems { get; }

        public OrderStatusChangedToAwaitingValidationDomainEvent(int orderId,
            IEnumerable<OrderItem> orderItems)
        {
            OrderId = orderId;
            OrderItems = orderItems;
        }
    }
}
