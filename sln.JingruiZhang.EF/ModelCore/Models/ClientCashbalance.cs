using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientCashbalance
    {
        public string CashBalanceId { get; set; }
        public string ObjectId { get; set; }
        public DateTime? ExecutionDate { get; set; }
        public string CashAccount { get; set; }
        public decimal? Receivable { get; set; }
        public decimal? Expenses { get; set; }
        public decimal? Balance { get; set; }
        public string Abstract { get; set; }
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
