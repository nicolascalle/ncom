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

namespace ncom.ui.oa {
    public partial class RaicesNaturales : Form {
        public RaicesNaturales() {
            InitializeComponent();
            InitializeComboBoxItems();
            InitializeListView();
        }

        private void buttonCalcular_Click(object sender, EventArgs e) {
            listViewResultado.Items.Clear();
            NumeroComplejo[] raicesComplejas = ObtenerPrimerComplejo().Raices_n_esimas(ObtenerIndice());

            Array.ForEach(raicesComplejas, raiz => {
                    if (raiz != null)
                        listViewResultado.Items.Add(new ListViewItem(raiz.ToString()));
                });
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
        }

        private void InitializeListView() {
            this.listViewResultado.Columns.Add("Raices");
            this.listViewResultado.View = View.Details;
            this.listViewResultado.MultiSelect = false;
            this.listViewResultado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            this.listViewResultado.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void numericUpDownIndice_ValueChanged(object sender, EventArgs e) {
            if (numericUpDownIndice.Value < 2) numericUpDownIndice.Value = 2;
        }
    }
}
