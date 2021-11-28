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
        public Cubo cuboAux;
        public frm_ConstruirHerramienta herramientas;
        public Herramienta toolAux;
        Jugador jugador;
        public Wiki wiki;
        bool formCubo;

        public frm_Ingreso()
        {
            InitializeComponent();
        }
        public frm_Ingreso(Wiki wiki) : this()
        {
            this.wiki = wiki;//aca estaba new
        }
        public frm_Ingreso(Wiki jugadoresInicio, bool formCubo) : this(jugadoresInicio)
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
                int realizado;
                bool nuevo;

                if (nombre != "Ingrese su usuario" && !string.IsNullOrEmpty(nombre))
                {
                    this.jugador = this.wiki.GetJugador(nombre, out nuevo);

                    realizado = this.FormularioDerivado(this.formCubo, this.jugador, out cuboAux, out toolAux);
                    Jugador player = new Jugador(this.jugador.Id, this.jugador.Usuario, this.jugador.Inventario);

                    if (nuevo)
                    {
                        JugadorAccesoDatos.GuardarJugadorConsulta(player);
                        if (realizado == 1)
                        {
                            JugadorAccesoDatos.GuardarCuboConsulta(player, cuboAux);
                        }
                        else
                        {
                            JugadorAccesoDatos.LimpiarInventarioConsulta(player.Inventario.ID, player.Inventario.Capacidad);
                        }
                    }
                    else
                    {
                        if (this.formCubo && realizado == 1)
                        {
                            JugadorAccesoDatos.GuardarCuboConsulta(player, cuboAux);
                        }
                        else
                        {
                            if (realizado == 1)
                            {
                                JugadorAccesoDatos.GuardarHerramientaConsulta(player, toolAux);
                            }
                            else
                            {
                                JugadorAccesoDatos.LimpiarInventarioConsulta(player.Inventario.ID, player.Inventario.Capacidad);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        /// <summary>
        /// Metodo que analiza a que formulario ingresa
        /// </summary>
        /// <param name="form"></param> true si ingresa al formulario de conseguir bloques, false si ingresa al formulario de construir herramienta
        private int FormularioDerivado(bool form, Jugador jugador, out Cubo cubo, out Herramienta tool)
        {
            cubo = new Cubo();
            tool = new Herramienta();
            int realizado = 0;
            try
            {
                if (form == true)
                {
                    this.bloques = new frm_ConseguirBloques(jugador);
                    DialogResult resultado = this.bloques.ShowDialog();

                    this.wiki += jugador;
                    if (resultado == DialogResult.No)
                    {
                        realizado = 0;
                    }
                    else
                    {
                        cubo = bloques.auxCubo;
                        realizado = 1;
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

                            this.wiki += jugador;
                            if (resultado == DialogResult.No)
                            {
                                realizado = 0;
                            }
                            else
                            {
                                tool = herramientas.auxTool;
                                realizado = 1;
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
                        throw;
                    }
                }
                return realizado;
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
