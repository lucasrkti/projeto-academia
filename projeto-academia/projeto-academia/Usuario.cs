using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projeto_academia
{
    public class Usuario : Pessoa
    {
        #region Atributos
        private string usuario = string.Empty;
        private string senha = string.Empty;

        public string _usuario { get => usuario; set => usuario = value; }

        public string _senha { get => senha; private set => senha = value; }

        Pessoa UsuarioAcademia = new Pessoa();

        #endregion

        #region Construtor
        public string AcessoUsuario (string usuario, string senha)
        {
         
            if (usuario == _usuario )
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
