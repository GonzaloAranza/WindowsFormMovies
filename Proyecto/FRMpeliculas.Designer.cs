
namespace Proyecto
{
    partial class FRMpeliculas
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
            this.BTNatras = new System.Windows.Forms.Button();
            this.DWVcatalogo = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.director = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BTNcomentar = new System.Windows.Forms.Button();
            this.Texto1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DWVcatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // BTNatras
            // 
            this.BTNatras.Location = new System.Drawing.Point(52, 502);
            this.BTNatras.Name = "BTNatras";
            this.BTNatras.Size = new System.Drawing.Size(123, 33);
            this.BTNatras.TabIndex = 0;
            this.BTNatras.Text = "Cerrar sesión";
            this.BTNatras.UseVisualStyleBackColor = true;
            this.BTNatras.Click += new System.EventHandler(this.BTNatras_Click);
            // 
            // DWVcatalogo
            // 
            this.DWVcatalogo.AllowUserToAddRows = false;
            this.DWVcatalogo.AllowUserToDeleteRows = false;
            this.DWVcatalogo.AllowUserToResizeColumns = false;
            this.DWVcatalogo.AllowUserToResizeRows = false;
            this.DWVcatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DWVcatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.fecha,
            this.director,
            this.genero,
            this.clasificacion});
            this.DWVcatalogo.Location = new System.Drawing.Point(52, 166);
            this.DWVcatalogo.MultiSelect = false;
            this.DWVcatalogo.Name = "DWVcatalogo";
            this.DWVcatalogo.ReadOnly = true;
            this.DWVcatalogo.RowHeadersVisible = false;
            this.DWVcatalogo.RowTemplate.Height = 25;
            this.DWVcatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DWVcatalogo.Size = new System.Drawing.Size(503, 274);
            this.DWVcatalogo.TabIndex = 1;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            this.nombre.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha de estreno";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            this.fecha.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // director
            // 
            this.director.HeaderText = "Director";
            this.director.Name = "director";
            this.director.ReadOnly = true;
            this.director.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // genero
            // 
            this.genero.HeaderText = "Género";
            this.genero.Name = "genero";
            this.genero.ReadOnly = true;
            this.genero.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clasificacion
            // 
            this.clasificacion.HeaderText = "Clasificacion";
            this.clasificacion.Name = "clasificacion";
            this.clasificacion.ReadOnly = true;
            this.clasificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // BTNcomentar
            // 
            this.BTNcomentar.Location = new System.Drawing.Point(400, 502);
            this.BTNcomentar.Name = "BTNcomentar";
            this.BTNcomentar.Size = new System.Drawing.Size(154, 32);
            this.BTNcomentar.TabIndex = 2;
            this.BTNcomentar.Text = "Comentarios";
            this.BTNcomentar.UseVisualStyleBackColor = true;
            this.BTNcomentar.Click += new System.EventHandler(this.BTNcomentar_Click);
            // 
            // Texto1
            // 
            this.Texto1.AutoSize = true;
            this.Texto1.Location = new System.Drawing.Point(52, 34);
            this.Texto1.Name = "Texto1";
            this.Texto1.Size = new System.Drawing.Size(38, 15);
            this.Texto1.TabIndex = 3;
            this.Texto1.Text = "label1";
            // 
            // FRMpeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 586);
            this.Controls.Add(this.Texto1);
            this.Controls.Add(this.BTNcomentar);
            this.Controls.Add(this.DWVcatalogo);
            this.Controls.Add(this.BTNatras);
            this.Name = "FRMpeliculas";
            this.Text = "FRMpeliculas";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMusuario_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DWVcatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNatras;
        private System.Windows.Forms.DataGridView DWVcatalogo;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn director;
        private System.Windows.Forms.DataGridViewTextBoxColumn genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacion;
        private System.Windows.Forms.Button BTNcomentar;
        private System.Windows.Forms.Label Texto1;
    }
}