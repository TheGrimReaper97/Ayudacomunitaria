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

        private int idpersona;
         public int IdPersona
        {
            get{ return idpersona ; }
            set{ idpersona  = value;}
        }


         private decimal integrantes;
         public decimal Integrantes
         {
             get { return integrantes ; }
             set { integrantes = value; }
         }

        
    }
}
