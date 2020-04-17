using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientReceivable
    {
        public string ReceivableId { get; set; }
        public string OrderId { get; set; }
        public DateTime? PaymentTime { get; set; }
        public decimal? PaymentPrice { get; set; }
        public string PaymentMode { get; set; }
        public string PaymentAccount { get; set; }
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
