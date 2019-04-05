using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom
{

    public struct formaBinomica{
            public double parteReal;
            public double parteImaginaria;
        };

    public struct formaPolar{
            public double modulo;
            public double argumento;
        };


    public class EDT{

        public formaPolar binomicaAPolar(formaBinomica numeroBinomico){

            formaPolar numeroPolar = new formaPolar();
            numeroPolar.modulo = calcularModulo(numeroBinomico);
            numeroPolar.argumento = calcularArgumento(numeroBinomico);
            return numeroPolar;
                
            }


        private double calcularModulo(formaBinomica numeroBinomico){

            return Math.Sqrt(Math.Pow(numeroBinomico.parteReal, 2) + Math.Pow(numeroBinomico.parteImaginaria, 2));

        }

        private double calcularArgumento(formaBinomica numeroBinomico){

            double argumento;

            if (numeroBinomico.parteReal == 0)
            {
                if (numeroBinomico.parteImaginaria > 0)
                {
                    return 0;
                }
                return Math.PI;
            }

            argumento = Math.Atan2(numeroBinomico.parteImaginaria, numeroBinomico.parteReal);
            
            return argumento + correccionAngulo(numeroBinomico);

        }

        private double correccionAngulo(formaBinomica numeroBinomico)
        {
            if (tercerCuadrante(numeroBinomico) || segundoCuadrante(numeroBinomico))
            {
                return  Math.PI;
            } 
            if(cuartoCuadrante(numeroBinomico)){
                return 2*Math.PI;
            }else{
                return 0;
            }
        }

        private bool segundoCuadrante(formaBinomica numeroBinomico)
        {
            return numeroBinomico.parteReal < 0 && numeroBinomico.parteImaginaria > 0;
        }

        private bool tercerCuadrante(formaBinomica numeroBinomico)
        {
            return numeroBinomico.parteReal < 0 && numeroBinomico.parteImaginaria < 0;
        }

        private bool cuartoCuadrante(formaBinomica numeroBinomico)
        {
            return numeroBinomico.parteReal > 0 && numeroBinomico.parteImaginaria < 0;
        }


        public formaBinomica polarABinomica(formaPolar numeroPolar){

            formaBinomica numeroBinomico = new formaBinomica();
            numeroBinomico.parteReal = numeroPolar.modulo * Math.Cos(numeroPolar.argumento);
            numeroBinomico.parteImaginaria = numeroPolar.modulo * Math.Sin(numeroPolar.argumento);
            return numeroBinomico;

        }
   }
        
}
