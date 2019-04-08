namespace ncom
{
    partial class Conversor
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.binomicaAPolar = new System.Windows.Forms.Button();
            this.parteReal = new System.Windows.Forms.TextBox();
            this.parteImaginaria = new System.Windows.Forms.TextBox();
            this.Labael1 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.argumento = new System.Windows.Forms.TextBox();
            this.modulo = new System.Windows.Forms.TextBox();
            this.polarABinomica = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // binomicaAPolar
            // 
            this.binomicaAPolar.Location = new System.Drawing.Point(469, 229);
            this.binomicaAPolar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.binomicaAPolar.Name = "binomicaAPolar";
            this.binomicaAPolar.Size = new System.Drawing.Size(195, 47);
            this.binomicaAPolar.TabIndex = 1;
            this.binomicaAPolar.Text = "Binomica a polar";
            this.binomicaAPolar.UseVisualStyleBackColor = true;
            this.binomicaAPolar.Click += new System.EventHandler(this.binomicaAPolar_Click);
            // 
            // parteReal
            // 
            this.parteReal.Location = new System.Drawing.Point(115, 241);
            this.parteReal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parteReal.Name = "parteReal";
            this.parteReal.Size = new System.Drawing.Size(132, 22);
            this.parteReal.TabIndex = 2;
            // 
            // parteImaginaria
            // 
            this.parteImaginaria.Location = new System.Drawing.Point(284, 241);
            this.parteImaginaria.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.parteImaginaria.Name = "parteImaginaria";
            this.parteImaginaria.Size = new System.Drawing.Size(132, 22);
            this.parteImaginaria.TabIndex = 3;
            // 
            // Labael1
            // 
            this.Labael1.AutoSize = true;
            this.Labael1.Location = new System.Drawing.Point(111, 206);
            this.Labael1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Labael1.Name = "Labael1";
            this.Labael1.Size = new System.Drawing.Size(70, 17);
            this.Labael1.TabIndex = 4;
            this.Labael1.Text = "Parte real";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 206);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Parte imaginaria";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(280, 338);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Argumento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(111, 338);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "Modulo";
            // 
            // argumento
            // 
            this.argumento.Location = new System.Drawing.Point(284, 374);
            this.argumento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.argumento.Name = "argumento";
            this.argumento.Size = new System.Drawing.Size(132, 22);
            this.argumento.TabIndex = 8;
            // 
            // modulo
            // 
            this.modulo.Location = new System.Drawing.Point(115, 374);
            this.modulo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.modulo.Name = "modulo";
            this.modulo.Size = new System.Drawing.Size(132, 22);
            this.modulo.TabIndex = 7;
            // 
            // polarABinomica
            // 
            this.polarABinomica.Location = new System.Drawing.Point(469, 362);
            this.polarABinomica.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.polarABinomica.Name = "polarABinomica";
            this.polarABinomica.Size = new System.Drawing.Size(195, 47);
            this.polarABinomica.TabIndex = 6;
            this.polarABinomica.Text = "Polar a binomica";
            this.polarABinomica.UseVisualStyleBackColor = true;
            this.polarABinomica.Click += new System.EventHandler(this.polarABinomica_Click);
            // 
            // inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 650);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.argumento);
            this.Controls.Add(this.modulo);
            this.Controls.Add(this.polarABinomica);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Labael1);
            this.Controls.Add(this.parteImaginaria);
            this.Controls.Add(this.parteReal);
            this.Controls.Add(this.binomicaAPolar);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "inicio";
            this.Text = "Inicio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button binomicaAPolar;
        private System.Windows.Forms.TextBox parteReal;
        private System.Windows.Forms.TextBox parteImaginaria;
        private System.Windows.Forms.Label Labael1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox argumento;
        private System.Windows.Forms.TextBox modulo;
        private System.Windows.Forms.Button polarABinomica;

    }
}

