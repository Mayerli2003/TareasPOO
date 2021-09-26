
namespace CalcularNotas
{
    partial class VistasMaterias
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Software = new System.Windows.Forms.Button();
            this.POO = new System.Windows.Forms.Button();
            this.BDatos = new System.Windows.Forms.Button();
            this.Psicología = new System.Windows.Forms.Button();
            this.MateriasCerrar = new System.Windows.Forms.Button();
            this.Matemática = new System.Windows.Forms.Button();
            this.PromedioGeneral = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione una opción";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Bienvenidos";
            // 
            // Software
            // 
            this.Software.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Software.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Software.Location = new System.Drawing.Point(12, 67);
            this.Software.Name = "Software";
            this.Software.Size = new System.Drawing.Size(105, 59);
            this.Software.TabIndex = 2;
            this.Software.Text = "Software utilitario";
            this.Software.UseVisualStyleBackColor = false;
            this.Software.Click += new System.EventHandler(this.Software_Click_1);
            // 
            // POO
            // 
            this.POO.BackColor = System.Drawing.SystemColors.HotTrack;
            this.POO.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.POO.Location = new System.Drawing.Point(171, 67);
            this.POO.Name = "POO";
            this.POO.Size = new System.Drawing.Size(103, 59);
            this.POO.TabIndex = 3;
            this.POO.Text = "POO";
            this.POO.UseVisualStyleBackColor = false;
            this.POO.Click += new System.EventHandler(this.POO_Click);
            // 
            // BDatos
            // 
            this.BDatos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BDatos.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BDatos.Location = new System.Drawing.Point(323, 68);
            this.BDatos.Name = "BDatos";
            this.BDatos.Size = new System.Drawing.Size(105, 59);
            this.BDatos.TabIndex = 4;
            this.BDatos.Text = "Base de datos";
            this.BDatos.UseVisualStyleBackColor = false;
            this.BDatos.Click += new System.EventHandler(this.BDatos_Click);
            // 
            // Psicología
            // 
            this.Psicología.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Psicología.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Psicología.Location = new System.Drawing.Point(484, 67);
            this.Psicología.Name = "Psicología";
            this.Psicología.Size = new System.Drawing.Size(104, 59);
            this.Psicología.TabIndex = 5;
            this.Psicología.Text = "Psicología";
            this.Psicología.UseVisualStyleBackColor = false;
            this.Psicología.Click += new System.EventHandler(this.Psicología_Click);
            // 
            // MateriasCerrar
            // 
            this.MateriasCerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.MateriasCerrar.Location = new System.Drawing.Point(657, 391);
            this.MateriasCerrar.Name = "MateriasCerrar";
            this.MateriasCerrar.Size = new System.Drawing.Size(94, 31);
            this.MateriasCerrar.TabIndex = 9;
            this.MateriasCerrar.Text = "Cerrar";
            this.MateriasCerrar.UseVisualStyleBackColor = false;
            this.MateriasCerrar.Click += new System.EventHandler(this.MateriasCerrar_Click);
            // 
            // Matemática
            // 
            this.Matemática.BackColor = System.Drawing.SystemColors.HotTrack;
            this.Matemática.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Matemática.Location = new System.Drawing.Point(646, 69);
            this.Matemática.Name = "Matemática";
            this.Matemática.Size = new System.Drawing.Size(105, 58);
            this.Matemática.TabIndex = 10;
            this.Matemática.Text = "Matemática";
            this.Matemática.UseVisualStyleBackColor = false;
            this.Matemática.Click += new System.EventHandler(this.Matemática_Click);
            // 
            // PromedioGeneral
            // 
            this.PromedioGeneral.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.PromedioGeneral.Location = new System.Drawing.Point(12, 224);
            this.PromedioGeneral.Name = "PromedioGeneral";
            this.PromedioGeneral.Size = new System.Drawing.Size(105, 46);
            this.PromedioGeneral.TabIndex = 11;
            this.PromedioGeneral.Text = "Promedio general";
            this.PromedioGeneral.UseVisualStyleBackColor = false;
            this.PromedioGeneral.Click += new System.EventHandler(this.PromedioGeneral_Click);
            // 
            // VistasMaterias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PromedioGeneral);
            this.Controls.Add(this.Matemática);
            this.Controls.Add(this.MateriasCerrar);
            this.Controls.Add(this.Psicología);
            this.Controls.Add(this.BDatos);
            this.Controls.Add(this.POO);
            this.Controls.Add(this.Software);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "VistasMaterias";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Software;
        private System.Windows.Forms.Button POO;
        private System.Windows.Forms.Button BDatos;
        private System.Windows.Forms.Button Psicología;
        private System.Windows.Forms.Button MateriasCerrar;
        private System.Windows.Forms.Button Matemática;
        private System.Windows.Forms.Button PromedioGeneral;
    }
}

