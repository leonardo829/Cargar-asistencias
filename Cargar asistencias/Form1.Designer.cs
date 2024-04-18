namespace Cargar_asistencias_FE
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnEntrar = new System.Windows.Forms.Button();
            this.lblNombre = new System.Windows.Forms.Label();
            this.textBoxNombreProfesor = new System.Windows.Forms.TextBox();
            this.lblTituloAsistidor = new System.Windows.Forms.Label();
            this.lblMateria = new System.Windows.Forms.Label();
            this.lblInstitución = new System.Windows.Forms.Label();
            this.TextBoxNombreMateria = new System.Windows.Forms.TextBox();
            this.textBoxNombreInst = new System.Windows.Forms.TextBox();
            this.errorNombreProfesor = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorMateria = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorInstitucion = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreProfesor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMateria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstitucion)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEntrar
            // 
            this.btnEntrar.Location = new System.Drawing.Point(642, 365);
            this.btnEntrar.Name = "btnEntrar";
            this.btnEntrar.Size = new System.Drawing.Size(105, 42);
            this.btnEntrar.TabIndex = 0;
            this.btnEntrar.Text = "Entrar";
            this.btnEntrar.UseVisualStyleBackColor = true;
            this.btnEntrar.Click += new System.EventHandler(this.btnEntrar_Click);
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(135, 137);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(102, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del profesor";
            // 
            // textBoxNombreProfesor
            // 
            this.textBoxNombreProfesor.Location = new System.Drawing.Point(314, 137);
            this.textBoxNombreProfesor.Name = "textBoxNombreProfesor";
            this.textBoxNombreProfesor.Size = new System.Drawing.Size(211, 20);
            this.textBoxNombreProfesor.TabIndex = 2;
            // 
            // lblTituloAsistidor
            // 
            this.lblTituloAsistidor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblTituloAsistidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.lblTituloAsistidor.Location = new System.Drawing.Point(314, 9);
            this.lblTituloAsistidor.Name = "lblTituloAsistidor";
            this.lblTituloAsistidor.Size = new System.Drawing.Size(211, 43);
            this.lblTituloAsistidor.TabIndex = 3;
            this.lblTituloAsistidor.Text = "ASISTIDOR";
            // 
            // lblMateria
            // 
            this.lblMateria.AutoSize = true;
            this.lblMateria.Location = new System.Drawing.Point(135, 176);
            this.lblMateria.Name = "lblMateria";
            this.lblMateria.Size = new System.Drawing.Size(97, 13);
            this.lblMateria.TabIndex = 4;
            this.lblMateria.Text = "Materia/Asignatura";
            // 
            // lblInstitución
            // 
            this.lblInstitución.AutoSize = true;
            this.lblInstitución.Location = new System.Drawing.Point(135, 215);
            this.lblInstitución.Name = "lblInstitución";
            this.lblInstitución.Size = new System.Drawing.Size(55, 13);
            this.lblInstitución.TabIndex = 5;
            this.lblInstitución.Text = "Institución";
            // 
            // TextBoxNombreMateria
            // 
            this.TextBoxNombreMateria.Location = new System.Drawing.Point(314, 176);
            this.TextBoxNombreMateria.Name = "TextBoxNombreMateria";
            this.TextBoxNombreMateria.Size = new System.Drawing.Size(211, 20);
            this.TextBoxNombreMateria.TabIndex = 6;
            // 
            // textBoxNombreInst
            // 
            this.textBoxNombreInst.Location = new System.Drawing.Point(315, 216);
            this.textBoxNombreInst.Name = "textBoxNombreInst";
            this.textBoxNombreInst.Size = new System.Drawing.Size(211, 20);
            this.textBoxNombreInst.TabIndex = 7;
            // 
            // errorNombreProfesor
            // 
            this.errorNombreProfesor.ContainerControl = this;
            // 
            // errorMateria
            // 
            this.errorMateria.ContainerControl = this;
            // 
            // errorInstitucion
            // 
            this.errorInstitucion.ContainerControl = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(789, 427);
            this.Controls.Add(this.textBoxNombreInst);
            this.Controls.Add(this.TextBoxNombreMateria);
            this.Controls.Add(this.lblInstitución);
            this.Controls.Add(this.lblMateria);
            this.Controls.Add(this.lblTituloAsistidor);
            this.Controls.Add(this.textBoxNombreProfesor);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.btnEntrar);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreProfesor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMateria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorInstitucion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEntrar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textBoxNombreProfesor;
        private System.Windows.Forms.Label lblTituloAsistidor;
        private System.Windows.Forms.Label lblMateria;
        private System.Windows.Forms.Label lblInstitución;
        private System.Windows.Forms.TextBox TextBoxNombreMateria;
        private System.Windows.Forms.TextBox textBoxNombreInst;
        private System.Windows.Forms.ErrorProvider errorNombreProfesor;
        private System.Windows.Forms.ErrorProvider errorMateria;
        private System.Windows.Forms.ErrorProvider errorInstitucion;
    }
}

