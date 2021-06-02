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
        string valueHour;
        string nameDay;


        //Valida que las condiciones de licencia, fecha y hora se cumplan correctamente
        public string validarLicense(string license, string fecha, string hora) {

            int lenghtLicense = license.Length;

            valueLicense = determinarUltimoDigitoPlaca(license);

            string autorizadoCircular= "you can road";

            if ((valueLicense=="1" || valueLicense=="2") && (determinarDia(fecha)==1) && validarHora(hora)==true  )
            {
                autorizadoCircular = "you can't road";
            }
            if ((valueLicense == "3" || valueLicense == "4") && determinarDia(fecha) == 2)
            {
                autorizadoCircular = "you can't road";
            }
            if ((valueLicense == "5" || valueLicense == "6") && determinarDia(fecha) == 3)
            {
                autorizadoCircular = "you can't road";
            }
             if ((valueLicense == "7" || valueLicense == "8") && determinarDia(fecha) == 4)
            {
                autorizadoCircular = "you can't road";
            }
            if ((valueLicense == "9" || valueLicense == "0") && determinarDia(fecha) == 5)
            {
                autorizadoCircular = "you can't road";
            }
           

            return autorizadoCircular;

        }

        //Se determina el último dígito de la placa
        public string determinarUltimoDigitoPlaca(string license) {
            int lenghtLicense = license.Length;

            valueLicense = license.Substring(lenghtLicense - 1);

            return valueLicense;
        }

        //Se determina el número del día de la semana utilizando la fecha ingresada por el usuario
        public int determinarDia(string fecha) {
            string dia;
            string mes;
            string anio;

            int anioDosDigit;

            int diaSemana=0;

            //Separación de fechas
            //13/06/1994 formato-> dd/mm/yyyy
            dia = fecha.Substring(0, 2);
            mes = fecha.Substring(3, 2);
            anio = fecha.Substring(6, 4);
            anioDosDigit = Convert.ToInt32(anio.Substring(2, 2));

            //Fórmula para determinar el día de la semana 
            // 0 -> Domingo, 1 -> Lunes, 2 -> Martes, 3 -> Miercoles, 4 -> Jueves, 5 -> Viernes, 6 -> Sábado
            diaSemana = Convert.ToInt32(dia) + codigoMes(mes) + anioDosDigit + (anioDosDigit / 4) + codigoSiglo(anio);
            diaSemana = diaSemana % 7;
            
            //nombre de la semana en letras
            diaXSemana(diaSemana);

            return diaSemana;
        }

        //Se determina el codigo de siglo que se utilizará en la funcion determinarUltimoDigitoPlaca() en la formula diaSemana
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

        //Se dermina el código del mes que se utilizará en la funcion determinarUltimoDigitoPlaca() en la formula diaSemana
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

        //Se determina el día de la semana utilizando el número obtenido del día de la semana
        public string diaXSemana(int diaSemana ) {

            switch (diaSemana) {
                case 0:
                    nameDay = "domingo";
                    break;
                case 1:
                    nameDay = "lunes";
                    break;
                case 2:
                    nameDay = "martes";
                    break;
                case 3:
                    nameDay = "miércoles";
                    break;
                case 4:
                    nameDay = "jueves";
                    break;
                case 5:
                    nameDay = "viernes";
                    break;
                case 6:
                    nameDay = "sábado";
                    break;

            }

            return nameDay;
        }

        //Validar la hora correcta
        public bool validarHora(string hora) {

            string hh=null;
            string mm=null;

            bool horaCorrecta = false;


            hh = hora.Substring(0, 2);
            mm = hora.Substring(3, 2);

            if (hh == "07" || hh == "08" || (hh == "09" && mm =="01") || (hh == "09" && mm == "02") || (hh == "09" && mm == "03") || (hh == "09" && mm == "04") || (hh == "09" && mm == "05") || (hh == "09" && mm == "06") || 
                (hh == "09" && mm == "07") || (hh == "09" && mm == "08") || (hh == "09" && mm == "09") || (hh == "09" && mm == "10") || (hh == "09" && mm == "11") || (hh == "09" && mm == "12") || (hh == "09" && mm == "13") || 
                (hh == "09" && mm == "14") || (hh == "09" && mm == "15") || (hh == "09" && mm == "16") || (hh == "09" && mm == "17") || (hh == "09" && mm == "18") || (hh == "09" && mm == "19") || (hh == "09" && mm == "20") || 
                (hh == "09" && mm == "21") || (hh == "09" && mm == "22") || (hh == "09" && mm == "23") || (hh == "09" && mm == "24") || (hh == "09" && mm == "25") || (hh == "09" && mm == "26") || (hh == "09" && mm == "27") || 
                (hh == "09" && mm == "28") || (hh == "09" && mm == "29") || (hh == "09" && mm == "30") || (hh == "09" && mm == "00")
                || hh == "16" || hh == "17" || hh == "18" || (hh == "19" && mm == "01") || (hh == "19" && mm == "02") || (hh == "19" && mm == "03") || (hh == "19" && mm == "04") || (hh == "19" && mm == "05") || (hh == "19" && mm == "06") ||
                (hh == "19" && mm == "07") || (hh == "19" && mm == "08") || (hh == "19" && mm == "09") || (hh == "19" && mm == "10") || (hh == "19" && mm == "11") || (hh == "19" && mm == "12") || (hh == "19" && mm == "13") ||
                (hh == "19" && mm == "14") || (hh == "19" && mm == "15") || (hh == "19" && mm == "16") || (hh == "19" && mm == "17") || (hh == "19" && mm == "18") || (hh == "19" && mm == "19") || (hh == "19" && mm == "20") ||
                (hh == "19" && mm == "21") || (hh == "19" && mm == "22") || (hh == "19" && mm == "23") || (hh == "19" && mm == "24") || (hh == "19" && mm == "25") || (hh == "19" && mm == "26") || (hh == "19" && mm == "27") ||
                (hh == "19" && mm == "28") || (hh == "19" && mm == "29") || (hh == "19" && mm == "30") || (hh == "19" && mm == "00"))
            {
                horaCorrecta = true;
            }
            else {
                horaCorrecta = false;
            }

            return horaCorrecta;

        }
    }
}