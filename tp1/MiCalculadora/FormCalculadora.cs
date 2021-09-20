using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades.Clases;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        Calculadora calculadora= new Calculadora();

        public FormCalculadora()
        {
            InitializeComponent();
        }
        private void Limpiar()
        {
            txtNumeroUno.Text = "";
            txtNumeroDos.Text = "";
            cboOperador.SelectedItem = -1;
            lblResultado.Text = "";
            txtNumeroUno.Focus();
        }
        private void AgregarHistorial()
        {
            string historial;

            if(cboOperador.SelectedItem == null)
            {
                cboOperador.SelectedItem = "+";
            }

            historial = txtNumeroUno.Text + cboOperador.SelectedItem + txtNumeroDos.Text + "=" + lblResultado.Text;
            lstOperaciones.Items.Add(historial);
        }
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            Operando operandoUno = new Operando();
            Operando operandoDos = new Operando();
            char operador;
            double result;

            operandoUno.Numero = txtNumeroUno.Text; 
            operandoDos.Numero = txtNumeroDos.Text;
            operador = Convert.ToChar (cboOperador.SelectedItem);

            if(!ValidarDivision())
            {
                result = calculadora.Operar(operandoUno, operandoDos, operador);
                lblResultado.Text = result.ToString();
                AgregarHistorial();
            }
        }
        private bool ValidarDivision()
        {
            bool resultado = false;

            if(string.IsNullOrEmpty(txtNumeroUno.Text) || string.IsNullOrEmpty(txtNumeroDos.Text))
            {
                MessageBox.Show("Falta un campo", "Error", MessageBoxButtons.OK);
                resultado = true;
            }
            if (txtNumeroDos.Text == "0" && Convert.ToString(cboOperador.SelectedItem) == "/")
            {
                MessageBox.Show("No se puede divivir por 0", "Error", MessageBoxButtons.OK);
                resultado = true;
            }

            return resultado;
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnABinario_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();

            lblResultado.Text = operando.DecimalBinario(lblResultado.Text);
        }
        private void btnADecimal_Click(object sender, EventArgs e)
        {
            Operando operando = new Operando();

            lblResultado.Text = operando.BinarioDecimal(lblResultado.Text);
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult MiDialog;
            MiDialog = MessageBox.Show("¿Está seguro de querer salir?","Salir", MessageBoxButtons.YesNo);
            if(MiDialog == DialogResult.No)
                e.Cancel = true;
        }

        private void SoloNumericos(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\b')
                return;
            if(!char.IsNumber(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
