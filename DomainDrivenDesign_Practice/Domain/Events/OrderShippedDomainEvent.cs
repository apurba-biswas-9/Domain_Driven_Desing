using Domain.Aggregate;
using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Events
{
    public class OrderShippedDomainEvent : INotification
    {
        public Order Order { get; }

        public OrderShippedDomainEvent(Order order)
        {
            Order = order;
        }
    }
}
