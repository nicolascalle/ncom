using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoBinomica : NumeroComplejo {
        private double real { get; set; }
        private double imaginaria { get; set; }

        public double Real { get { return real; } set { real = value; } }
        public double Imaginaria { get { return imaginaria; } set { imaginaria = value; } }

        public ComplejoBinomica(double real, double imaginaria) {
            Real = real;
            Imaginaria = imaginaria;
        }

        public NumeroComplejo ToBinomica() {
            return this;
        }

        public NumeroComplejo ToPolar() {
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

        private double CalcularModulo() {
            return Math.Sqrt( Math.Pow(real, 2) + Math.Pow(imaginaria, 2) );
        }

        private double CalcularArgumento() {
            return Math.Atan2(imaginaria,real);       
        }
    }
}
