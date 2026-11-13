using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;

namespace bancouh1.CapaDatos
{

    public class Tecnicos
    {
        private string tecnicoID;

        public string TecnicoID
        {
            get { return tecnicoID; }
            set { tecnicoID = value; }
        }

        private string especialidad;

        public string Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public Tecnicos(string tecnicoID, string especialidad, string nombre)
        {
            this.tecnicoID = tecnicoID;
            this.especialidad = especialidad;
            this.nombre = nombre;
        }

        public Tecnicos() { }
    }
}   