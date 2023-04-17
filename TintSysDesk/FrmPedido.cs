using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass1;

namespace TintSysDesk
{
    public partial class FrmPedido : Form
    {
        public FrmPedido()
        {
            InitializeComponent();
        }

        private void FrmPedido_Load(object sender, EventArgs e)
        {
            cmbCliente.DataSource = Cliente.Listar();
            cmbCliente.DisplayMember = "Nome";
            cmbCliente.ValueMember= "Id";

            cmbUsuario.DataSource= Usuario.Listar();
            cmbUsuario.DisplayMember = "Nome";
            cmbUsuario.ValueMember= "Id";
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            grbDados.Enabled = true;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Pedido pedido = new Pedido(
                Cliente.ObterPorId(
                    Convert.ToInt32(cmbCliente.SelectedValue)),
                    Usuario.ObterPorId(Convert.ToInt32(cmbUsuario.SelectedValue))
                );
            pedido.Inserir();
            Pedido newped = Pedido.ObterPorId(pedido.Id);
            lblStatus.Text = newped.Status + " - "+newped.HashCode;
            txtId.Text = newped.Id.ToString();

            grbDados.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Show();
            panel1.Visible = true;
        }

        private void txtIdProd_TextChanged(object sender, EventArgs e)
        {
            if (txtIdProd.Text.Length > 0)
            {
                Produto produto = Produto.ObtertPorId(Convert.ToInt32(txtIdProd.Text));
                if (produto != null)
                {
                    txtDescricao.Text = produto.Descricao;
                    txtPreco.Text = produto.Preco.ToString();
                    txtUnid.Text = produto.Unidade.ToString();
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(txtQuantidade.Text) > 0)
            {
                ItemPedido item = new ItemPedido(
                    Convert.ToInt32(txtId.Text),
                    Produto.ObtertPorId(Convert.ToInt32(txtIdProd.Text)),
                    Convert.ToDouble(txtPreco.Text),
                    Convert.ToDouble(txtQuantidade.Text),
                    Convert.ToDouble(txtDesconto.Text)
                    );
                item.Adicionar();
                CarregaGrid();
            }
            else
            {
                MessageBox.Show("A quantidade deve ser maior que 0");
            }
        }

        private void CarregaGrid()
        {
            List<ItemPedido> itens = ItemPedido.ListarPorPedido(Convert.ToInt32(txtId.Text));
            double SubTotal = 0;
            int linha = 0;
            dgvItens.Rows.Clear();
            foreach (ItemPedido iten in itens)
            {
                dgvItens.Rows.Add();
                dgvItens.Rows[linha].Cells[0].Value = linha + 1;
                dgvItens.Rows[linha].Cells[1].Value = iten.Produto.Id;
                dgvItens.Rows[linha].Cells[2].Value = iten.Produto.Descricao;
                dgvItens.Rows[linha].Cells[3].Value = iten.Produto.Unidade;
                dgvItens.Rows[linha].Cells[4].Value = iten.Preco;
                dgvItens.Rows[linha].Cells[5].Value = iten.Quantidade;
                dgvItens.Rows[linha].Cells[6].Value = iten.Desconto;
                double valorItem = iten.Preco * iten.Quantidade - iten.Desconto;
                dgvItens.Rows[linha].Cells[7].Value = valorItem;
                SubTotal += valorItem;
                linha++;
            }
            txtTotal.Text = SubTotal.ToString();
        }

        private void cmbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

    }
}
