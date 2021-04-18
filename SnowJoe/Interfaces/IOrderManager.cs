using System;
using System.Collections.Generic;

namespace SnowJoe
{
    interface IOrderManager
    {
        void AddDeal(DealItem dealItem);
        void AddItem(Item item);
        void AddOrder(Order order);
        void PrintItems();
        void PrintOrders();
        void RemoveItem(string itemNumber);
        List<Order> GetAllOrders();
        List<DealItem> GetAllItems();
    }
}