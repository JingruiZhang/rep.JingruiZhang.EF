using System;
using System.Collections.Generic;

namespace ModelCore.Models
{
    public partial class PlusProject
    {
        public string Uid { get; set; }
        public string Name { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Finishdate { get; set; }
        public string Lastsaved { get; set; }
        public string Calendaruid { get; set; }
        public string Calendars { get; set; }
    }
}
