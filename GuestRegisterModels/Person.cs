using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuestRegisterModels
{
    public class Person
    {
        public string Name { get; set; } 
        public string ReservCode { get; set; }
        public string RoomNumber { get; set; } 
        public string companions { get; set; }
        public string NatCode { get; set; } 
        public string CheckinDate { get; set; } 
        public string CheckOutDate { get; set; } 
        public string Price { get; set; } 
    }
}
