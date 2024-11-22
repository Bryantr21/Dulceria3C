using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Dulceria3C.Utilidades;
using VO;

namespace Dulceria3C.Catalogos.Empresas
{
    public partial class formularioempresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                //Validar si voy a insertar o a editar
                if (Request.QueryString["id"] == null)
                {
                    //voy a insertar
                    Titulo.Text = "Agregar Empresa";
                    Subtitulo.Text = "Registro de una empresa";

                }
                else
                {
                    //voy a actulizar recupero el id de la url donde porviene 
                    int _id = Convert.ToInt32(Request.QueryString["id"]);
                    Empresa_VO _dato_original = BLL_Empresa.GetEmpresa("@Id_Empresa", _id)[0];

                    if (_dato_original.Id_Empresa != 0)
                    {
                        //si ecuentra el objeto y comienzo a colocar los valores
                        Titulo.Text = "Actualizar Empresa";
                        Subtitulo.Text = $"Modificar los datos del Empresa #{_id}";
                        txtnombre.Text = _dato_original.Nombre;
                        txtdescripcion.Text = _dato_original.Descripcion;
                    }
                    else
                    {

                        //NO encotre el objeto y para atras

                        Response.Redirect("listar_empresas.aspx");
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
                Empresa_VO _dato_aux = new Empresa_VO();
                _dato_aux.Nombre = txtnombre.Text;
                _dato_aux.Direccion = txtdireccion.Text;
                _dato_aux.Colonia = txtcolonia.Text;
                _dato_aux.Municipio_Delegacion = txtmunicipio_delegacion.Text;
                _dato_aux.Estado = txtestado.Text;
                _dato_aux.Email = txtemail.Text;
                _dato_aux.Cel = txtcel.Text;
                _dato_aux.Descripcion = txtdescripcion.Text;

                //FOrma 2 (durante la instanicación
                Empresa_VO _dato_aux_2 = new Empresa_VO()
                {

                    Nombre = txtnombre.Text,
                    Direccion = txtdireccion.Text,
                    Colonia = txtcolonia.Text,
                    Municipio_Delegacion = txtmunicipio_delegacion.Text,
                    Estado = txtestado.Text,
                    Email = txtemail.Text,
                    Cel = txtcel.Text,
                    Descripcion = txtdescripcion.Text
                };

                //decido si voy a actualziar o a insertar
                if (Request.QueryString["Id"] == null)
                {
                    //Voy a insertar
                    salida = BLL_Empresa.InsertarEmpresa(_dato_aux);
                }
                else
                {
                    //Actualizar
                    _dato_aux.Id_Empresa = int.Parse(Request.QueryString["Id"]);
                    salida = BLL_Empresa.ActualizarEmpresa(_dato_aux);
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
            sweetAlert.Sweet_Alert(titulo, respuesta, tipo, this.Page, this.GetType(), "/Catalogos/Empresas/listar_empresas.aspx");

        }
    }
}