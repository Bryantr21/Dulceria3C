using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Dulceria3C.Utilidades;
using VO;

namespace Dulceria3C.Catalogos.Categorias
{
    public partial class listar_categorias : System.Web.UI.Page
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
            GVCategorias.DataSource = BLL_Categoria.GetCategorias();
            GVCategorias.DataBind();
        }
        protected void Insertar_Click(object sender, EventArgs e)
        {
            Response.Redirect("formulariocatalogo.aspx");
        }

        protected void GVCategorias_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "Select")
            {
                int varIndex = int.Parse(e.CommandArgument.ToString());
                String id = GVCategorias.DataKeys[varIndex].Values["Id_Categoria"].ToString();
                Response.Redirect($"formulariocatalogo.aspx?Id={id}");

            }
        }

        protected void GVCategorias_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GVCategorias.EditIndex = e.NewEditIndex;
            cargarGrid();
        }

        protected void GVCategorias_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            int idcategoria = int.Parse(GVCategorias.DataKeys[e.RowIndex].Values["Id_Categoria"].ToString());
            string nombre = e.NewValues["Nombre"].ToString();
            string descripcion = e.NewValues["Descripcion"].ToString();
            Categoria_VO _categoria = BLL_Categoria.GetCategorias("@Id_Categoria", idcategoria)[0];
            Categoria_VO _categoriaAux = new Categoria_VO();
            _categoriaAux.Id_Categoria = idcategoria;
            _categoriaAux.Nombre = nombre;
            _categoriaAux.Descripcion = descripcion;
            //sweetAlert
            string respuesta = "";
            string titulo, msg, tipo;
            try
            {
                respuesta = BLL_Categoria.ActualizarCategoria(_categoriaAux);
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
            }
            catch (Exception ex)
            {
                titulo = "Opss..";
                msg = ex.Message;
                tipo = "error";
            }
        }

        protected void GVCategorias_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GVCategorias.EditIndex = -1;
            cargarGrid();
        }

        protected void GVCategorias_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            int id = int.Parse(GVCategorias.DataKeys[e.RowIndex].Values["Id_Categoria"].ToString());
            string respuesta = BLL_Categoria.Eliminarcategoria(id);
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
    }
}