using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoPolar : NumeroComplejo {
        private double modulo;
        private double argumento;

        public double Modulo { get { return modulo; } set { modulo = value; } }
        public double Argumento { get { return argumento; } set { argumento = value; } }

        public ComplejoPolar(double modulo, double argumento) {
            Modulo = modulo;
            Argumento = argumento;
        }

        public NumeroComplejo ToBinomica() {
            double real = Math.Round(modulo * Math.Cos(argumento),3);
            double imaginaria = Math.Round(modulo * Math.Sin(argumento),3);
            return new ComplejoBinomica(real, imaginaria);
        }

        public NumeroComplejo ToPolar() {
            return this;
        }

        public NumeroComplejo Sumar(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Restar(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Multiplicar(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Dividir(NumeroComplejo otroComplejo) { throw new NotImplementedException(); }

        public NumeroComplejo Potencia(int potencia) { throw new NotImplementedException(); }

        public List<NumeroComplejo> Raiz(int indice) { throw new NotImplementedException(); }

    }
}
