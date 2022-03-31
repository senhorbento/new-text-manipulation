namespace Text_Manipulation.UI
{
    partial class JanelaLinks
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
            if (disposing && (components != null))
            {
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
            this.LbTitulo = new System.Windows.Forms.Label();
            this.LbLista1 = new System.Windows.Forms.Label();
            this.TxBxCaminho = new System.Windows.Forms.TextBox();
            this.BtLista1 = new System.Windows.Forms.Button();
            this.LbEnderecos = new System.Windows.Forms.Label();
            this.BtAjuda = new System.Windows.Forms.Button();
            this.BtExecutar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(8, 9);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(49, 21);
            this.LbTitulo.TabIndex = 0;
            this.LbTitulo.Text = "Titulo";
            // 
            // LbLista1
            // 
            this.LbLista1.AutoSize = true;
            this.LbLista1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLista1.Location = new System.Drawing.Point(56, 75);
            this.LbLista1.Name = "LbLista1";
            this.LbLista1.Size = new System.Drawing.Size(64, 15);
            this.LbLista1.TabIndex = 1;
            this.LbLista1.Text = "Endereços:";
            // 
            // TxBxCaminho
            // 
            this.TxBxCaminho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxBxCaminho.Location = new System.Drawing.Point(126, 74);
            this.TxBxCaminho.Name = "TxBxCaminho";
            this.TxBxCaminho.Size = new System.Drawing.Size(320, 20);
            this.TxBxCaminho.TabIndex = 2;
            // 
            // BtLista1
            // 
            this.BtLista1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLista1.Location = new System.Drawing.Point(452, 74);
            this.BtLista1.Name = "BtLista1";
            this.BtLista1.Size = new System.Drawing.Size(30, 20);
            this.BtLista1.TabIndex = 3;
            this.BtLista1.Text = "...";
            this.BtLista1.UseVisualStyleBackColor = true;
            this.BtLista1.Click += new System.EventHandler(this.BtLista1_Click);
            // 
            // LbEnderecos
            // 
            this.LbEnderecos.AutoSize = true;
            this.LbEnderecos.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbEnderecos.Location = new System.Drawing.Point(53, 145);
            this.LbEnderecos.Name = "LbEnderecos";
            this.LbEnderecos.Size = new System.Drawing.Size(78, 32);
            this.LbEnderecos.TabIndex = 4;
            this.LbEnderecos.Text = "label1";
            // 
            // BtAjuda
            // 
            this.BtAjuda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAjuda.Location = new System.Drawing.Point(12, 256);
            this.BtAjuda.Name = "BtAjuda";
            this.BtAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtAjuda.TabIndex = 5;
            this.BtAjuda.Text = "Ajuda";
            this.BtAjuda.UseVisualStyleBackColor = true;
            this.BtAjuda.Click += new System.EventHandler(this.BtAjuda_Click);
            // 
            // BtExecutar
            // 
            this.BtExecutar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExecutar.Location = new System.Drawing.Point(452, 256);
            this.BtExecutar.Name = "BtExecutar";
            this.BtExecutar.Size = new System.Drawing.Size(75, 23);
            this.BtExecutar.TabIndex = 6;
            this.BtExecutar.Text = "Executar";
            this.BtExecutar.UseVisualStyleBackColor = true;
            this.BtExecutar.Click += new System.EventHandler(this.BtExecutar_Click);
            // 
            // JanelaLinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(539, 291);
            this.Controls.Add(this.BtExecutar);
            this.Controls.Add(this.BtAjuda);
            this.Controls.Add(this.LbEnderecos);
            this.Controls.Add(this.BtLista1);
            this.Controls.Add(this.TxBxCaminho);
            this.Controls.Add(this.LbLista1);
            this.Controls.Add(this.LbTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "JanelaLinks";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Testador";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Label LbLista1;
        private System.Windows.Forms.TextBox TxBxCaminho;
        private System.Windows.Forms.Button BtLista1;
        private System.Windows.Forms.Label LbEnderecos;
        private System.Windows.Forms.Button BtAjuda;
        private System.Windows.Forms.Button BtExecutar;
    }
}