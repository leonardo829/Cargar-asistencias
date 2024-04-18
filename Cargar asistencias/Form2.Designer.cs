namespace Cargar_asistencias_FE
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.btnCargar = new System.Windows.Forms.Button();
            this.textBoxNombreDelAlumno = new System.Windows.Forms.TextBox();
            this.lblNombreDelAlumno = new System.Windows.Forms.Label();
            this.lblApellidoAlumno = new System.Windows.Forms.Label();
            this.lblNota = new System.Windows.Forms.Label();
            this.lblSeguimiento = new System.Windows.Forms.Label();
            this.textBoxApellidoDelAlumno = new System.Windows.Forms.TextBox();
            this.textBoxNota = new System.Windows.Forms.TextBox();
            this.textBoxSeguimiento = new System.Windows.Forms.TextBox();
            this.DataGridView1 = new System.Windows.Forms.DataGridView();
            this.errorNota = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(1290, 615);
            this.btnCargar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(128, 58);
            this.btnCargar.TabIndex = 0;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // textBoxNombreDelAlumno
            // 
            this.textBoxNombreDelAlumno.Location = new System.Drawing.Point(422, 174);
            this.textBoxNombreDelAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNombreDelAlumno.Name = "textBoxNombreDelAlumno";
            this.textBoxNombreDelAlumno.Size = new System.Drawing.Size(379, 26);
            this.textBoxNombreDelAlumno.TabIndex = 1;
            // 
            // lblNombreDelAlumno
            // 
            this.lblNombreDelAlumno.AutoSize = true;
            this.lblNombreDelAlumno.Location = new System.Drawing.Point(154, 174);
            this.lblNombreDelAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreDelAlumno.Name = "lblNombreDelAlumno";
            this.lblNombreDelAlumno.Size = new System.Drawing.Size(148, 20);
            this.lblNombreDelAlumno.TabIndex = 2;
            this.lblNombreDelAlumno.Text = "Nombre del Alumno";
            // 
            // lblApellidoAlumno
            // 
            this.lblApellidoAlumno.AutoSize = true;
            this.lblApellidoAlumno.Location = new System.Drawing.Point(154, 266);
            this.lblApellidoAlumno.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellidoAlumno.Name = "lblApellidoAlumno";
            this.lblApellidoAlumno.Size = new System.Drawing.Size(148, 20);
            this.lblApellidoAlumno.TabIndex = 3;
            this.lblApellidoAlumno.Text = "Apellido del Alumno";
            // 
            // lblNota
            // 
            this.lblNota.AutoSize = true;
            this.lblNota.Location = new System.Drawing.Point(154, 357);
            this.lblNota.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNota.Name = "lblNota";
            this.lblNota.Size = new System.Drawing.Size(43, 20);
            this.lblNota.TabIndex = 4;
            this.lblNota.Text = "Nota";
            // 
            // lblSeguimiento
            // 
            this.lblSeguimiento.AutoSize = true;
            this.lblSeguimiento.Location = new System.Drawing.Point(154, 432);
            this.lblSeguimiento.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeguimiento.Name = "lblSeguimiento";
            this.lblSeguimiento.Size = new System.Drawing.Size(98, 20);
            this.lblSeguimiento.TabIndex = 5;
            this.lblSeguimiento.Text = "Seguimiento";
            // 
            // textBoxApellidoDelAlumno
            // 
            this.textBoxApellidoDelAlumno.Location = new System.Drawing.Point(422, 266);
            this.textBoxApellidoDelAlumno.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxApellidoDelAlumno.Name = "textBoxApellidoDelAlumno";
            this.textBoxApellidoDelAlumno.Size = new System.Drawing.Size(379, 26);
            this.textBoxApellidoDelAlumno.TabIndex = 6;
            // 
            // textBoxNota
            // 
            this.textBoxNota.Location = new System.Drawing.Point(422, 352);
            this.textBoxNota.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxNota.Name = "textBoxNota";
            this.textBoxNota.Size = new System.Drawing.Size(379, 26);
            this.textBoxNota.TabIndex = 7;
            // 
            // textBoxSeguimiento
            // 
            this.textBoxSeguimiento.Location = new System.Drawing.Point(422, 432);
            this.textBoxSeguimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxSeguimiento.Name = "textBoxSeguimiento";
            this.textBoxSeguimiento.Size = new System.Drawing.Size(379, 26);
            this.textBoxSeguimiento.TabIndex = 8;
            // 
            // DataGridView1
            // 
            this.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridView1.Location = new System.Drawing.Point(837, 174);
            this.DataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DataGridView1.Name = "DataGridView1";
            this.DataGridView1.RowHeadersWidth = 62;
            this.DataGridView1.Size = new System.Drawing.Size(562, 289);
            this.DataGridView1.TabIndex = 9;
            // 
            // errorNota
            // 
            this.errorNota.BlinkRate = 100;
            this.errorNota.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1635, 692);
            this.Controls.Add(this.DataGridView1);
            this.Controls.Add(this.textBoxSeguimiento);
            this.Controls.Add(this.textBoxNota);
            this.Controls.Add(this.textBoxApellidoDelAlumno);
            this.Controls.Add(this.lblSeguimiento);
            this.Controls.Add(this.lblNota);
            this.Controls.Add(this.lblApellidoAlumno);
            this.Controls.Add(this.lblNombreDelAlumno);
            this.Controls.Add(this.textBoxNombreDelAlumno);
            this.Controls.Add(this.btnCargar);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.DataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNota)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox textBoxNombreDelAlumno;
        private System.Windows.Forms.Label lblNombreDelAlumno;
        private System.Windows.Forms.Label lblApellidoAlumno;
        private System.Windows.Forms.Label lblNota;
        private System.Windows.Forms.Label lblSeguimiento;
        private System.Windows.Forms.TextBox textBoxApellidoDelAlumno;
        private System.Windows.Forms.TextBox textBoxNota;
        private System.Windows.Forms.TextBox textBoxSeguimiento;
        private System.Windows.Forms.DataGridView DataGridView1;
        private System.Windows.Forms.ErrorProvider errorNota;
    }
}