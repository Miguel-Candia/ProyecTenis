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
    class TeacherDao: ITeacher
    {

        private SqlConnection con;

        public TeacherDao()
        {
            Conexion();
        }
        public Teacher BuscarById(int id)
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
                SqlCommand cmdSql = new SqlCommand("Select * from Teacher", con);
                SqlCommand cmdEliminar = new SqlCommand("Delete from Teacher where Id = " + id, con);

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

        public List<Teacher> GetAll() {

            List<Teacher> lista = new List<Teacher>();
            lista.Add(new Teacher(1,"12345678-9","sadsd","asdasd","adsad","sdsaads"));

            return lista;
        }

        public bool Ingresar(Teacher producto)
        {
            throw new NotImplementedException();
        }

        public bool Modificar(Teacher producto)
        {
            throw new NotImplementedException();
        }
    }
}