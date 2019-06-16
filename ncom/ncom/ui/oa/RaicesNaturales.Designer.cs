namespace ncom.ui.oa {
    partial class RaicesNaturales {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.numericUpDownIndice = new System.Windows.Forms.NumericUpDown();
            this.labelIndice = new System.Windows.Forms.Label();
            this.labelForma = new System.Windows.Forms.Label();
            this.labelImaginariaArgumento = new System.Windows.Forms.Label();
            this.labelParteRealModulo = new System.Windows.Forms.Label();
            this.labelComplejo1 = new System.Windows.Forms.Label();
            this.comboBoxForma1 = new System.Windows.Forms.ComboBox();
            this.numericInput12 = new System.Windows.Forms.NumericUpDown();
            this.numericInput11 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelRaicesNaturales = new System.Windows.Forms.Label();
            this.listViewResultado = new System.Windows.Forms.ListView();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput11)).BeginInit();
            this.SuspendLayout();
            // 
            // numericUpDownIndice
            // 
            this.numericUpDownIndice.Location = new System.Drawing.Point(94, 186);
            this.numericUpDownIndice.Name = "numericUpDownIndice";
            this.numericUpDownIndice.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownIndice.TabIndex = 101;
            this.numericUpDownIndice.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.numericUpDownIndice.ValueChanged += new System.EventHandler(this.numericUpDownIndice_ValueChanged);
            // 
            // labelIndice
            // 
            this.labelIndice.AutoSize = true;
            this.labelIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndice.Location = new System.Drawing.Point(39, 188);
            this.labelIndice.Name = "labelIndice";
            this.labelIndice.Size = new System.Drawing.Size(49, 17);
            this.labelIndice.TabIndex = 100;
            this.labelIndice.Text = "Indice:";
            // 
            // labelForma
            // 
            this.labelForma.AutoSize = true;
            this.labelForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForma.Location = new System.Drawing.Point(472, 78);
            this.labelForma.Name = "labelForma";
            this.labelForma.Size = new System.Drawing.Size(48, 17);
            this.labelForma.TabIndex = 97;
            this.labelForma.Text = "Forma";
            // 
            // labelImaginariaArgumento
            // 
            this.labelImaginariaArgumento.AutoSize = true;
            this.labelImaginariaArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImaginariaArgumento.Location = new System.Drawing.Point(272, 78);
            this.labelImaginariaArgumento.Name = "labelImaginariaArgumento";
            this.labelImaginariaArgumento.Size = new System.Drawing.Size(154, 17);
            this.labelImaginariaArgumento.TabIndex = 96;
            this.labelImaginariaArgumento.Text = "Imaginaria / Argumento";
            // 
            // labelParteRealModulo
            // 
            this.labelParteRealModulo.AutoSize = true;
            this.labelParteRealModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteRealModulo.Location = new System.Drawing.Point(143, 78);
            this.labelParteRealModulo.Name = "labelParteRealModulo";
            this.labelParteRealModulo.Size = new System.Drawing.Size(95, 17);
            this.labelParteRealModulo.TabIndex = 95;
            this.labelParteRealModulo.Text = "Real / Modulo";
            // 
            // labelComplejo1
            // 
            this.labelComplejo1.AutoSize = true;
            this.labelComplejo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplejo1.Location = new System.Drawing.Point(37, 120);
            this.labelComplejo1.Name = "labelComplejo1";
            this.labelComplejo1.Size = new System.Drawing.Size(70, 17);
            this.labelComplejo1.TabIndex = 94;
            this.labelComplejo1.Text = "Complejo:";
            // 
            // comboBoxForma1
            // 
            this.comboBoxForma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForma1.FormattingEnabled = true;
            this.comboBoxForma1.Items.AddRange(new object[] {
            "Binomica",
            "Polar"});
            this.comboBoxForma1.Location = new System.Drawing.Point(447, 117);
            this.comboBoxForma1.Name = "comboBoxForma1";
            this.comboBoxForma1.Size = new System.Drawing.Size(104, 24);
            this.comboBoxForma1.TabIndex = 93;
            this.comboBoxForma1.SelectedIndexChanged += new System.EventHandler(this.comboBoxForma1_SelectedIndexChanged);
            // 
            // numericInput12
            // 
            this.numericInput12.DecimalPlaces = 3;
            this.numericInput12.Location = new System.Drawing.Point(305, 118);
            this.numericInput12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput12.Name = "numericInput12";
            this.numericInput12.Size = new System.Drawing.Size(79, 22);
            this.numericInput12.TabIndex = 92;
            // 
            // numericInput11
            // 
            this.numericInput11.DecimalPlaces = 3;
            this.numericInput11.Location = new System.Drawing.Point(151, 119);
            this.numericInput11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput11.Name = "numericInput11";
            this.numericInput11.Size = new System.Drawing.Size(79, 22);
            this.numericInput11.TabIndex = 91;
            this.numericInput11.ValueChanged += new System.EventHandler(this.numericInput11_ValueChanged);
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(332, 287);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(103, 30);
            this.buttonCalcular.TabIndex = 90;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(38, 254);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(89, 18);
            this.labelResultado.TabIndex = 89;
            this.labelResultado.Text = "Resultado:";
            // 
            // labelRaicesNaturales
            // 
            this.labelRaicesNaturales.AutoSize = true;
            this.labelRaicesNaturales.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRaicesNaturales.Location = new System.Drawing.Point(209, 30);
            this.labelRaicesNaturales.Name = "labelRaicesNaturales";
            this.labelRaicesNaturales.Size = new System.Drawing.Size(175, 25);
            this.labelRaicesNaturales.TabIndex = 88;
            this.labelRaicesNaturales.Text = "Raíces Naturales";
            // 
            // listViewResultado
            // 
            this.listViewResultado.Location = new System.Drawing.Point(146, 254);
            this.listViewResultado.Name = "listViewResultado";
            this.listViewResultado.Size = new System.Drawing.Size(165, 97);
            this.listViewResultado.TabIndex = 102;
            this.listViewResultado.UseCompatibleStateImageBehavior = false;
            // 
            // RaicesNaturales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 380);
            this.Controls.Add(this.listViewResultado);
            this.Controls.Add(this.numericUpDownIndice);
            this.Controls.Add(this.labelIndice);
            this.Controls.Add(this.labelForma);
            this.Controls.Add(this.labelImaginariaArgumento);
            this.Controls.Add(this.labelParteRealModulo);
            this.Controls.Add(this.labelComplejo1);
            this.Controls.Add(this.comboBoxForma1);
            this.Controls.Add(this.numericInput12);
            this.Controls.Add(this.numericInput11);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelRaicesNaturales);
            this.Name = "RaicesNaturales";
            this.Text = "RaicesNaturales";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput11)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numericUpDownIndice;
        private System.Windows.Forms.Label labelIndice;
        private System.Windows.Forms.Label labelForma;
        private System.Windows.Forms.Label labelImaginariaArgumento;
        private System.Windows.Forms.Label labelParteRealModulo;
        private System.Windows.Forms.Label labelComplejo1;
        private System.Windows.Forms.ComboBox comboBoxForma1;
        private System.Windows.Forms.NumericUpDown numericInput12;
        private System.Windows.Forms.NumericUpDown numericInput11;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelRaicesNaturales;
        private System.Windows.Forms.ListView listViewResultado;
    }
}