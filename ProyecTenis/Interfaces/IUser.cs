﻿using ProyecTenis.Interfaces;
using ProyecTenis.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyecTenis.Interfaces
{
    interface IUser: ICRUD<User> {
        // add the funtionality to the interface
        // User Insert(User user);

    }
}