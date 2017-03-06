using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
  public  abstract class CelularConPlan : IServicio
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

        private int minutosPlan;

        public int MinutosPlan
        {
            get { return minutosPlan; }
            set { minutosPlan = value; }
        }

        private int minutosUtilizados;

        public int MinutosUtilizados
        {
            get { return minutosUtilizados; }
            set { minutosUtilizados = value; }
        }

        private Boolean enServicio;

        public Boolean EnServicio
        {
            get { return enServicio; }
            set { enServicio = value; }
        }


        private int valorPlan;

        public int ValorPlan
        {
            get { return valorPlan; }
            set { valorPlan = value; }
        }

        private int cantidadSMS;

        public int CantidadSMS
        {
            get { return cantidadSMS; }
            set { cantidadSMS = value; }
        }

        private  void Init()
        {
            numero = 0;
            titular = string.Empty;
            minutosPlan = 0;
            minutosUtilizados = 0;
            enServicio = false;
            valorPlan = 0;
            cantidadSMS = 0;

        }

        public virtual void ReiniciarMinutosPlan()
        {
            minutosUtilizados = 0;
        }

        public virtual void RecargarMinutos(int min)
        {
            if (min>0)
            {
                this.minutosUtilizados+=  min;

            }


        }

        public CelularConPlan()
        {
            Init();
        }

        public abstract double CalcularPagoMes();

        public abstract void ImprimirFactura();

    }
}
