using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ncom.model;

namespace ncom {
    public partial class Conversor : Form {

        public Conversor() { InitializeComponent(); }

        private void binomicaAPolar_Click(object sender, EventArgs e) {
            double realIngresado = Convert.ToDouble(parteReal.Text.ToString());
            double imaginarioIngresado = Convert.ToDouble(parteImaginaria.Text.ToString());

            ComplejoPolar numeroPolar = (ComplejoPolar)new ComplejoBinomica(realIngresado, imaginarioIngresado).ToPolar();

            string resultado = "[ " + numeroPolar.Modulo + " ; " + numeroPolar.Argumento + " ]";
            MessageBox.Show(resultado);
        }

        private void polarABinomica_Click(object sender, EventArgs e) {
            double moduloIngresado = Convert.ToDouble(modulo.Text.ToString());
            double argumentoIngresado = Convert.ToDouble(argumento.Text.ToString());

            ComplejoBinomica numeroBinomico = (ComplejoBinomica)new ComplejoPolar(moduloIngresado, argumentoIngresado).ToBinomica();

            string resultado = "( " + numeroBinomico.Real + " , " + numeroBinomico.Imaginaria + " )";
            MessageBox.Show(resultado);
        }

    }
}
