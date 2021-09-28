
namespace ParcialBrunoDeRenzis
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.tbUser = new System.Windows.Forms.TextBox();
            this.tbPass = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.lsUsuarios = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // tbUser
            // 
            this.tbUser.Location = new System.Drawing.Point(188, 39);
            this.tbUser.Name = "tbUser";
            this.tbUser.PlaceholderText = "Ingrese usuario";
            this.tbUser.Size = new System.Drawing.Size(166, 23);
            this.tbUser.TabIndex = 0;
            // 
            // tbPass
            // 
            this.tbPass.Location = new System.Drawing.Point(188, 98);
            this.tbPass.Name = "tbPass";
            this.tbPass.PasswordChar = '*';
            this.tbPass.PlaceholderText = "Ingrese contraseña";
            this.tbPass.Size = new System.Drawing.Size(166, 23);
            this.tbPass.TabIndex = 1;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(197, 148);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(142, 43);
            this.btnIngresar.TabIndex = 0;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // lsUsuarios
            // 
            this.lsUsuarios.FormattingEnabled = true;
            this.lsUsuarios.ItemHeight = 15;
            this.lsUsuarios.Location = new System.Drawing.Point(399, 37);
            this.lsUsuarios.Name = "lsUsuarios";
            this.lsUsuarios.Size = new System.Drawing.Size(183, 154);
            this.lsUsuarios.TabIndex = 2;
            this.lsUsuarios.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lsUsuarios_MouseClick);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(594, 203);
            this.Controls.Add(this.lsUsuarios);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.tbPass);
            this.Controls.Add(this.tbUser);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logueo Usuario";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbUser;
        private System.Windows.Forms.TextBox tbPass;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.ListBox lsUsuarios;
    }
}