
namespace WikiCrafteo
{
    partial class frm_Estadisticas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Estadisticas));
            this.btn_JugadorMasHerramientas = new System.Windows.Forms.Button();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_JugadoresMasCubos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_JugadorMasHerramientas
            // 
            this.btn_JugadorMasHerramientas.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_JugadorMasHerramientas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JugadorMasHerramientas.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_JugadorMasHerramientas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JugadorMasHerramientas.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JugadorMasHerramientas.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_JugadorMasHerramientas.Location = new System.Drawing.Point(411, 465);
            this.btn_JugadorMasHerramientas.Name = "btn_JugadorMasHerramientas";
            this.btn_JugadorMasHerramientas.Size = new System.Drawing.Size(186, 73);
            this.btn_JugadorMasHerramientas.TabIndex = 5;
            this.btn_JugadorMasHerramientas.Text = "Ver jugadores con más herramientas";
            this.btn_JugadorMasHerramientas.UseVisualStyleBackColor = false;
            this.btn_JugadorMasHerramientas.Click += new System.EventHandler(this.btn_JugadoresMasHerramientas_Click);
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Salir.Location = new System.Drawing.Point(639, 465);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(186, 73);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_JugadoresMasCubos
            // 
            this.btn_JugadoresMasCubos.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_JugadoresMasCubos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_JugadoresMasCubos.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_JugadoresMasCubos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_JugadoresMasCubos.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_JugadoresMasCubos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_JugadoresMasCubos.Location = new System.Drawing.Point(190, 465);
            this.btn_JugadoresMasCubos.Name = "btn_JugadoresMasCubos";
            this.btn_JugadoresMasCubos.Size = new System.Drawing.Size(186, 73);
            this.btn_JugadoresMasCubos.TabIndex = 7;
            this.btn_JugadoresMasCubos.Text = "Ver jugadores con más cubos";
            this.btn_JugadoresMasCubos.UseVisualStyleBackColor = false;
            this.btn_JugadoresMasCubos.Click += new System.EventHandler(this.btn_JugadoresConMasCubos_Click);
            // 
            // frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 669);
            this.Controls.Add(this.btn_JugadoresMasCubos);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.btn_JugadorMasHerramientas);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Estadisticas";
            this.Load += new System.EventHandler(this.frm_Estadisticas_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_JugadorMasHerramientas;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_JugadoresMasCubos;
    }
}