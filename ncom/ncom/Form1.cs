using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncom
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent();
        }

        private void binomicaAPolar_Click(object sender, EventArgs e)
        {
            formaBinomica numeroBinomico = new formaBinomica();
            numeroBinomico.parteReal = Convert.ToDouble(parteReal.Text.ToString());
            numeroBinomico.parteImaginaria = Convert.ToDouble(parteImaginaria.Text.ToString());

            formaPolar numeroPolar = new formaPolar();

            EDT objeto = new EDT();

            numeroPolar = objeto.binomicaAPolar(numeroBinomico);
            string resultado = "[ " + numeroPolar.modulo.ToString() + " ; " + numeroPolar.argumento.ToString() + " ]";

            MessageBox.Show(resultado);
        }

        private void polarABinomica_Click(object sender, EventArgs e)
        {
            formaPolar numeroPolar = new formaPolar();
            numeroPolar.modulo = Convert.ToDouble(modulo.Text.ToString());
            numeroPolar.argumento = Convert.ToDouble(argumento.Text.ToString());

            formaBinomica numeroBinomico = new formaBinomica();

            EDT objeto = new EDT();

            numeroBinomico = objeto.polarABinomica(numeroPolar);
            string resultado = "( " + numeroBinomico.parteReal.ToString() + " , " + numeroBinomico.parteImaginaria.ToString() + " )";

            MessageBox.Show(resultado);

        }

    }
}
