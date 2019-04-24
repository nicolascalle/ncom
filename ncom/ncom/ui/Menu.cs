using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncom.ui {
    public partial class Menu : Form {
        public Menu() { InitializeComponent(); }

        private void buttonSuma_Click(object sender, EventArgs e) { new Suma().Show(); }
        private void buttonResta_Click(object sender, EventArgs e) { new Resta().Show(); }
        private void buttonMultiplicacion_Click(object sender, EventArgs e) { new Multiplicacion().Show(); }
        private void buttonDivision_Click(object sender, EventArgs e) { new Division().Show(); }

        private void buttonPotencia_Click(object sender, EventArgs e) {

        }

        private void buttonRadicacionNatural_Click(object sender, EventArgs e) {

        }

        private void buttonSumaDeFasores_Click(object sender, EventArgs e) {

        }

        private void buttonRestaDeFasores_Click(object sender, EventArgs e) {

        }
    }
}
