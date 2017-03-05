using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoInicial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idadeJoao = 10;
            int idadeMaria = 25;
            int idadeCarlos = 32;
            int mediaIdade = (idadeCarlos + idadeJoao + idadeMaria) / 3;
            MessageBox.Show("A Média das idades é: "+mediaIdade);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //int pi = 3.14;

            MessageBox.Show("Não Compila!!!");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            double pi = 3.14;
            int piQuebrado = (int)pi;
            MessageBox.Show("piQuebrado = " + piQuebrado);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a=1, b=3, c=2;
            double delta = b * b - 4 * a * c;
            double a1 = (-b + Math.Sqrt(delta)) / (2 * a);
            double a2 = (-b - Math.Sqrt(delta)) / (2 * a);

            MessageBox.Show("delta = "+delta);
            MessageBox.Show("a1 = " + a1 + ", " + "a2 = " + a2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double saldo = 100;
            double valorSaque = 10;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque Realizado com Sucesso e seu saldo atual é de: R$ " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente para realizar essa operação!");
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            double saldo = 5;
            double valorSaque = 10;

            if (saldo >= valorSaque)
            {
                saldo -= valorSaque;
                MessageBox.Show("Saque Realizado com Sucesso e seu saldo atual é de: R$ " + saldo);
            }
            else
            {
                MessageBox.Show("Saldo Insuficiente para realizar essa operação!");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double saldo = 500.0;
            if (saldo < 0.0)
            {
                MessageBox.Show("Você está no negativo!");
            }
            else if (saldo < 1000000.0)
            {
                MessageBox.Show("Você é um bom cliente");
            }
            else
            {
                MessageBox.Show("Você é milionário!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            int idade = 16;
            bool brasileira = true;

            if(idade>=16 && brasileira==true)
                    {
                MessageBox.Show("Apta a votar!");
            }
            else
            {
                MessageBox.Show("Não está apta a votação!");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            double valorDaNotaFiscal = 8000;

            if(valorDaNotaFiscal < 999)
            {
                double taxa = 0.02;
                double notaComImposto = (valorDaNotaFiscal * taxa) + valorDaNotaFiscal;
                MessageBox.Show("O valor da taxa a ser pega é de 2% e o valor da nota é: " + notaComImposto);
            }
            else if(valorDaNotaFiscal > 1000 && valorDaNotaFiscal < 2999)
            {
                double taxa = 0.025;
                double notaComImposto = (valorDaNotaFiscal * taxa) + valorDaNotaFiscal;
                MessageBox.Show("O valor da taxa a ser pega é de 2,5% e o valor da nota é: " + notaComImposto);
            }
            else if(valorDaNotaFiscal > 3000 && valorDaNotaFiscal < 6999)
            {
                double taxa = 0.028;
                double notaComImposto = (valorDaNotaFiscal * taxa) + valorDaNotaFiscal;
                MessageBox.Show("O valor da taxa a ser pega é de 2,8% e o valor da nota é: " + notaComImposto);
            }else
            {
                double taxa = 0.03;
                double notaComImposto = (valorDaNotaFiscal * taxa) + valorDaNotaFiscal;
                MessageBox.Show("O valor da taxa a ser pega é de 3% e o valor da nota é: " + notaComImposto);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            int total = 2;
            for(int i = 0; i<5; i++)
            {
                total = total * 2;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            int total = 1;
            for (int i = 0; i <=1000; i++)
            {
                total++;
            }
            MessageBox.Show("O total é: " + total);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int num = 1;
            for(int i =1; i<=100; i++)
            {
                if(num %3==0)
                {
                    MessageBox.Show(""+num);
                    
                }
                num++;

            }
        }
    }
}
