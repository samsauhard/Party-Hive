using System;
using System.Collections.Generic;

namespace PartyHive.Models
{
    public partial class Party
    {
        public Party()
        {
            Booking = new HashSet<Booking>();
        }

        public int Id { get; set; }
        public decimal? Price { get; set; }
        public string Address { get; set; }
        public string TargetAudience { get; set; }
        public string Description { get; set; }
        public string CurrentEnrollment { get; set; }
        public string MaxEnrollment { get; set; }
        public bool IsActivated { get; set; }
        public int HostId { get; set; }
        public string Name { get; set; }

        public Host Host { get; set; }
        public ICollection<Booking> Booking { get; set; }
    }
}
