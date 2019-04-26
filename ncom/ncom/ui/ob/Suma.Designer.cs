namespace ncom.ui
{
    partial class Suma
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
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
        private void InitializeComponent()
        {
            this.labelSuma = new System.Windows.Forms.Label();
            this.labelResultado = new System.Windows.Forms.Label();
            this.buttonCalcular = new System.Windows.Forms.Button();
            this.numericInput11 = new System.Windows.Forms.NumericUpDown();
            this.numericInput21 = new System.Windows.Forms.NumericUpDown();
            this.numericInput12 = new System.Windows.Forms.NumericUpDown();
            this.numericInput22 = new System.Windows.Forms.NumericUpDown();
            this.comboBoxForma1 = new System.Windows.Forms.ComboBox();
            this.comboBoxForma2 = new System.Windows.Forms.ComboBox();
            this.labelComplejo1 = new System.Windows.Forms.Label();
            this.labelComplejo2 = new System.Windows.Forms.Label();
            this.labelParteRealModulo = new System.Windows.Forms.Label();
            this.labelImaginariaArgumento = new System.Windows.Forms.Label();
            this.labelForma = new System.Windows.Forms.Label();
            this.labelResultadoCalculado = new System.Windows.Forms.Label();
            this.comboBoxFormaResultado = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput21)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput22)).BeginInit();
            this.SuspendLayout();
            // 
            // labelSuma
            // 
            this.labelSuma.AutoSize = true;
            this.labelSuma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSuma.Location = new System.Drawing.Point(270, 30);
            this.labelSuma.Name = "labelSuma";
            this.labelSuma.Size = new System.Drawing.Size(68, 25);
            this.labelSuma.TabIndex = 1;
            this.labelSuma.Text = "Suma";
            // 
            // labelResultado
            // 
            this.labelResultado.AutoSize = true;
            this.labelResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelResultado.Location = new System.Drawing.Point(38, 285);
            this.labelResultado.Name = "labelResultado";
            this.labelResultado.Size = new System.Drawing.Size(89, 18);
            this.labelResultado.TabIndex = 2;
            this.labelResultado.Text = "Resultado:";
            // 
            // buttonCalcular
            // 
            this.buttonCalcular.Location = new System.Drawing.Point(261, 325);
            this.buttonCalcular.Name = "buttonCalcular";
            this.buttonCalcular.Size = new System.Drawing.Size(103, 30);
            this.buttonCalcular.TabIndex = 8;
            this.buttonCalcular.Text = "Calcular";
            this.buttonCalcular.UseVisualStyleBackColor = true;
            this.buttonCalcular.Click += new System.EventHandler(this.buttonCalcular_Click);
            // 
            // numericInput11
            // 
            this.numericInput11.DecimalPlaces = 3;
            this.numericInput11.Location = new System.Drawing.Point(151, 125);
            this.numericInput11.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput11.Name = "numericInput11";
            this.numericInput11.Size = new System.Drawing.Size(79, 22);
            this.numericInput11.TabIndex = 9;
            this.numericInput11.ValueChanged += new System.EventHandler(this.numericInput11_ValueChanged);
            // 
            // numericInput21
            // 
            this.numericInput21.DecimalPlaces = 3;
            this.numericInput21.Location = new System.Drawing.Point(151, 202);
            this.numericInput21.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput21.Name = "numericInput21";
            this.numericInput21.Size = new System.Drawing.Size(79, 22);
            this.numericInput21.TabIndex = 10;
            this.numericInput21.ValueChanged += new System.EventHandler(this.numericInput21_ValueChanged);
            // 
            // numericInput12
            // 
            this.numericInput12.DecimalPlaces = 3;
            this.numericInput12.Location = new System.Drawing.Point(305, 124);
            this.numericInput12.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput12.Name = "numericInput12";
            this.numericInput12.Size = new System.Drawing.Size(79, 22);
            this.numericInput12.TabIndex = 11;
            // 
            // numericInput22
            // 
            this.numericInput22.DecimalPlaces = 3;
            this.numericInput22.Location = new System.Drawing.Point(305, 201);
            this.numericInput22.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericInput22.Name = "numericInput22";
            this.numericInput22.Size = new System.Drawing.Size(79, 22);
            this.numericInput22.TabIndex = 12;
            // 
            // comboBoxForma1
            // 
            this.comboBoxForma1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForma1.FormattingEnabled = true;
            this.comboBoxForma1.Items.AddRange(new object[] {
            "Binomica",
            "Polar"});
            this.comboBoxForma1.Location = new System.Drawing.Point(447, 123);
            this.comboBoxForma1.Name = "comboBoxForma1";
            this.comboBoxForma1.Size = new System.Drawing.Size(104, 24);
            this.comboBoxForma1.TabIndex = 13;
            this.comboBoxForma1.SelectedIndexChanged += new System.EventHandler(this.comboBoxForma1_SelectedIndexChanged);
            // 
            // comboBoxForma2
            // 
            this.comboBoxForma2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxForma2.FormattingEnabled = true;
            this.comboBoxForma2.Items.AddRange(new object[] {
            "Binomica",
            "Polar"});
            this.comboBoxForma2.Location = new System.Drawing.Point(447, 200);
            this.comboBoxForma2.Name = "comboBoxForma2";
            this.comboBoxForma2.Size = new System.Drawing.Size(104, 24);
            this.comboBoxForma2.TabIndex = 14;
            this.comboBoxForma2.SelectedIndexChanged += new System.EventHandler(this.comboBoxForma2_SelectedIndexChanged);
            // 
            // labelComplejo1
            // 
            this.labelComplejo1.AutoSize = true;
            this.labelComplejo1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplejo1.Location = new System.Drawing.Point(37, 126);
            this.labelComplejo1.Name = "labelComplejo1";
            this.labelComplejo1.Size = new System.Drawing.Size(82, 17);
            this.labelComplejo1.TabIndex = 15;
            this.labelComplejo1.Text = "Complejo 1:";
            // 
            // labelComplejo2
            // 
            this.labelComplejo2.AutoSize = true;
            this.labelComplejo2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelComplejo2.Location = new System.Drawing.Point(37, 204);
            this.labelComplejo2.Name = "labelComplejo2";
            this.labelComplejo2.Size = new System.Drawing.Size(82, 17);
            this.labelComplejo2.TabIndex = 16;
            this.labelComplejo2.Text = "Complejo 2:";
            // 
            // labelParteRealModulo
            // 
            this.labelParteRealModulo.AutoSize = true;
            this.labelParteRealModulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelParteRealModulo.Location = new System.Drawing.Point(143, 84);
            this.labelParteRealModulo.Name = "labelParteRealModulo";
            this.labelParteRealModulo.Size = new System.Drawing.Size(95, 17);
            this.labelParteRealModulo.TabIndex = 17;
            this.labelParteRealModulo.Text = "Real / Modulo";
            // 
            // labelImaginariaArgumento
            // 
            this.labelImaginariaArgumento.AutoSize = true;
            this.labelImaginariaArgumento.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelImaginariaArgumento.Location = new System.Drawing.Point(272, 84);
            this.labelImaginariaArgumento.Name = "labelImaginariaArgumento";
            this.labelImaginariaArgumento.Size = new System.Drawing.Size(154, 17);
            this.labelImaginariaArgumento.TabIndex = 18;
            this.labelImaginariaArgumento.Text = "Imaginaria / Argumento";
            // 
            // labelForma
            // 
            this.labelForma.AutoSize = true;
            this.labelForma.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelForma.Location = new System.Drawing.Point(472, 84);
            this.labelForma.Name = "labelForma";
            this.labelForma.Size = new System.Drawing.Size(48, 17);
            this.labelForma.TabIndex = 19;
            this.labelForma.Text = "Forma";
            // 
            // labelResultadoCalculado
            // 
            this.labelResultadoCalculado.AutoSize = true;
            this.labelResultadoCalculado.Location = new System.Drawing.Point(148, 287);
            this.labelResultadoCalculado.Name = "labelResultadoCalculado";
            this.labelResultadoCalculado.Size = new System.Drawing.Size(50, 17);
            this.labelResultadoCalculado.TabIndex = 20;
            this.labelResultadoCalculado.Text = "( 0, 0 )";
            // 
            // comboBoxFormaResultado
            // 
            this.comboBoxFormaResultado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxFormaResultado.FormattingEnabled = true;
            this.comboBoxFormaResultado.Items.AddRange(new object[] {
            "Binomica",
            "Polar"});
            this.comboBoxFormaResultado.Location = new System.Drawing.Point(447, 280);
            this.comboBoxFormaResultado.Name = "comboBoxFormaResultado";
            this.comboBoxFormaResultado.Size = new System.Drawing.Size(104, 24);
            this.comboBoxFormaResultado.TabIndex = 21;
            // 
            // Suma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(589, 380);
            this.Controls.Add(this.comboBoxFormaResultado);
            this.Controls.Add(this.labelResultadoCalculado);
            this.Controls.Add(this.labelForma);
            this.Controls.Add(this.labelImaginariaArgumento);
            this.Controls.Add(this.labelParteRealModulo);
            this.Controls.Add(this.labelComplejo2);
            this.Controls.Add(this.labelComplejo1);
            this.Controls.Add(this.comboBoxForma2);
            this.Controls.Add(this.comboBoxForma1);
            this.Controls.Add(this.numericInput22);
            this.Controls.Add(this.numericInput12);
            this.Controls.Add(this.numericInput21);
            this.Controls.Add(this.numericInput11);
            this.Controls.Add(this.buttonCalcular);
            this.Controls.Add(this.labelResultado);
            this.Controls.Add(this.labelSuma);
            this.Name = "Suma";
            this.Text = "Suma";
            ((System.ComponentModel.ISupportInitialize)(this.numericInput11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput21)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericInput22)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelSuma;
        private System.Windows.Forms.Label labelResultado;
        private System.Windows.Forms.Button buttonCalcular;
        private System.Windows.Forms.NumericUpDown numericInput11;
        private System.Windows.Forms.NumericUpDown numericInput21;
        private System.Windows.Forms.NumericUpDown numericInput12;
        private System.Windows.Forms.NumericUpDown numericInput22;
        private System.Windows.Forms.ComboBox comboBoxForma1;
        private System.Windows.Forms.ComboBox comboBoxForma2;
        private System.Windows.Forms.Label labelComplejo1;
        private System.Windows.Forms.Label labelComplejo2;
        private System.Windows.Forms.Label labelParteRealModulo;
        private System.Windows.Forms.Label labelImaginariaArgumento;
        private System.Windows.Forms.Label labelForma;
        private System.Windows.Forms.Label labelResultadoCalculado;
        private System.Windows.Forms.ComboBox comboBoxFormaResultado;
    }
}