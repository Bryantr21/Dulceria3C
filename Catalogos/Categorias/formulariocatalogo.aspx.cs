using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Dulceria3C.Utilidades;
using VO;

namespace Dulceria3C.Catalogos.Categorias
{
    public partial class formulariocatalogo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Validar  sie es postback
            if (!IsPostBack)
            {
                //Validar si voy a insertar o a editar
                if (Request.QueryString["id"] == null)
                {
                    //voy a insertar
                    Titulo.Text = "Agregar Categoria";
                    Subtitulo.Text = "Registro de una categoria";
                    
                }
                else
                {
                    //voy a actulizar recupero el id de la url donde porviene 
                    int _id = Convert.ToInt32(Request.QueryString["id"]);
                    Categoria_VO _dato_original = BLL_Categoria.GetCategorias("@Id_Categoria", _id)[0];

                    if (_dato_original.Id_Categoria != 0)
                    {
                        //si ecuentra el objeto y comienzo a colocar los valores
                        Titulo.Text = "Actualizar Categoria";
                        Subtitulo.Text = $"Modificar los datos del Categoria #{_id}";
                        txtnombre.Text = _dato_original.Nombre;
                        txtdescripcion.Text = _dato_original.Descripcion;
                     }
                    else
                    {

                        //NO encotre el objeto y para atras

                        Response.Redirect("listar_categorias.aspx");
                    }

                }
            }
        }
       
        protected void btnguardar_Click(object sender, EventArgs e)
        {
            string titulo = "", respuesta = "", tipo = "", salida = "";

            try
            {
                //creamos el objeto que enviaremos para actualiza o insertar
                //forma 1 (x atributos)
                Categoria_VO _dato_aux = new Categoria_VO();
                _dato_aux.Nombre = txtnombre.Text;
                _dato_aux.Descripcion = txtdescripcion.Text;
                //FOrma 2 (durante la instanicación
                Categoria_VO _dato_aux_2 = new Categoria_VO()
                {
                    Nombre = txtnombre.Text,
                    Descripcion = txtdescripcion.Text,
                 };

                //decido si voy a actualziar o a insertar
                if (Request.QueryString["Id"] == null)
                {
                    //Voy a insertar
                    salida = BLL_Categoria.InsertarCategoria(_dato_aux);
                }
                else
                {
                    //Actualizar
                    _dato_aux.Id_Categoria = int.Parse(Request.QueryString["Id"]);
                    salida = BLL_Categoria.ActualizarCategoria(_dato_aux);
                }
                //preparamos la salida para cachar nu error y mostrar un sweer alert
                if (salida.ToUpper().Contains("ERROR"))
                {
                    titulo = "Ops...";
                    respuesta = salida;
                    tipo = "warning";
                }
                else
                {
                    titulo = "Correcto!";
                    respuesta = salida;
                    tipo = "success";
                }

            }
            catch (Exception ex)
            {
                titulo = "Error";
                respuesta = ex.Message;
                tipo = "error";
            }
            //sweet alert
            sweetAlert.Sweet_Alert(titulo, respuesta, tipo, this.Page, this.GetType(), "/Catalogos/Categorias/listar_categorias.aspx");

        }
    }
}