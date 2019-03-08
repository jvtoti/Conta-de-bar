using System;
using ClassConta;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsConta
{
    public partial class Form1 : Form
    {
        public Conta conta = new Conta();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal valorUnitario = Convert.ToDecimal(valorUnitarioTbx.Text);
            int quantidade = Convert.ToInt32(quantidadeTbx.Text);
            int qtdPessoa = Convert.ToInt32(qtdPessoasTbx.Text);
            conta.Despesa(qtdPessoa, valorUnitario, quantidade);
            totalLbl.Text = Convert.ToString(conta.total);
            totalPorPessoasLbl.Text = (conta.total / qtdPessoa).ToString();


            valorUnitarioTbx.Text = String.Empty;
            quantidadeTbx.Text = "1";
        }
    }
}
