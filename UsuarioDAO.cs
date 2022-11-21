using chama.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace chama.Modelo
{
    internal class UsuarioDAO
    {

        private Conexao Con { get; set; }
        private SqlCommand Cmd { get; set; }
        public UsuarioDAO()
        {
            Con = new Conexao();
            Cmd = new SqlCommand();
        }
        public void Inserir(Usuario usuario)
        {
            Cmd.Connection = Con.ReturnConnection();
            Cmd.CommandText = @"INSERT INTO USUARIO VALUES (@nome, @tel, @email, @usuario, @senha)";
            //testecomentario
            Cmd.Parameters.AddWithValue("@nome", usuario.Nome);
            Cmd.Parameters.AddWithValue("@tel", usuario.Telefone);
            Cmd.Parameters.AddWithValue("@email", usuario.Email);
            Cmd.Parameters.AddWithValue("@usuario", usuario.UsuarioSis);
            Cmd.Parameters.AddWithValue("@senha", usuario.Senha);
            // Cmd.Parameters.AddWithValue("@genero", usuario.Genero);   
            try
            {
                //Executa query definida acima.
                Cmd.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir usuario no banco.\n" + err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }

        public int Devolver(string login, string senha)//passando uma string login e senha
        {
            try
            {
                //conexao com o banco de dados & 
                Cmd.Connection = Con.ReturnConnection();//conexao
                Cmd.CommandText = "Select * From USUARIO WHERE Email = @login OR Usuario = @login AND Senha = @senha";
                Cmd.Parameters.AddWithValue("@login", login);//passagem de parametro
                Cmd.Parameters.AddWithValue("@senha", senha);//passaem de parametro
                

                SqlDataReader rd = Cmd.ExecuteReader();

                if (rd.Read())
                {
                    return (int)rd["ID"];
                }
                return -1;
                
            }
            catch (Exception err)
            {

                throw new Exception(err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        /*public Usuario Alterar(string login, string senha)
        {
            try
            {
                Usuario usuario = null;
                Cmd.Connection = Con.ReturnConnection();//conexao
                Cmd.CommandText = @"Select ID,
                Nome,
                Email,
                Telefone,
                Usuario,
                Senha
                From USUARIO WHERE Email = @login OR Usuario = @login AND Senha = @senha";
                Cmd.Parameters.AddWithValue("@login", login);//passagem de parametro
                Cmd.Parameters.AddWithValue("@senha", senha);//passaem de parametro
                SqlDataReader rd = Cmd.ExecuteReader();

                if (rd.Read())
                {
                    usuario = new Usuario(, (string)rd["Nome"], (string)rd["Email"], (string)rd["Telefone"], (string)rd["Usuario"], (string)rd["Senha"]);
                    
                }
                return usuario;

            }
            catch (Exception err)
            {

                return null;
            }
            finally
            {
                Con.CloseConnection();
            }

        }*/
        public Usuario Identificar(int id)
        {
            try
            {
                Usuario usuario = null;
                Cmd.Connection = Con.ReturnConnection();//conexao
                Cmd.CommandText = @"Select ID,
                Nome,
                Email,
                Telefone,
                Usuario,
                Senha
                From USUARIO WHERE ID = @id";
                Cmd.Parameters.AddWithValue("@id", id);//passagem de parametro               
                SqlDataReader rd = Cmd.ExecuteReader();

                if (rd.Read())
                {
                    usuario = new Usuario((int)rd["ID"], (string)rd["Nome"], (string)rd["Email"], (string)rd["Telefone"], (string)rd["Usuario"], (string)rd["Senha"]);

                }
                return usuario;
        
            }
            catch (Exception err)
            {

               throw new Exception(err.Message);
            }
            finally
            {
                Con.CloseConnection();
            }

        }
    }
}
