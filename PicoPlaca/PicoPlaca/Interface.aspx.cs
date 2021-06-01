using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
 

namespace PicoPlaca
{
    public partial class Interface : System.Web.UI.Page
    {
        string license = null;
        string fecha = null;
        string hora = null;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            license = txtLicense.Text.ToString();
            fecha = txtDate.Text.ToString();
            //10/05/2020; //dd/mm/yyyy
            hora = txtHour.Text.ToString();

            Predictor pred = new Predictor();         

            lblResultado.Text = pred.validarLicense(license,fecha).ToString() +
                " Día de la semana: "+pred.determinarDia(fecha);
        }
    }
}