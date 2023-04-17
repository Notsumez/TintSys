using MySql.Data.MySqlClient;
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
        private string cpf;
        private string email;
        private DateTime datacad;
        private bool ativo;


        // criando as propriedades
        public int Id { get => id; set => id = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Cpf { get => cpf; set => cpf = value; }
        public string Email { get => email; set => email = value; }
        public DateTime Datacad { get => datacad; set => datacad = value; }
        public bool Ativo { get => ativo; set => ativo = value; }

        // criando os métodos construtores
        public Cliente(string nome, string cpf, string email, bool ativo)
        {

            Nome = nome;
            Cpf = cpf;
            Email = email;
            Ativo = ativo;
        }
        public Cliente(int id, string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }
        public Cliente(int id, string nome, string cpf, string email, DateTime datacad)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
        }

        public Cliente(string nome, string cpf, string email, DateTime datacad, bool ativo)
        {
            Nome = nome;
            Cpf = cpf;
            Email = email;
            Datacad = datacad;
            Ativo = ativo;
        }
        public Cliente(int id, string nome, string cpf, string email)
        {
            Id = id;
            Nome = nome;
            Cpf = cpf;
            Email = email;
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
            cmd.CommandText = "select * from clientes where id = " + id;
            cmd.Parameters.AddWithValue("id", id);
            var dr = cmd.ExecuteReader();
            Cliente cliente = null;
            while (dr.Read())
            {
                cliente = new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    );
            }
            Banco.Fechar(cmd);
            return cliente;
        }

        /// <summary>
        /// Inserir o Cliente
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert into clientes (nome, cpf, email, datacad, ativo) " +
                "values(@nome, @cpf, @email, default, 1)";
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Listar o Cliente pelo nome
        /// </summary>
        /// <param name="_nome"></param>
        /// <returns>Retorna o cliente de acordo com o nome inserido</returns>
        public static List<Cliente> Listar(string _nome = "")
        {
            List<Cliente> lista = new List<Cliente>();
            var cmd = Banco.Abrir();
            if (_nome != string.Empty)
            {
                cmd.CommandText = "select * from clientes where nome like '%' = " + _nome + "'%'";
            }
            else
            {
                cmd.CommandText = "select * from clientes";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Cliente(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetDateTime(4),
                    dr.GetBoolean(5)
                    )
                );
            }
            Banco.Fechar(cmd);
            return lista;
        }
        /// <summary>
        /// Atualizar o cliente
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set nome = @nome, cpf = @cpf, email = @email" +
                "where id = " + Id;
            cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = Nome;
            cmd.Parameters.Add("@cpf", MySqlDbType.VarChar).Value = Cpf;
            cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = Email;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Arquivar o Cliente 
        /// </summary>
        /// <param name="_id"></param>
        public void Arquivar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set ativo = 0 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Restaura o Cliente
        /// </summary>
        /// <param name="_id"></param>
        public static void Restaurar(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update clientes set ativo = 1 where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        /// <summary>
        /// Exclui o Cliente
        /// </summary>
        /// <param name="_id"></param>
        public void Excluir(int _id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete from clientes where id = " + _id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
