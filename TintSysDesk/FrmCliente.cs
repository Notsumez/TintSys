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
    public partial class FrmCliente : Form
    {
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {
            CarregaGrid();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void tabCliente_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtDateTime_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCpf_TextChanged(object sender, EventArgs e)
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

        private void btnInserir_Click(object sender, EventArgs e)
        {
            Cliente cliente = new Cliente(
                txtNome.Text, txtCpf.Text, txtEmail.Text);
            cliente.Inserir();
            txtId.Text = cliente.Id.ToString();

            CarregaGrid();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            Cliente u = Cliente.ObterPorId(Convert.ToInt32(txtId.Text));
            if (u != null)
            {
                txtNome.Text = u.Nome;
                txtCpf.Text = u.Cpf;
                txtEmail.Text = u.Email;
                txtDatacad.Text = u.Datacad.ToString("dd/MM/yyyy");
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
    }
}
