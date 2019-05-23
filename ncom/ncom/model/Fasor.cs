using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ncom.model {

    enum Funcion { COS, SEN }

    class Fasor {
        private double amplitud;
        private Funcion funcion;
        private double frecuencia;
        private double fase;
        
        public double GetAmplitud() { return amplitud; }
        public Funcion GetFuncion() { return funcion; }
        public double GetFase() { return fase; }

        public void SetAmplitud(double amplitud) { this.amplitud = amplitud; }
        public void SetFuncion(Funcion funcion) { this.funcion = funcion; }
        public void SetFase(double fase) { this.fase = fase; }

        public Fasor(double amplitud, Funcion funcion, double frecuencia, double fase) {
            this.amplitud = amplitud;
            this.frecuencia = frecuencia;
            this.funcion = funcion;
            this.fase = fase;
        }

        override
        public String ToString() {
            return amplitud + " . " + funcion.ToString().ToLower() + " ( " + frecuencia + ".t" + " + " + fase + " )";
        }

        public Fasor SumarFasor(Fasor fasor){
            if(this.funcion == Funcion.SEN){
                this.fase = this.fase - Math.PI / 2;
            }
            if (fasor.funcion == Funcion.SEN){
                fasor.fase = fasor.fase - Math.PI / 2;
            }

            double parteReal = this.amplitud * Math.Cos(this.fase) + fasor.amplitud * Math.Cos(fasor.fase);
            double parteImaginaria = this.amplitud * Math.Sin(this.fase) + fasor.amplitud * Math.Sin(fasor.fase);
            ComplejoBinomica binomica = new ComplejoBinomica(parteReal, parteImaginaria);
            double amplitud = binomica.ToPolar().GetModulo();
            double fase = binomica.ToPolar().GetArgumento();

            return new Fasor(amplitud, Funcion.COS, frecuencia, fase);
        }       
    }
}
