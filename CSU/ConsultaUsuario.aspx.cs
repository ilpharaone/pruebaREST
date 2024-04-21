using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Newtonsoft.Json;
using RestSharp;
using PruebaREST.CSD;


namespace PruebaREST.CSU
{
    public partial class ConsultaUsuario : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Consultar_Click(object sender, EventArgs e)
        {
            RestClient client = new RestClient("https://randomuser.me/api/");
            string Respuesta;

            RestRequest request = new RestRequest();

            var response = client.Get(request);

            Respuesta = response.Content;

            Resultados objResultado = JsonConvert.DeserializeObject<Resultados>(Respuesta);

            Usuario objUsuario = objResultado.results[0];

            imgUsuario.ImageUrl = objUsuario.picture.large;
            txtTitulo.Text = objUsuario.name.title;
            txtNombre.Text = objUsuario.name.first;
            txtApellido.Text = objUsuario.name.last;
            txtUsuario.Text = objUsuario.login.username;
            txtContrasena.Text = objUsuario.login.password;

        }
    }
}