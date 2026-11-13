using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bancouh1.CapaDatos
{
    public class Equipos
    {

        private string equipoID;

        public string EquipoID
        {
            get { return equipoID; }
            set { equipoID = value; }
        }

        private string tipoEquipo;

        public string TipoEquipo
        {
            get { return tipoEquipo; }
            set { tipoEquipo = value; }
        }

        private string modelo;

        public string Modelo
        {
            get { return modelo; }
            set { modelo = value; }
        }
        private string correo;

        public string Correo
        {
            get { return correo; }
            set { correo = value; }
        }

        public Equipos(string equipoID, string tipoEquipo, string modelo, string correo)
        {
            this.equipoID = equipoID;
            this.tipoEquipo = tipoEquipo;
            this.modelo = modelo;
            this.correo = correo;
        }

        public Equipos() { }
    }
}

