using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyecTenis.Interfaces
{
    interface ICRUD<T>: IDisposable
    {
        List<T> GetAll();

        T BuscarById(int id);

        bool Ingresar(T t);

        bool Modificar(T t);

        bool Eliminar(int id);

        bool Conexion();
    }
}