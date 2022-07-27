using ProyecTenis.Models;
using ProyecTenis.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using ProyecTenis.BD;

namespace ProyecTenis.DAO
{
    class BookingDao: IBooking
    {

        private SqlConnection con;

        public BookingDao()
        {
            Conexion();
        }
        public Booking BuscarById(int idbooking)
        {
            throw new NotImplementedException();
        }

        public bool Conexion()
        { 
            Console.WriteLine("Abriendo conexión");
            con = BaseDatos.GetConnection();

            if (con != null)
                Console.WriteLine("Conexión establecida");
            else
                throw new Exception("Error al conectar base");


            return true;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public bool Eliminar(int id) {
            try{
                Console.WriteLine("Eliminando booking(reserva) id" + id);

                if (con != null)
                {
                    SqlCommand cmdSql = new SqlCommand("Select * from booking", con);
                    SqlCommand cmdEliminar = new SqlCommand("Delete from booking where id_booking = " + id, con);
                    cmdEliminar.ExecuteNonQuery();
                }
                return true;
            } catch(Exception e) {
                Console.WriteLine(e.Message);
                return false;
            }
        }

        public List<Booking> GetAll() {

            List<Booking> listaBooking = new List<Booking>();
            Booking booking;

            if (con != null)
            {
                SqlCommand cmdSql = new SqlCommand("Select * from booking ", con);
                SqlDataReader resultBooking = cmdSql.ExecuteReader();

                while (resultBooking.Read())
                {

                    booking = new Booking();
                    booking.IdBooking = resultBooking.GetInt32(0);
                    booking.IdCancha = resultBooking.GetInt32(1);
                    booking.IdUser = resultBooking.GetInt32(2);
                    booking.IdTeacher = resultBooking.GetInt32(3);
                    booking.BookingDate = resultBooking["booking_date"].ToString();
                    booking.BookingTime = resultBooking["booking_time"].ToString();

                    listaBooking.Add(booking);

                }
                resultBooking.Close();
            }
            return listaBooking;

        }

        public bool Ingresar(Booking producto)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Booking producto)
        {
            throw new NotImplementedException();
        }
    }
}