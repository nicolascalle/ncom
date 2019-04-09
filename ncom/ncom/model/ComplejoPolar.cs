using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoPolar : NumeroComplejo {
        private double modulo;
        private double argumento;

        public double GetModulo() { return modulo; }
        public double GetArgumento() { return argumento; }
        public void SetModulo(double modulo) { this.modulo = modulo; }
        public void SetArgumento(double argumento) { this.argumento = argumento; }

        public ComplejoPolar(double modulo, double argumento) {
            this.modulo = modulo;
            this.argumento = argumento;
        }

        public NumeroComplejo ToBinomica() {
            double real = modulo * Math.Cos(argumento);
            double imaginaria = modulo * Math.Sin(argumento);
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
