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

namespace WikiCrafteo
{
    public partial class frm_Ingreso : Form
    {
        public frm_ConseguirBloques bloques;
        public frm_ConstruirHerramienta herramientas;
        Jugador jugador;
        public Wiki wiki;
        bool formCubo;
        int limpiar;

        public frm_Ingreso()
        {
            InitializeComponent();
        }
        public frm_Ingreso(Wiki wiki, int limpiar) : this()
        {
            this.wiki = new Wiki(wiki.Jugadores);
            this.limpiar = limpiar;
        }
        public frm_Ingreso(Wiki jugadoresInicio, bool formCubo) : this(jugadoresInicio, 0)
        {
            this.formCubo = formCubo;
        }

        private void frm_Ingreso_Load(object sender, EventArgs e)
        {
            txt_NombreIngreso.Text = "Ingrese su usuario";
        }
        private void btn_Ingresar_Click(object sender, EventArgs e)
        {
            try
            {
                string nombre = txt_NombreIngreso.Text;

                if (nombre != "Ingrese su usuario" && !string.IsNullOrEmpty(nombre))
                {
                    this.jugador = this.wiki.GetJugador(nombre);

                    if (this.formCubo is false && this.limpiar == 1)
                    {
                        if (MessageBox.Show("¿Seguro desea borrar su inventario?", "Limpiar", MessageBoxButtons.OKCancel, MessageBoxIcon.Information) == DialogResult.OK)
                        {
                            jugador.Inventario.ListaCubos.Clear();
                            jugador.Inventario.ListaHerramienta.Clear();
                            jugador.Inventario.Capacidad=10;
                            this.wiki += jugador;
                            DialogResult = DialogResult.OK;
                        }
                    }
                    else
                    {
                        this.FormularioDerivado(this.formCubo, this.jugador);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new NombreInvalidoException(ex);
            }
        }

        /// <summary>
        /// Metodo que analiza a que formulario ingresa
        /// </summary>
        /// <param name="form"></param> true si ingresa al formulario de conseguir bloques, false si ingresa al formulario de construir herramienta
        private void FormularioDerivado(bool form, Jugador jugador)
        {
            if (form == true)
            {
                this.bloques = new frm_ConseguirBloques(jugador);
                DialogResult resultado = this.bloques.ShowDialog();

                if (resultado == DialogResult.OK)
                {
                    this.wiki += jugador;
                    this.DialogResult = DialogResult.OK;
                }

            }
            else
            {
                try
                {


                    if (jugador.Inventario.TieneCubo() == true)
                    {
                        this.herramientas = new frm_ConstruirHerramienta(jugador);
                        DialogResult resultado = this.herramientas.ShowDialog();

                        if (resultado == DialogResult.OK)
                        {
                            this.wiki += jugador;
                            this.DialogResult = DialogResult.OK;

                        }
                    }
                    else
                    {
                        MessageBox.Show("Primero debe obtener bloques", "No puede ingresar", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    }
                }
                catch (Exception)
                {
                    throw new CantidadInsuficienteCubosException();
                }


            }
        }


    }
}
