namespace WindowsFormsAppteste2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.bntsomar = new System.Windows.Forms.Button();
            this.bntlimpar = new System.Windows.Forms.Button();
            this.bntfechar = new System.Windows.Forms.Button();
            this.lblresultado = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero 1";
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(46, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(121, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Numero 2";
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(206, 73);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(100, 20);
            this.txt1.TabIndex = 2;
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(206, 128);
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(100, 20);
            this.txt2.TabIndex = 3;
            // 
            // bntsomar
            // 
            this.bntsomar.Location = new System.Drawing.Point(49, 212);
            this.bntsomar.Name = "bntsomar";
            this.bntsomar.Size = new System.Drawing.Size(75, 23);
            this.bntsomar.TabIndex = 4;
            this.bntsomar.Text = "somar";
            this.bntsomar.UseVisualStyleBackColor = true;
            this.bntsomar.Click += new System.EventHandler(this.bntsomar_Click);
            // 
            // bntlimpar
            // 
            this.bntlimpar.Location = new System.Drawing.Point(171, 212);
            this.bntlimpar.Name = "bntlimpar";
            this.bntlimpar.Size = new System.Drawing.Size(75, 23);
            this.bntlimpar.TabIndex = 5;
            this.bntlimpar.Text = "Limpar";
            this.bntlimpar.UseVisualStyleBackColor = true;
            this.bntlimpar.Click += new System.EventHandler(this.bntlimpar_Click);
            // 
            // bntfechar
            // 
            this.bntfechar.Location = new System.Drawing.Point(296, 212);
            this.bntfechar.Name = "bntfechar";
            this.bntfechar.Size = new System.Drawing.Size(75, 23);
            this.bntfechar.TabIndex = 6;
            this.bntfechar.Text = "fechar";
            this.bntfechar.UseVisualStyleBackColor = true;
            this.bntfechar.Click += new System.EventHandler(this.bntfechar_Click);
            // 
            // lblresultado
            // 
            this.lblresultado.AutoSize = true;
            this.lblresultado.Location = new System.Drawing.Point(49, 265);
            this.lblresultado.Name = "lblresultado";
            this.lblresultado.Size = new System.Drawing.Size(55, 13);
            this.lblresultado.TabIndex = 7;
            this.lblresultado.Text = "Resultado";
            // 
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(171, 265);
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(100, 20);
            this.txt3.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txt3);
            this.Controls.Add(this.lblresultado);
            this.Controls.Add(this.bntfechar);
            this.Controls.Add(this.bntlimpar);
            this.Controls.Add(this.bntsomar);
            this.Controls.Add(this.txt2);
            this.Controls.Add(this.txt1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Button bntsomar;
        private System.Windows.Forms.Button bntlimpar;
        private System.Windows.Forms.Button bntfechar;
        private System.Windows.Forms.Label lblresultado;
        private System.Windows.Forms.TextBox txt3;
    }
}

