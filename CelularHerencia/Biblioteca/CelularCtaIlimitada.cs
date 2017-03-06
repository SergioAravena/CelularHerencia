using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class CelularCtaIlimitada : CelularConPlan
    {
        private const double VALOR_SMS = 100;

        private const int VALOR_ADICIONAL = 120;



        public override double CalcularPagoMes()
        {
            double monto = ValorPlan + (CantidadSMS + VALOR_SMS);

            int minAdicional = MinutosUtilizados - MinutosPlan;

            if (minAdicional>0)
            {
                return monto + minAdicional + VALOR_ADICIONAL;
            }
            else
            {
                return monto;
            }

        }

        public override void ImprimirFactura()
        {
            Console.WriteLine("Numero Celular "+Numero);
            Console.WriteLine("Tipo Cuenta : Ilimitada ");
            Console.WriteLine("Minutos plan "+MinutosPlan);
            Console.WriteLine("Monto a pagar "+CalcularPagoMes());

        }
    }
}
