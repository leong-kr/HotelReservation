using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoomReservation.Models
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public Customer(int iD, string name)
        {
            ID = iD;
            Name = name;
        }
    }
}
