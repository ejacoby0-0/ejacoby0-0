using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelReservationSystem
{
    class Booking
    {
        public string GuestName { get; set; }
        public string RoomType { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }

        public override string ToString()
        {
            return $"Name: {GuestName}, Room: {RoomType}, Check-In: {CheckInDate.ToShortDateString()}, Check-Out: {CheckOutDate.ToShortDateString()}";
        }
    }
}
