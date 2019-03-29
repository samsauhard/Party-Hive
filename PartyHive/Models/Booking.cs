using System;
using System.Collections.Generic;

namespace PartyHive.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int UserId { get; set; }
        public int PartyId { get; set; }

        public Party Party { get; set; }
        public User User { get; set; }
    }
}
