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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TintSysDesk
{
    public partial class FrmClientes : Form
    {
        public FrmClientes()
        {
            InitializeComponent();
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                            txtNome.Text,
                            txtCpf.Text,
                            txtEmail.Text,
                            Convert.ToDateTime(txtDatacad.Text),
                            true
                           );
            cliente.Inserir();
            txtId.Text = cliente.Id.ToString();
            CarregaGrid();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void CarregaGrid()
        {
            List<Cliente> lista = Cliente.Listar();
            int linha = 0;
            dgvCliente.Rows.Clear();
            foreach (Cliente iten in lista)
            {
                dgvCliente.Rows.Add();
                dgvCliente.Rows[linha].Cells[0].Value = iten.Id.ToString();
                dgvCliente.Rows[linha].Cells[1].Value = iten.Nome;
                dgvCliente.Rows[linha].Cells[2].Value = iten.Cpf;
                dgvCliente.Rows[linha].Cells[3].Value = iten.Email;
                dgvCliente.Rows[linha].Cells[4].Value = iten.Datacad;
                dgvCliente.Rows[linha].Cells[5].Value = iten.Ativo;
                linha++;
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente n = Cliente.ObterPorId(Convert.ToInt32(txtId.Text));
            if (n != null)
            {
                txtNome.Text = n.Nome;
                txtCpf.Text = n.Cpf;
                txtEmail.Text = n.Email;
                txtDatacad.Text = n.Datacad.ToString("dd/MM/yyyy");
            }
            else
            {
                MessageBox.Show("Cliente não cadastrado!");
                txtDatacad.Clear();
                txtEmail.Clear();
                txtCpf.Clear();
                txtNome.Clear();
                txtId.Focus();
                txtId.Clear();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cliente n = new Cliente(
                Convert.ToInt32(txtId.Text),
                txtNome.Text,
                txtCpf.Text,
                txtEmail.Text,
                Convert.ToDateTime(txtDatacad.Text));
            n.Atualizar();
            CarregaGrid();
        }
    }
}
