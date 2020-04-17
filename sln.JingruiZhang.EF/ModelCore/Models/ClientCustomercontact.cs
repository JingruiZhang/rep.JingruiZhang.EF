using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class ClientCustomercontact
    {
        public string CustomerContactId { get; set; }
        public string CustomerId { get; set; }
        public string Contact { get; set; }
        public int? Gender { get; set; }
        public string Mobile { get; set; }
        public string Tel { get; set; }
        public string Fax { get; set; }
        public string Qq { get; set; }
        public string Email { get; set; }
        public string Wechat { get; set; }
        public string PostId { get; set; }
        public string Hobby { get; set; }
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
