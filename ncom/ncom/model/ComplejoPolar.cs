using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoPolar : NumeroComplejo {
        private double modulo;
        private double argumento;

        public double Modulo { get => modulo; set => modulo = value; }
        public double Argumento { get => argumento; set => argumento = value; }

        public ComplejoPolar(double modulo, double argumento) {
            Modulo = modulo;
            Argumento = argumento;
        }

        public NumeroComplejo ToBinomica() {
            double real = modulo * Math.Cos(argumento);
            double imaginaria = modulo * Math.Sin(argumento);
            return new ComplejoBinomica(real, imaginaria);
        }

        public NumeroComplejo ToPolar() {
            return this;
        }
    }
}
