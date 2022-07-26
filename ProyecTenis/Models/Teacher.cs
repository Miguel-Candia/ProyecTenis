using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyecTenis.Models
{
    public class Teacher
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Rut { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }

        public Teacher(int id,string name, string lastname, string rut, string username, string password)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Rut = rut;
            UserName = username;
            Password = password;
        }

        public Teacher() { }

    }

}