using System.Collections;

namespace Calculadora
{
    public partial class Tela : Form
    {
        public string n1, n2;
        public string operacao;
        public double result;

        public Tela()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bt1_Click(object sender, EventArgs e)
        {
            visor.Text += "1";
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            visor.Text += "9";
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            visor.Text += "0";
        }

        private void btVirgula_Click(object sender, EventArgs e)
        {
            visor.Text += ",";
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            visor.Text += "2";
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            visor.Text += "3";
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            visor.Text += "4";
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            visor.Text += "5";
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            visor.Text += "6";
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            visor.Text += "7";
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            visor.Text += "8";
        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            n1 = visor.Text;
            visor.Text = " ";
            operacao = "/";
        }

        private void btsoma_Click(object sender, EventArgs e)
        {
            n1 = visor.Text;
            visor.Text = " ";
            operacao = "+";
        }

        private void btmulti_Click(object sender, EventArgs e)
        {
            n1 = visor.Text;
            visor.Text = " ";
            operacao = "*";
        }

        private void btsubtracao_Click(object sender, EventArgs e)
        {
            n1 = visor.Text;
            visor.Text = " ";
            operacao = "-";
        }

        private void btclear_Click(object sender, EventArgs e)
        {
            visor.Text = " ";
        }

        private void btigual_Click(object sender, EventArgs e)
        {
            n2 = visor.Text;
            if (operacao == "/")
            {
                result = Convert.ToDouble(n1) / Convert.ToDouble(n2);
            }
            if (operacao == "+")
            {
                result = Convert.ToDouble(n1) + Convert.ToDouble(n2);
            }
            if(operacao == "*")
            {
                result = Convert.ToDouble(n1) * Convert.ToDouble(n2);
            }
            if(operacao == "-")
            {
                result = Convert.ToDouble(n1) - Convert.ToDouble(n2);
            }

            string texto = string.Empty;
            List<string> historico = new List<string>();
            historico.Add(n1+" "+operacao+n2+" = " + result);

            int cont = 0;
            while(cont < historico.Count)
            {
                texto += historico[cont] + "\n";
                cont++;
            }

            lbHistorico.Text += texto;
            visor.Text = result.ToString();
        }
    }
}