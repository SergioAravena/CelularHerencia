using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
  public  abstract class CelularConPlan
    {

        private int numero;

        public int Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        private string titular;

        public string Titular
        {
            get { return titular; }
            set { titular = value; }
        }


    }
}
