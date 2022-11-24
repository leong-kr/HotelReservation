using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class Hotel
    {
        private readonly ReservationBook _reservationBook;
        private string name;

        public Hotel(string name)
        {
            _reservationBook = new ReservationBook();
            this.name = name;
        }

        public void makeReservation(Reservation reservation)
        {
            _reservationBook.AddReservation(reservation);
        }
    }
}
