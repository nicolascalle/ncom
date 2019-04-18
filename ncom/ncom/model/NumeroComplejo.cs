using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ncom.model;

namespace ncom {
    interface NumeroComplejo {
        ComplejoBinomica ToBinomica();
        ComplejoPolar ToPolar();
        NumeroComplejo Sumar(NumeroComplejo otroComplejo);
        NumeroComplejo Restar(NumeroComplejo otroComplejo);
        NumeroComplejo Multiplicar(NumeroComplejo otroComplejo);
        NumeroComplejo Dividir(NumeroComplejo otroComplejo);
        NumeroComplejo Potencia(int potencia);
        NumeroComplejo[] Raices_n_esimas(int indice);
        NumeroComplejo[] RaicesPrimitivas(int indice);
    }
}
