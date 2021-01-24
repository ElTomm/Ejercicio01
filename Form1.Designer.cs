
namespace OpeEjercicio1
{
    partial class lblv1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmdSuma = new System.Windows.Forms.Button();
            this.cmdResta = new System.Windows.Forms.Button();
            this.cmdMult = new System.Windows.Forms.Button();
            this.cmdDiv = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblv2 = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.txtv1 = new System.Windows.Forms.TextBox();
            this.txtv2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cmdSuma
            // 
            this.cmdSuma.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdSuma.Location = new System.Drawing.Point(279, 205);
            this.cmdSuma.Name = "cmdSuma";
            this.cmdSuma.Size = new System.Drawing.Size(75, 23);
            this.cmdSuma.TabIndex = 0;
            this.cmdSuma.Text = "Suma";
            this.cmdSuma.UseVisualStyleBackColor = false;
            this.cmdSuma.Click += new System.EventHandler(this.cmdSuma_Click);
            // 
            // cmdResta
            // 
            this.cmdResta.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdResta.Location = new System.Drawing.Point(406, 205);
            this.cmdResta.Name = "cmdResta";
            this.cmdResta.Size = new System.Drawing.Size(75, 23);
            this.cmdResta.TabIndex = 1;
            this.cmdResta.Text = "Resta";
            this.cmdResta.UseVisualStyleBackColor = false;
            this.cmdResta.Click += new System.EventHandler(this.cmdResta_Click);
            // 
            // cmdMult
            // 
            this.cmdMult.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdMult.Location = new System.Drawing.Point(546, 205);
            this.cmdMult.Name = "cmdMult";
            this.cmdMult.Size = new System.Drawing.Size(82, 23);
            this.cmdMult.TabIndex = 2;
            this.cmdMult.Text = "Multiplicación";
            this.cmdMult.UseVisualStyleBackColor = false;
            this.cmdMult.Click += new System.EventHandler(this.button3_Click);
            // 
            // cmdDiv
            // 
            this.cmdDiv.BackColor = System.Drawing.SystemColors.Highlight;
            this.cmdDiv.Location = new System.Drawing.Point(688, 205);
            this.cmdDiv.Name = "cmdDiv";
            this.cmdDiv.Size = new System.Drawing.Size(75, 23);
            this.cmdDiv.TabIndex = 3;
            this.cmdDiv.Text = "División";
            this.cmdDiv.UseVisualStyleBackColor = false;
            this.cmdDiv.Click += new System.EventHandler(this.cmdDiv_Click);
            // 
            // cmdSalir
            // 
            this.cmdSalir.BackColor = System.Drawing.SystemColors.GrayText;
            this.cmdSalir.Location = new System.Drawing.Point(463, 262);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(75, 23);
            this.cmdSalir.TabIndex = 4;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = false;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lbl1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lbl1.Location = new System.Drawing.Point(342, 70);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(63, 13);
            this.lbl1.TabIndex = 5;
            this.lbl1.Text = "Primer Valor";
            // 
            // lblv2
            // 
            this.lblv2.AutoSize = true;
            this.lblv2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblv2.Location = new System.Drawing.Point(345, 112);
            this.lblv2.Name = "lblv2";
            this.lblv2.Size = new System.Drawing.Size(77, 13);
            this.lblv2.TabIndex = 6;
            this.lblv2.Text = "Segundo Valor";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.lblResultado.Location = new System.Drawing.Point(460, 162);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(55, 13);
            this.lblResultado.TabIndex = 7;
            this.lblResultado.Text = "Resultado";
            this.lblResultado.Click += new System.EventHandler(this.lblresultado_Click);
            // 
            // txtv1
            // 
            this.txtv1.Location = new System.Drawing.Point(438, 67);
            this.txtv1.Name = "txtv1";
            this.txtv1.Size = new System.Drawing.Size(107, 20);
            this.txtv1.TabIndex = 8;
            // 
            // txtv2
            // 
            this.txtv2.Location = new System.Drawing.Point(438, 105);
            this.txtv2.Name = "txtv2";
            this.txtv2.Size = new System.Drawing.Size(107, 20);
            this.txtv2.TabIndex = 9;
            // 
            // lblv1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 448);
            this.Controls.Add(this.txtv2);
            this.Controls.Add(this.txtv1);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblv2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdDiv);
            this.Controls.Add(this.cmdMult);
            this.Controls.Add(this.cmdResta);
            this.Controls.Add(this.cmdSuma);
            this.Name = "lblv1";
            this.Text = "Suma";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdSuma;
        private System.Windows.Forms.Button cmdResta;
        private System.Windows.Forms.Button cmdMult;
        private System.Windows.Forms.Button cmdDiv;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblv2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.TextBox txtv1;
        private System.Windows.Forms.TextBox txtv2;
    }
}

