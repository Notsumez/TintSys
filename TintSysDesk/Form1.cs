using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TintSysClass1;
using TintSysDesk;

namespace TintSysDesk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Nivel nivel = new Nivel("Administrador", "ADM");
            //nivel.Inserir();
            //if (nivel.Id > 0)
            //MessageBox.Show(nivel.Id.ToString());

        }

        //private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    textBox1.Text = comboBox1.SelectedValue.ToString();
        //}

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    Nivel nivel = new Nivel(1, "Estoquista", "EST");
        //    nivel.Atualizar();
        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    Nivel nivel = new Nivel();
        //    if (nivel.Excluir(1)) //como o método retorna bool não é necessário fazer: if(nivel.Excluir(1)==true)
        //        MessageBox.Show("Nivel Excluido com sucesso");
        //    else
        //        MessageBox.Show("Falha ao excluir o nível");
        //}

    }
}
