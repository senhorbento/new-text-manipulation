namespace Text_Manipulation
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
            this.NmBxQtd = new System.Windows.Forms.NumericUpDown();
            this.LbPergunta = new System.Windows.Forms.Label();
            this.BtOk = new System.Windows.Forms.Button();
            this.BtCancelar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NmBxQtd)).BeginInit();
            this.SuspendLayout();
            // 
            // NmBxQtd
            // 
            this.NmBxQtd.BackColor = System.Drawing.Color.Silver;
            this.NmBxQtd.Location = new System.Drawing.Point(114, 55);
            this.NmBxQtd.Name = "NmBxQtd";
            this.NmBxQtd.Size = new System.Drawing.Size(45, 23);
            this.NmBxQtd.TabIndex = 0;
            this.NmBxQtd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // LbPergunta
            // 
            this.LbPergunta.AutoSize = true;
            this.LbPergunta.Location = new System.Drawing.Point(12, 19);
            this.LbPergunta.Name = "LbPergunta";
            this.LbPergunta.Size = new System.Drawing.Size(272, 15);
            this.LbPergunta.TabIndex = 1;
            this.LbPergunta.Text = "Quantos endereços deseja abrir simultaneamente?";
            // 
            // BtOk
            // 
            this.BtOk.Location = new System.Drawing.Point(218, 106);
            this.BtOk.Name = "BtOk";
            this.BtOk.Size = new System.Drawing.Size(75, 23);
            this.BtOk.TabIndex = 2;
            this.BtOk.Text = "OK";
            this.BtOk.UseVisualStyleBackColor = true;
            this.BtOk.Click += new System.EventHandler(this.BtOk_Click);
            // 
            // BtCancelar
            // 
            this.BtCancelar.Location = new System.Drawing.Point(137, 106);
            this.BtCancelar.Name = "BtCancelar";
            this.BtCancelar.Size = new System.Drawing.Size(75, 23);
            this.BtCancelar.TabIndex = 3;
            this.BtCancelar.Text = "Cancelar";
            this.BtCancelar.UseVisualStyleBackColor = true;
            this.BtCancelar.Click += new System.EventHandler(this.BtCancelar_Click);
            // 
            // JanelaAuxiliar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(305, 141);
            this.ControlBox = false;
            this.Controls.Add(this.BtCancelar);
            this.Controls.Add(this.BtOk);
            this.Controls.Add(this.LbPergunta);
            this.Controls.Add(this.NmBxQtd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "JanelaAuxiliar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Confirmação";
            ((System.ComponentModel.ISupportInitialize)(this.NmBxQtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private NumericUpDown NmBxQtd;
        private Label LbPergunta;
        private Button BtOk;
        private Button BtCancelar;
    }
}