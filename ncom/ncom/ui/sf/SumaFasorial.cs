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

namespace ncom.ui.sf {
    public partial class SumaFasorial : Form {
        public SumaFasorial() {
            InitializeComponent();
            InitializeComboBoxItems();
        }

        private void buttonCalcular_Click(object sender, EventArgs e) {
            Fasor fasor = ObtenerPrimerFasor().SumarFasor(ObtenerSegundoFasor());
            labelResultadoCalculado.Text = fasor.ToString();
        }

        private Fasor ObtenerPrimerFasor() {
            Funcion funcion = Funcion.SEN;
            if (comboBoxFuncion1.SelectedIndex == 1)
                funcion = Funcion.COS;
            return new Fasor((double)numericInputAmplitud1.Value, funcion, (double)numericInputFrecuencia1.Value, (double)numericInputFase1.Value);
        }

        private Fasor ObtenerSegundoFasor() {
            Funcion funcion = Funcion.SEN;
            if (comboBoxFuncion2.SelectedIndex == 1)
                funcion = Funcion.COS;
            return new Fasor((double)numericInputAmplitud2.Value, funcion, (double)numericInputFrecuencia2.Value, (double)numericInputFase2.Value);
        }

        private void InitializeComboBoxItems() {
            comboBoxFuncion1.SelectedIndex = 0;
            comboBoxFuncion2.SelectedIndex = 0;
        }

    }
}
