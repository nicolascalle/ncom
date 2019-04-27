using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model{
    class ComplejoPolar : NumeroComplejo{
        private double modulo;
        private double argumento;

        public double GetModulo() { return modulo; }
        public double GetArgumento() { return argumento; }
        public void SetModulo(double modulo) { this.modulo = modulo; }
        public void SetArgumento(double argumento) { this.argumento = argumento; }

        public ComplejoPolar(double modulo, double argumento){
            this.modulo = modulo;
            this.argumento = argumento;
        }

        //PASAJE A BINOMICA
        public ComplejoBinomica ToBinomica(){
            double real = CalcularNumeroReal();
            double imaginaria = CalcularNumeroImaginario();
            return new ComplejoBinomica(real, imaginaria);
        }

        private double CalcularNumeroReal(){
            return Math.Round(modulo * Math.Cos(argumento), 3); ;
        }

        private double CalcularNumeroImaginario(){
            return Math.Round(modulo * Math.Sin(argumento), 3);
        }

        //PASAJE A POLAR (devuelvo este objeto)
        public ComplejoPolar ToPolar(){
            return this;
        }


        //SUMA
        public NumeroComplejo Sumar(NumeroComplejo complejo){
            //Convierto ambos numero a forma binomica
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();
            NumeroComplejo sumaBinomica = binomico2.Sumar(binomico1);//Sumo en forma binomica  
            return sumaBinomica.ToPolar();//Devulevo la suma convertida a polar
        }


        //RESTA
        public NumeroComplejo Restar(NumeroComplejo complejo){
            //Convierto ambos numeros a forma binomica
            ComplejoBinomica binomico1 = complejo.ToBinomica();
            ComplejoBinomica binomico2 = this.ToBinomica();
            NumeroComplejo restaBinomica = binomico2.Restar(binomico1);   //Resto en forma binomica
            return restaBinomica.ToPolar();   //Devulevo la suma convertida a polar
        }


        //MULTIPLICACION
        public NumeroComplejo Multiplicar(ComplejoPolar complejo){
            double modulo = this.modulo * complejo.GetModulo();
            double argumento = this.argumento + complejo.GetArgumento();
            return new ComplejoPolar(modulo, argumento);
        }


        //DIVISION
        public NumeroComplejo Dividir(ComplejoPolar complejo){
            double modulo = this.modulo / complejo.GetModulo();
            double argumento = this.argumento - complejo.GetArgumento();
            return new ComplejoPolar(modulo, argumento);
        }

        public NumeroComplejo Potencia(int potencia) { throw new NotImplementedException(); }

        public List<NumeroComplejo> Raiz(int indice) { throw new NotImplementedException(); }

    }
}
