namespace SISTEMA
{
    partial class FormEliminarMaestro
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
            this.btn_eliminar_maestro = new System.Windows.Forms.Button();
            this.btn_regresar_maestro = new System.Windows.Forms.Button();
            this.txt_curp = new System.Windows.Forms.TextBox();
            this.txt_am = new System.Windows.Forms.TextBox();
            this.txt_matricula = new System.Windows.Forms.TextBox();
            this.txt_ap = new System.Windows.Forms.TextBox();
            this.txt_nombre = new System.Windows.Forms.TextBox();
            this.lbl_curp = new System.Windows.Forms.Label();
            this.lbl_matricula = new System.Windows.Forms.Label();
            this.lbl_am = new System.Windows.Forms.Label();
            this.lbl_ap = new System.Windows.Forms.Label();
            this.lbl_nombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_eliminar_maestro
            // 
            this.btn_eliminar_maestro.Location = new System.Drawing.Point(192, 214);
            this.btn_eliminar_maestro.Name = "btn_eliminar_maestro";
            this.btn_eliminar_maestro.Size = new System.Drawing.Size(75, 23);
            this.btn_eliminar_maestro.TabIndex = 24;
            this.btn_eliminar_maestro.Text = "ELIMINAR";
            this.btn_eliminar_maestro.UseVisualStyleBackColor = true;
            // 
            // btn_regresar_maestro
            // 
            this.btn_regresar_maestro.Location = new System.Drawing.Point(18, 214);
            this.btn_regresar_maestro.Name = "btn_regresar_maestro";
            this.btn_regresar_maestro.Size = new System.Drawing.Size(75, 23);
            this.btn_regresar_maestro.TabIndex = 23;
            this.btn_regresar_maestro.Text = "REGRESAR";
            this.btn_regresar_maestro.UseVisualStyleBackColor = true;
            this.btn_regresar_maestro.Click += new System.EventHandler(this.btn_regresar_maestro_Click);
            // 
            // txt_curp
            // 
            this.txt_curp.Location = new System.Drawing.Point(138, 170);
            this.txt_curp.Name = "txt_curp";
            this.txt_curp.Size = new System.Drawing.Size(100, 20);
            this.txt_curp.TabIndex = 22;
            // 
            // txt_am
            // 
            this.txt_am.Location = new System.Drawing.Point(138, 102);
            this.txt_am.Name = "txt_am";
            this.txt_am.Size = new System.Drawing.Size(100, 20);
            this.txt_am.TabIndex = 21;
            // 
            // txt_matricula
            // 
            this.txt_matricula.Location = new System.Drawing.Point(138, 140);
            this.txt_matricula.Name = "txt_matricula";
            this.txt_matricula.Size = new System.Drawing.Size(100, 20);
            this.txt_matricula.TabIndex = 20;
            // 
            // txt_ap
            // 
            this.txt_ap.Location = new System.Drawing.Point(138, 66);
            this.txt_ap.Name = "txt_ap";
            this.txt_ap.Size = new System.Drawing.Size(100, 20);
            this.txt_ap.TabIndex = 19;
            // 
            // txt_nombre
            // 
            this.txt_nombre.Location = new System.Drawing.Point(138, 24);
            this.txt_nombre.Name = "txt_nombre";
            this.txt_nombre.Size = new System.Drawing.Size(100, 20);
            this.txt_nombre.TabIndex = 18;
            // 
            // lbl_curp
            // 
            this.lbl_curp.AutoSize = true;
            this.lbl_curp.Location = new System.Drawing.Point(40, 173);
            this.lbl_curp.Name = "lbl_curp";
            this.lbl_curp.Size = new System.Drawing.Size(37, 13);
            this.lbl_curp.TabIndex = 17;
            this.lbl_curp.Text = "CURP";
            // 
            // lbl_matricula
            // 
            this.lbl_matricula.AutoSize = true;
            this.lbl_matricula.Location = new System.Drawing.Point(40, 143);
            this.lbl_matricula.Name = "lbl_matricula";
            this.lbl_matricula.Size = new System.Drawing.Size(50, 13);
            this.lbl_matricula.TabIndex = 16;
            this.lbl_matricula.Text = "Matricula";
            // 
            // lbl_am
            // 
            this.lbl_am.AutoSize = true;
            this.lbl_am.Location = new System.Drawing.Point(40, 105);
            this.lbl_am.Name = "lbl_am";
            this.lbl_am.Size = new System.Drawing.Size(85, 13);
            this.lbl_am.TabIndex = 15;
            this.lbl_am.Text = "Apellido materno";
            // 
            // lbl_ap
            // 
            this.lbl_ap.AutoSize = true;
            this.lbl_ap.Location = new System.Drawing.Point(40, 69);
            this.lbl_ap.Name = "lbl_ap";
            this.lbl_ap.Size = new System.Drawing.Size(83, 13);
            this.lbl_ap.TabIndex = 14;
            this.lbl_ap.Text = "Apellido paterno";
            // 
            // lbl_nombre
            // 
            this.lbl_nombre.AutoSize = true;
            this.lbl_nombre.Location = new System.Drawing.Point(40, 27);
            this.lbl_nombre.Name = "lbl_nombre";
            this.lbl_nombre.Size = new System.Drawing.Size(44, 13);
            this.lbl_nombre.TabIndex = 13;
            this.lbl_nombre.Text = "Nombre";
            // 
            // FormEliminarMaestro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btn_eliminar_maestro);
            this.Controls.Add(this.btn_regresar_maestro);
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
            this.Name = "FormEliminarMaestro";
            this.Text = "FormEliminarMaestro";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_eliminar_maestro;
        private System.Windows.Forms.Button btn_regresar_maestro;
        private System.Windows.Forms.TextBox txt_curp;
        private System.Windows.Forms.TextBox txt_am;
        private System.Windows.Forms.TextBox txt_matricula;
        private System.Windows.Forms.TextBox txt_ap;
        private System.Windows.Forms.TextBox txt_nombre;
        private System.Windows.Forms.Label lbl_curp;
        private System.Windows.Forms.Label lbl_matricula;
        private System.Windows.Forms.Label lbl_am;
        private System.Windows.Forms.Label lbl_ap;
        private System.Windows.Forms.Label lbl_nombre;
    }
}