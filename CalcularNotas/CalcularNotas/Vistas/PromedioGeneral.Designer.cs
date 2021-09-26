
namespace CalcularNotas
{
    partial class PromedioGeneral
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
            this.label = new System.Windows.Forms.Label();
            this.labeluno = new System.Windows.Forms.Label();
            this.labeldos = new System.Windows.Forms.Label();
            this.PromedioPsicología = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPromedioPOO = new System.Windows.Forms.TextBox();
            this.PromedioMatemática = new System.Windows.Forms.TextBox();
            this.PromedioBDatos = new System.Windows.Forms.TextBox();
            this.textPromedioPsicologia = new System.Windows.Forms.TextBox();
            this.PromedioSoftware = new System.Windows.Forms.TextBox();
            this.EnviarPromedio = new System.Windows.Forms.Button();
            this.CerrarPG = new System.Windows.Forms.Button();
            this.Atrás = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(188, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese los promedios de cada materia";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Location = new System.Drawing.Point(54, 42);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(165, 13);
            this.label.TabIndex = 1;
            this.label.Text = "Programación orientada a objetos";
            // 
            // labeluno
            // 
            this.labeluno.AutoSize = true;
            this.labeluno.Location = new System.Drawing.Point(54, 107);
            this.labeluno.Name = "labeluno";
            this.labeluno.Size = new System.Drawing.Size(62, 13);
            this.labeluno.TabIndex = 2;
            this.labeluno.Text = "Matemática";
            // 
            // labeldos
            // 
            this.labeldos.AutoSize = true;
            this.labeldos.Location = new System.Drawing.Point(54, 169);
            this.labeldos.Name = "labeldos";
            this.labeldos.Size = new System.Drawing.Size(75, 13);
            this.labeldos.TabIndex = 3;
            this.labeldos.Text = "Base de datos";
            this.labeldos.Click += new System.EventHandler(this.PromedioBDatos_Click);
            // 
            // PromedioPsicología
            // 
            this.PromedioPsicología.AutoSize = true;
            this.PromedioPsicología.Location = new System.Drawing.Point(54, 230);
            this.PromedioPsicología.Name = "PromedioPsicología";
            this.PromedioPsicología.Size = new System.Drawing.Size(57, 13);
            this.PromedioPsicología.TabIndex = 4;
            this.PromedioPsicología.Text = "Psicología";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(54, 293);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Software utilitario";
            // 
            // txtPromedioPOO
            // 
            this.txtPromedioPOO.Location = new System.Drawing.Point(54, 69);
            this.txtPromedioPOO.Name = "txtPromedioPOO";
            this.txtPromedioPOO.Size = new System.Drawing.Size(100, 20);
            this.txtPromedioPOO.TabIndex = 6;
            // 
            // PromedioMatemática
            // 
            this.PromedioMatemática.Location = new System.Drawing.Point(54, 134);
            this.PromedioMatemática.Name = "PromedioMatemática";
            this.PromedioMatemática.Size = new System.Drawing.Size(100, 20);
            this.PromedioMatemática.TabIndex = 7;
            // 
            // PromedioBDatos
            // 
            this.PromedioBDatos.Location = new System.Drawing.Point(54, 194);
            this.PromedioBDatos.Name = "PromedioBDatos";
            this.PromedioBDatos.Size = new System.Drawing.Size(100, 20);
            this.PromedioBDatos.TabIndex = 8;
            // 
            // textPromedioPsicologia
            // 
            this.textPromedioPsicologia.Location = new System.Drawing.Point(54, 256);
            this.textPromedioPsicologia.Name = "textPromedioPsicologia";
            this.textPromedioPsicologia.Size = new System.Drawing.Size(100, 20);
            this.textPromedioPsicologia.TabIndex = 9;
            // 
            // PromedioSoftware
            // 
            this.PromedioSoftware.Location = new System.Drawing.Point(54, 318);
            this.PromedioSoftware.Name = "PromedioSoftware";
            this.PromedioSoftware.Size = new System.Drawing.Size(100, 20);
            this.PromedioSoftware.TabIndex = 10;
            // 
            // EnviarPromedio
            // 
            this.EnviarPromedio.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.EnviarPromedio.Location = new System.Drawing.Point(709, 410);
            this.EnviarPromedio.Name = "EnviarPromedio";
            this.EnviarPromedio.Size = new System.Drawing.Size(75, 23);
            this.EnviarPromedio.TabIndex = 11;
            this.EnviarPromedio.Text = "Enviar";
            this.EnviarPromedio.UseVisualStyleBackColor = false;
            this.EnviarPromedio.Click += new System.EventHandler(this.EnviarPromedio_Click);
            // 
            // CerrarPG
            // 
            this.CerrarPG.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.CerrarPG.Location = new System.Drawing.Point(608, 410);
            this.CerrarPG.Name = "CerrarPG";
            this.CerrarPG.Size = new System.Drawing.Size(75, 23);
            this.CerrarPG.TabIndex = 12;
            this.CerrarPG.Text = "Cerrar";
            this.CerrarPG.UseVisualStyleBackColor = false;
            this.CerrarPG.Click += new System.EventHandler(this.CerrarPG_Click);
            // 
            // Atrás
            // 
            this.Atrás.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Atrás.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Atrás.Location = new System.Drawing.Point(499, 410);
            this.Atrás.Name = "Atrás";
            this.Atrás.Size = new System.Drawing.Size(75, 23);
            this.Atrás.TabIndex = 13;
            this.Atrás.Text = "Atrás";
            this.Atrás.UseVisualStyleBackColor = false;
            this.Atrás.Click += new System.EventHandler(this.Atrás_Click);
            // 
            // PromedioGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Atrás);
            this.Controls.Add(this.CerrarPG);
            this.Controls.Add(this.EnviarPromedio);
            this.Controls.Add(this.PromedioSoftware);
            this.Controls.Add(this.textPromedioPsicologia);
            this.Controls.Add(this.PromedioBDatos);
            this.Controls.Add(this.PromedioMatemática);
            this.Controls.Add(this.txtPromedioPOO);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.PromedioPsicología);
            this.Controls.Add(this.labeldos);
            this.Controls.Add(this.labeluno);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label1);
            this.Name = "PromedioGeneral";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labeluno;
        private System.Windows.Forms.Label labeldos;
        private System.Windows.Forms.Label PromedioPsicología;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtPromedioPOO;
        private System.Windows.Forms.TextBox PromedioMatemática;
        private System.Windows.Forms.TextBox PromedioBDatos;
        private System.Windows.Forms.TextBox textPromedioPsicologia;
        private System.Windows.Forms.TextBox PromedioSoftware;
        private System.Windows.Forms.Button EnviarPromedio;
        private System.Windows.Forms.Button CerrarPG;
        private System.Windows.Forms.Button Atrás;
    }
}