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
    public partial class formulariohorario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            cargar_DLL();
            if (!IsPostBack)
            {
                //Validar si voy a insertar o a editar
                if (Request.QueryString["id"] == null)
                {
                    //voy a insertar
                    Titulo.Text = "Agregar Horario";
                    Subtitulo.Text = "Registro de un horario";

                }
                else
                {
                    //voy a actulizar recupero el id de la url donde porviene 
                    int _id = Convert.ToInt32(Request.QueryString["id"]);
                    Horarios_VO _dato_original = BLL_Horarios.GetHorarios("@Id_Horario", _id)[0];

                    if (_dato_original.Id_Horario != 0)
                    {
                        //si ecuentra el objeto y comienzo a colocar los valores
                        Titulo.Text = "Actualizar Horario";
                        Subtitulo.Text = $"Modificar los datos del Horario #{_id}";
                        txtdescripcion.Text = _dato_original.Descripcion;
                    }
                    else
                    {

                        //NO encotre el objeto y para atras

                        Response.Redirect("listar_horario.aspx");
                    }

                }
            }
        }
        protected void cargar_DLL()
        {
            ListItem ddllista_I = new ListItem("Seleccione una Empresa", "0");
            ddlempresa.Items.Add(ddllista_I);
            List<Empresa_VO> list_c = BLL_Empresa.GetEmpresa();

            if (list_c.Count > 0)
            {
                foreach (var c in list_c)
                {
                    ListItem Ci = new ListItem(
                        (c.Nombre),
                        c.Id_Empresa.ToString());
                    ddlempresa.Items.Add(Ci);
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
                Horarios_VO _dato_aux = new Horarios_VO();
                _dato_aux.Descripcion = txtdescripcion.Text;
                _dato_aux.Horario_Inicio = txthorario_inicio.Text;
                _dato_aux.Horario_fin = txthorario_fin.Text;
                
                //FOrma 2 (durante la instanicación
                Horarios_VO _dato_aux_2 = new Horarios_VO()
                {

                    Descripcion = txtdescripcion.Text,
                    Horario_Inicio = txthorario_inicio.Text,
                    Horario_fin = txthorario_fin.Text,
                };

                //decido si voy a actualziar o a insertar
                if (Request.QueryString["Id"] == null)
                {
                    //Voy a insertar
                    salida = BLL_Horarios.InsertarHorarios(_dato_aux);
                }
                else
                {
                    //Actualizar
                    _dato_aux.Id_Horario = int.Parse(Request.QueryString["Id"]);
                    salida = BLL_Horarios.ActualizarHorarios(_dato_aux);
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
            sweetAlert.Sweet_Alert(titulo, respuesta, tipo, this.Page, this.GetType(), "/Catalogos/Horarios/listar_horario.aspx");

        }
       }
    
}