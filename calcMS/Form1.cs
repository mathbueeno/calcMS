using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calcMS
{
    public partial class Form1 : Form
    {
        decimal valor1 = 0, valor2 = 0, resultado = 0;
        string operacao = "";
        public Form1()
        {
            InitializeComponent();
        }

        
        // NÚMERO ZERO
        private void button18_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "0";
        }


        // NÚMERO 1
        private void button10_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "1";
        }

        // NÚMERO 2
        private void button11_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "2";
        }

        // NÚMERO 3
        private void button12_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "3";
        }

        //NÚMERO 4
        private void button7_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "4";
        }

        //NÚMERO 5
        private void button8_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "5";
        }

        //NÚMERO 6
        private void button9_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "6";
        }

        // NÚMERO 7
        private void button4_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "7";
        }

        // NÚMERO 8
        private void button5_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "8";
        }

        //NÚMERO 9
        private void button6_Click(object sender, EventArgs e)
        {
            txtResultado.Text += "9";
        }


        // INÍCIO DAS OPERAÇÕES



        // BOTÃO DE SOMA
      
        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SOMA";
                lblOperacao.Text = "+";
            }
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira um número antes da operação");
                
            }
           
        }

        // BOTÃO DE DIVISÃO

        private void button14_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "DIV";
                lblOperacao.Text = "/";
            }
                     
            catch (Exception)
            {
                MessageBox.Show("Por favor, insira um número antes da operação.");

            }
           
           
        }

        // BOTÃO DE MULTIPLICAÇÃO
        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "MULT";
                lblOperacao.Text = "X";
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, insira um número antes da operação.");

            }
            
        }


        // BOTÃO DE SUBTRAÇÃO
        private void button16_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "SUBTRACAO";
                lblOperacao.Text = "-";
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, insira um número antes da operação.");

            }
            
        }

        // BOTÃO DE PORCENTAGEM
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                valor1 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);
                txtResultado.Text = "";
                operacao = "PORC";
                lblOperacao.Text = "%";
            }
            catch (Exception)
            {

                MessageBox.Show("Por favor, insira um número antes da operação.");

            }
           
        }

       

        // BOTÃO DE IGUAL/RESULTADO

        private void button20_Click(object sender, EventArgs e)
        {
            try
            {
                valor2 = decimal.Parse(txtResultado.Text, CultureInfo.InvariantCulture);

                switch (operacao)
                {
                    case "SOMA":

                        resultado = (valor1 + valor2);

                        break;
                    case "SUBTRACAO":

                        resultado = (valor1 - valor2);
                        break;
                    case "MULT":

                        resultado = (valor1 * valor2);
                        break;
                    case "DIV":

                        resultado = (valor1 / valor2);
                        break;
                    case "PORC":

                        resultado = (valor1 / 100 * valor2 );
                        break;






                }



                {
                    txtResultado.Text = Convert.ToString(resultado);

                }
            }
            catch (System.DivideByZeroException)
            {

               txtResultado.Text = "É impossível dividir zero por zero";
                
            }
            





        }
           

             
             
        
       

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

       

        

       

       

        

       

       

        

       

        private void button3_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            lblOperacao.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtResultado.Text = "";
            valor1 = 0;
            valor2 = 0;
            lblOperacao.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            txtResultado.Text += ".";
        }
    }
    

}

    

