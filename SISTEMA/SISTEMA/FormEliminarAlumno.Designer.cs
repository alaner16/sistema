namespace SISTEMA
{
    partial class FormEliminarAlumno
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
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.lbl_ap = new System.Windows.Forms.Label();
            this.lbl_am = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.txt_ap = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_am = new System.Windows.Forms.TextBox();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.btn_regresar_alumno = new System.Windows.Forms.Button();
            this.btn_eliminar_alumno = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(35, 39);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 0;
            this.lbl_nombre.Text = "Nombre";
            this.lbl_nombre.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Location = new System.Drawing.Point(35, 81);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(83, 13);
            this.lbl_ap.TabIndex = 2;
            this.lbl_ap.Text = "Apellido paterno";
            // 
            // lbl_am
            // 
            this.lbl_am.AutoSize = true;
            this.lbl_am.Location = new System.Drawing.Point(35, 117);
            this.lbl_am.Name = "lbl_am";
            this.lbl_am.Size = new System.Drawing.Size(85, 13);
            this.lbl_am.TabIndex = 3;
            this.lbl_am.Text = "Apellido materno";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(35, 155);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(50, 13);
            this.lbl_matricula.TabIndex = 4;
            this.lbl_matricula.Text = "Matricula";
            // 
            // lbl_curp
            // 
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Location = new System.Drawing.Point(35, 185);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(37, 13);
            this.lbl_curp.TabIndex = 5;
            this.lbl_curp.Text = "CURP";
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(133, 36);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 6;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(133, 78);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(100, 20);
            this.txt_ap.TabIndex = 7;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(133, 152);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 8;
            // 
            // txt_am
            // 
            this.txt_am.Location = new System.Drawing.Point(133, 114);
            this.txt_am.Name = "txt_am";
            this.txt_am.Size = new System.Drawing.Size(100, 20);
            this.txt_am.TabIndex = 9;
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(133, 182);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(100, 20);
            this.txt_curp.TabIndex = 10;
            // 
            // btn_regresar_alumno
            // 
            this.btn_regresar_alumno.Location = new System.Drawing.Point(13, 226);
            this.btn_regresar_alumno.Name = "btn_regresar_alumno";
            this.btn_regresar_alumno.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar_alumno.TabIndex = 11;
            this.btn_regresar_alumno.Text = "REGRESAR";
            this.btn_regresar_alumno.UseVisualStyleBackColor = true;
            this.btn_regresar_alumno.Click += new System.EventHandler(this.btn_regresar_alumno_Click);
            // 
            // btn_eliminar_alumno
            // 
            this.btn_eliminar_alumno.Location = new System.Drawing.Point(187, 226);
            this.btn_eliminar_alumno.Name = "btn_eliminar_alumno";
            this.btn_eliminar_alumno.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_alumno.TabIndex = 12;
            this.btn_eliminar_alumno.Text = "ELIMINAR";
            this.btn_eliminar_alumno.UseVisualStyleBackColor = true;
            // 
            // FormEliminarAlumno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_eliminar_alumno);
            this.Controls.Add(this.btn_regresar_alumno);
            this.Controls.Add(this.txt_curp);
            this.Controls.Add(this.txt_am);
            this.Controls.Add(this.txt_matricula);
            this.Controls.Add(this.txt_ap);
            this.Controls.Add(this.txt_nombre);
            this.Controls.Add(this.lbl_curp);
            this.Controls.Add(this.lbl_matricula);
            this.Controls.Add(this.lbl_am);
            this.Controls.Add(this.lbl_ap);
            this.Controls.Add(this.lbl_nombre);
            this.Name = "FormEliminarAlumno";
            this.Text = "FormEliminarAlumno";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_nombre;
        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.Label lbl_am;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_am;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.Button btn_regresar_alumno;
        private System.Windows.Forms.Button btn_eliminar_alumno;
    }
}