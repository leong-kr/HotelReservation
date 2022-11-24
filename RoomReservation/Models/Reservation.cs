using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class Reservation
    {
        public RoomID roomID { get; }

        public DateTime startTime { get; }
        public DateTime endTime { get; }
        public Customer customer { get; }

        public Reservation(RoomID roomID, DateTime startTime, DateTime endTime, Customer customer)
        {
            this.roomID = roomID;
            this.startTime = startTime;
            this.endTime = endTime;
            this.customer = customer;
        }
    }
}
