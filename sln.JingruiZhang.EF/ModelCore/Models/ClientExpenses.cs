using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientExpenses
    {
        public string ExpensesId { get; set; }
        public DateTime? ExpensesDate { get; set; }
        public decimal? ExpensesPrice { get; set; }
        public string ExpensesAccount { get; set; }
        public string ExpensesType { get; set; }
        public string ExpensesAbstract { get; set; }
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
        public int? ExpensesObject { get; set; }
        public string Managers { get; set; }
    }
}
