using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass1
{
    public class Cliente
    {
        // Criando as variáveis
        private int id;
        private string nome;
        private char cpf;
        private string email;
        private DateTime datacad;
        private bool ativo;

        // criando as propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public char Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Datacad { get => datacad; set => datacad = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        // criando os métodos construtores
        public Cliente(int id, string nome, char cpf, string email, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }
        public Cliente(int id, string nome, char cpf, string email, DateTime datacad)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
        }

        public Cliente(string nome, char cpf, string email, DateTime datacad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }


        // Criando os Métodos da Classe

        /// <summary>
        /// Obter o Cliente Pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna todas as informações do cliente com o id solicitado</returns>
        public static Cliente ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from cliente where id = " + id;
            cmd.Parameters.AddWithValue("id", id);
            var dr = cmd.ExecuteReader();
            Cliente cliente = null;
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetChar(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    );
            }
            Banco.Fechar(cmd);
            return cliente;
        }


    }
}
