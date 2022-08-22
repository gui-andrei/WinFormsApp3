using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace ex3
{
    class Funcionario
    {
        private int id;
        private string nome;
        private string rg;
        private double salario;

        
    
      

    public int ID
        {
            get => id;
            set
            {
                if(value <0)
                {
                    MessageBox.Show("id tem que ser maior que zero");

                }
                else
                {
                    id = value;
                }
            }
        }
        public string Nome
        {
            get => nome;
            set
            {
                if(value.Length <2)
                {
                    MessageBox.Show("nome precisa no minimo 2 caracters");
                }
                else
                {
                    nome = value;
                }
            }
        }
        public string RG
        {
            get => rg;
            set
            {
                if(value.Length != 9)
                {
                    MessageBox.Show("Rg invalido");
                }
                else
                {
                    rg = value;
                }
            }
        }
        public double Salario
        {
            get => salario;
            set
            {
                salario = value;
            }
        }
        public override string ToString()
        {
            return "ID: " + id + " nome: " + nome + " RG: " + rg + " salario: " + salario;
        }

    }
}
