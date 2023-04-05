﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace TintSysClass1
{
    public class Produto
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Unidade { get; set; }
        public string CodBar { get; set; }
        public double Preco { get; set; }
        public double Desconto { get; set; }
        public bool Descontinuado { get; set; }

        // métodos construtores
        public Produto()
        {
            
        }
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
        }
        public Produto(string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }
        public Produto(int id, string descricao, string unidade, string codBar, double preco, double desconto, bool descontinuado)
        {
            Id = id;
            Descricao = descricao;
            Unidade = unidade;
            CodBar = codBar;
            Preco = preco;
            Desconto = desconto;
            Descontinuado = descontinuado;
        }

        // métodos da classe
        public void Inserir()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "Insert into produtos (descricao, unidade, codbar, preco, " +
                "desconto, descontinuado)" +
                "values (@descricao, @unidade, @codbar, @preco, @desconto/100, 0)";
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@unidade", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@codbar", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "select @@identity";
            Id = Convert.ToInt32(cmd.ExecuteScalar());
            Banco.Fechar(cmd);
        }
        public static List<Produto> Listar(string descricao = "") 
        {
            List<Produto> lista = new List<Produto>();
            MySqlCommand cmd = Banco.Abrir();
            if (descricao.Length > 0)
            {
                cmd.CommandText = "select * from produtos where descicao like '%"+descricao+"%'";
            }
            else
            {
                cmd.CommandText = "select * from produtos";
            }
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lista.Add(new Produto(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDouble(4),
                        dr.GetDouble(5),
                        dr.GetBoolean(6)
                    ));
            }
            Banco.Fechar(cmd);
            return lista;
        }
        public static Produto ObtertPorId(int id)
        {
            Produto produto = null;
            MySqlCommand cmd = Banco.Abrir();
            cmd.CommandText = "select * from produtos where id = "+id;
            var dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                    produto = new Produto(
                        dr.GetInt32(0),
                        dr.GetString(1),
                        dr.GetString(2),
                        dr.GetString(3),
                        dr.GetDouble(4),
                        dr.GetDouble(5),
                        dr.GetBoolean(6)
                    );
            }
            Banco.Fechar(cmd);
            return produto;
        }
        public void Atualizar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update produtos (descricao = @descricao, unidade = @unidade, codbar = @codbar, preco = @preco, " +
                "desconto = @desconto) where id = @id";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            cmd.Parameters.Add("@descricao", MySqlDbType.VarChar).Value = Descricao;
            cmd.Parameters.Add("@unidade", MySqlDbType.VarChar).Value = Unidade;
            cmd.Parameters.Add("@codbar", MySqlDbType.VarChar).Value = CodBar;
            cmd.Parameters.Add("@preco", MySqlDbType.Decimal).Value = Preco;
            cmd.Parameters.Add("@desconto", MySqlDbType.Decimal).Value = Desconto;
            cmd.ExecuteNonQuery();
            Banco.Fechar(cmd);
        }
        public void Arquivar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set descontinuado = 1 where id = @id";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            Banco.Fechar(cmd);
        }
        public void Restaurar()
        {
            var cmd = Banco.Abrir();
            cmd.CommandText = "update usuarios set descontinuado = 0 where id = @id";
            cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = Id;
            Banco.Fechar(cmd);
        }

    }
}
