using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyecTenis.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public string Rut { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public User(int id,string name, string lastname, string rut, string phone, string email)
        {
            Id = id;
            Name = name;
            LastName = lastname;
            Rut = rut;
            Phone = phone;
            Email = email;
        }

        public User() { }

    }

}