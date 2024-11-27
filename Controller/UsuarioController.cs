using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using projetoAgendaSolo.Data;
using projetoAgendaSolo.VariableGlobal;
using projetoAgendaSolo.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace projetoAgendaSolo.Controller
{
    internal class UsuarioController
    {
        public bool addUsuario(string nome, string usuario, string telefone, string senha)
        {
            MySqlConnection conn = null;
            try
            {
                conn = ConexaoDB.CriaConexao();
                conn.Open();
                string sql = $"INSERT INTO usuarios (nome, usuario, telefone, senha) VALUES (@nome, @usuario, @telefone, @senha);" +
                    $"CREATE USER '{usuario}'@'%' IDENTIFIED BY '{senha}';" +
                    $"GRANT select, insert, delete, update on dbagenda.* to '{usuario}'@'%';";
                MySqlCommand cmd = new MySqlCommand(sql, conn);

                cmd.Parameters.AddWithValue("@nome", nome);
                cmd.Parameters.AddWithValue("@usuario", usuario);
                cmd.Parameters.AddWithValue("@telefone", telefone);
                cmd.Parameters.AddWithValue("@senha", senha);

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

        public bool ValidaLogin(string usuario, string senha)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    conn.Open();

                    string sql = "SELECT usuarios.idUsuario, usuarios.nome AS 'nome', usuarios.usuario, usuarios.telefone FROM usuarios WHERE usuario = @valorUsuario AND BINARY senha = @valorSenha;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valorUsuario", usuario);
                    cmd.Parameters.AddWithValue("@valorSenha", senha);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            UserSession.usuario = usuario;
                            UserSession.senha = senha;
                            UserSession.nome = reader.GetString("nome");

                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }



                }
                catch (Exception e)
                {
                    MessageBox.Show($"ERRO AO FAZER LOGIN: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        //public DataTable GetUsuario()
        //{
        //    using (MySqlConnection conn = ConexaoDB.CriaConexao())
        //    {
        //        try
        //        {
        //            string sql = "SELECT usuarios.idusuarios AS 'Código', usuarios.nome AS 'Nome', usuarios.usuario AS 'Usuário', usuarios.telefone AS 'Telefône' FROM usuarios;";

        //            conn.Open();

        //            MySqlDataAdapter adapter = new MySqlDataAdapter(sql, conn);

        //            DataTable dt = new DataTable();

        //            adapter.Fill(dt);

        //            return dt;
        //        }
        //        catch (Exception e)
        //        {
        //            MessageBox.Show($"ERRO AO BUSCAR USUÁRIOS: {e.Message}");
        //            return new DataTable();
        //        }
        //        finally
        //        {
        //            conn.Close();
        //        }
        //    }
        //}

        public bool DropUser(int id)
        {
            using(MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    conn.Open();

                    string sql = "DELETE FROM usuarios WHERE idusuarios = @ValorId;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@ValorId", id);

                    int linhasAfetadas = cmd.ExecuteNonQuery();

                    if(linhasAfetadas > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }catch (Exception e)
                {
                    MessageBox.Show($"ERRO AO DELETAR USUÁRIO: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool AlterUser(int id, string nome, string usuario, string telefone, string senha)
        {
            using(MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE usuarios SET nome = @valorNome, usuario = @valorUsuario, telefone = @valorTelefone, senha = @valorSenha WHERE idUsuario = @valorId;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valorId", id);
                    cmd.Parameters.AddWithValue("@valorNome", nome);
                    cmd.Parameters.AddWithValue("@valorUsuario", usuario);
                    cmd.Parameters.AddWithValue("@valorTelefone", telefone);
                    cmd.Parameters.AddWithValue("@valorSenha", senha);

                    int linasAfetadas = cmd.ExecuteNonQuery();

                    if( linasAfetadas > 0)
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
                    MessageBox.Show($"ERRO AO ALTERAR CADASTRO: {e.Message}");
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
