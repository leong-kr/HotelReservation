using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    // Holds all reservation for a hotel
    public class ReservationBook
    {
        private Dictionary<string, List<Reservation>> roomsToReservations;

        public ReservationBook()
        {
            roomsToReservations = new Dictionary<string, List<Reservation>>();
        }

        public void AddReservation(Reservation reservation)
        {
            if (roomsToReservations.ContainsKey(reservation.roomID.ToString())){
                   List<Reservation> newList = roomsToReservations[reservation.roomID.ToString()];
                   newList.Add(reservation);
                   roomsToReservations[reservation.roomID.ToString()] = newList;
            }
            else
            {
                List<Reservation> list = new List<Reservation>();
                list.Add(reservation);
                roomsToReservations.Add(reservation.roomID.ToString(), list);    
            }
      
        }
    }
}
