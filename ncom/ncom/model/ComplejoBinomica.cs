﻿using System;
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
        public ComplejoBinomica ToBinomica(){
            return this;
        }


        //PASAJE A POLAR
        public ComplejoPolar ToPolar(){
            double modulo = this.CalcularModulo();
            double argumento = this.CalcularArgumento();
            return new ComplejoPolar(modulo, argumento);
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
        public NumeroComplejo Sumar(NumeroComplejo complejo){
            ComplejoBinomica complejoBinomica = complejo.ToBinomica();
            double modulo = complejoBinomica.GetReal() + this.real;
            double argumento = complejoBinomica.GetImaginaria() + this.imaginaria;
            return new ComplejoBinomica(modulo, argumento);
        }


        //RESTA
        public NumeroComplejo Restar(NumeroComplejo complejo){
            ComplejoBinomica complejoBinomica = complejo.ToBinomica();
            double modulo = complejoBinomica.GetReal() - this.real;
            double argumento = complejoBinomica.GetImaginaria() - this.imaginaria;
            return new ComplejoBinomica(modulo, argumento);
        }


        //MULTIPLICACION
        public NumeroComplejo Multiplicar(NumeroComplejo complejo){
            //Convierto ambos numeros a polar
            ComplejoPolar polar1 = complejo.ToPolar();
            ComplejoPolar polar2 = this.ToPolar();
            NumeroComplejo productoPolar = polar2.Multiplicar(polar1);//Envio calculo a forma polar
            return productoPolar.ToBinomica();//Retorno en forma binomica
        }


        //DIVISION
        public NumeroComplejo Dividir(NumeroComplejo complejo){
            //Convierto ambos numeros a polar
            ComplejoPolar polar1 = complejo.ToPolar();
            ComplejoPolar polar2 = this.ToPolar();
            NumeroComplejo cocientePolar = polar2.Dividir(polar1); //Envio calculo a forma polar
            return cocientePolar.ToBinomica(); //Retorno en forma binomica
        }

        public NumeroComplejo Potencia(int potencia) { throw new NotImplementedException(); }

        public List<NumeroComplejo> Raiz(int indice) { throw new NotImplementedException(); }

    }
}
