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
        string hora;

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

            lblResultado.Text = "El día: "+ pred.diaXSemana(pred.determinarDia(fecha))+ " " + 
                                pred.validarLicense(license,fecha,hora).ToString() + " con la placa terminada en " + pred.determinarUltimoDigitoPlaca(license) + " la hora true dentro del rango: "+pred.validarHora(hora).ToString() ;
        }

        protected void txtDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}