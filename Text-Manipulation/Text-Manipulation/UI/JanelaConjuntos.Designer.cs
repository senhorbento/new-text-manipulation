namespace Text_Manipulation
{
    partial class JanelaConjuntos
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
            this.LbLista1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxBxLista1 = new System.Windows.Forms.TextBox();
            this.TxBxLista2 = new System.Windows.Forms.TextBox();
            this.BtLista1 = new System.Windows.Forms.Button();
            this.BtLista2 = new System.Windows.Forms.Button();
            this.BtExportar = new System.Windows.Forms.Button();
            this.BtAbrir = new System.Windows.Forms.Button();
            this.LbTitulo = new System.Windows.Forms.Label();
            this.BtAjuda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LbLista1
            // 
            this.LbLista1.AutoSize = true;
            this.LbLista1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LbLista1.Location = new System.Drawing.Point(33, 63);
            this.LbLista1.Name = "LbLista1";
            this.LbLista1.Size = new System.Drawing.Size(61, 15);
            this.LbLista1.TabIndex = 0;
            this.LbLista1.Text = "Arquivo 1:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Arquivo 2:";
            // 
            // TxBxLista1
            // 
            this.TxBxLista1.Location = new System.Drawing.Point(115, 60);
            this.TxBxLista1.Name = "TxBxLista1";
            this.TxBxLista1.Size = new System.Drawing.Size(313, 23);
            this.TxBxLista1.TabIndex = 2;
            // 
            // TxBxLista2
            // 
            this.TxBxLista2.Location = new System.Drawing.Point(115, 107);
            this.TxBxLista2.Name = "TxBxLista2";
            this.TxBxLista2.Size = new System.Drawing.Size(313, 23);
            this.TxBxLista2.TabIndex = 3;
            // 
            // BtLista1
            // 
            this.BtLista1.Location = new System.Drawing.Point(434, 60);
            this.BtLista1.Name = "BtLista1";
            this.BtLista1.Size = new System.Drawing.Size(30, 23);
            this.BtLista1.TabIndex = 4;
            this.BtLista1.Text = "...";
            this.BtLista1.UseVisualStyleBackColor = true;
            this.BtLista1.Click += new System.EventHandler(this.BtLista1_Click_1);
            // 
            // BtLista2
            // 
            this.BtLista2.Location = new System.Drawing.Point(434, 106);
            this.BtLista2.Name = "BtLista2";
            this.BtLista2.Size = new System.Drawing.Size(30, 23);
            this.BtLista2.TabIndex = 5;
            this.BtLista2.Text = "...";
            this.BtLista2.UseVisualStyleBackColor = true;
            this.BtLista2.Click += new System.EventHandler(this.BtLista2_Click);
            // 
            // BtExportar
            // 
            this.BtExportar.Location = new System.Drawing.Point(434, 249);
            this.BtExportar.Name = "BtExportar";
            this.BtExportar.Size = new System.Drawing.Size(75, 23);
            this.BtExportar.TabIndex = 6;
            this.BtExportar.Text = "Exportar";
            this.BtExportar.UseVisualStyleBackColor = true;
            this.BtExportar.Click += new System.EventHandler(this.BtExportar_Click);
            // 
            // BtAbrir
            // 
            this.BtAbrir.Location = new System.Drawing.Point(353, 249);
            this.BtAbrir.Name = "BtAbrir";
            this.BtAbrir.Size = new System.Drawing.Size(75, 23);
            this.BtAbrir.TabIndex = 7;
            this.BtAbrir.Text = "Abrir";
            this.BtAbrir.UseVisualStyleBackColor = true;
            this.BtAbrir.Click += new System.EventHandler(this.LbGerar_Click);
            // 
            // LbTitulo
            // 
            this.LbTitulo.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LbTitulo.AutoSize = true;
            this.LbTitulo.Enabled = false;
            this.LbTitulo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LbTitulo.Location = new System.Drawing.Point(12, 9);
            this.LbTitulo.Name = "LbTitulo";
            this.LbTitulo.Size = new System.Drawing.Size(49, 21);
            this.LbTitulo.TabIndex = 8;
            this.LbTitulo.Text = "Titulo";
            // 
            // BtAjuda
            // 
            this.BtAjuda.Location = new System.Drawing.Point(12, 249);
            this.BtAjuda.Name = "BtAjuda";
            this.BtAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtAjuda.TabIndex = 9;
            this.BtAjuda.Text = "Ajuda";
            this.BtAjuda.UseVisualStyleBackColor = true;
            this.BtAjuda.Click += new System.EventHandler(this.BtAjuda_Click);
            // 
            // JanelaConjuntos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(534, 286);
            this.Controls.Add(this.BtAjuda);
            this.Controls.Add(this.LbTitulo);
            this.Controls.Add(this.BtAbrir);
            this.Controls.Add(this.BtExportar);
            this.Controls.Add(this.BtLista2);
            this.Controls.Add(this.BtLista1);
            this.Controls.Add(this.TxBxLista2);
            this.Controls.Add(this.TxBxLista1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LbLista1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "JanelaConjuntos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "JanelaAção";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label LbLista1;
        private Label label2;
        private TextBox TxBxLista1;
        private TextBox TxBxLista2;
        private Button BtLista1;
        private Button BtLista2;
        private Button BtExportar;
        private Button BtAbrir;
        private Label LbTitulo;
        private Button BtAjuda;
    }
}