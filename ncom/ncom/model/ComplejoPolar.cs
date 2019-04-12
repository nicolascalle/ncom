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

        public ComplejoPolar(double modulo, double argumento)
        {
            this.modulo = modulo;
            this.argumento = argumento;
        }


        public ComplejoBinomica ToBinomica() {
            double real = Math.Round(modulo * Math.Cos(argumento),3);
            double imaginaria = Math.Round(modulo * Math.Sin(argumento),3);
            return new ComplejoBinomica(real, imaginaria);
        }

        public ComplejoPolar ToPolar() {
            return this;
        }

        public NumeroComplejo Sumar(ComplejoPolar complejo) {
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();

            NumeroComplejo sumaBinomica = binomico2.Sumar(binomico1);
            return sumaBinomica.ToPolar();
        }

        public NumeroComplejo Restar(ComplejoPolar complejo) {
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();

            NumeroComplejo restaBinomica = binomico2.Restar(binomico1);
            return restaBinomica.ToPolar();
        }

        public NumeroComplejo Multiplicar(ComplejoPolar complejo) {
            return new ComplejoBinomica(complejo.GetModulo() * this.modulo, complejo.GetArgumento() + this.argumento);
        }

        public NumeroComplejo Dividir(ComplejoPolar complejo) {
            return new ComplejoBinomica(complejo.GetModulo() / this.modulo, complejo.GetArgumento() - this.argumento);
        }

        public NumeroComplejo Potencia(int potencia) { throw new NotImplementedException(); }

        public List<NumeroComplejo> Raiz(int indice) { throw new NotImplementedException(); }

    }
}
