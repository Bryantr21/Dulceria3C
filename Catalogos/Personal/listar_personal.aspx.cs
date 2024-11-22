using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Dulceria3C.Utilidades;
using VO;

namespace Dulceria3C.Catalogos.Personal
{
    public partial class listar_personal : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                cargarGrid();

            }
        }
        public void cargarGrid()
        {
            //carga info desde bll al gv
            GVPersonal.DataSource = BLL_Personal.GetPersonal();
            GVPersonal.DataBind();
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formulariopersonal.aspx");

        }

        protected void GVPersonal_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GVPersonal.DataKeys[e.RowIndex].Values["Id_Persona"].ToString());
            string respuesta = BLL_Personal.EliminarPersonal(id);
            string titulo, msg, tipo;
            if (respuesta.ToUpper().Contains("Error"))
            {
                titulo = "Error";
                msg = respuesta;
                tipo = "error";
            }
            else
            {
                titulo = "Correcto";
                msg = respuesta;
                tipo = "success";
            }
            sweetAlert.Sweet_Alert(titulo, msg, tipo, this.Page, this.GetType());
            cargarGrid();
        }

        protected void GVPersonal_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                String id = GVPersonal.DataKeys[varIndex].Values["Id_Persona"].ToString();
                Response.Redirect($"formulariopersonal.aspx?Id={id}");

            }
        }

        protected void GVPersonal_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVPersonal.EditIndex = e.NewEditIndex;
            cargarGrid();
        }

        protected void GVPersonal_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = int.Parse(GVPersonal.DataKeys[e.RowIndex].Values["Id_Persona"].ToString());
            string Nombres = e.NewValues["Nombres"].ToString();
            string Apellido_P = e.NewValues["Apellido_P"].ToString();
            string Apellido_M = e.NewValues["Apellido_M"].ToString();
            string Direccion = e.NewValues["Direccion"].ToString();
            string Colonia = e.NewValues["Colonia"].ToString();
            string Municipio_Delegacion = e.NewValues["Municipio_Delegacion"].ToString();
            string Estado = e.NewValues["Estado"].ToString();
            string CURP = e.NewValues["CURP"].ToString();
            string Cel = e.NewValues["Cel"].ToString();
            string Email = e.NewValues["Email"].ToString();
            string Puesto = e.NewValues["Puesto"].ToString();
            Personal_VO _personal = BLL_Personal.GetPersonal("@Id_Persona", id)[0];
            Personal_VO _personalAux = new Personal_VO();
            _personalAux.Id_Persona = id;
            _personalAux.Nombres = Nombres;
            _personalAux.Apellido_P = Apellido_P;
            _personalAux.Apellido_M = Apellido_M;
            _personalAux.Colonia = Colonia;
            _personalAux.Municipio_Delegacion = Municipio_Delegacion;
            _personalAux.Estado = Estado;
            _personalAux.Email = Email;
            _personalAux.Cel = Cel;
            _personalAux.Puesto = Puesto;
            //sweetAlert
            string respuesta = "";
            string titulo, msg, tipo;
            try
            {
                respuesta = BLL_Personal.ActualizarPersonal(_personalAux);
                if (respuesta.ToUpper().Contains("Error"))
                {
                    titulo = "Error";
                    msg = respuesta;
                    tipo = "error";
                }
                else
                {
                    titulo = "Correcto";
                    msg = respuesta;
                    tipo = "success";
                    cargarGrid();

                }
            }
            catch (Exception ex)
            {
                titulo = "Opss..";
                msg = ex.Message;
                tipo = "error";
            }
        }

        protected void GVPersonal_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVPersonal.EditIndex = -1;
            cargarGrid();
        }
    }
}