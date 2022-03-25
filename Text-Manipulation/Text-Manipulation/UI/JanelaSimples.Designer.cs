namespace Text_Manipulation
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
            this.LbTitulo = new System.Windows.Forms.Label();
            this.BtAbrir = new System.Windows.Forms.Button();
            this.BtExportar = new System.Windows.Forms.Button();
            this.BtLista1 = new System.Windows.Forms.Button();
            this.TxBxLista1 = new System.Windows.Forms.TextBox();
            this.LbLista1 = new System.Windows.Forms.Label();
            this.BtAjuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbTitulo
            // 
            this.LbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Enabled = false;
            this.LbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitulo.Location = new System.Drawing.Point(19, 12);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(49, 21);
            this.LbTitulo.TabIndex = 17;
            this.LbTitulo.Text = "Titulo";
            // 
            // BtAbrir
            // 
            this.BtAbrir.Location = new System.Drawing.Point(360, 252);
            this.BtAbrir.Name = "BtAbrir";
            this.BtAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtAbrir.TabIndex = 16;
            this.BtAbrir.Text = "Abrir";
            this.BtAbrir.UseVisualStyleBackColor = true;
            this.BtAbrir.Click += new System.EventHandler(this.BtAbrir_Click);
            // 
            // BtExportar
            // 
            this.BtExportar.Location = new System.Drawing.Point(441, 252);
            this.BtExportar.Name = "BtExportar";
            this.BtExportar.Size = new System.Drawing.Size(75, 23);
            this.BtExportar.TabIndex = 15;
            this.BtExportar.Text = "Exportar";
            this.BtExportar.UseVisualStyleBackColor = true;
            this.BtExportar.Click += new System.EventHandler(this.BtExportar_Click);
            // 
            // BtLista1
            // 
            this.BtLista1.Location = new System.Drawing.Point(441, 63);
            this.BtLista1.Name = "BtLista1";
            this.BtLista1.Size = new System.Drawing.Size(30, 23);
            this.BtLista1.TabIndex = 13;
            this.BtLista1.Text = "...";
            this.BtLista1.UseVisualStyleBackColor = true;
            this.BtLista1.Click += new System.EventHandler(this.BtLista1_Click);
            // 
            // TxBxLista1
            // 
            this.TxBxLista1.Location = new System.Drawing.Point(122, 63);
            this.TxBxLista1.Name = "TxBxLista1";
            this.TxBxLista1.Size = new System.Drawing.Size(313, 23);
            this.TxBxLista1.TabIndex = 11;
            // 
            // LbLista1
            // 
            this.LbLista1.AutoSize = true;
            this.LbLista1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbLista1.Location = new System.Drawing.Point(40, 66);
            this.LbLista1.Name = "LbLista1";
            this.LbLista1.Size = new System.Drawing.Size(61, 15);
            this.LbLista1.TabIndex = 9;
            this.LbLista1.Text = "Arquivo 1:";
            // 
            // BtAjuda
            // 
            this.BtAjuda.Location = new System.Drawing.Point(19, 252);
            this.BtAjuda.Name = "BtAjuda";
            this.BtAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtAjuda.TabIndex = 18;
            this.BtAjuda.Text = "Ajuda";
            this.BtAjuda.UseVisualStyleBackColor = true;
            // 
            // JanelaSimples
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(534, 286);
            this.Controls.Add(this.BtAjuda);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.BtAbrir);
            this.Controls.Add(this.BtExportar);
            this.Controls.Add(this.BtLista1);
            this.Controls.Add(this.TxBxLista1);
            this.Controls.Add(this.LbLista1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "JanelaSimples";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaTerciaria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbTitulo;
        private Button BtAbrir;
        private Button BtExportar;
        private Button BtLista1;
        private TextBox TxBxLista1;
        private Label LbLista1;
        private Button BtAjuda;
    }
}