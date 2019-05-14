using ncom.model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ncom.ui.oa {
    public partial class Potencia : Form {
        public Potencia() {
            InitializeComponent();
            InitializeComboBoxItems();
        }

        private void buttonCalcular_Click(object sender, EventArgs e) {
            NumeroComplejo complejoCalculado = ObtenerPrimerComplejo().Potencia( ObtenerIndice() ).ToBinomica();
            if (comboBoxFormaResultado.SelectedIndex == 1)
                complejoCalculado = complejoCalculado.ToPolar();
            labelResultadoCalculado.Text = complejoCalculado.ToString();
        }

        private NumeroComplejo ObtenerPrimerComplejo() {
            return ObtenerComplejoEnFormaSeleccionada(comboBoxForma1, (double)numericInput11.Value, (double)numericInput12.Value);
        }

        private int ObtenerIndice() {
            return (int)numericUpDownIndice.Value;
        }

        private NumeroComplejo ObtenerComplejoEnFormaSeleccionada(ComboBox comboBox, double input1, double input2) {
            if (comboBox.SelectedIndex == 0)
                return new ComplejoBinomica(input1, input2);
            else
                return new ComplejoPolar(input1, input2);
        }

        private void numericInput11_ValueChanged(object sender, EventArgs e) {
            if (comboBoxForma1.SelectedIndex == 1 && numericInput11.Value < 0)
                numericInput11.Value = 0;
        }

        private void comboBoxForma1_SelectedIndexChanged(object sender, EventArgs e) {
            if (comboBoxForma1.SelectedIndex == 1 && numericInput11.Value < 0)
                numericInput11.Value = 0;
        }

        private void InitializeComboBoxItems() {
            comboBoxForma1.SelectedIndex = 0;
            comboBoxFormaResultado.SelectedIndex = 0;
        }
    }
}
