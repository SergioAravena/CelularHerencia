using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Biblioteca
{
    public class CelularCtaControlada : CelularConPlan
    {
        private const double VALOR_SMS = 100;

        public CelularCtaControlada(): base()
        {

        }

        public override void RecargarMinutos(int min)
        {
            base.RecargarMinutos(min);
            if (MinutosUtilizados>MinutosPlan)
            {
                EnServicio = false;

            }
        }


        public override double CalcularPagoMes()
        {
            return this.ValorPlan + (CantidadSMS * VALOR_SMS);
        }

        public override void ImprimirFactura()
        {

            Console.WriteLine("Numero Celular {0} ",Numero);
            Console.WriteLine("Tipo de Cuenta : Cuenta Controlada ");
            Console.WriteLine("Minutos Plan {0} " ,MinutosPlan);
            Console.WriteLine("Calcular pago mes "+CalcularPagoMes());


        }
    }
}
