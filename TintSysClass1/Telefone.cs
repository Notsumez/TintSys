using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace TintSysClass1
{
    public class Telefone
    {
        private int id;
        private string numero;
        private string tipo;
        private Cliente cliente;


        public int Id { get => id; set => id = value; }
        public string Numero { get => numero; set => numero = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public Cliente Cliente { get => cliente; set => cliente = value; }
        
        public Telefone(int id, string numero, string tipo, Cliente cliente)
        {
            this.id = id;
            this.numero = numero;
            this.tipo = tipo;
            this.cliente = cliente;
        }

        public Telefone(string numero, string tipo, Cliente cliente)
        {
            this.numero = numero;
            this.tipo = tipo;
            this.cliente = cliente;
        }

        public Telefone(string numero, string tipo)
        {
            this.numero = numero;
            this.tipo = tipo;
        }

        public static Telefone ObterPorId(int id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefones where id = "+id;
            cmd.Parameters.AddWithValue("id", id);
            var dr = cmd.ExecuteReader();
            Telefone telefone = null;
            while (dr.Read())
            {
                telefone = new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3))
                    );
            }
            Banco.Fechar(cmd);
            return telefone;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert into telefones (numero, tipo, cliente_id) " +
                "values(@numero, @tipo, @cliente_id)";
            cmd.Parameters.Add("@numero", MySqlDbType.String).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.String).Value = Tipo;
            cmd.Parameters.Add("@cliente_id", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static List<Telefone> Listar(string telefone_id = "")
        {
            List<Telefone> lista = new List<Telefone>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from telefones";
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Telefone(
                    dr.GetInt32(0),
                    dr.GetString(1),
                    dr.GetString(2),
                    Cliente.ObterPorId(dr.GetInt32(3))
                    )
                );
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update telefones (numero, tipo) where id = "+Id;
            cmd.Parameters.Add("@numero", MySqlDbType.String).Value = Numero;
            cmd.Parameters.Add("@tipo", MySqlDbType.String).Value = Tipo;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
    }
}
