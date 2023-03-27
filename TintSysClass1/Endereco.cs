using MySqlX.XDevAPI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass1
{
    internal class Endereco
    {
        private int id;
        private char cep;
        private string logradouro;
        private string numero;
        private string complemento;
        private string bairro;
        private string cidade;
        private string estado;
        private char uf;
        private string tipo;
        private Cliente cliente;

        public int Id { get => id; set => id = value; }
        public char Cep { get => cep; set => cep = value; }
        public string Logradouro { get => logradouro; set => logradouro = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Complemento { get => complemento; set => complemento = value; }
        public string Bairro { get => bairro; set => bairro = value; }
        public string Cidade { get => cidade; set => cidade = value; }
        public string Estado { get => estado; set => estado = value; }
        public char Uf { get => uf; set => uf = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }

        public Endereco(int id, char cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, char uf, string tipo, Cliente cliente)
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

        public Endereco(char cep, string logradouro, string numero, string complemento, string bairro, string cidade, string estado, char uf, string tipo, Cliente cliente)
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
            cmd.CommandText = "select * from endereco where id = " + id;
            cmd.Parameters.AddWithValue("id", id);
            var dr = cmd.ExecuteReader();
            Endereco endereco = null;
            while (dr.Read())
            {
                endereco = new Endereco(
                    dr.GetInt32(0),
                    dr.GetChar(1),
                    dr.GetString(2),
                    dr.GetString(3),
                    dr.GetString(4),
                    dr.GetString(5),
                    dr.GetString(6),
                    dr.GetString(7),
                    dr.GetChar(8),
                    dr.GetString(9),
                    Cliente.ObterPorId(dr.GetInt32(10))
                    );
            }
            Banco.Fechar(cmd);
            return endereco;
        }

    }
}
