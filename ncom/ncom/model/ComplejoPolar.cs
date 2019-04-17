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

        public ComplejoBinomica ToBinomica() {
            double real = Math.Round( modulo * Math.Cos(argumento), 3 );
            double imaginaria = Math.Round( modulo * Math.Sin(argumento), 3 );
            return new ComplejoBinomica( real, imaginaria );
        }

        public ComplejoPolar ToPolar() {
            return this;
        }

        public NumeroComplejo Sumar(NumeroComplejo complejo) {
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();

            NumeroComplejo sumaBinomica = binomico2.Sumar(binomico1);
            return sumaBinomica.ToPolar();
        }

        public NumeroComplejo Restar(NumeroComplejo complejo) {
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();

            NumeroComplejo restaBinomica = binomico2.Restar(binomico1);
            return restaBinomica.ToPolar();
        }

        public NumeroComplejo Multiplicar(NumeroComplejo complejo) {
            ComplejoPolar complejoPolar = complejo.ToPolar();
            return new ComplejoBinomica( complejoPolar.GetModulo() * this.modulo, complejoPolar.ToPolar().GetArgumento() + this.argumento );
        }

        public NumeroComplejo Dividir(NumeroComplejo complejo) {
            ComplejoPolar complejoPolar = complejo.ToPolar();
            return new ComplejoBinomica( complejoPolar.GetModulo() / this.modulo, complejoPolar.GetArgumento() - this.argumento );
        }

        public NumeroComplejo Potencia(int potencia) {
            double modulo = Math.Pow( this.modulo, potencia );
            double argumento = this.argumento * potencia;
            return new ComplejoPolar( modulo , this.corregirArgumento(argumento) );
        }

        public NumeroComplejo[] Raiz(int indice) {
            int k = 0;
            NumeroComplejo[] raicesComplejas = new NumeroComplejo[indice - 1];
            while (k < indice){
                double modulo = Math.Pow( this.modulo, 1 / indice );
                double argumento = (this.argumento + 2 * k * Math.PI) / indice;
                raicesComplejas[k] = new ComplejoPolar( modulo, argumento );
                k++;
            }

            return raicesComplejas;
        }

        private double corregirArgumento(double argumento)
        {
            // si a alguien se le ocurre un nombre mejor para arg .. Binevenido
            double arg = Math.Truncate(argumento / 2 * Math.PI);
            return argumento - arg * 2 * Math.PI;
        }

    }
}
