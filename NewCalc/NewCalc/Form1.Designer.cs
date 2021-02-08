namespace NewCalc
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClose = new System.Windows.Forms.Button();
            this.txtValores = new System.Windows.Forms.TextBox();
            this.btnSoma = new System.Windows.Forms.Button();
            this.btnSub = new System.Windows.Forms.Button();
            this.btnDividir = new System.Windows.Forms.Button();
            this.btnMult = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValores2 = new System.Windows.Forms.TextBox();
            this.lblResultado = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.DarkRed;
            this.btnClose.Location = new System.Drawing.Point(257, 1);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(44, 33);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtValores
            // 
            this.txtValores.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtValores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtValores.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValores.ForeColor = System.Drawing.Color.White;
            this.txtValores.Location = new System.Drawing.Point(-1, 34);
            this.txtValores.Multiline = true;
            this.txtValores.Name = "txtValores";
            this.txtValores.Size = new System.Drawing.Size(153, 113);
            this.txtValores.TabIndex = 1;
            // 
            // btnSoma
            // 
            this.btnSoma.Location = new System.Drawing.Point(12, 153);
            this.btnSoma.Name = "btnSoma";
            this.btnSoma.Size = new System.Drawing.Size(35, 41);
            this.btnSoma.TabIndex = 2;
            this.btnSoma.Text = "+";
            this.btnSoma.UseVisualStyleBackColor = true;
            this.btnSoma.Click += new System.EventHandler(this.btnSoma_Click);
            // 
            // btnSub
            // 
            this.btnSub.Location = new System.Drawing.Point(53, 153);
            this.btnSub.Name = "btnSub";
            this.btnSub.Size = new System.Drawing.Size(33, 41);
            this.btnSub.TabIndex = 3;
            this.btnSub.Text = "-";
            this.btnSub.UseVisualStyleBackColor = true;
            this.btnSub.Click += new System.EventHandler(this.btnSub_Click);
            // 
            // btnDividir
            // 
            this.btnDividir.Location = new System.Drawing.Point(92, 153);
            this.btnDividir.Name = "btnDividir";
            this.btnDividir.Size = new System.Drawing.Size(34, 41);
            this.btnDividir.TabIndex = 4;
            this.btnDividir.Text = "/";
            this.btnDividir.UseVisualStyleBackColor = true;
            this.btnDividir.Click += new System.EventHandler(this.btnDividir_Click);
            // 
            // btnMult
            // 
            this.btnMult.Location = new System.Drawing.Point(133, 153);
            this.btnMult.Name = "btnMult";
            this.btnMult.Size = new System.Drawing.Size(34, 41);
            this.btnMult.TabIndex = 5;
            this.btnMult.Text = "x";
            this.btnMult.UseVisualStyleBackColor = true;
            this.btnMult.Click += new System.EventHandler(this.btnMult_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 167);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "By: Cássio";
            // 
            // txtValores2
            // 
            this.txtValores2.Font = new System.Drawing.Font("MS PGothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtValores2.Location = new System.Drawing.Point(158, 34);
            this.txtValores2.Multiline = true;
            this.txtValores2.Name = "txtValores2";
            this.txtValores2.Size = new System.Drawing.Size(143, 113);
            this.txtValores2.TabIndex = 7;
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.BackColor = System.Drawing.Color.White;
            this.lblResultado.Font = new System.Drawing.Font("MS PGothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(226, 119);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(26, 27);
            this.lblResultado.TabIndex = 8;
            this.lblResultado.Text = "0";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(195, 153);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(33, 41);
            this.button2.TabIndex = 9;
            this.button2.Text = "C";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LimeGreen;
            this.ClientSize = new System.Drawing.Size(302, 206);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.txtValores2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnMult);
            this.Controls.Add(this.btnDividir);
            this.Controls.Add(this.btnSub);
            this.Controls.Add(this.btnSoma);
            this.Controls.Add(this.txtValores);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtValores;
        private System.Windows.Forms.Button btnSoma;
        private System.Windows.Forms.Button btnSub;
        private System.Windows.Forms.Button btnDividir;
        private System.Windows.Forms.Button btnMult;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValores2;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button button2;
    }
}

