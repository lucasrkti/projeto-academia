using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using Npgsql;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace projeto_academia
{
    internal class DAL
    {
        static string EndServidor = "127.0.0.1";
        static string PortaServidor = "5432";
        static string NomeServidor = "postgres";
        static string Senha = "password";
        static string NomeBanco = "academia";
        NpgsqlConnection Conexao = null;
        string connString = null;

        public DAL()
        {
            connString = String.Format("Server={0};Port={1};User Id={2};Password={3};Database={4};",
                                              EndServidor, PortaServidor, NomeServidor, Senha, NomeBanco);
        }

        public void InserirRegistro(string nome, string login, string senha)
        {
            try
            {
                using (NpgsqlConnection pgsqlConnection = new NpgsqlConnection(connString))
                {
                    //Abra a conexão com o PgSQL                  
                    pgsqlConnection.Open();

                    string cmdInserir = String.Format("Insert Into usuarios(nome,login,senha) values('{0}','{1}',{2})", nome, login, senha);

                    using (NpgsqlCommand pgsqlcommand = new NpgsqlCommand(cmdInserir, pgsqlConnection))
                    {
                        pgsqlcommand.ExecuteNonQuery();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                throw ex;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                Conexao.Close();
            }
        }

    }
    
}
