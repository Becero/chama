using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chama.Modelo
{
    internal class Usuario
    {
        private int _id;
        private string _nome;
        private string _email;
        private string _telefone;
        private string _usuarioSis;
        private string _senha;

        public Usuario(string nome, string email, string telefone, string usuarioSis, string senha)
        {
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            UsuarioSis = usuarioSis;
        }
        public Usuario(int id, string nome, string email, string telefone, string usuarioSis, string senha)
        {
            _id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
            Senha = senha;
            UsuarioSis = usuarioSis;
        }
        public int Id
        {
            get { return _id; }
        }
        //Validação do Nome.
        public string Nome
        {
            get { return _nome; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome informado não é um texto válido");
                _nome = value;
            }
        }
        //Validação do Email
        public string Email
        {
            get { return _email; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O email informado não é um texto válido");
                _email = value;
            }
        }

        //Validação do Telefone
        public string Telefone
        {
            get { return _telefone; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O telefone informado não é um texto válido");
                _telefone = value;
            }
        }

        //Validação do Usuario
        public string UsuarioSis
        {
            get { return _usuarioSis; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O nome de usuario informado não é um texto válido");
                _usuarioSis = value;
            }
        }
        //Validação do Senha
        public string Senha
        {
            get { return _senha; }
            set
            {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("A senha informada não é um texto válido");
                _senha = value;
            }
        }

        public object DatadeNascimento { get; internal set; }
    }
}
