﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoBinomica : NumeroComplejo {
        private double real { get; set; }
        private double imaginaria { get; set; }

        public double Real { get => real; set => real = value; }
        public double Imaginaria { get => imaginaria; set => imaginaria = value; }

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

        private double CalcularModulo() {
            return Math.Sqrt( Math.Pow(real, 2) + Math.Pow(imaginaria, 2) );
        }

        private double CalcularArgumento() {
            double argumento;
            if (real == 0) {
                if (imaginaria > 0) {
                    return 0;
                }
                return Math.PI;
            }
            argumento = Math.Atan2(imaginaria, real);
            return argumento + CorreccionAngulo();
        }

        private double CorreccionAngulo() {
            if (tercerCuadrante() || segundoCuadrante()) {
                return Math.PI;
            }
            if (cuartoCuadrante()) {
                return 2 * Math.PI;
            }
            else {
                return 0;
            }
        }

        private bool segundoCuadrante() {
            return real < 0 && imaginaria > 0;
        }

        private bool tercerCuadrante() {
            return real < 0 && imaginaria < 0;
        }

        private bool cuartoCuadrante() {
            return real > 0 && imaginaria < 0;
        }

    }
}
