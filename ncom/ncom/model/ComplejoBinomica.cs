using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {
    class ComplejoBinomica : NumeroComplejo {
        private double real;
        private double imaginaria;

        public double GetReal() { return real; }
        public double GetImaginaria() { return imaginaria; }
        public void SetReal(double real) { this.real = real; }
        public void SetImaginaria(double imaginaria) { this.imaginaria = imaginaria; }

        public ComplejoBinomica(double real, double imaginaria) {
            this.real = real;
            this.imaginaria = imaginaria;
        }

        //PASAJE A BINOMICA (devuelvo este objeto)
        public ComplejoBinomica ToBinomica() {
            return this;
        }

        //PASAJE A POLAR
        public ComplejoPolar ToPolar() {
            double modulo = this.CalcularModulo();
            double argumento = this.CalcularArgumento();
            return new ComplejoPolar(modulo, argumento);
        }

        override
        public string ToString() {
            return "( " + real + ", " + imaginaria + " )";
            //return imaginaria >= 0 ? real + " + " + imaginaria + " j" : real + " " + imaginaria + " j";
        }

        private double CalcularModulo(){
            return Math.Round(Math.Sqrt(Math.Pow(real, 2) + Math.Pow(imaginaria, 2)), 3);
        }

        private double CalcularArgumento(){
            double argumento = Math.Atan2(imaginaria, real);
            return Math.Round(argumento + CorregirArgumento(), 3);
        }

        private double CorregirArgumento(){
            if (TercerCuadrante() || CuartoCuadrante()){
                return Math.PI * 2;
            }else{
                return 0;
            }
        }

        private bool TercerCuadrante(){
            return real < 0 && imaginaria < 0;
        }

        private bool CuartoCuadrante(){
            return real > 0 && imaginaria < 0;
        }


        //SUMA
        public NumeroComplejo Sumar(NumeroComplejo complejo) {
            ComplejoBinomica complejoBinomica = complejo.ToBinomica();
            double modulo = complejoBinomica.GetReal() + this.real;
            double argumento = complejoBinomica.GetImaginaria() + this.imaginaria;
            return new ComplejoBinomica( modulo, argumento );
        }


        //RESTA
        public NumeroComplejo Restar(NumeroComplejo complejo) {
            ComplejoBinomica complejoBinomica = complejo.ToBinomica();
            double modulo = this.real - complejoBinomica.GetReal();
            double argumento = this.imaginaria - complejoBinomica.GetImaginaria();
            return new ComplejoBinomica(modulo, argumento);  
        }


        //MULTIPLICACION
        public NumeroComplejo Multiplicar(NumeroComplejo complejo) {
            //Convierto ambos numeros a polar
            ComplejoPolar polar1 = complejo.ToPolar();
            ComplejoPolar polar2 = this.ToPolar();
            NumeroComplejo productoPolar = polar2.Multiplicar(polar1);//Envio calculo a forma polar
            return productoPolar.ToBinomica();//Retorno en forma binomica
        }


        //DIVISION
        public NumeroComplejo Dividir(NumeroComplejo complejo) {
            //Convierto ambos numeros a polar
            ComplejoPolar polar1 = complejo.ToPolar();
            ComplejoPolar polar2 = this.ToPolar();
            NumeroComplejo cocientePolar = polar2.Dividir(polar1); //Envio calculo a forma polar
            return cocientePolar.ToBinomica(); //Retorno en forma binomica
        }


        //POTENCIA
        public NumeroComplejo Potencia(int potencia) {
            ComplejoPolar numeroPolar = this.ToPolar(); //Convierto numero a polar
            NumeroComplejo potenciaPolar = numeroPolar.Potencia(potencia); //Envio calculo a forma polar
            return potenciaPolar.ToBinomica(); //Retorno en forma binomica
        }


        //RAICES N-ESIMAS
        public NumeroComplejo[] Raices_n_esimas(int indice) {
            ComplejoPolar numeroPolar = this.ToPolar(); //Convierto numero a polar
            NumeroComplejo[] raicesPolares = numeroPolar.Raices_n_esimas(indice); //Envio calculo a forma polar
            return raicesPolares;
        }


        //RAICES PRIMITIVAS
        public NumeroComplejo[] RaicesPrimitivas(int indice){
            ComplejoPolar numeroPolar = this.ToPolar(); //Convierto numero a polar
            NumeroComplejo[] raicesPolares = numeroPolar.RaicesPrimitivas(indice); //Envio calculo a forma polar
            return raicesPolares;
        }
    }
}
