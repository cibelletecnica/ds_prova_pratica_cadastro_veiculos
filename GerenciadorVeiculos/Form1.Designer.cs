namespace GerenciadorVeiculos
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
            this.txtModelo = new System.Windows.Forms.TextBox();
            this.txtPrecoBase = new System.Windows.Forms.TextBox();
            this.txtParametro = new System.Windows.Forms.TextBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.lblParametro = new System.Windows.Forms.Label();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtModelo
            // 
            this.txtModelo.Location = new System.Drawing.Point(100, 90);
            this.txtModelo.Name = "txtModelo";
            this.txtModelo.Size = new System.Drawing.Size(185, 20);
            this.txtModelo.TabIndex = 0;
            this.txtModelo.Text = "Digite o modelo do veículo";
            // 
            // txtPrecoBase
            // 
            this.txtPrecoBase.Location = new System.Drawing.Point(100, 132);
            this.txtPrecoBase.Name = "txtPrecoBase";
            this.txtPrecoBase.Size = new System.Drawing.Size(185, 20);
            this.txtPrecoBase.TabIndex = 1;
            this.txtPrecoBase.Text = "Digite o preço base";
            // 
            // txtParametro
            // 
            this.txtParametro.Location = new System.Drawing.Point(100, 216);
            this.txtParametro.Name = "txtParametro";
            this.txtParametro.Size = new System.Drawing.Size(185, 20);
            this.txtParametro.TabIndex = 2;
            this.txtParametro.Text = "Portas | Cilindradas";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(100, 276);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 3;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // lblParametro
            // 
            this.lblParametro.AutoSize = true;
            this.lblParametro.Location = new System.Drawing.Point(97, 250);
            this.lblParametro.Name = "lblParametro";
            this.lblParametro.Size = new System.Drawing.Size(16, 13);
            this.lblParametro.TabIndex = 4;
            this.lblParametro.Text = "...";
            // 
            // cmbTipo
            // 
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Carro",
            "Moto"});
            this.cmbTipo.Location = new System.Drawing.Point(100, 175);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(185, 21);
            this.cmbTipo.TabIndex = 5;
            this.cmbTipo.Text = "Tipo";
            this.cmbTipo.SelectedIndexChanged += new System.EventHandler(this.cmbTipo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.lblParametro);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtParametro);
            this.Controls.Add(this.txtPrecoBase);
            this.Controls.Add(this.txtModelo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtModelo;
        private System.Windows.Forms.TextBox txtPrecoBase;
        private System.Windows.Forms.TextBox txtParametro;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label lblParametro;
        private System.Windows.Forms.ComboBox cmbTipo;
    }
}

