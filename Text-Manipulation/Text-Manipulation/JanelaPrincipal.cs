namespace Text_Manipulation
{
    public partial class JanelaPrincipal : Form
    {
        const int _INTERSECAO_ = 1;
        const int _FILTRO_     = 2;
        const int _UNIAO_      = 3;

        const int _WPP_        = 10;

        const int _ABRIR_LINK_ = 20;
        const int _TESTAR_IPS_ = 21;

        public JanelaPrincipal()
        {
            InitializeComponent();
        }

        private void AbrirJanelaConjuntos(int funcao)
        {
            var janela = new JanelaConjuntos();
            janela.SetFuncao(funcao);
            janela.DefinirNomeJanela();
            janela.ShowDialog();
        }

        private void AbrirJanelaSimples(int funcao)
        {
            var janela = new JanelaSimples();
            janela.SetFuncao(funcao);
            janela.DefinirNomeJanela();
            janela.ShowDialog();
        }

        private void AbrirJanelaLinks(int funcao)
        {
            var janela = new JanelaLinks();
            janela.SetFuncao(funcao);
            janela.DefinirNomeJanela();
            janela.ShowDialog();
        }

        private void BtFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtIntersecao_Click(object sender, EventArgs e)
        {
            AbrirJanelaConjuntos(_INTERSECAO_);
        }

        private void BtFiltro_Click(object sender, EventArgs e)
        {
            AbrirJanelaConjuntos(_FILTRO_);
        }

        private void BtUnião_Click(object sender, EventArgs e)
        {
            AbrirJanelaConjuntos(_UNIAO_);
        }

        private void BtWpp_Click(object sender, EventArgs e)
        {
            AbrirJanelaSimples(_WPP_);
        }

        private void BtIpTester_Click(object sender, EventArgs e)
        {
            AbrirJanelaLinks(_TESTAR_IPS_);
        }

        private void BtAbrirUrls_Click(object sender, EventArgs e)
        {
            AbrirJanelaLinks(_ABRIR_LINK_);
        }

        private void BtAjuda_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process AbrirNavegador = new System.Diagnostics.Process();
            AbrirNavegador.StartInfo.UseShellExecute = true;
            AbrirNavegador.StartInfo.FileName = "https://github.com/senhorbento/text_manipulation";
            AbrirNavegador.Start();
        } 
    }
}