using Domain.Aggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Events
{
    public class OrderCancelledDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderCancelledDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
