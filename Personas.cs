using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Ayuda_Comunitaria
{
    class Personas
    {
        private string nombres;
        public string Nombres
        {
            get{ return nombres; }
            set{ nombres = value; }
        }

        private string apellidos;
        public string Apellidos
        {
            get{ return apellidos; }
            set{ apellidos = value; }
        }

        private decimal casa;
        public decimal Casa
        {
            get{ return casa; }
            set{ casa = value;}
        }

        private Int32 idpersona;
         public Int32 IdPersona
        {
            get{ return idpersona ; }
            set{ idpersona  = value;}
        }


         private int  integrantes;
         public Int32 Integrantes
         {
             get { return integrantes ; }
             set { integrantes = value; }
         }

         private DateTime fecha;
        public DateTime Fecha
         {
             get { return fecha; }
             set { fecha = value; }
         }
       
        
    }
}
