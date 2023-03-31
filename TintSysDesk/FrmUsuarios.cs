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
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmUsuarios_Load(object sender, EventArgs e)
        {
            CarregaComboNivel();
            CarregaGrid();
            CarregaGridNiveis();
        }

        private void CarregaComboNivel()
        {
            comboBox1.DataSource= Nivel.Listar();
            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Nome";
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnInserirNivel_Click(object sender, EventArgs e)
        {
            Nivel n = new Nivel(txtNomeNivel.Text, txtSiglaNivel.Text);
            n.Inserir();
            CarregaComboNivel();
        }

        private void btnConsultarNivel_Click(object sender, EventArgs e)
        {
            Nivel n = Nivel.ObterPorId(Convert.ToInt32(txtIdNivel.Text));
            if (n != null)
            {
                txtNomeNivel.Text = n.Nome;
                txtSiglaNivel.Text = n.Sigla;
            }
            else
            {
                MessageBox.Show("Nível não cadastrado!");
                txtSiglaNivel.Clear();
                txtNomeNivel.Clear();
                txtIdNivel.Focus();
                txtIdNivel.Clear();
            }
        }

        private void CarregaGrid()
        {
            List<Usuario> lista = Usuario.Listar();
            int linha = 0;
            dgvUsuarios.Rows.Clear();
            foreach (Usuario iten in lista)
            {
                dgvUsuarios.Rows.Add();
                dgvUsuarios.Rows[linha].Cells[0].Value = iten.Id.ToString();
                dgvUsuarios.Rows[linha].Cells[1].Value = iten.Nome;
                dgvUsuarios.Rows[linha].Cells[2].Value = iten.Email;
                dgvUsuarios.Rows[linha].Cells[3].Value = iten.Nivel.Nome;
                dgvUsuarios.Rows[linha].Cells[4].Value = iten.Ativo;
                linha++;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario(
            txtNome.Text, txtEmail.Text, txtSenha.Text,
            Nivel.ObterPorId(Convert.ToInt32(comboBox1.SelectedValue)));
            usuario.Inserir();
            txtId.Text = usuario.Id.ToString();

            CarregaGrid();
        }

        private void CarregaGridNiveis()
        {
            List<Nivel> lista = Nivel.Listar();
            int linha = 0;
            dgvNiveis.Rows.Clear();
            foreach (Nivel iten in lista)
            {
                dgvNiveis.Rows.Add();
                dgvNiveis.Rows[linha].Cells[0].Value = iten.Id.ToString();
                dgvNiveis.Rows[linha].Cells[1].Value = iten.Nome;
                dgvNiveis.Rows[linha].Cells[2].Value = iten.Sigla;
                linha++;
            }
        }

        private void btnEditarNivel_Click(object sender, EventArgs e)
        {
            Nivel n = new Nivel(
                Convert.ToInt32(txtIdNivel.Text),
                txtNomeNivel.Text,
                txtSiglaNivel.Text);
            n.Atualizar();
            CarregaComboNivel();
            CarregaGridNiveis();
            CarregaGrid();
        }
    }
}
