using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyecTenis.Models
{
    public class Booking
    {
        public int IdBooking { get; set; }
        public int IdCancha { get; set; }
        public int IdUser { get; set; }
        public int IdTeacher { get; set; }
        public string BookingDate { get; set; }
        public string BookingTime { get; set; }

        public Booking(int idBooking, int idCancha, int idUser, int idTeacher, string bookingDate, string bookingTime)
        {
            IdBooking = idBooking;
            IdCancha = idCancha;
            IdUser = idUser;
            IdTeacher = idTeacher;
            BookingDate = bookingDate;
            BookingTime = bookingTime;
        }


        public Booking() { }

    }

}