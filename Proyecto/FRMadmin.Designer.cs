
namespace Proyecto
{
    partial class FRMadmin
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.fecha = new System.Windows.Forms.TextBox();
            this.director = new System.Windows.Forms.TextBox();
            this.genero = new System.Windows.Forms.TextBox();
            this.BTNvolver = new System.Windows.Forms.Button();
            this.BTNborrar = new System.Windows.Forms.Button();
            this.BTNagregar = new System.Windows.Forms.Button();
            this.ATP = new System.Windows.Forms.RadioButton();
            this.pre = new System.Windows.Forms.RadioButton();
            this.ado = new System.Windows.Forms.RadioButton();
            this.adu = new System.Windows.Forms.RadioButton();
            this.DWVcatalogo = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estreno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clasificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label5 = new System.Windows.Forms.Label();
            this.sinopsis = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DWVcatalogo)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "director:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 146);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 15);
            this.label4.TabIndex = 3;
            this.label4.Text = "género:";
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(89, 14);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(257, 23);
            this.nombre.TabIndex = 4;
            // 
            // fecha
            // 
            this.fecha.Location = new System.Drawing.Point(89, 54);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(257, 23);
            this.fecha.TabIndex = 5;
            // 
            // director
            // 
            this.director.AcceptsReturn = true;
            this.director.Location = new System.Drawing.Point(89, 99);
            this.director.Name = "director";
            this.director.Size = new System.Drawing.Size(257, 23);
            this.director.TabIndex = 6;
            // 
            // genero
            // 
            this.genero.Location = new System.Drawing.Point(89, 143);
            this.genero.Name = "genero";
            this.genero.Size = new System.Drawing.Size(257, 23);
            this.genero.TabIndex = 7;
            // 
            // BTNvolver
            // 
            this.BTNvolver.Location = new System.Drawing.Point(31, 418);
            this.BTNvolver.Name = "BTNvolver";
            this.BTNvolver.Size = new System.Drawing.Size(60, 23);
            this.BTNvolver.TabIndex = 8;
            this.BTNvolver.Text = "Volver";
            this.BTNvolver.UseVisualStyleBackColor = true;
            this.BTNvolver.Click += new System.EventHandler(this.BTNvolver_Click);
            // 
            // BTNborrar
            // 
            this.BTNborrar.Location = new System.Drawing.Point(647, 372);
            this.BTNborrar.Name = "BTNborrar";
            this.BTNborrar.Size = new System.Drawing.Size(60, 23);
            this.BTNborrar.TabIndex = 9;
            this.BTNborrar.Text = "borrar";
            this.BTNborrar.UseVisualStyleBackColor = true;
            this.BTNborrar.Click += new System.EventHandler(this.BTNborrar_Click);
            // 
            // BTNagregar
            // 
            this.BTNagregar.Location = new System.Drawing.Point(647, 418);
            this.BTNagregar.Name = "BTNagregar";
            this.BTNagregar.Size = new System.Drawing.Size(60, 23);
            this.BTNagregar.TabIndex = 10;
            this.BTNagregar.Text = "agregar";
            this.BTNagregar.UseVisualStyleBackColor = true;
            this.BTNagregar.Click += new System.EventHandler(this.BTNagregar_Click);
            // 
            // ATP
            // 
            this.ATP.AutoSize = true;
            this.ATP.Checked = true;
            this.ATP.Location = new System.Drawing.Point(31, 218);
            this.ATP.Name = "ATP";
            this.ATP.Size = new System.Drawing.Size(45, 19);
            this.ATP.TabIndex = 11;
            this.ATP.TabStop = true;
            this.ATP.Text = "ATP";
            this.ATP.UseVisualStyleBackColor = true;
            // 
            // pre
            // 
            this.pre.AutoSize = true;
            this.pre.Location = new System.Drawing.Point(125, 218);
            this.pre.Name = "pre";
            this.pre.Size = new System.Drawing.Size(45, 19);
            this.pre.TabIndex = 12;
            this.pre.Text = "+13";
            this.pre.UseVisualStyleBackColor = true;
            // 
            // ado
            // 
            this.ado.AutoSize = true;
            this.ado.Location = new System.Drawing.Point(214, 218);
            this.ado.Name = "ado";
            this.ado.Size = new System.Drawing.Size(45, 19);
            this.ado.TabIndex = 13;
            this.ado.Text = "+16";
            this.ado.UseVisualStyleBackColor = true;
            // 
            // adu
            // 
            this.adu.AutoSize = true;
            this.adu.Location = new System.Drawing.Point(301, 218);
            this.adu.Name = "adu";
            this.adu.Size = new System.Drawing.Size(45, 19);
            this.adu.TabIndex = 14;
            this.adu.Text = "+18";
            this.adu.UseVisualStyleBackColor = true;
            // 
            // DWVcatalogo
            // 
            this.DWVcatalogo.AllowUserToAddRows = false;
            this.DWVcatalogo.AllowUserToDeleteRows = false;
            this.DWVcatalogo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DWVcatalogo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DWVcatalogo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.estreno,
            this.dataGridViewTextBoxColumn3,
            this.clasificacion,
            this.ID});
            this.DWVcatalogo.Location = new System.Drawing.Point(99, 278);
            this.DWVcatalogo.MultiSelect = false;
            this.DWVcatalogo.Name = "DWVcatalogo";
            this.DWVcatalogo.ReadOnly = true;
            this.DWVcatalogo.RowHeadersVisible = false;
            this.DWVcatalogo.RowTemplate.Height = 25;
            this.DWVcatalogo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DWVcatalogo.Size = new System.Drawing.Size(504, 163);
            this.DWVcatalogo.TabIndex = 15;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.dataGridViewTextBoxColumn1.Width = 111;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Director";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // estreno
            // 
            this.estreno.HeaderText = "Estreno";
            this.estreno.Name = "estreno";
            this.estreno.ReadOnly = true;
            this.estreno.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Género";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // clasificacion
            // 
            this.clasificacion.HeaderText = "Clasificación";
            this.clasificacion.Name = "clasificacion";
            this.clasificacion.ReadOnly = true;
            this.clasificacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.ID.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(512, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 30);
            this.label5.TabIndex = 17;
            this.label5.Text = "Sinopsis";
            // 
            // sinopsis
            // 
            this.sinopsis.Location = new System.Drawing.Point(407, 43);
            this.sinopsis.Multiline = true;
            this.sinopsis.Name = "sinopsis";
            this.sinopsis.Size = new System.Drawing.Size(300, 194);
            this.sinopsis.TabIndex = 18;
            // 
            // FRMadmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 475);
            this.Controls.Add(this.sinopsis);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.DWVcatalogo);
            this.Controls.Add(this.adu);
            this.Controls.Add(this.ado);
            this.Controls.Add(this.pre);
            this.Controls.Add(this.ATP);
            this.Controls.Add(this.BTNagregar);
            this.Controls.Add(this.BTNborrar);
            this.Controls.Add(this.BTNvolver);
            this.Controls.Add(this.genero);
            this.Controls.Add(this.director);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FRMadmin";
            this.Text = "FRMadmin";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FRMadmin_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DWVcatalogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox fecha;
        private System.Windows.Forms.TextBox director;
        private System.Windows.Forms.TextBox genero;
        private System.Windows.Forms.Button BTNvolver;
        private System.Windows.Forms.Button BTNborrar;
        private System.Windows.Forms.Button BTNagregar;
        private System.Windows.Forms.RadioButton ATP;
        private System.Windows.Forms.RadioButton pre;
        private System.Windows.Forms.RadioButton ado;
        private System.Windows.Forms.RadioButton adu;
        private System.Windows.Forms.DataGridView DWVcatalogo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox sinopsis;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn estreno;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clasificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
    }
}