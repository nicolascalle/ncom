namespace ncom.ui.sf {
    partial class SumaFasorial {
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
            this.labelResultadoCalculado = new System.Windows.Forms.Label();
            this.labelFuncion = new System.Windows.Forms.Label();
            this.labelFrecuencia = new System.Windows.Forms.Label();
            this.labelAmplitud = new System.Windows.Forms.Label();
            this.labelFasor2 = new System.Windows.Forms.Label();
            this.labelFasor1 = new System.Windows.Forms.Label();
            this.numericInputFase2 = new System.Windows.Forms.NumericUpDown();
            this.numericInputFrecuencia1 = new System.Windows.Forms.NumericUpDown();
            this.numericInputAmplitud2 = new System.Windows.Forms.NumericUpDown();
            this.numericInputAmplitud1 = new System.Windows.Forms.NumericUpDown();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.labelResultado = new System.Windows.Forms.Label();
            this.labelSuma = new System.Windows.Forms.Label();
            this.comboBoxFuncion1 = new System.Windows.Forms.ComboBox();
            this.comboBoxFuncion2 = new System.Windows.Forms.ComboBox();
            this.labelFase = new System.Windows.Forms.Label();
            this.numericInputFase1 = new System.Windows.Forms.NumericUpDown();
            this.numericInputFrecuencia2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFase2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFrecuencia1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputAmplitud2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputAmplitud1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFase1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFrecuencia2)).BeginInit();
            this.SuspendLayout();
            // 
            // labelResultadoCalculado
            // 
            this.labelResultadoCalculado.AutoSize = true;
            this.labelResultadoCalculado.Location = new System.Drawing.Point(144, 282);
            this.labelResultadoCalculado.Name = "labelResultadoCalculado";
            this.labelResultadoCalculado.Size = new System.Drawing.Size(112, 17);
            this.labelResultadoCalculado.TabIndex = 36;
            this.labelResultadoCalculado.Text = "0 . cos ( 0.t + 0 )";
            // 
            // labelFuncion
            // 
            this.labelFuncion.AutoSize = true;
            this.labelFuncion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFuncion.Location = new System.Drawing.Point(240, 91);
            this.labelFuncion.Name = "labelFuncion";
            this.labelFuncion.Size = new System.Drawing.Size(58, 17);
            this.labelFuncion.TabIndex = 35;
            this.labelFuncion.Text = "Función";
            // 
            // labelFrecuencia
            // 
            this.labelFrecuencia.AutoSize = true;
            this.labelFrecuencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFrecuencia.Location = new System.Drawing.Point(336, 91);
            this.labelFrecuencia.Name = "labelFrecuencia";
            this.labelFrecuencia.Size = new System.Drawing.Size(122, 17);
            this.labelFrecuencia.TabIndex = 34;
            this.labelFrecuencia.Text = "Frecuencia (Rad.)";
            // 
            // labelAmplitud
            // 
            this.labelAmplitud.AutoSize = true;
            this.labelAmplitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAmplitud.Location = new System.Drawing.Point(121, 91);
            this.labelAmplitud.Name = "labelAmplitud";
            this.labelAmplitud.Size = new System.Drawing.Size(62, 17);
            this.labelAmplitud.TabIndex = 33;
            this.labelAmplitud.Text = "Amplitud";
            // 
            // labelFasor2
            // 
            this.labelFasor2.AutoSize = true;
            this.labelFasor2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFasor2.Location = new System.Drawing.Point(35, 211);
            this.labelFasor2.Name = "labelFasor2";
            this.labelFasor2.Size = new System.Drawing.Size(60, 17);
            this.labelFasor2.TabIndex = 32;
            this.labelFasor2.Text = "Fasor 2:";
            // 
            // labelFasor1
            // 
            this.labelFasor1.AutoSize = true;
            this.labelFasor1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFasor1.Location = new System.Drawing.Point(35, 133);
            this.labelFasor1.Name = "labelFasor1";
            this.labelFasor1.Size = new System.Drawing.Size(60, 17);
            this.labelFasor1.TabIndex = 31;
            this.labelFasor1.Text = "Fasor 1:";
            // 
            // numericInputFase2
            // 
            this.numericInputFase2.DecimalPlaces = 3;
            this.numericInputFase2.Location = new System.Drawing.Point(475, 209);
            this.numericInputFase2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInputFase2.Name = "numericInputFase2";
            this.numericInputFase2.Size = new System.Drawing.Size(79, 22);
            this.numericInputFase2.TabIndex = 28;
            // 
            // numericInputFrecuencia1
            // 
            this.numericInputFrecuencia1.DecimalPlaces = 3;
            this.numericInputFrecuencia1.Location = new System.Drawing.Point(351, 131);
            this.numericInputFrecuencia1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInputFrecuencia1.Name = "numericInputFrecuencia1";
            this.numericInputFrecuencia1.Size = new System.Drawing.Size(79, 22);
            this.numericInputFrecuencia1.TabIndex = 27;
            this.numericInputFrecuencia1.ValueChanged += new System.EventHandler(this.numericInputFrecuencia1_ValueChanged);
            // 
            // numericInputAmplitud2
            // 
            this.numericInputAmplitud2.DecimalPlaces = 3;
            this.numericInputAmplitud2.Location = new System.Drawing.Point(114, 209);
            this.numericInputAmplitud2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInputAmplitud2.Name = "numericInputAmplitud2";
            this.numericInputAmplitud2.Size = new System.Drawing.Size(79, 22);
            this.numericInputAmplitud2.TabIndex = 26;
            // 
            // numericInputAmplitud1
            // 
            this.numericInputAmplitud1.DecimalPlaces = 3;
            this.numericInputAmplitud1.Location = new System.Drawing.Point(114, 132);
            this.numericInputAmplitud1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInputAmplitud1.Name = "numericInputAmplitud1";
            this.numericInputAmplitud1.Size = new System.Drawing.Size(79, 22);
            this.numericInputAmplitud1.TabIndex = 25;
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(254, 326);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(103, 30);
            this.buttonCalcular.TabIndex = 24;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(38, 280);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(89, 18);
            this.labelResultado.TabIndex = 23;
            this.labelResultado.Text = "Resultado:";
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuma.Location = new System.Drawing.Point(212, 30);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(182, 25);
            this.labelSuma.TabIndex = 22;
            this.labelSuma.Text = "Suma de Fasores";
            // 
            // comboBoxFuncion1
            // 
            this.comboBoxFuncion1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncion1.FormattingEnabled = true;
            this.comboBoxFuncion1.Items.AddRange(new object[] {
            "sen",
            "cos"});
            this.comboBoxFuncion1.Location = new System.Drawing.Point(226, 130);
            this.comboBoxFuncion1.Name = "comboBoxFuncion1";
            this.comboBoxFuncion1.Size = new System.Drawing.Size(84, 24);
            this.comboBoxFuncion1.TabIndex = 37;
            // 
            // comboBoxFuncion2
            // 
            this.comboBoxFuncion2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFuncion2.FormattingEnabled = true;
            this.comboBoxFuncion2.Items.AddRange(new object[] {
            "sen",
            "cos"});
            this.comboBoxFuncion2.Location = new System.Drawing.Point(226, 208);
            this.comboBoxFuncion2.Name = "comboBoxFuncion2";
            this.comboBoxFuncion2.Size = new System.Drawing.Size(84, 24);
            this.comboBoxFuncion2.TabIndex = 38;
            // 
            // labelFase
            // 
            this.labelFase.AutoSize = true;
            this.labelFase.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFase.Location = new System.Drawing.Point(472, 91);
            this.labelFase.Name = "labelFase";
            this.labelFase.Size = new System.Drawing.Size(83, 17);
            this.labelFase.TabIndex = 41;
            this.labelFase.Text = "Fase (Rad.)";
            // 
            // numericInputFase1
            // 
            this.numericInputFase1.DecimalPlaces = 3;
            this.numericInputFase1.Location = new System.Drawing.Point(475, 131);
            this.numericInputFase1.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInputFase1.Name = "numericInputFase1";
            this.numericInputFase1.Size = new System.Drawing.Size(79, 22);
            this.numericInputFase1.TabIndex = 39;
            // 
            // numericInputFrecuencia2
            // 
            this.numericInputFrecuencia2.DecimalPlaces = 3;
            this.numericInputFrecuencia2.Location = new System.Drawing.Point(351, 209);
            this.numericInputFrecuencia2.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInputFrecuencia2.Name = "numericInputFrecuencia2";
            this.numericInputFrecuencia2.Size = new System.Drawing.Size(79, 22);
            this.numericInputFrecuencia2.TabIndex = 40;
            this.numericInputFrecuencia2.ValueChanged += new System.EventHandler(this.numericInputFrecuencia2_ValueChanged);
            // 
            // SumaFasorial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 380);
            this.Controls.Add(this.labelFase);
            this.Controls.Add(this.numericInputFrecuencia2);
            this.Controls.Add(this.numericInputFase1);
            this.Controls.Add(this.comboBoxFuncion2);
            this.Controls.Add(this.comboBoxFuncion1);
            this.Controls.Add(this.labelResultadoCalculado);
            this.Controls.Add(this.labelFuncion);
            this.Controls.Add(this.labelFrecuencia);
            this.Controls.Add(this.labelAmplitud);
            this.Controls.Add(this.labelFasor2);
            this.Controls.Add(this.labelFasor1);
            this.Controls.Add(this.numericInputFase2);
            this.Controls.Add(this.numericInputFrecuencia1);
            this.Controls.Add(this.numericInputAmplitud2);
            this.Controls.Add(this.numericInputAmplitud1);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelSuma);
            this.Name = "SumaFasorial";
            this.Text = "SumaFasorial";
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFase2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFrecuencia1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputAmplitud2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputAmplitud1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFase1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInputFrecuencia2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelResultadoCalculado;
        private System.Windows.Forms.Label labelFuncion;
        private System.Windows.Forms.Label labelFrecuencia;
        private System.Windows.Forms.Label labelAmplitud;
        private System.Windows.Forms.Label labelFasor2;
        private System.Windows.Forms.Label labelFasor1;
        private System.Windows.Forms.NumericUpDown numericInputFase2;
        private System.Windows.Forms.NumericUpDown numericInputFrecuencia1;
        private System.Windows.Forms.NumericUpDown numericInputAmplitud2;
        private System.Windows.Forms.NumericUpDown numericInputAmplitud1;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.ComboBox comboBoxFuncion1;
        private System.Windows.Forms.ComboBox comboBoxFuncion2;
        private System.Windows.Forms.Label labelFase;
        private System.Windows.Forms.NumericUpDown numericInputFase1;
        private System.Windows.Forms.NumericUpDown numericInputFrecuencia2;
    }
}