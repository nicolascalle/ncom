using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model
{
    class Fasor{
        private double amplitud;
        private Funcion funcion;
        private double fase;

        enum Funcion{
            COSENO,
            SENO
        }
        
        private Funcion COSENO { get; set; }
        private Funcion SENO { get; set; }
        public double GetAmplitud() { return amplitud; }
        public Funcion GetFuncion() { return funcion; }
        public double GetFase() { return fase; }

        public void SetAmplitud(double amplitud) { this.amplitud = amplitud; }
        public void SetFuncion(Funcion funcion) { this.funcion = funcion; }
        public void SetFase(double fase) { this.fase = fase; }

        public Fasor(double amplitud, Funcion funcion, double fase){
            this.amplitud = amplitud;
            this.funcion = funcion;
            this.fase = fase;
        }

        private Fasor sumarFasores(Fasor fasor){
            if(this.funcion == SENO){
                this.fase = this.fase - Math.PI / 2;
            }
            if (fasor.funcion == SENO){
                fasor.fase = fasor.fase - Math.PI / 2;
            }

            double parteReal = this.amplitud * Math.Cos(this.fase) + fasor.amplitud * Math.Cos(fasor.fase);
            double parteImaginaria = this.amplitud * Math.Sin(this.fase) + fasor.amplitud * Math.Sin(fasor.fase);
            ComplejoBinomica binomica = new ComplejoBinomica(parteReal, parteImaginaria);
            double amplitud = binomica.CalcularModulo();
            double fase = binomica.CalcularArgumento();

            return new Fasor(amplitud, COSENO , fase);
        }       
    }
}
