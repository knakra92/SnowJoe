using System;
using System.Collections.Generic;

namespace SnowJoe
{
    interface IDealItem
    {
        decimal Discount { get; set; }
        DateTime StartDate { get; set; }
        DateTime EndDate { get; set; }
        List<DealItem> Items { get; set; }
    }
}