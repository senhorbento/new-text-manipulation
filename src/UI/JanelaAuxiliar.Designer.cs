namespace Text_Manipulation.UI
{
    partial class JanelaAuxiliar
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
            this.BtContinuar = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            this.LbPergunta = new System.Windows.Forms.Label();
            this.NmBxQtd = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.NmBxQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // BtContinuar
            // 
            this.BtContinuar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtContinuar.Location = new System.Drawing.Point(125, 106);
            this.BtContinuar.Name = "BtContinuar";
            this.BtContinuar.Size = new System.Drawing.Size(75, 23);
            this.BtContinuar.TabIndex = 0;
            this.BtContinuar.Text = "Continuar";
            this.BtContinuar.UseVisualStyleBackColor = true;
            this.BtContinuar.Click += new System.EventHandler(this.BtContinuar_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtCancelar.Location = new System.Drawing.Point(206, 106);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 1;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // LbPergunta
            // 
            this.LbPergunta.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LbPergunta.AutoSize = true;
            this.LbPergunta.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LbPergunta.Location = new System.Drawing.Point(30, 27);
            this.LbPergunta.Name = "LbPergunta";
            this.LbPergunta.Size = new System.Drawing.Size(266, 13);
            this.LbPergunta.TabIndex = 2;
            this.LbPergunta.Text = "Quantos endereços deseja abrir simultaneamente?";
            this.LbPergunta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NmBxQtd
            // 
            this.NmBxQtd.Location = new System.Drawing.Point(141, 63);
            this.NmBxQtd.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.NmBxQtd.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NmBxQtd.Name = "NmBxQtd";
            this.NmBxQtd.Size = new System.Drawing.Size(46, 20);
            this.NmBxQtd.TabIndex = 3;
            this.NmBxQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // JanelaAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(329, 141);
            this.ControlBox = false;
            this.Controls.Add(this.NmBxQtd);
            this.Controls.Add(this.LbPergunta);
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtContinuar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "JanelaAuxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pergunta";
            ((System.ComponentModel.ISupportInitialize)(this.NmBxQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtContinuar;
        private System.Windows.Forms.Button BtCancelar;
        private System.Windows.Forms.Label LbPergunta;
        private System.Windows.Forms.NumericUpDown NmBxQtd;
    }
}