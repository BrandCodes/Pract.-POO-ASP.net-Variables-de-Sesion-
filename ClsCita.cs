using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practica08_ControlesB.AppCode
{
    public class ClsCitaBLF
    {
        #region atributos
        private string _nombreEst;
        private string _profesor;
        private string _dia;
        private string _hr;
        private string _asunto;
        #endregion 

        #region propiedades
            public string nombreEst        {
                set {   _nombreEst = value; }
                get {   return _nombreEst;  }
            }

            public string profesor            {
                set {   _profesor = value;  }
                get {   return _profesor;   }
            }

            public string dia            {
                set {   _dia = value;   }
                get {   return _dia;    }
            }

            public string hora            {
                set {   _hr = value;    }
                get {   return _hr; }
            }

            public string asunto            {
                set {   _asunto = value;    }
                get {   return _asunto; }
            }            
        #endregion

        #region metodos
            //Constructor
            public ClsCitaBLF()        {

            }

            //funciones
            public string agregarDatos(string nom, string prof, string day, string hra, string asnt)            {                
                nombreEst = nom;
                profesor = prof;
                dia = day;
                hora = hra;
                asunto = asnt;
                return "Agregados Correctamente";
            }

            public string mostrarDatos()            {
                string cadena = "Datos generados por: " + nombreEst;
                return cadena += "<br/> Profesor: " + profesor + "<br/> Dia: " + dia + "<br/> Hora: " + hora + "<br/> Asunto: " + asunto;
            }
        #endregion

    }//FIN CLASS
}//FIN NAME