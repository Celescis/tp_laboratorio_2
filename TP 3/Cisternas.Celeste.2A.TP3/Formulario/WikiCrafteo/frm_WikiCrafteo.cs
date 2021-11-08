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
    public partial class frm_WikiCrafteo : Form
    {
        Wiki wiki;
        frm_Ingreso formIngreso;

        public frm_WikiCrafteo()
        {
            InitializeComponent();
            this.wiki = new Wiki();
        }

        /// <summary>
        /// Evento Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frm_WikiCrafteo_Load(object sender, EventArgs e)
        {
        }

        private void btn_ConseguirBloques_Click(object sender, EventArgs e)
        {
            formIngreso = new frm_Ingreso(this.wiki, true);

            this.ResultadoIngreso();
        }

        private void btn_ConstruirHerramientas_Click(object sender, EventArgs e)
        {
            formIngreso = new frm_Ingreso(this.wiki, false);

            this.ResultadoIngreso();
        }

        private void btn_VerLista_Click(object sender, EventArgs e)
        {
            foreach (Jugador item in this.wiki.Jugadores)
            {
                MessageBox.Show(item.ToString());
            }
        }

        /// <summary>
        /// Metodo interno para reutilizar codigo, revisa el resultado del formulario Ingreso
        /// </summary>
        private void ResultadoIngreso()
        {
            DialogResult resultado = formIngreso.ShowDialog();

            if (resultado == DialogResult.OK)
            {
                this.wiki = formIngreso.wiki;
            }
        }
        private void btn_Estadisticas_Click(object sender, EventArgs e)
        {
            frm_Estadisticas estadisticas = new frm_Estadisticas(this.wiki);
            estadisticas.ShowDialog();
        }

        #region SALIR
        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void frm_WikiCrafteo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro que desea salir?", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion SALIR

        private void btn_Limpiar_Click(object sender, EventArgs e)
        {
            formIngreso = new frm_Ingreso(this.wiki, 1);
          
            this.ResultadoIngreso();

        }
    }
}
