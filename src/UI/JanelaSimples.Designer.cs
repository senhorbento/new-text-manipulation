namespace Text_Manipulation.UI
{
    partial class JanelaSimples
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
            this.BtExportar = new System.Windows.Forms.Button();
            this.BtAjuda = new System.Windows.Forms.Button();
            this.BtLista1 = new System.Windows.Forms.Button();
            this.TxBxCaminho = new System.Windows.Forms.TextBox();
            this.LbLista1 = new System.Windows.Forms.Label();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.BtAbrir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtExportar
            // 
            this.BtExportar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtExportar.Location = new System.Drawing.Point(454, 257);
            this.BtExportar.Name = "BtExportar";
            this.BtExportar.Size = new System.Drawing.Size(75, 23);
            this.BtExportar.TabIndex = 12;
            this.BtExportar.Text = "Exportar";
            this.BtExportar.UseVisualStyleBackColor = true;
            this.BtExportar.Click += new System.EventHandler(this.BtExportar_Click);
            // 
            // BtAjuda
            // 
            this.BtAjuda.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAjuda.Location = new System.Drawing.Point(14, 257);
            this.BtAjuda.Name = "BtAjuda";
            this.BtAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtAjuda.TabIndex = 11;
            this.BtAjuda.Text = "Ajuda";
            this.BtAjuda.UseVisualStyleBackColor = true;
            this.BtAjuda.Click += new System.EventHandler(this.BtAjuda_Click);
            // 
            // BtLista1
            // 
            this.BtLista1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLista1.Location = new System.Drawing.Point(454, 75);
            this.BtLista1.Name = "BtLista1";
            this.BtLista1.Size = new System.Drawing.Size(30, 20);
            this.BtLista1.TabIndex = 10;
            this.BtLista1.Text = "...";
            this.BtLista1.UseVisualStyleBackColor = true;
            this.BtLista1.Click += new System.EventHandler(this.BtLista1_Click);
            // 
            // TxBxCaminho
            // 
            this.TxBxCaminho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxBxCaminho.Location = new System.Drawing.Point(128, 75);
            this.TxBxCaminho.Name = "TxBxCaminho";
            this.TxBxCaminho.Size = new System.Drawing.Size(320, 20);
            this.TxBxCaminho.TabIndex = 9;
            // 
            // LbLista1
            // 
            this.LbLista1.AutoSize = true;
            this.LbLista1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbLista1.Location = new System.Drawing.Point(58, 76);
            this.LbLista1.Name = "LbLista1";
            this.LbLista1.Size = new System.Drawing.Size(59, 15);
            this.LbLista1.TabIndex = 8;
            this.LbLista1.Text = "Números:";
            // 
            // LbTitulo
            // 
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbTitulo.Location = new System.Drawing.Point(10, 10);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(49, 21);
            this.LbTitulo.TabIndex = 7;
            this.LbTitulo.Text = "Titulo";
            // 
            // BtAbrir
            // 
            this.BtAbrir.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAbrir.Location = new System.Drawing.Point(373, 256);
            this.BtAbrir.Name = "BtAbrir";
            this.BtAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtAbrir.TabIndex = 13;
            this.BtAbrir.Text = "Abrir";
            this.BtAbrir.UseVisualStyleBackColor = true;
            this.BtAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // JanelaSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(539, 291);
            this.Controls.Add(this.BtAbrir);
            this.Controls.Add(this.BtExportar);
            this.Controls.Add(this.BtAjuda);
            this.Controls.Add(this.BtLista1);
            this.Controls.Add(this.TxBxCaminho);
            this.Controls.Add(this.LbLista1);
            this.Controls.Add(this.LbTitulo);
            this.MaximizeBox = false;
            this.Name = "JanelaSimples";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Simples";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtExportar;
        private System.Windows.Forms.Button BtAjuda;
        private System.Windows.Forms.Button BtLista1;
        private System.Windows.Forms.TextBox TxBxCaminho;
        private System.Windows.Forms.Label LbLista1;
        private System.Windows.Forms.Label LbTitulo;
        private System.Windows.Forms.Button BtAbrir;
    }
}