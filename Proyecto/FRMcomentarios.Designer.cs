
namespace Proyecto
{
    partial class FRMcomentarios
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
            this.comentario = new System.Windows.Forms.TextBox();
            this.BTNcomentar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comentario
            // 
            this.comentario.Location = new System.Drawing.Point(113, 220);
            this.comentario.Name = "comentario";
            this.comentario.Size = new System.Drawing.Size(561, 23);
            this.comentario.TabIndex = 0;
            // 
            // BTNcomentar
            // 
            this.BTNcomentar.Location = new System.Drawing.Point(511, 355);
            this.BTNcomentar.Name = "BTNcomentar";
            this.BTNcomentar.Size = new System.Drawing.Size(181, 50);
            this.BTNcomentar.TabIndex = 1;
            this.BTNcomentar.Text = "Comentar";
            this.BTNcomentar.UseVisualStyleBackColor = true;
            this.BTNcomentar.Click += new System.EventHandler(this.BTNcomentar_Click);
            // 
            // FRMcomentarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BTNcomentar);
            this.Controls.Add(this.comentario);
            this.Name = "FRMcomentarios";
            this.Text = "FRMcomentarios";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMcomentarios_FormClosed);
            this.Load += new System.EventHandler(this.FRMcomentarios_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox comentario;
        private System.Windows.Forms.Button BTNcomentar;
    }
}