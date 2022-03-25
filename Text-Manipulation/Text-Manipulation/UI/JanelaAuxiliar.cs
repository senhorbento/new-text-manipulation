using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Text_Manipulation
{
    public partial class JanelaAuxiliar : Form
    {
        JanelaLinks JT = new JanelaLinks();
        public JanelaAuxiliar()
        {
            InitializeComponent();
        }
        public JanelaAuxiliar(JanelaLinks janela)
        {
            InitializeComponent();
            JT = janela;
        }
        
        private void BtCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtOk_Click(object sender, EventArgs e)
        {
            JT.SetQuantidade(int.Parse(NmBxQtd.Text));
            this.Close();
        }
    }
}
