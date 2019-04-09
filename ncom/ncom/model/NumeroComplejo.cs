﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom {
    interface NumeroComplejo {
        NumeroComplejo ToBinomica();
        NumeroComplejo ToPolar();
        NumeroComplejo Sumar(NumeroComplejo otroComplejo);
        NumeroComplejo Restar(NumeroComplejo otroComplejo);
        NumeroComplejo Multiplicar(NumeroComplejo otroComplejo);
        NumeroComplejo Dividir(NumeroComplejo otroComplejo);
        NumeroComplejo Potencia(int potencia);
        List<NumeroComplejo> Raiz(int indice);
    }
}