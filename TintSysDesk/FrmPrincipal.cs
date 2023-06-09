﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TintSysDesk
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void administrarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUsuarios frmUsuarios= new FrmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Show();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(GetHashCode().ToString());
        }

        private void gerenciarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCliente frmCliente = new FrmCliente();
            frmCliente.MdiParent = this;
            frmCliente.Show();
        }

        private void gerenciarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmProduto frmProduto = new FrmProduto();
            frmProduto.MdiParent = this;
            frmProduto.Show();
        }

        private void novoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmPedido frmPedido= new FrmPedido();
            frmPedido.MdiParent = this;
            frmPedido.Show();
        }
    }
}
