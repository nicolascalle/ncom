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
            this.modulo = Math.Round(modulo, 3);
            this.argumento = Math.Round(argumento, 3);
        }

        //PASAJE A BINOMICA
        public ComplejoBinomica ToBinomica() {
            double real = CalcularNumeroReal(); 
            double imaginaria = CalcularNumeroImaginario(); 
            return new ComplejoBinomica( real, imaginaria );
        }

        private double CalcularNumeroReal() {
            return Math.Round(modulo * Math.Cos(argumento), 3);
        }

        private double CalcularNumeroImaginario() {
            return Math.Round(modulo * Math.Sin(argumento), 3);
        }

        //PASAJE A POLAR (devuelvo este objeto)
        public ComplejoPolar ToPolar() {
            return this;
        }

        override
        public string ToString() {
            return "[ " + modulo + ", " + argumento + " ]";
        }

        //SUMA
        public NumeroComplejo Sumar(NumeroComplejo complejo) {
            //Convierto ambos numero a forma binomica
            ComplejoBinomica binomico1 = complejo.ToBinomica(); 
            ComplejoBinomica binomico2 = this.ToBinomica();            
            NumeroComplejo sumaBinomica = binomico2.Sumar(binomico1);//Sumo en forma binomica  
            return sumaBinomica.ToPolar();//Devulevo la suma convertida a polar
        }


        //RESTA
        public NumeroComplejo Restar(NumeroComplejo complejo) {
            //Convierto ambos numeros a forma binomica
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();
            NumeroComplejo restaBinomica = binomico2.Restar(binomico1);   //Resto en forma binomica
            return restaBinomica.ToPolar();   //Devulevo la suma convertida a polar
        }

        
        //MULTIPLICACION
        public NumeroComplejo Multiplicar(NumeroComplejo complejo) {
            ComplejoPolar complejoPolar = complejo.ToPolar();
            double modulo = this.modulo * complejoPolar.GetModulo();
            double argumento = this.argumento + complejoPolar.GetArgumento();
            return new ComplejoPolar( modulo, argumento);
        }

 
        //DIVISION
        public NumeroComplejo Dividir(NumeroComplejo complejo){
            ComplejoPolar complejoPolar = complejo.ToPolar();
            double modulo = this.modulo / complejoPolar.GetModulo();
            double argumento = this.argumento - complejoPolar.GetArgumento();
            return new ComplejoPolar( modulo, argumento );
        }


        //POTENCIA
        public NumeroComplejo Potencia(int potencia) {
            double modulo = Math.Pow( this.modulo, potencia );
            double argumento = this.argumento * potencia;
            return new ComplejoPolar( modulo , this.CorregirArgumento(argumento) );
        }

        private double CorregirArgumento(double argumento) {
            double arg = Math.Truncate(argumento / 2 * Math.PI);
            return argumento - arg * 2 * Math.PI;
        }


        //RAICES N-ESIMAS
        public NumeroComplejo[] Raices_n_esimas(int indice) {
            int k = 0;
            NumeroComplejo[] raicesComplejas = new NumeroComplejo[indice];
            
            while (k < indice){  //Calculo cada raiz y las agrego al array.
                double modulo = Math.Pow( this.modulo, Math.Pow(indice,-1));
                double argumento = (this.argumento + 2 * k * Math.PI) / indice;
                raicesComplejas[k] = new ComplejoPolar( modulo, argumento );
                k++;
            }

            return raicesComplejas;
        }


        //RAICES PRIMITIVAS
        public NumeroComplejo[] RaicesPrimitivas(int indice){
            
            NumeroComplejo[] raicesPrimitivas = new NumeroComplejo[indice];

            if (indice == 1) {
                raicesPrimitivas[0] = new ComplejoPolar(1, 0);
                return raicesPrimitivas;
            }

            NumeroComplejo[] raicesNesimas = this.Raices_n_esimas(indice);//Obtengo las raices n-esimas

            //La raiz sub0 no es primitiva, no la agrego 

            raicesPrimitivas[0] = raicesNesimas[1]; //La raiz sub 1 siempre es primitiva, la agrego
            int k = 2, i = 1;
            while ( k < indice ){    //Recorro las raices n-esimas y me quedo con las primitivas segun MCD
                if (MCD(k, indice) == 1){
                    raicesPrimitivas[i] = raicesNesimas[k];
                    i++;
                }
                k++;
            }
            return raicesPrimitivas;
        }

        //Calculo MCD
        private int MCD(int k, int n){ 
            int resultado;
            do{
                resultado = k;
                k = n % k;
                n = resultado;
            } while (k != 0);

            return resultado;
        }
    }
}
