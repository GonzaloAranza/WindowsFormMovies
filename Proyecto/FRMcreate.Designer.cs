
namespace Proyecto
{
    partial class FRMcreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.BTNsalir = new System.Windows.Forms.Button();
            this.BTNcrear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Contraseña:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(78, 5);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(178, 23);
            this.usuario.TabIndex = 3;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(78, 42);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(178, 23);
            this.contraseña.TabIndex = 4;
            // 
            // BTNsalir
            // 
            this.BTNsalir.Location = new System.Drawing.Point(12, 104);
            this.BTNsalir.Name = "BTNsalir";
            this.BTNsalir.Size = new System.Drawing.Size(98, 21);
            this.BTNsalir.TabIndex = 6;
            this.BTNsalir.Text = "Volver";
            this.BTNsalir.UseVisualStyleBackColor = true;
            this.BTNsalir.Click += new System.EventHandler(this.BTNsalir_Click);
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(158, 104);
            this.BTNcrear.Name = "BTNcrear";
            this.BTNcrear.Size = new System.Drawing.Size(98, 21);
            this.BTNcrear.TabIndex = 7;
            this.BTNcrear.Text = "Crear";
            this.BTNcrear.UseVisualStyleBackColor = true;
            this.BTNcrear.Click += new System.EventHandler(this.BTNcrear_Click);
            // 
            // FRMcreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(293, 158);
            this.Controls.Add(this.BTNcrear);
            this.Controls.Add(this.BTNsalir);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMcreate";
            this.Text = "Create Account";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMcreate_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
        private System.Windows.Forms.Button BTNsalir;
        private System.Windows.Forms.Button BTNcrear;
    }
}