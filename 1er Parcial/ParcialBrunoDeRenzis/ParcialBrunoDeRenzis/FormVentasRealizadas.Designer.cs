
namespace ParcialBrunoDeRenzis
{
    partial class FormVentasRealizadas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVentasRealizadas));
            this.lsVentas = new System.Windows.Forms.ListBox();
            this.lblFacturacion = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lsVentas
            // 
            this.lsVentas.FormattingEnabled = true;
            this.lsVentas.ItemHeight = 15;
            this.lsVentas.Location = new System.Drawing.Point(1, 27);
            this.lsVentas.Name = "lsVentas";
            this.lsVentas.Size = new System.Drawing.Size(799, 274);
            this.lsVentas.TabIndex = 0;
            // 
            // lblFacturacion
            // 
            this.lblFacturacion.AutoSize = true;
            this.lblFacturacion.Location = new System.Drawing.Point(628, 318);
            this.lblFacturacion.Name = "lblFacturacion";
            this.lblFacturacion.Size = new System.Drawing.Size(0, 15);
            this.lblFacturacion.TabIndex = 2;
            // 
            // FormVentasRealizadas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 342);
            this.Controls.Add(this.lblFacturacion);
            this.Controls.Add(this.lsVentas);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVentasRealizadas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventas Realizadas";
            this.Load += new System.EventHandler(this.FormVentasRealizadas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lsVentas;
        private System.Windows.Forms.Label lblFacturacion;
    }
}