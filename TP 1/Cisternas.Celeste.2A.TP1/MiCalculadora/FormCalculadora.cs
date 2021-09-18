using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }//LISTO
        //14. El evento click del botón btnConvertirABinario convertirá el resultado, de existir, a binario.
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {

        }
        //15. El evento click del botón btnConvertirADecimal convertirá el resultado, de existir y ser binario, a decimal.
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {

        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }//LISTO
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string numero1 = txtNumero1.Text;
            string numero2 = txtNumero2.Text;
            string operador = cmbOperador.Text;
            
            if(numero1!=""&&numero2!="")
            {
                if (operador == "")
                {
                    operador = "+";
                }
                double result = FormCalculadora.Operar(numero1,numero2,operador);
                lblResultado.Text = result.ToString();
                lstOperaciones.Items.Add(numero1+operador+numero2+"="+result);
            }
            else
            {
                MessageBox.Show("El formulario no fue llenado correctamente","ERROR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }//LISTO
        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            cmbOperador.Items.Add("");
            cmbOperador.Items.Add("+");
            cmbOperador.Items.Add("-");
            cmbOperador.Items.Add("/");
            cmbOperador.Items.Add("*");
            this.Limpiar();
        }//LISTO
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            string mensaje = "¿Esta seguro que desea salir?";
            DialogResult result = MessageBox.Show(mensaje, "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if(result == DialogResult.No)
            {
                e.Cancel = true;
            }
        }//LISTO
        private void Limpiar()
        {
            cmbOperador.SelectedItem = "";
            this.txtNumero1.Clear();
            this.txtNumero2.Clear();
            this.lblResultado.Text = "";
        }//LISTO
        private static double Operar(string numero1, string numero2, string operador)
        {
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            
            if (operador == "")
            {
                operador = "+";
            }

            return Calculadora.Operar(num1, num2, Convert.ToChar(operador));
        }//LISTO
    }
}
