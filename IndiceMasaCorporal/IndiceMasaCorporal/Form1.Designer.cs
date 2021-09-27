
namespace IndiceMasaCorporal
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
            this.Enviar = new System.Windows.Forms.Button();
            this.Cerrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.TextBox();
            this.edad = new System.Windows.Forms.TextBox();
            this.peso = new System.Windows.Forms.TextBox();
            this.altura = new System.Windows.Forms.TextBox();
            this.sexo = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Enviar
            // 
            this.Enviar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Enviar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Enviar.Location = new System.Drawing.Point(712, 404);
            this.Enviar.Name = "Enviar";
            this.Enviar.Size = new System.Drawing.Size(75, 32);
            this.Enviar.TabIndex = 0;
            this.Enviar.Text = "Enviar";
            this.Enviar.UseVisualStyleBackColor = false;
            this.Enviar.Click += new System.EventHandler(this.Enviar_Click);
            // 
            // Cerrar
            // 
            this.Cerrar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cerrar.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrar.Location = new System.Drawing.Point(631, 404);
            this.Cerrar.Name = "Cerrar";
            this.Cerrar.Size = new System.Drawing.Size(75, 32);
            this.Cerrar.TabIndex = 1;
            this.Cerrar.Text = "Cerrar";
            this.Cerrar.UseVisualStyleBackColor = false;
            this.Cerrar.Click += new System.EventHandler(this.Cerrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bienvenido/a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(34, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 19);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ingrese sus datos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ingrese su nombre:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(109, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ingrese su edad:";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(34, 191);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(107, 19);
            this.label.TabIndex = 6;
            this.label.Text = "Ingrese su sexo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Ingrese su peso:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(34, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Ingrese su altura:";
            // 
            // nombre
            // 
            this.nombre.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombre.Location = new System.Drawing.Point(37, 108);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(100, 24);
            this.nombre.TabIndex = 10;
            // 
            // edad
            // 
            this.edad.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edad.Location = new System.Drawing.Point(37, 160);
            this.edad.Name = "edad";
            this.edad.Size = new System.Drawing.Size(100, 24);
            this.edad.TabIndex = 11;
            // 
            // peso
            // 
            this.peso.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.peso.Location = new System.Drawing.Point(37, 266);
            this.peso.Name = "peso";
            this.peso.Size = new System.Drawing.Size(100, 24);
            this.peso.TabIndex = 13;
            // 
            // altura
            // 
            this.altura.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.altura.Location = new System.Drawing.Point(37, 318);
            this.altura.Name = "altura";
            this.altura.Size = new System.Drawing.Size(100, 24);
            this.altura.TabIndex = 14;
            // 
            // sexo
            // 
            this.sexo.Font = new System.Drawing.Font("Microsoft YaHei UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sexo.Location = new System.Drawing.Point(36, 213);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(100, 24);
            this.sexo.TabIndex = 15;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.altura);
            this.Controls.Add(this.peso);
            this.Controls.Add(this.edad);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cerrar);
            this.Controls.Add(this.Enviar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Enviar;
        private System.Windows.Forms.Button Cerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox nombre;
        private System.Windows.Forms.TextBox edad;
        private System.Windows.Forms.TextBox peso;
        private System.Windows.Forms.TextBox altura;
        private System.Windows.Forms.TextBox sexo;
    }
}

