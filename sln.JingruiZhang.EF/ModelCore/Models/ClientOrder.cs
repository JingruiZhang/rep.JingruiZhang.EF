using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientOrder
    {
        public string OrderId { get; set; }
        public string CustomerId { get; set; }
        public string CustomerName { get; set; }
        public string SellerId { get; set; }
        public string SellerName { get; set; }
        public DateTime? OrderDate { get; set; }
        public string OrderCode { get; set; }
        public decimal? DiscountSum { get; set; }
        public decimal? Accounts { get; set; }
        public decimal? ReceivedAmount { get; set; }
        public DateTime? PaymentDate { get; set; }
        public string PaymentMode { get; set; }
        public int? PaymentState { get; set; }
        public decimal? SaleCost { get; set; }
        public string AbstractInfo { get; set; }
        public string ContractCode { get; set; }
        public string ContractFile { get; set; }
        public int? SortCode { get; set; }
        public int? DeleteMark { get; set; }
        public int? EnabledMark { get; set; }
        public string Description { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateUserId { get; set; }
        public string CreateUserName { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifyUserId { get; set; }
        public string ModifyUserName { get; set; }
    }
}
