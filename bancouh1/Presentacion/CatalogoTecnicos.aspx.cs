using bancouh1.Capa_Logica;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace bancouh1.Presentacion
{
    public partial class CatalogoTecnicos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            LlenarGrid();
        }

        protected void LlenarGrid()
        {
            string constr = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;
            using (SqlConnection con = new SqlConnection(constr))
            using (SqlCommand cmd = new SqlCommand("SELECT * FROM tecnicos", con))
            {
                con.Open();
                using (SqlDataReader rdr = cmd.ExecuteReader())
                {
                    GridView1.DataSource = rdr;
                    GridView1.DataBind();
                }
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            if (Tecnicos.Agregartecnicos(txtTecnicoID.Text, txtNombre.Text, txtEspecialidad.Text) > 0)
            {
                LlenarGrid();
            }
        }

        protected void btnActualizar_Click(object sender, EventArgs e)
        {
            if (Tecnicos.Actualizartecnicos(txtTecnicoID.Text, txtNombre.Text, txtEspecialidad.Text) > 0)
            {
                LlenarGrid();
            }
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            if (Tecnicos.Eliminartecnicos(txtTecnicoID.Text) > 0)
            {
                LlenarGrid();
            }
        }
    }
}