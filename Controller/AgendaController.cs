using MySql.Data.MySqlClient;
using projetoAgendaSolo.Data;
using projetoAgendaSolo.VariableGlobal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaSolo.Controller
{
    internal class AgendaController
    {

        public DataTable getAgenda()
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    string sql = $"SELECT agenda.id_agenda AS 'Código', agenda.nome AS 'Nome', agenda.telefone AS 'Telefone', agenda.categoria AS 'Categoria' FROM agenda WHERE agenda.usuario = '{UserSession.usuario + "@localhost"}';";

                    conn.Open();

                    MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

                    DataTable dt = new DataTable();

                    adapter.Fill(dt);

                    return dt;
                }
                catch (Exception e)
                {
                    MessageBox.Show($"ERRO AO BUSCAR CATEGORIAS: {e.Message}");
                    return new DataTable();
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool deleteAgenda(int chavePrimaria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao(UserSession.usuario, UserSession.senha))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM agenda WHERE id_agenda = @valor;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valor", chavePrimaria);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if (linhasAfetadas > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"Erro ao deletar: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool addContato(string nome, string telefone, string categoria)
        {
            MySqlConnection conn = null;
            try
            {
                conn = ConexaoDB.CriaConexao(UserSession.usuario, UserSession.senha);
                conn.Open();
                string sql = $"INSERT INTO agenda (nome, telefone, categoria) VALUES (@nome, @telefone, @categoria);";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@categoria", categoria);

                int linhasAfetadas = cmd.ExecuteNonQuery();

                if (linhasAfetadas > 0)
                {

                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                MessageBox.Show($"Erro ao cadastrar: {e.Message}");
                return false;
            }
            finally
            {
                conn.Close();
            }

        }

        public bool AlterContato(int id, string nome, string telefone, string categoria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao(UserSession.usuario, UserSession.senha))
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE agenda SET nome = @valorNome, telefone = @valorTelefone, categoria = @valorCategoria WHERE id_agenda = @valorId;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valorId", id);
                    cmd.Parameters.AddWithValue("@valorNome", nome);
                    cmd.Parameters.AddWithValue("@valorTelefone", telefone);
                    cmd.Parameters.AddWithValue("@valorCategoria", categoria);

                    int linasAfetadas = cmd.ExecuteNonQuery();

                    if (linasAfetadas > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show($"ERRO AO ALTERAR CONTATO: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }
    }
}
