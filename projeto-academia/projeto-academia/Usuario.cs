using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace projeto_academia
{
    public class Usuario : Pessoa
    {
        #region Atributos
        private string nome = string.Empty;
        private string usuario = string.Empty;
        private string senha = string.Empty;

        public string _nome { get => nome; set => nome = value; }
        public string _usuario { get => usuario; private set => usuario = value; }
        public string _senha { get => senha; private set => senha = value; }

        Pessoa UsuarioAcademia = new Pessoa();
        
        #endregion

        #region Construtor
        public string AcessoUsuario (string nome, string usuario, string senha)
        {
            nome = UsuarioAcademia.nome;
            
            if (usuario == usuario && senha == senha && nome == nome) // contexto do banco nas variaveis
            {
                //acesso ok, salvar no banco
            }
            else
            {
                //ususario ou senha invalidos
            }

            return null;
            
        }
        public string CadastroUsuario(string nome, string usuario, string senha)
        {

            

            if (usuario == _usuario)
            {
                //acesso ok
            }
            else
            {
                //ususario ou senha invalidos
            }

            return null;

        }
        #endregion

        #region Métodos
        #endregion

        #region Eventos
        #endregion
    }
}
