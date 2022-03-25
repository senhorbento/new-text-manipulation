namespace Text_Manipulation
{
    partial class JanelaPrincipal
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BtIntersecao = new System.Windows.Forms.Button();
            this.BtFiltro = new System.Windows.Forms.Button();
            this.BtUnião = new System.Windows.Forms.Button();
            this.BtWpp = new System.Windows.Forms.Button();
            this.BtFechar = new System.Windows.Forms.Button();
            this.BtAjuda = new System.Windows.Forms.Button();
            this.BtAbrirUrls = new System.Windows.Forms.Button();
            this.BtIpTester = new System.Windows.Forms.Button();
            this.LbConjuntos = new System.Windows.Forms.Label();
            this.LbLinks = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BtIntersecao
            // 
            this.BtIntersecao.Location = new System.Drawing.Point(13, 45);
            this.BtIntersecao.Margin = new System.Windows.Forms.Padding(4);
            this.BtIntersecao.Name = "BtIntersecao";
            this.BtIntersecao.Size = new System.Drawing.Size(75, 22);
            this.BtIntersecao.TabIndex = 0;
            this.BtIntersecao.Text = "Interseção";
            this.BtIntersecao.UseVisualStyleBackColor = true;
            this.BtIntersecao.Click += new System.EventHandler(this.BtIntersecao_Click);
            // 
            // BtFiltro
            // 
            this.BtFiltro.Location = new System.Drawing.Point(12, 75);
            this.BtFiltro.Margin = new System.Windows.Forms.Padding(4);
            this.BtFiltro.Name = "BtFiltro";
            this.BtFiltro.Size = new System.Drawing.Size(75, 22);
            this.BtFiltro.TabIndex = 1;
            this.BtFiltro.Text = "Filtro";
            this.BtFiltro.UseVisualStyleBackColor = true;
            this.BtFiltro.Click += new System.EventHandler(this.BtFiltro_Click);
            // 
            // BtUnião
            // 
            this.BtUnião.Location = new System.Drawing.Point(12, 105);
            this.BtUnião.Margin = new System.Windows.Forms.Padding(4);
            this.BtUnião.Name = "BtUnião";
            this.BtUnião.Size = new System.Drawing.Size(75, 22);
            this.BtUnião.TabIndex = 2;
            this.BtUnião.Text = "Uniao";
            this.BtUnião.UseVisualStyleBackColor = true;
            this.BtUnião.Click += new System.EventHandler(this.BtUnião_Click);
            // 
            // BtWpp
            // 
            this.BtWpp.Location = new System.Drawing.Point(146, 46);
            this.BtWpp.Margin = new System.Windows.Forms.Padding(4);
            this.BtWpp.Name = "BtWpp";
            this.BtWpp.Size = new System.Drawing.Size(75, 22);
            this.BtWpp.TabIndex = 3;
            this.BtWpp.Text = "Whatsapp";
            this.BtWpp.UseVisualStyleBackColor = true;
            this.BtWpp.Click += new System.EventHandler(this.BtWpp_Click);
            // 
            // BtFechar
            // 
            this.BtFechar.Location = new System.Drawing.Point(147, 226);
            this.BtFechar.Margin = new System.Windows.Forms.Padding(4);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(75, 22);
            this.BtFechar.TabIndex = 4;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.UseVisualStyleBackColor = true;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // BtAjuda
            // 
            this.BtAjuda.Location = new System.Drawing.Point(12, 225);
            this.BtAjuda.Name = "BtAjuda";
            this.BtAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtAjuda.TabIndex = 5;
            this.BtAjuda.Text = "Ajuda";
            this.BtAjuda.UseVisualStyleBackColor = true;
            this.BtAjuda.Click += new System.EventHandler(this.BtAjuda_Click);
            // 
            // BtAbrirUrls
            // 
            this.BtAbrirUrls.Location = new System.Drawing.Point(146, 104);
            this.BtAbrirUrls.Name = "BtAbrirUrls";
            this.BtAbrirUrls.Size = new System.Drawing.Size(75, 23);
            this.BtAbrirUrls.TabIndex = 6;
            this.BtAbrirUrls.Text = "Abrir links";
            this.BtAbrirUrls.UseVisualStyleBackColor = true;
            this.BtAbrirUrls.Click += new System.EventHandler(this.BtAbrirUrls_Click);
            // 
            // BtIpTester
            // 
            this.BtIpTester.Location = new System.Drawing.Point(146, 75);
            this.BtIpTester.Name = "BtIpTester";
            this.BtIpTester.Size = new System.Drawing.Size(75, 23);
            this.BtIpTester.TabIndex = 7;
            this.BtIpTester.Text = "Testador";
            this.BtIpTester.UseVisualStyleBackColor = true;
            this.BtIpTester.Click += new System.EventHandler(this.BtIpTester_Click);
            // 
            // LbConjuntos
            // 
            this.LbConjuntos.AutoSize = true;
            this.LbConjuntos.Location = new System.Drawing.Point(12, 9);
            this.LbConjuntos.Name = "LbConjuntos";
            this.LbConjuntos.Size = new System.Drawing.Size(65, 15);
            this.LbConjuntos.TabIndex = 8;
            this.LbConjuntos.Text = "Conjuntos:";
            // 
            // LbLinks
            // 
            this.LbLinks.AutoSize = true;
            this.LbLinks.Location = new System.Drawing.Point(146, 9);
            this.LbLinks.Name = "LbLinks";
            this.LbLinks.Size = new System.Drawing.Size(37, 15);
            this.LbLinks.TabIndex = 9;
            this.LbLinks.Text = "Links:";
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(234, 261);
            this.ControlBox = false;
            this.Controls.Add(this.LbLinks);
            this.Controls.Add(this.LbConjuntos);
            this.Controls.Add(this.BtIpTester);
            this.Controls.Add(this.BtAbrirUrls);
            this.Controls.Add(this.BtAjuda);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.BtWpp);
            this.Controls.Add(this.BtUnião);
            this.Controls.Add(this.BtFiltro);
            this.Controls.Add(this.BtIntersecao);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MdiChildrenMinimizedAnchorBottom = false;
            this.Name = "JanelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulação de textos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button BtIntersecao;
        private Button BtFiltro;
        private Button BtUnião;
        private Button BtWpp;
        private Button BtFechar;
        private Button BtAjuda;
        private Button BtAbrirUrls;
        private Button BtIpTester;
        private Label LbConjuntos;
        private Label LbLinks;
    }
}