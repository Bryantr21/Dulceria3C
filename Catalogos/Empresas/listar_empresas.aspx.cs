using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Dulceria3C.Utilidades;
using VO;

namespace Dulceria3C.Catalogos.Empresas
{
    public partial class listar_empresas : System.Web.UI.Page
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
            GVEmpresas.DataSource = BLL_Empresa.GetEmpresa();
            GVEmpresas.DataBind();
        }

        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formularioempresa.aspx");
        }

        protected void GVEmpresas_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GVEmpresas.DataKeys[e.RowIndex].Values["Id_Empresa"].ToString());
            string respuesta = BLL_Empresa.EliminarEmpresa(id);
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

        protected void GVEmpresas_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                String id = GVEmpresas.DataKeys[varIndex].Values["Id_Empresa"].ToString();
                Response.Redirect($"formularioempresa.aspx?Id={id}");

            }
        }

        protected void GVEmpresas_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVEmpresas.EditIndex = e.NewEditIndex;
            cargarGrid();
        }

        protected void GVEmpresas_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int id = int.Parse(GVEmpresas.DataKeys[e.RowIndex].Values["Id_Empresa"].ToString());
            string nombre = e.NewValues["Nombre"].ToString();
            string Direccion = e.NewValues["Direccion"].ToString();
            string Colonia = e.NewValues["Colonia"].ToString();
            string Municipio_Delegacion = e.NewValues["Municipio_Delegacion"].ToString();
            string Estado = e.NewValues["Estado"].ToString();
            string Email = e.NewValues["Email"].ToString(); 
            string Cel = e.NewValues["Cel"].ToString();
            string Descripcion = e.NewValues["Descripcion"].ToString();
            Empresa_VO _empresa = BLL_Empresa.GetEmpresa("@Id_Empresa", id)[0];
            Empresa_VO _empresaAux = new Empresa_VO();
            _empresaAux.Id_Empresa = id;
            _empresaAux.Nombre = nombre;
            _empresaAux.Colonia = Colonia;
            _empresaAux.Municipio_Delegacion = Municipio_Delegacion;
            _empresaAux.Estado = Estado;
            _empresaAux.Email = Email;
            _empresaAux.Cel = Cel;
            _empresaAux.Descripcion = Descripcion;
            //sweetAlert
            string respuesta = "";
            string titulo, msg, tipo;
            try
            {
                respuesta = BLL_Empresa.ActualizarEmpresa(_empresaAux);
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

        protected void GVEmpresas_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVEmpresas.EditIndex = -1;
            cargarGrid();
        }
    }
}