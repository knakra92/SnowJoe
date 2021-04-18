using System;
using System.Collections.Generic;

namespace SnowJoe
{
    interface IOrder
    {
        string OrderId { get; set; }
        DateTime DateCreated { get; set; }
        string ItemNumber { get; set; }
        int QuantityOrdered { get; set; }
        List<Order> Orders { get; set; }
    }
}