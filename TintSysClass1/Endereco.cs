using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass1
{
    public class Endereco
    {
        private int id;
        private string cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private string uf;
        private string tipo;
        private Cliente cliente;

        public int Id { get => id; set => id = value; }
        public string Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public string Uf { get => uf; set => uf = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public Endereco(int id, string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Cliente cliente)
        {
            this.id = id;
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.tipo = tipo;
            this.cliente = cliente;
        }

        public Endereco(string cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, string uf, string tipo, Cliente cliente)
        {
            this.cep = cep;
            this.logradouro = logradouro;
            this.numero = numero;
            this.complemento = complemento;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.uf = uf;
            this.tipo = tipo;
            this.cliente = cliente;
        }
        /// <summary>
        /// Obtem o Endereço pelo Id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Retorna todas as informações do endereço com o id solicitado</returns>
        public static Endereco ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos where id = " + id;
            cmd.Parameters.AddWithValue("id", id);
            var dr = cmd.ExecuteReader();
            Endereco endereco = null;
            while (dr.Read())
            {
                endereco = new Endereco(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9),
                    Cliente.ObterPorId(dr.GetInt32(10))
                    );
            }
            Banco.Fechar(cmd);
            return endereco;
        }
        /// <summary>
        /// Inserir o Endereço
        /// </summary>
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert into enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf, tipo, cliente_id) " +
                "values(@cep, @logradouro, @numero, @complemento, @bairro, @cidade, @estado, @uf, 1, 1";
            cmd.Parameters.Add("@cep", MySqlDbType.String).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.String).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.String).Value = Numero;
            cmd.Parameters.Add("@complemento", MySqlDbType.String).Value = Complemento;
            cmd.Parameters.Add("@bairro", MySqlDbType.String).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.String).Value = Cidade;
            cmd.Parameters.Add("@estado", MySqlDbType.String).Value = Estado;
            cmd.Parameters.Add("@uf", MySqlDbType.String).Value = Uf;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static List<Endereco> Listar(string endereco_id = "")
        {
            List<Endereco> lista = new List<Endereco>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from enderecos";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Endereco(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetString(8),
                    dr.GetString(9),
                    Cliente.ObterPorId(dr.GetInt32(10))
                    )
                );
            }
            Banco.Fechar(cmd);
            return lista;
        }
        /// <summary>
        /// Atualizar o endereço
        /// </summary>
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update enderecos (cep, logradouro, numero, complemento, bairro, cidade, estado, uf) where id = " + Id;
            cmd.Parameters.Add("@cep", MySqlDbType.String).Value = Cep;
            cmd.Parameters.Add("@logradouro", MySqlDbType.String).Value = Logradouro;
            cmd.Parameters.Add("@numero", MySqlDbType.String).Value = Numero;
            cmd.Parameters.Add("@complemento", MySqlDbType.String).Value = Complemento;
            cmd.Parameters.Add("@bairro", MySqlDbType.String).Value = Bairro;
            cmd.Parameters.Add("@cidade", MySqlDbType.String).Value = Cidade;
            cmd.Parameters.Add("@estado", MySqlDbType.String).Value = Estado;
            cmd.Parameters.Add("@uf", MySqlDbType.String).Value = Uf;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

    }
}
