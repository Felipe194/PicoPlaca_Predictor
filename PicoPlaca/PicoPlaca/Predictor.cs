using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PicoPlaca
{
    public class Predictor
    {
        string valueLicense;
        string valueDate;
        string ValueHour;
        public string validarLicense(string license, string fecha) {

            int lenghtLicense = license.Length;

            valueLicense = license.Substring(lenghtLicense-1);

            string autorizadoCircular= "You can´t road";

            if ((valueLicense=="1" || valueLicense=="2") && determinarDia(fecha)==1 )
            {
                autorizadoCircular = "You can road!!!";
            }
            if ((valueLicense == "3" || valueLicense == "4") && determinarDia(fecha) == 2)
            {
                autorizadoCircular = "You can road!!!";
            }
            if ((valueLicense == "5" || valueLicense == "6") && determinarDia(fecha) == 3)
            {
                autorizadoCircular = "You can road!!!";
            }
             if ((valueLicense == "7" || valueLicense == "8") && determinarDia(fecha) == 4)
            {
                autorizadoCircular = "You can road!!!";
            }
            if ((valueLicense == "9" || valueLicense == "0") && determinarDia(fecha) == 5)
            {
                autorizadoCircular = "You can road!!!";
            }
           

            return autorizadoCircular;

        }

        public int determinarDia(string fecha) {
            string dia;
            string mes;
            string anio;

            int anioDosDigit;

            int diaSemana=0;

            
            //13/06/1994 -- dd/mm/yyyy
            //0123456789
            dia = fecha.Substring(0, 2);
            mes = fecha.Substring(3, 2);
            anio = fecha.Substring(6, 4);
            anioDosDigit = Convert.ToInt32(anio.Substring(2, 2));

            //Fórmula para determinar el día de la semana 
            // 0 -> Domingo, 1 -> Lunes, 2 -> Martes, 3 -> Miercoles, 4 -> Jueves, 5 -> Viernes, 6 -> Sábado
            diaSemana = Convert.ToInt32(dia) + codigoMes(mes) + anioDosDigit + (anioDosDigit / 4) + codigoSiglo(anio);
            diaSemana = diaSemana % 7;
            return diaSemana;
        }

        private int codigoSiglo(string anio) {

            int codigoS=0;

            if (Convert.ToInt32(anio) >= 2000 && Convert.ToInt32(anio) <= 2999){
                codigoS = 6;
            }
            else if (Convert.ToInt32(anio) >= 1900 && Convert.ToInt32(anio) <= 1999) {
                codigoS = 0;
            }
            else if (Convert.ToInt32(anio) >= 1800 && Convert.ToInt32(anio) <= 1899)
            {
                codigoS = 2;
            }
            else if (Convert.ToInt32(anio) >= 1700 && Convert.ToInt32(anio) <= 1799)
            {
                codigoS = 4;
            }
            else if (Convert.ToInt32(anio) >= 1600 && Convert.ToInt32(anio) <= 1699)
            {
                codigoS = 6;
            }

            return codigoS;
        }

        private int codigoMes(string mes)
        {

            int codigoM = 0;

            if (mes =="01")
            {
                codigoM = 0;
            }
            else if (mes == "02")
            {
                codigoM = 3;
            }
            else if (mes == "03")
            {
                codigoM = 3;
            }
            else if (mes == "04")
            {
                codigoM = 6;
            }
            else if (mes == "05")
            {
                codigoM = 1;
            }
            else if (mes == "06")
            {
                codigoM = 4;
            }
            else if (mes == "07")
            {
                codigoM = 6;
            }
            else if (mes == "08")
            {
                codigoM = 2;
            }
            else if (mes == "09")
            {
                codigoM = 5;
            }
            else if (mes == "10")
            {
                codigoM = 0;
            }
            else if (mes == "11")
            {
                codigoM = 3;
            }
            else if (mes == "12")
            {
                codigoM = 5;
            }

            return codigoM;
        }

    }
}