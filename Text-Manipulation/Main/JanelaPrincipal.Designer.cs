namespace Text_Manipulation
{
    partial class JanelaPrincipal
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
            this.BtAjuda = new System.Windows.Forms.Button();
            this.BtFechar = new System.Windows.Forms.Button();
            this.BtIntersecao = new System.Windows.Forms.Button();
            this.BtFiltro = new System.Windows.Forms.Button();
            this.BtUniao = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.BtWpp = new System.Windows.Forms.Button();
            this.BtTestador = new System.Windows.Forms.Button();
            this.BtAbrirUrls = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtAjuda
            // 
            this.BtAjuda.Location = new System.Drawing.Point(21, 222);
            this.BtAjuda.Name = "BtAjuda";
            this.BtAjuda.Size = new System.Drawing.Size(75, 23);
            this.BtAjuda.TabIndex = 0;
            this.BtAjuda.Text = "Ajuda";
            this.BtAjuda.UseVisualStyleBackColor = true;
            this.BtAjuda.Click += new System.EventHandler(this.BtAjuda_Click);
            // 
            // BtFechar
            // 
            this.BtFechar.Location = new System.Drawing.Point(137, 222);
            this.BtFechar.Name = "BtFechar";
            this.BtFechar.Size = new System.Drawing.Size(75, 23);
            this.BtFechar.TabIndex = 1;
            this.BtFechar.Text = "Fechar";
            this.BtFechar.UseVisualStyleBackColor = true;
            this.BtFechar.Click += new System.EventHandler(this.BtFechar_Click);
            // 
            // BtIntersecao
            // 
            this.BtIntersecao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIntersecao.Location = new System.Drawing.Point(8, 33);
            this.BtIntersecao.Name = "BtIntersecao";
            this.BtIntersecao.Size = new System.Drawing.Size(75, 23);
            this.BtIntersecao.TabIndex = 2;
            this.BtIntersecao.Text = "Interseção";
            this.BtIntersecao.UseVisualStyleBackColor = true;
            this.BtIntersecao.Click += new System.EventHandler(this.BtIntersecao_Click);
            // 
            // BtFiltro
            // 
            this.BtFiltro.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtFiltro.Location = new System.Drawing.Point(8, 62);
            this.BtFiltro.Name = "BtFiltro";
            this.BtFiltro.Size = new System.Drawing.Size(75, 23);
            this.BtFiltro.TabIndex = 4;
            this.BtFiltro.Text = "Filtro";
            this.BtFiltro.UseVisualStyleBackColor = true;
            this.BtFiltro.Click += new System.EventHandler(this.BtFiltro_Click);
            // 
            // BtUniao
            // 
            this.BtUniao.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtUniao.Location = new System.Drawing.Point(8, 91);
            this.BtUniao.Name = "BtUniao";
            this.BtUniao.Size = new System.Drawing.Size(75, 23);
            this.BtUniao.TabIndex = 6;
            this.BtUniao.Text = "União";
            this.BtUniao.UseVisualStyleBackColor = true;
            this.BtUniao.Click += new System.EventHandler(this.BtUniao_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.BtIntersecao);
            this.groupBox1.Controls.Add(this.BtFiltro);
            this.groupBox1.Controls.Add(this.BtUniao);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(89, 133);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Conjuntos:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.BtWpp);
            this.groupBox2.Controls.Add(this.BtTestador);
            this.groupBox2.Controls.Add(this.BtAbrirUrls);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(129, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(89, 133);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Links:";
            // 
            // BtWpp
            // 
            this.BtWpp.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtWpp.Location = new System.Drawing.Point(8, 33);
            this.BtWpp.Name = "BtWpp";
            this.BtWpp.Size = new System.Drawing.Size(75, 23);
            this.BtWpp.TabIndex = 2;
            this.BtWpp.Text = "Whatsapp";
            this.BtWpp.UseVisualStyleBackColor = true;
            this.BtWpp.Click += new System.EventHandler(this.BtWpp_Click);
            // 
            // BtTestador
            // 
            this.BtTestador.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtTestador.Location = new System.Drawing.Point(8, 62);
            this.BtTestador.Name = "BtTestador";
            this.BtTestador.Size = new System.Drawing.Size(75, 23);
            this.BtTestador.TabIndex = 4;
            this.BtTestador.Text = "Testar IPs";
            this.BtTestador.UseVisualStyleBackColor = true;
            this.BtTestador.Click += new System.EventHandler(this.BtTestador_Click);
            // 
            // BtAbrirUrls
            // 
            this.BtAbrirUrls.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtAbrirUrls.Location = new System.Drawing.Point(8, 91);
            this.BtAbrirUrls.Name = "BtAbrirUrls";
            this.BtAbrirUrls.Size = new System.Drawing.Size(75, 23);
            this.BtAbrirUrls.TabIndex = 6;
            this.BtAbrirUrls.Text = "Abrir links";
            this.BtAbrirUrls.UseVisualStyleBackColor = true;
            this.BtAbrirUrls.Click += new System.EventHandler(this.BtAbrirUrls_Click);
            // 
            // JanelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(230, 257);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.BtFechar);
            this.Controls.Add(this.BtAjuda);
            this.Name = "JanelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manipulação de textos";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtAjuda;
        private System.Windows.Forms.Button BtFechar;
        private System.Windows.Forms.Button BtIntersecao;
        private System.Windows.Forms.Button BtFiltro;
        private System.Windows.Forms.Button BtUniao;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button BtWpp;
        private System.Windows.Forms.Button BtTestador;
        private System.Windows.Forms.Button BtAbrirUrls;
    }
}

