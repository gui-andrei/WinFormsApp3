using System;
using ex3;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Funcionario funcionario = new Funcionario();
            try
            {
                funcionario.ID = int.Parse(cdgtxt.Text);
                funcionario.Nome = nometxt.Text;
                funcionario.RG = rgTxt.Text;
                funcionario.Salario = double.Parse(salariotxt.Text);
            }catch (Exception  erro)
            {
                MessageBox.Show(erro.Message);
                return;
            }
                
            


            registrostxt.Text += funcionario.ToString();

        }

        private void cleartxt_Click(object sender, EventArgs e)
        {
            registrostxt.Clear();
        }
    }
}