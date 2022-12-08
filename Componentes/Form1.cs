using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Componentes
{
    public partial class frmFrutas : Form
    {
        public frmFrutas()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnSeleionar_Click(object sender, EventArgs e)
        {
            int operador;
            string frutas = "";
            operador = int.Parse(txtSelecione.Text);

            switch (operador)
            {
                case 1: frutas = "Banana";
                    break;
                case 2: frutas = "Maça";
                    break;
                case 3:frutas = "Pêra";
                    break;
                case 4:frutas = "Melancia";
                    break;
                default: frutas = "Nenhuma fruta selecionada.";
                    break;
            }
            txtSelecionada.Text = "";
            txtSelecionada.Focus();

            txtSelecionada.Text = frutas;

            
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //Executar o método criado
            limparCampos();
        }
        //Criar o método para limpar os componentes
        public void limparCampos()
        {
            txtSelecionada.Clear();
            txtSelecione.Text = "";
            ltbFrutas.Items.Clear();
            cbbListadas.Items.Clear();
            cbbListadas.Text = "";
            txtSelecione.Focus();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            ltbFrutas.Items.Clear();
            cbbListadas.Items.Clear();
            ltbFrutas.Items.Add(txtSelecionada.Text);
            cbbListadas.Items.Add(txtSelecionada.Text);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            //Formas de sair
            //Close();
            //this.Close();
            

            DialogResult res;

            res = MessageBox.Show("Deseja sair?", "Mensagem do Sistema",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Exclamation,
                MessageBoxDefaultButton.Button2);
            if (res == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {
                limparCampos();
            }
        }

        private void txtSelecione_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSelecionar.Focus();
            }
        }
    }
}
