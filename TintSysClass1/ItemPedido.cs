using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass1
{
    public class ItemPedido
    {
        public int Id { get;set; }
        public Produto Produto { get;set; }
        public double Preco { get;set; }
        public double Quantidade { get;set; }
        public double Desconto { get;set; }

        public ItemPedido()
        {
            
        }

        public ItemPedido(Produto produto, double preco, double quantidade, double desconto)
        {
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }
        public ItemPedido(int id, Produto produto, double preco, double quantidade, double desconto)
        {
            Id = id;
            Produto = produto;
            Preco = preco;
            Quantidade = quantidade;
            Desconto = desconto;
        }

        public void Adicionar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "insert into itempedido (pedido_id, produto_id, preco, quantidade, desconto)" +
                " values (@pedido_id, @produto_id, @preco, @quantidade, @desconto)";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = Produto.Id;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Produto.Preco;
            cmd.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = Quantidade;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

        public static ItemPedido BuscarPorProdutoPedido(int pedido_id, int produto_id)
        {
            ItemPedido iten = new ItemPedido();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = @pedido and produto_id = @produto";
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto", MySqlDbType.Int32).Value = produto_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                iten.Id = dr.GetInt32(0);
                iten.Produto = Produto.ObtertPorId(dr.GetInt32(2));
                iten.Preco = dr.GetDouble(3);
                iten.Quantidade = dr.GetDouble(4);
                iten.Desconto = dr.GetDouble(5);
            }
            return iten;
        }
        public static List<ItemPedido> ListarPorPedido(int pedido_id)
        {
            ItemPedido iten = null;
            List<ItemPedido> itens = new List<ItemPedido>();
            var cmd = Banco.Abrir();
            cmd.CommandText = "select * from itempedido where pedido_id = @pedido";
            cmd.Parameters.Add("@pedido", MySqlDbType.Int32).Value = pedido_id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                iten= new ItemPedido(); //Criando o método construtor no próprio método listar
                iten.Id = dr.GetInt32(0);
                iten.Produto = Produto.ObtertPorId(dr.GetInt32(2));
                iten.Preco = dr.GetDouble(3);
                iten.Quantidade = dr.GetDouble(4);
                iten.Desconto = dr.GetDouble(5);
                itens.Add(iten);
            }
            Banco.Fechar(cmd);
            return itens;
        }

        public void Alterar(int pedido_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update itempedido set quantidade = @quantidade, desconto = @desconto" +
                " where pedido_id = @pedido_id and produto_id = @produto_id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = Produto.Id;
            cmd.Parameters.Add("@quantidade", MySqlDbType.Decimal).Value = Quantidade;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public void Excluir(int pedido_id, int produto_id)
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "delete itempedido where where pedido_id = @pedido_id and produto_id = @produto_id";
            cmd.Parameters.Clear();
            cmd.Parameters.Add("@pedido_id", MySqlDbType.Int32).Value = pedido_id;
            cmd.Parameters.Add("@produto_id", MySqlDbType.Int32).Value = produto_id;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }

    }
}
