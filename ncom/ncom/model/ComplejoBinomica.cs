using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoBinomica : NumeroComplejo
    {
        /*private double real;
        private double imaginaria;*/

        public double Real { get; set; }
        public double Imaginaria { get; set; }

        public ComplejoBinomica(double real, double imaginaria)
        {
            Real = real;
            Imaginaria = imaginaria;
        }

        public NumeroComplejo ToBinomica()
        {
            return this;
        }

        public NumeroComplejo ToPolar()
        {
            double modulo = this.CalcularModulo();
            double argumento = this.CalcularArgumento();
            return new ComplejoPolar(modulo, argumento);
        }

        public NumeroComplejo Sumar(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Restar(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Multiplicar(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Dividir(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Potencia(int potencia) { throw new NotImplementedException(); }

        public List<NumeroComplejo> Raiz(int indice) { throw new NotImplementedException(); }

        private double CalcularModulo()
        {
            return Math.Round(Math.Sqrt(Math.Pow(Real, 2) + Math.Pow(Imaginaria, 2)), 3);
        }

        private double CalcularArgumento()
        {
            double argumento = Math.Atan2(Imaginaria, Real);

            return Math.Round(argumento + CorregirArgumento(), 3);
        }

        private double CorregirArgumento()
        {
            if (TercerCuadrante() || CuartoCuadrante())
            {
                return Math.PI * 2;
            }
            else
            {
                return 0;
            }
        }

        private bool TercerCuadrante()
        {
            return Real < 0 && Imaginaria < 0;
        }

        private bool CuartoCuadrante()
        {
            return Real > 0 && Imaginaria < 0;
        }
    }
}
