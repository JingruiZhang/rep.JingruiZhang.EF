using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientOrderentry
    {
        public string OrderEntryId { get; set; }
        public string OrderId { get; set; }
        public string ProductId { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public string UnitId { get; set; }
        public decimal? Qty { get; set; }
        public decimal? Price { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Taxprice { get; set; }
        public decimal? TaxRate { get; set; }
        public decimal? Tax { get; set; }
        public decimal? TaxAmount { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
    }
}
