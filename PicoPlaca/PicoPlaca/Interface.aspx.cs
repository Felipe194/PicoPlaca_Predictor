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
            hora = txtHour.Text.ToString();
            if (license == ""  || fecha == "" || hora == "")
            {               
                lblResultado.Text = "There are boxes empty";
            }
            else
            {
                Predictor pred = new Predictor();

                lblResultado.Text = "On " + pred.diaXSemana(pred.determinarDia(fecha)) + " " +
                                    pred.validarLicense(license, fecha, hora).ToString() + " if the license plate ends with a " + pred.determinarUltimoDigitoPlaca(license) + " at " + hora;
            }
        }

    }
}
