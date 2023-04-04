using System.DirectoryServices;

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
          
            InitializeComponent();
            txtSenha.PasswordChar= '*';
            usuario.nome = string.Empty;
        }

        
       

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            usuario.nome = txtNome.Text.Trim();
            strLogin = txtLogin.Text.Trim();
            strSenha = txtSenha.Text.Trim();
            usuario.AcessoUsuario(usuario.nome, strLogin, strSenha);
            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Text = string.Empty;
            txtLogin.Text = string.Empty;
            txtSenha.Text = string.Empty;
        }
    }
}