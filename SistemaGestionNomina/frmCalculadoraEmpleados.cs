using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGestionNomina
{
    public partial class frmCalculadoraEmpleados : Form
    {
        public frmCalculadoraEmpleados(decimal[] salarioSemanal)
        {
            InitializeComponent();
        }

        public void frmCalculadoraEmpleados_Load(object sender, EventArgs e)
        {

        }
        //VARIABLES
        string operador = "";
        private double nun1;
        double num1 = 0;
        double num2 = 0;

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtPantalla.Text = "0";
            num1 = 0;
            num2 = 0;
            operador = "";

        }

        private void btnDeshacer_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text.Length > 0)
            {
                txtPantalla.Text = txtPantalla.Text.Remove(txtPantalla.Text.Length - 1, 1);
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "1";
            else txtPantalla.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "2";
            else txtPantalla.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "3";
            else txtPantalla.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "4";
            else txtPantalla.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "5";
            else txtPantalla.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "6";
            else txtPantalla.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "7";
            else txtPantalla.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "8";
            else txtPantalla.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "9";
            else txtPantalla.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            if (txtPantalla.Text == "0") txtPantalla.Text = "0";
            else txtPantalla.Text += "0";
        }

        private void btnEmpleadoHora_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text == "0") txtPantalla.Text = "Empleado por Horas";
            else txtPantalla.Text += "0";
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (txtPantalla.Text == "0") txtPantalla.Text = ",";
            else txtPantalla.Text += ",";
        }

        private void btnSuma_Click(object sender, EventArgs e)
        {
            operador = "+";
            nun1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";


        }

        private void btnMultiplicacion_Click(object sender, EventArgs e)
        {
            operador = "*";
            nun1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        private void btnDivision_Click(object sender, EventArgs e)
        {
            operador = "/";
            nun1 = Convert.ToDouble(txtPantalla.Text);
            txtPantalla.Text = "0";
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
           
            num2 = Convert.ToDouble(txtPantalla.Text);

            switch (operador) 
            {
                case "+":
                    txtPantalla.Text = Convert.ToString(nun1 + num2);
                    break;
                case "*":
                    txtPantalla.Text = Convert.ToString(nun1 * num2);
                    break; 

                case "/":
                    txtPantalla.Text = Convert.ToString(nun1 / num2);
                    break;

                    default:
                    txtPantalla.Text = "Error: Operador no válido";
                    break;

            }
        }    }
}
