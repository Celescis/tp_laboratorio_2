
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
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_InventarioLleno = new System.Windows.Forms.Button();
            this.btn_PorcentajeDeDiamantes = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_SeleccionDescarga = new System.Windows.Forms.ComboBox();
            this.btn_PorcentajeMadera = new System.Windows.Forms.Button();
            this.btn_PorcentajePiedra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Salir
            // 
            this.btn_Salir.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_Salir.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_Salir.Location = new System.Drawing.Point(755, 581);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(134, 37);
            this.btn_Salir.TabIndex = 6;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = false;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_InventarioLleno
            // 
            this.btn_InventarioLleno.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_InventarioLleno.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InventarioLleno.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_InventarioLleno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_InventarioLleno.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_InventarioLleno.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_InventarioLleno.Location = new System.Drawing.Point(87, 465);
            this.btn_InventarioLleno.Name = "btn_InventarioLleno";
            this.btn_InventarioLleno.Size = new System.Drawing.Size(186, 73);
            this.btn_InventarioLleno.TabIndex = 7;
            this.btn_InventarioLleno.Text = "Porcentaje Inventario Lleno";
            this.btn_InventarioLleno.UseVisualStyleBackColor = false;
            this.btn_InventarioLleno.Click += new System.EventHandler(this.btn_InventarioLleno_Click);
            // 
            // btn_PorcentajeDeDiamantes
            // 
            this.btn_PorcentajeDeDiamantes.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_PorcentajeDeDiamantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PorcentajeDeDiamantes.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_PorcentajeDeDiamantes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PorcentajeDeDiamantes.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PorcentajeDeDiamantes.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_PorcentajeDeDiamantes.Location = new System.Drawing.Point(299, 465);
            this.btn_PorcentajeDeDiamantes.Name = "btn_PorcentajeDeDiamantes";
            this.btn_PorcentajeDeDiamantes.Size = new System.Drawing.Size(186, 73);
            this.btn_PorcentajeDeDiamantes.TabIndex = 8;
            this.btn_PorcentajeDeDiamantes.Text = "Porcentaje de Diamantes";
            this.btn_PorcentajeDeDiamantes.UseVisualStyleBackColor = false;
            this.btn_PorcentajeDeDiamantes.Click += new System.EventHandler(this.btn_PorcentajeDeDiamantes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(189, 584);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 37);
            this.label1.TabIndex = 9;
            this.label1.Text = "DESCARGAR DATOS COMO:";
            // 
            // cmb_SeleccionDescarga
            // 
            this.cmb_SeleccionDescarga.BackColor = System.Drawing.Color.DarkGray;
            this.cmb_SeleccionDescarga.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cmb_SeleccionDescarga.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_SeleccionDescarga.Font = new System.Drawing.Font("Malgun Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmb_SeleccionDescarga.FormattingEnabled = true;
            this.cmb_SeleccionDescarga.Items.AddRange(new object[] {
            "Xml",
            "Json",
            "Txt"});
            this.cmb_SeleccionDescarga.Location = new System.Drawing.Point(560, 593);
            this.cmb_SeleccionDescarga.Name = "cmb_SeleccionDescarga";
            this.cmb_SeleccionDescarga.Size = new System.Drawing.Size(90, 25);
            this.cmb_SeleccionDescarga.TabIndex = 10;
            // 
            // btn_PorcentajeMadera
            // 
            this.btn_PorcentajeMadera.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_PorcentajeMadera.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PorcentajeMadera.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_PorcentajeMadera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PorcentajeMadera.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PorcentajeMadera.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_PorcentajeMadera.Location = new System.Drawing.Point(731, 465);
            this.btn_PorcentajeMadera.Name = "btn_PorcentajeMadera";
            this.btn_PorcentajeMadera.Size = new System.Drawing.Size(186, 73);
            this.btn_PorcentajeMadera.TabIndex = 11;
            this.btn_PorcentajeMadera.Text = "Porcentaje de Madera";
            this.btn_PorcentajeMadera.UseVisualStyleBackColor = false;
            this.btn_PorcentajeMadera.Click += new System.EventHandler(this.btn_PorcentajeMadera_Click);
            // 
            // btn_PorcentajePiedra
            // 
            this.btn_PorcentajePiedra.BackColor = System.Drawing.SystemColors.GrayText;
            this.btn_PorcentajePiedra.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_PorcentajePiedra.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.btn_PorcentajePiedra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_PorcentajePiedra.Font = new System.Drawing.Font("Malgun Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_PorcentajePiedra.ForeColor = System.Drawing.Color.Gainsboro;
            this.btn_PorcentajePiedra.Location = new System.Drawing.Point(513, 465);
            this.btn_PorcentajePiedra.Name = "btn_PorcentajePiedra";
            this.btn_PorcentajePiedra.Size = new System.Drawing.Size(186, 73);
            this.btn_PorcentajePiedra.TabIndex = 12;
            this.btn_PorcentajePiedra.Text = "Porcentaje de Piedra";
            this.btn_PorcentajePiedra.UseVisualStyleBackColor = false;
            this.btn_PorcentajePiedra.Click += new System.EventHandler(this.btn_PorcentajePiedra_Click);
            // 
            // frm_Estadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1035, 669);
            this.Controls.Add(this.btn_PorcentajePiedra);
            this.Controls.Add(this.btn_PorcentajeMadera);
            this.Controls.Add(this.cmb_SeleccionDescarga);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_PorcentajeDeDiamantes);
            this.Controls.Add(this.btn_InventarioLleno);
            this.Controls.Add(this.btn_Salir);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Estadisticas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Estadisticas";
            this.Load += new System.EventHandler(this.frm_Estadisticas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_InventarioLleno;
        private System.Windows.Forms.Button btn_PorcentajeDeDiamantes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_SeleccionDescarga;
        private System.Windows.Forms.Button btn_PorcentajeMadera;
        private System.Windows.Forms.Button btn_PorcentajePiedra;
    }
}