﻿using chama.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        public bool Devolver(string login, string senha)//passando uma string login e senha
        {
            try
            {
                //conexao com o banco de dados & 
                Cmd.Connection = Con.ReturnConnection();//conexao
                Cmd.CommandText = "Select * From USUARIO WHERE Email = @login OR Usuario = @login AND Senha = @senha ";
                Cmd.Parameters.AddWithValue("@login", login);//passagem de parametro
                Cmd.Parameters.AddWithValue("@senha", senha);//passaem de parametro
                SqlDataReader rd = Cmd.ExecuteReader();

                if (rd.Read())
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception err)
            {

                return false;
            }
            finally
            {
                Con.CloseConnection();
            }
        }
        /* public List<Usuario> ListarTodosUsuarios()
         {
             Cmd.Connection = Con.ReturnConnection();
             Cmd.CommandText = "SELECT * FROM Usuarios";

             List<Usuario> listaDeUsuarios = new List<Usuario>(); //Instancio a list com o tamanho padrão.
             try
             {
                 SqlDataReader rd = Cmd.ExecuteReader();

                 //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                 while (rd.Read())
                 {
                     Usuario usuario = new Usuario((int)rd["Id"], (string)rd["Nome"],
                         (string)rd["Email"], (string)rd["Telefone"], (string)rd["Usuario"], (string)rd["Senha"]);
                     listaDeUsuarios.Add(usuario);
                 }
                 rd.Close();
             }
             catch (Exception err)
             {
                 throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
             }
             finally
             {
                 Con.CloseConnection();
             }

             return listaDeUsuarios;
         }*/
    }
}
