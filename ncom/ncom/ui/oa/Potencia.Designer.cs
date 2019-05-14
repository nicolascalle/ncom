namespace ncom.ui.oa {
    partial class Potencia {
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
            this.comboBoxFormaResultado = new System.Windows.Forms.ComboBox();
            this.labelResultadoCalculado = new System.Windows.Forms.Label();
            this.labelForma = new System.Windows.Forms.Label();
            this.labelImaginariaArgumento = new System.Windows.Forms.Label();
            this.labelParteRealModulo = new System.Windows.Forms.Label();
            this.labelComplejo1 = new System.Windows.Forms.Label();
            this.comboBoxForma1 = new System.Windows.Forms.ComboBox();
            this.numericInput12 = new System.Windows.Forms.NumericUpDown();
            this.numericInput11 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelPotencia = new System.Windows.Forms.Label();
            this.labelIndice = new System.Windows.Forms.Label();
            this.numericUpDownIndice = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndice)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxFormaResultado
            // 
            this.comboBoxFormaResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaResultado.FormattingEnabled = true;
            this.comboBoxFormaResultado.Items.AddRange(new object[] {
            "Binomica",
            "Polar"});
            this.comboBoxFormaResultado.Location = new System.Drawing.Point(447, 276);
            this.comboBoxFormaResultado.Name = "comboBoxFormaResultado";
            this.comboBoxFormaResultado.Size = new System.Drawing.Size(104, 24);
            this.comboBoxFormaResultado.TabIndex = 85;
            // 
            // labelResultadoCalculado
            // 
            this.labelResultadoCalculado.AutoSize = true;
            this.labelResultadoCalculado.Location = new System.Drawing.Point(148, 283);
            this.labelResultadoCalculado.Name = "labelResultadoCalculado";
            this.labelResultadoCalculado.Size = new System.Drawing.Size(50, 17);
            this.labelResultadoCalculado.TabIndex = 84;
            this.labelResultadoCalculado.Text = "( 0, 0 )";
            // 
            // labelForma
            // 
            this.labelForma.AutoSize = true;
            this.labelForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForma.Location = new System.Drawing.Point(472, 80);
            this.labelForma.Name = "labelForma";
            this.labelForma.Size = new System.Drawing.Size(48, 17);
            this.labelForma.TabIndex = 83;
            this.labelForma.Text = "Forma";
            // 
            // labelImaginariaArgumento
            // 
            this.labelImaginariaArgumento.AutoSize = true;
            this.labelImaginariaArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImaginariaArgumento.Location = new System.Drawing.Point(272, 80);
            this.labelImaginariaArgumento.Name = "labelImaginariaArgumento";
            this.labelImaginariaArgumento.Size = new System.Drawing.Size(154, 17);
            this.labelImaginariaArgumento.TabIndex = 82;
            this.labelImaginariaArgumento.Text = "Imaginaria / Argumento";
            // 
            // labelParteRealModulo
            // 
            this.labelParteRealModulo.AutoSize = true;
            this.labelParteRealModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteRealModulo.Location = new System.Drawing.Point(143, 80);
            this.labelParteRealModulo.Name = "labelParteRealModulo";
            this.labelParteRealModulo.Size = new System.Drawing.Size(95, 17);
            this.labelParteRealModulo.TabIndex = 81;
            this.labelParteRealModulo.Text = "Real / Modulo";
            // 
            // labelComplejo1
            // 
            this.labelComplejo1.AutoSize = true;
            this.labelComplejo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplejo1.Location = new System.Drawing.Point(37, 122);
            this.labelComplejo1.Name = "labelComplejo1";
            this.labelComplejo1.Size = new System.Drawing.Size(70, 17);
            this.labelComplejo1.TabIndex = 79;
            this.labelComplejo1.Text = "Complejo:";
            // 
            // comboBoxForma1
            // 
            this.comboBoxForma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForma1.FormattingEnabled = true;
            this.comboBoxForma1.Items.AddRange(new object[] {
            "Binomica",
            "Polar"});
            this.comboBoxForma1.Location = new System.Drawing.Point(447, 119);
            this.comboBoxForma1.Name = "comboBoxForma1";
            this.comboBoxForma1.Size = new System.Drawing.Size(104, 24);
            this.comboBoxForma1.TabIndex = 77;
            // 
            // numericInput12
            // 
            this.numericInput12.DecimalPlaces = 3;
            this.numericInput12.Location = new System.Drawing.Point(305, 120);
            this.numericInput12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput12.Name = "numericInput12";
            this.numericInput12.Size = new System.Drawing.Size(79, 22);
            this.numericInput12.TabIndex = 75;
            // 
            // numericInput11
            // 
            this.numericInput11.DecimalPlaces = 3;
            this.numericInput11.Location = new System.Drawing.Point(151, 121);
            this.numericInput11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput11.Name = "numericInput11";
            this.numericInput11.Size = new System.Drawing.Size(79, 22);
            this.numericInput11.TabIndex = 73;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(252, 326);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(103, 30);
            this.buttonCalcular.TabIndex = 72;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(38, 281);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(89, 18);
            this.labelResultado.TabIndex = 71;
            this.labelResultado.Text = "Resultado:";
            // 
            // labelPotencia
            // 
            this.labelPotencia.AutoSize = true;
            this.labelPotencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPotencia.Location = new System.Drawing.Point(247, 29);
            this.labelPotencia.Name = "labelPotencia";
            this.labelPotencia.Size = new System.Drawing.Size(96, 25);
            this.labelPotencia.TabIndex = 70;
            this.labelPotencia.Text = "Potencia";
            // 
            // labelIndice
            // 
            this.labelIndice.AutoSize = true;
            this.labelIndice.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndice.Location = new System.Drawing.Point(37, 200);
            this.labelIndice.Name = "labelIndice";
            this.labelIndice.Size = new System.Drawing.Size(49, 17);
            this.labelIndice.TabIndex = 86;
            this.labelIndice.Text = "Indice:";
            // 
            // numericUpDownIndice
            // 
            this.numericUpDownIndice.Location = new System.Drawing.Point(92, 198);
            this.numericUpDownIndice.Name = "numericUpDownIndice";
            this.numericUpDownIndice.Size = new System.Drawing.Size(66, 22);
            this.numericUpDownIndice.TabIndex = 87;
            this.numericUpDownIndice.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Potencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 380);
            this.Controls.Add(this.numericUpDownIndice);
            this.Controls.Add(this.labelIndice);
            this.Controls.Add(this.comboBoxFormaResultado);
            this.Controls.Add(this.labelResultadoCalculado);
            this.Controls.Add(this.labelForma);
            this.Controls.Add(this.labelImaginariaArgumento);
            this.Controls.Add(this.labelParteRealModulo);
            this.Controls.Add(this.labelComplejo1);
            this.Controls.Add(this.comboBoxForma1);
            this.Controls.Add(this.numericInput12);
            this.Controls.Add(this.numericInput11);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelPotencia);
            this.Name = "Potencia";
            this.Text = "Potencia";
            ((System.ComponentModel.ISupportInitialize)(this.numericInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownIndice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBoxFormaResultado;
        private System.Windows.Forms.Label labelResultadoCalculado;
        private System.Windows.Forms.Label labelForma;
        private System.Windows.Forms.Label labelImaginariaArgumento;
        private System.Windows.Forms.Label labelParteRealModulo;
        private System.Windows.Forms.Label labelComplejo1;
        private System.Windows.Forms.ComboBox comboBoxForma1;
        private System.Windows.Forms.NumericUpDown numericInput12;
        private System.Windows.Forms.NumericUpDown numericInput11;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelPotencia;
        private System.Windows.Forms.Label labelIndice;
        private System.Windows.Forms.NumericUpDown numericUpDownIndice;
    }
}