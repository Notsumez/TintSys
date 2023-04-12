using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass1
{
    public class Pedido
    {
        private int id;
        private DateTime data;
        private string status;
        private double desconto;
        private Cliente cliente;
        private Usuario usuario;
        private DateTime arquivadoem;
        private string hashcode;

        //propriedades
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public double Desconto { get; set; }
        public Cliente Cliente { get; set; }
        public Usuario Usuario { get; set; }
        public DateTime ArquivadoEm { get; set; }
        public string HashCode { get; set; }
        
        public Pedido(Cliente cliente, Usuario usuario) 
        { 
            Cliente = cliente;
            Usuario = usuario;
        }
        public Pedido(int id, DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivadoEm, string hashCode)
        {
            Id = id;
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            ArquivadoEm = arquivadoEm;
            HashCode = hashCode;
        }
        public Pedido(DateTime data, string status, double desconto, Cliente cliente, Usuario usuario, DateTime arquivadoEm, string hashCode)
        {
            Data = data;
            Status = status;
            Desconto = desconto;
            Cliente = cliente;
            Usuario = usuario;
            ArquivadoEm = arquivadoEm;
            HashCode = hashCode;
        }

        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert into pedidos (data, status, desconto, cliente_id, usuario_id, hashcode)" +
                " values (default, default, 0, @cliente, @usuario, @hash)";
            cmd.Parameters.Add("@cliente", MySqlDbType.Int32).Value = Cliente.Id;
            cmd.Parameters.Add("@usuario", MySqlDbType.Int32).Value = Usuario.Id;
            cmd.Parameters.Add("@hash", MySqlDbType.VarChar).Value = ObterHashCode(Cliente.Id, Usuario.Id);
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public void ObterPorId(int id)
        {

        }
        public void ObterPorCliente(int id)
        {

        }

        public void Listar()
        {

        }

        public void Atualizar()
        {

        }

        public void Arquicar()
        {

        }

        public void Restaurar()
        {

        }
        private string ObterHashCode(int cli, int user) 
        { 
            StringBuilder sb = new StringBuilder();
            sb.Append("PD-");
            sb.Append(cli);
            sb.Append(user);
            sb.Append(GetHashCode());
            return sb.ToString(); 
        }

    }
}
