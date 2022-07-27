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
    class AdminDao: IAdmin
    {

        private SqlConnection con;

        public AdminDao()
        {
            Conexion();
        }
        public Admin BuscarById(int id)
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
                SqlCommand cmdSql = new SqlCommand("Select * from administrador", con);
                SqlCommand cmdEliminar = new SqlCommand("Delete from administrador where id_administrador = " + id, con);

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

        public List<Admin> GetAll() {

            List<Admin> listaAdmin = new List<Admin>();
            Admin admin;

            if (con != null)
            {
                SqlCommand cmdSql = new SqlCommand("Select * from administrator", con);
                SqlDataReader resultAdmin = cmdSql.ExecuteReader();

                while(resultAdmin.Read()) 
                {

                    admin = new Admin();
                    admin.Id = resultAdmin.GetInt32(0);
                    admin.Name = resultAdmin["name"].ToString();
                    admin.LastName = resultAdmin["last_name"].ToString();
                    admin.Rut = resultAdmin["rut"].ToString();
                    admin.UserName = resultAdmin["username"].ToString();
                    admin.Password = resultAdmin["password"].ToString();

                    listaAdmin.Add(admin);

                }
                resultAdmin.Close();
            }
            return listaAdmin;
        }

        public bool Ingresar(Admin producto)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Admin producto)
        {
            throw new NotImplementedException();
        }
    }
}