namespace projeto_academia
{
    public partial class FrmLogin : Form
    {
        #region Atributos
            string strLogin = string.Empty;
            string strSenha = string.Empty;
            Usuario usuario = new Usuario();
        #endregion
        public FrmLogin()
        {
            strLogin = usuario._usuario;
            strSenha = usuario._senha;
            InitializeComponent();

        }

        
        private void btnLogin_Click(object sender, EventArgs e)
        {
            usuario.AcessoUsuario(strLogin, strSenha);
        }
    }
}