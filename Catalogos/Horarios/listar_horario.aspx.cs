using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Dulceria3C.Utilidades;
using VO;

namespace Dulceria3C.Catalogos.Horarios
{
    public partial class listar_horario : System.Web.UI.Page
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

            GVHorarios.DataSource = BLL_Horarios.GetHorarios();
            GVHorarios.DataBind();
        }
        
        protected void GVHorarios_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GVHorarios.DataKeys[e.RowIndex].Values["Id_Horario"].ToString());
            string respuesta = BLL_Horarios.EliminarHorario(id);
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

        protected void GVHorarios_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                String id = GVHorarios.DataKeys[varIndex].Values["Id_Horario"].ToString();
                Response.Redirect($"formulariohorario.aspx?Id={id}");

            }
        }

        protected void GVHorarios_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVHorarios.EditIndex = e.NewEditIndex;
            cargarGrid();
        }

        protected void GVHorarios_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = int.Parse(GVHorarios.DataKeys[e.RowIndex].Values["Id_Horario"].ToString());
            string Descripcion = e.NewValues["Descripcion"].ToString();
            string Horario_Inicio = e.NewValues["Horario_Inicio"].ToString();
            string Horario_fin = e.NewValues["Horario_fin"].ToString();
            Horarios_VO _horario = BLL_Horarios.GetHorarios("@Id_Horario", id)[0];
            Horarios_VO _horarioAux = new Horarios_VO();
            _horarioAux.Id_Horario = id;
            _horarioAux.Descripcion = Descripcion;
            _horarioAux.Horario_Inicio = Horario_Inicio;
            _horarioAux.Horario_fin = Horario_fin;
            //sweetAlert
            string respuesta = "";
            string titulo, msg, tipo;
            try
            {
                respuesta = BLL_Horarios.ActualizarHorarios(_horarioAux);
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

        protected void GVHorarios_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVHorarios.EditIndex = -1;
            cargarGrid();
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formulariohorario.aspx");

        }
    }
}