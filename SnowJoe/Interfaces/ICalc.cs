namespace SnowJoe
{
    interface ICalc
    {
        decimal GetProfit(Order order, DealItem dealItem);
        decimal GetProfit(string orderId, string itemNumber, bool isDealItem);
        decimal GetProfit(Order order, Item item);
        decimal GetProfitLoss(IOrderManager orderManager);
        decimal GetProfitLoss();
    }
}