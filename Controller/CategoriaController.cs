﻿using MySql.Data.MySqlClient;
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
    internal class CategoriaController
    {
        public DataTable GetCategorias()
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao())
            {
                try
                {
                    string sql = $"SELECT categorias.id_categoria AS 'Código', categorias.categoria AS 'Categoria' FROM categorias WHERE categorias.usuario = '{UserSession.usuario + "@localhost"}';";

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

        public bool AddCategoria(string categoria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao(UserSession.usuario, UserSession.senha))
            {
                try
                {
                    conn.Open();

                    string sql = "INSERT INTO categorias (categoria) VALUES (@valorCategoria);";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valorCategoria", categoria);

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
                    MessageBox.Show($"ERRO AO CADASTRAR: {e.Message}");
                    return false;
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        public bool DropCategoria(int chavePrimaria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao(UserSession.usuario, UserSession.senha))
            {
                try
                {
                    conn.Open();
                    string sql = "DELETE FROM categorias WHERE id_categoria = @valor;";

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

        public bool AlterCategoria(int id, string newCategoria)
        {
            using (MySqlConnection conn = ConexaoDB.CriaConexao(UserSession.usuario, UserSession.senha))
            {
                try
                {
                    conn.Open();

                    string sql = "UPDATE categorias SET categoria = @valorcategoria WHERE id_categoria = @valorId;";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@valorId", id);
                    cmd.Parameters.AddWithValue("@valorcategoria", newCategoria);

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
                    MessageBox.Show($"ERRO AO ALTERAR CATEGORIA: {e.Message}");
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
