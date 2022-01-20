
namespace Proyecto
{
    partial class FRMlogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNacceder = new System.Windows.Forms.Button();
            this.BTNcrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.usuario = new System.Windows.Forms.TextBox();
            this.contraseña = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // BTNacceder
            // 
            this.BTNacceder.Location = new System.Drawing.Point(171, 124);
            this.BTNacceder.Name = "BTNacceder";
            this.BTNacceder.Size = new System.Drawing.Size(122, 42);
            this.BTNacceder.TabIndex = 0;
            this.BTNacceder.Text = "Ingresar";
            this.BTNacceder.UseVisualStyleBackColor = true;
            this.BTNacceder.Click += new System.EventHandler(this.BTNacceder_Click);
            // 
            // BTNcrear
            // 
            this.BTNcrear.Location = new System.Drawing.Point(12, 124);
            this.BTNcrear.Name = "BTNcrear";
            this.BTNcrear.Size = new System.Drawing.Size(122, 42);
            this.BTNcrear.TabIndex = 1;
            this.BTNcrear.Text = "Crear Usuario";
            this.BTNcrear.UseVisualStyleBackColor = true;
            this.BTNcrear.Click += new System.EventHandler(this.BTNcrear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Contraseña:";
            // 
            // usuario
            // 
            this.usuario.Location = new System.Drawing.Point(88, 8);
            this.usuario.Name = "usuario";
            this.usuario.Size = new System.Drawing.Size(175, 23);
            this.usuario.TabIndex = 4;
            // 
            // contraseña
            // 
            this.contraseña.Location = new System.Drawing.Point(88, 51);
            this.contraseña.Name = "contraseña";
            this.contraseña.Size = new System.Drawing.Size(176, 23);
            this.contraseña.TabIndex = 5;
            // 
            // FRMlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(321, 200);
            this.Controls.Add(this.contraseña);
            this.Controls.Add(this.usuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BTNcrear);
            this.Controls.Add(this.BTNacceder);
            this.Name = "FRMlogin";
            this.Text = "Log In";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNacceder;
        private System.Windows.Forms.Button BTNcrear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox usuario;
        private System.Windows.Forms.TextBox contraseña;
    }
}

