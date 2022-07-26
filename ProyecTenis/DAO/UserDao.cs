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

                // SqlDataReader drProductos = cmdSql.ExecuteReader();

                // while (drProductos.Read())
                // {
                //     Console.Write("Descripción " + drProductos.GetString(1));
                //     Console.WriteLine("Precio " + drProductos["Precio"].ToString());
                // }

                // drProductos.Close();

                cmdEliminar.ExecuteNonQuery();

            }


            return true;
        }

        public List<User> GetAll() {

            List<User> lista = new List<User>();
            lista.Add(new User(1,"12345678-9","sadsd","asdasd","adsad","sdsaads"));

            return lista;
        }

        public bool Ingresar(User producto)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(User producto)
        {
            throw new NotImplementedException();
        }
    }
}