
namespace ParcialBrunoDeRenzis
{
    partial class FormVenta
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormVenta));
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.btnAgregarAVenta = new System.Windows.Forms.Button();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtBoxCantidad = new System.Windows.Forms.TextBox();
            this.btnConfirmar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.lsProductosVenta = new System.Windows.Forms.ListBox();
            this.tbProducto = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Location = new System.Drawing.Point(0, 44);
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            this.dgvProductos.RowTemplate.Height = 25;
            this.dgvProductos.Size = new System.Drawing.Size(711, 184);
            this.dgvProductos.TabIndex = 0;
            // 
            // btnAgregarAVenta
            // 
            this.btnAgregarAVenta.Location = new System.Drawing.Point(55, 328);
            this.btnAgregarAVenta.Name = "btnAgregarAVenta";
            this.btnAgregarAVenta.Size = new System.Drawing.Size(152, 52);
            this.btnAgregarAVenta.TabIndex = 1;
            this.btnAgregarAVenta.Text = "Agregar";
            this.btnAgregarAVenta.UseVisualStyleBackColor = true;
            this.btnAgregarAVenta.Click += new System.EventHandler(this.btnAgregarAVenta_Click);
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(55, 273);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(55, 15);
            this.lblCantidad.TabIndex = 2;
            this.lblCantidad.Text = "Cantidad";
            // 
            // txtBoxCantidad
            // 
            this.txtBoxCantidad.Location = new System.Drawing.Point(116, 270);
            this.txtBoxCantidad.Name = "txtBoxCantidad";
            this.txtBoxCantidad.Size = new System.Drawing.Size(100, 23);
            this.txtBoxCantidad.TabIndex = 3;
            // 
            // btnConfirmar
            // 
            this.btnConfirmar.Location = new System.Drawing.Point(1286, 307);
            this.btnConfirmar.Name = "btnConfirmar";
            this.btnConfirmar.Size = new System.Drawing.Size(152, 52);
            this.btnConfirmar.TabIndex = 4;
            this.btnConfirmar.Text = "Confirmar Compra";
            this.btnConfirmar.UseVisualStyleBackColor = true;
            this.btnConfirmar.Click += new System.EventHandler(this.btnConfirmar_Click);
            // 
            // dgvClientes
            // 
            this.dgvClientes.AllowUserToDeleteRows = false;
            this.dgvClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClientes.Location = new System.Drawing.Point(717, 0);
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowTemplate.Height = 25;
            this.dgvClientes.Size = new System.Drawing.Size(728, 295);
            this.dgvClientes.TabIndex = 5;
            // 
            // lsProductosVenta
            // 
            this.lsProductosVenta.FormattingEnabled = true;
            this.lsProductosVenta.ItemHeight = 15;
            this.lsProductosVenta.Location = new System.Drawing.Point(404, 258);
            this.lsProductosVenta.Name = "lsProductosVenta";
            this.lsProductosVenta.Size = new System.Drawing.Size(256, 214);
            this.lsProductosVenta.TabIndex = 6;
            // 
            // tbProducto
            // 
            this.tbProducto.Location = new System.Drawing.Point(0, 15);
            this.tbProducto.Name = "tbProducto";
            this.tbProducto.PlaceholderText = "Ingrese nombre producto";
            this.tbProducto.Size = new System.Drawing.Size(309, 23);
            this.tbProducto.TabIndex = 7;
            this.tbProducto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbProducto_KeyUp);
            // 
            // FormVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1450, 507);
            this.Controls.Add(this.tbProducto);
            this.Controls.Add(this.lsProductosVenta);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.btnConfirmar);
            this.Controls.Add(this.txtBoxCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.btnAgregarAVenta);
            this.Controls.Add(this.dgvProductos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormVenta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venta Nueva";
            this.Load += new System.EventHandler(this.FormVenta_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.Button btnAgregarAVenta;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.TextBox txtBoxCantidad;
        private System.Windows.Forms.Button btnConfirmar;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.ListBox lsProductosVenta;
        private System.Windows.Forms.TextBox tbProducto;
    }
}