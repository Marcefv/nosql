using MongoDB.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Semana05.Collections
{
    public class Animales
    {
        ObjectId _id;
        string nombre;
        DateTime fecha;
        string tipo;
        string dueno;
        IList <Tratamiento> tratamiento;

    }

    public class Tratamiento
    {
        string Tipo;
        DateTime fecha;
        decimal precio;
    }
}