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
            using (MySqlConnection conn = new MySqlConnection())
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
    }
}
