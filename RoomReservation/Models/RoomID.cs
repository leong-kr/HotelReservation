using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class RoomID
    {
        public int FloorNumber { get; }
        public int RoomNumber { get; }

        public RoomID(int floorNumber, int roomNumber)
        {
            this.FloorNumber = floorNumber;
            this.RoomNumber = roomNumber;
        }
    
        public override string ToString()
        {
            return $"{FloorNumber}{RoomNumber}"; 
        }

        /*
        public override bool Equals(object obj)
        {
            return obj is RoomID roomID && //If that object is another RoomID
                FloorNumber == roomID.FloorNumber && 
                RoomNumber == roomID.RoomNumber;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(FloorNumber, RoomNumber);
        }
        */
    }
}
