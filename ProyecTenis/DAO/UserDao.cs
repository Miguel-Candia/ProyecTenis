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
    class UserDao : IUser
    {

        private SqlConnection con;

        public UserDao()
        {
            Conexion();
        }
        public User BuscarById(int id)
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

        public bool Eliminar(int id)
        {
            Console.WriteLine("Eliminando producto id" + id);

            if (con != null)
            {
                SqlCommand cmdSql = new SqlCommand("Select * from User", con);
                SqlCommand cmdEliminar = new SqlCommand("Delete from User where Id = " + id, con);

                cmdEliminar.ExecuteNonQuery();

            }


            return true;
        }

        public List<User> GetAll() {
            List<User> lista = new List<User>();
            try {

                if (con != null) {
                    SqlCommand cmdSql = new SqlCommand("Select * from users", con);
                    SqlDataReader reader = cmdSql.ExecuteReader();
                    while (reader.Read()) {
                        User u = new User();
                        u.Id = reader.GetInt32(0);
                        u.Name = reader.GetString(1);
                        u.LastName = reader.GetString(2);   
                        u.Rut = reader.GetString(3);
                        u.Phone = reader.GetString(4);
                        u.Email = reader.GetString(5);
                        lista.Add(u);

                    }
                    reader.Close();
                }

            } catch(Exception e) {
                Console.WriteLine(e.Message);
            }
            return lista;
        }

        public bool Ingresar(User user) {

            try {
                if(con != null) {
                    SqlCommand cmdSql = new SqlCommand("INSERT INTO user (name, last_name, rut, phone, email) VALUES (@name, @last_name, @rut, @phone, @email)", con);
                    cmdSql.Parameters.AddWithValue("@name", user.Name);
                    cmdSql.Parameters.AddWithValue("@last_name", user.LastName);
                    cmdSql.Parameters.AddWithValue("@rut", user.Rut);
                    cmdSql.Parameters.AddWithValue("@phone", user.Phone);
                    cmdSql.Parameters.AddWithValue("@email", user.Email);
                    cmdSql.ExecuteNonQuery();
                }

            } catch (Exception e) {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
                return false;
            }
            return true;
        }

        public bool Modificar(User producto)
        {
            throw new NotImplementedException();
        }
    }
}