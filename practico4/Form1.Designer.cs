namespace practico4
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
            this.LAB_DESDE = new System.Windows.Forms.Label();
            this.LAB_HASTA = new System.Windows.Forms.Label();
            this.TXT_DESDE = new System.Windows.Forms.TextBox();
            this.TXT_HASTA = new System.Windows.Forms.TextBox();
            this.BUT_GENERAR = new System.Windows.Forms.Button();
            this.LAB_LISTA = new System.Windows.Forms.Label();
            this.LBOX_NUMEROS = new System.Windows.Forms.ListBox();
            this.BUT_PARES = new System.Windows.Forms.Button();
            this.BUT_IMPARES = new System.Windows.Forms.Button();
            this.BUT_PRIMOS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LAB_DESDE
            // 
            this.LAB_DESDE.AutoSize = true;
            this.LAB_DESDE.Location = new System.Drawing.Point(92, 56);
            this.LAB_DESDE.Name = "LAB_DESDE";
            this.LAB_DESDE.Size = new System.Drawing.Size(38, 13);
            this.LAB_DESDE.TabIndex = 0;
            this.LAB_DESDE.Text = "Desde";
            // 
            // LAB_HASTA
            // 
            this.LAB_HASTA.AutoSize = true;
            this.LAB_HASTA.Location = new System.Drawing.Point(92, 110);
            this.LAB_HASTA.Name = "LAB_HASTA";
            this.LAB_HASTA.Size = new System.Drawing.Size(35, 13);
            this.LAB_HASTA.TabIndex = 1;
            this.LAB_HASTA.Text = "Hasta";
            // 
            // TXT_DESDE
            // 
            this.TXT_DESDE.Location = new System.Drawing.Point(195, 56);
            this.TXT_DESDE.Name = "TXT_DESDE";
            this.TXT_DESDE.Size = new System.Drawing.Size(100, 20);
            this.TXT_DESDE.TabIndex = 2;
            this.TXT_DESDE.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_DESDE_KeyPress);
            // 
            // TXT_HASTA
            // 
            this.TXT_HASTA.Location = new System.Drawing.Point(195, 110);
            this.TXT_HASTA.Name = "TXT_HASTA";
            this.TXT_HASTA.Size = new System.Drawing.Size(100, 20);
            this.TXT_HASTA.TabIndex = 3;
            this.TXT_HASTA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TXT_HASTA_KeyPress);
            // 
            // BUT_GENERAR
            // 
            this.BUT_GENERAR.Location = new System.Drawing.Point(54, 169);
            this.BUT_GENERAR.Name = "BUT_GENERAR";
            this.BUT_GENERAR.Size = new System.Drawing.Size(100, 23);
            this.BUT_GENERAR.TabIndex = 4;
            this.BUT_GENERAR.Text = "Generar función";
            this.BUT_GENERAR.UseVisualStyleBackColor = true;
            this.BUT_GENERAR.Click += new System.EventHandler(this.BUT_GENERAR_Click);
            // 
            // LAB_LISTA
            // 
            this.LAB_LISTA.AutoSize = true;
            this.LAB_LISTA.Location = new System.Drawing.Point(437, 232);
            this.LAB_LISTA.Name = "LAB_LISTA";
            this.LAB_LISTA.Size = new System.Drawing.Size(87, 13);
            this.LAB_LISTA.TabIndex = 6;
            this.LAB_LISTA.Text = "Lista de numeros";
            // 
            // LBOX_NUMEROS
            // 
            this.LBOX_NUMEROS.FormattingEnabled = true;
            this.LBOX_NUMEROS.Location = new System.Drawing.Point(379, 56);
            this.LBOX_NUMEROS.Name = "LBOX_NUMEROS";
            this.LBOX_NUMEROS.Size = new System.Drawing.Size(200, 173);
            this.LBOX_NUMEROS.TabIndex = 7;
            // 
            // BUT_PARES
            // 
            this.BUT_PARES.Location = new System.Drawing.Point(214, 168);
            this.BUT_PARES.Name = "BUT_PARES";
            this.BUT_PARES.Size = new System.Drawing.Size(100, 23);
            this.BUT_PARES.TabIndex = 8;
            this.BUT_PARES.Text = "Numeros pares";
            this.BUT_PARES.UseVisualStyleBackColor = true;
            this.BUT_PARES.Click += new System.EventHandler(this.BUT_PARES_Click);
            // 
            // BUT_IMPARES
            // 
            this.BUT_IMPARES.Location = new System.Drawing.Point(54, 205);
            this.BUT_IMPARES.Name = "BUT_IMPARES";
            this.BUT_IMPARES.Size = new System.Drawing.Size(100, 23);
            this.BUT_IMPARES.TabIndex = 9;
            this.BUT_IMPARES.Text = "Numeros impares";
            this.BUT_IMPARES.UseVisualStyleBackColor = true;
            this.BUT_IMPARES.Click += new System.EventHandler(this.BUT_IMPARES_Click);
            // 
            // BUT_PRIMOS
            // 
            this.BUT_PRIMOS.Location = new System.Drawing.Point(214, 205);
            this.BUT_PRIMOS.Name = "BUT_PRIMOS";
            this.BUT_PRIMOS.Size = new System.Drawing.Size(100, 23);
            this.BUT_PRIMOS.TabIndex = 10;
            this.BUT_PRIMOS.Text = "Numeros primos";
            this.BUT_PRIMOS.UseVisualStyleBackColor = true;
            this.BUT_PRIMOS.Click += new System.EventHandler(this.BUT_PRIMOS_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 311);
            this.Controls.Add(this.BUT_PRIMOS);
            this.Controls.Add(this.BUT_IMPARES);
            this.Controls.Add(this.BUT_PARES);
            this.Controls.Add(this.LBOX_NUMEROS);
            this.Controls.Add(this.LAB_LISTA);
            this.Controls.Add(this.BUT_GENERAR);
            this.Controls.Add(this.TXT_HASTA);
            this.Controls.Add(this.TXT_DESDE);
            this.Controls.Add(this.LAB_HASTA);
            this.Controls.Add(this.LAB_DESDE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LAB_DESDE;
        private System.Windows.Forms.Label LAB_HASTA;
        private System.Windows.Forms.TextBox TXT_DESDE;
        private System.Windows.Forms.TextBox TXT_HASTA;
        private System.Windows.Forms.Button BUT_GENERAR;
        private System.Windows.Forms.Label LAB_LISTA;
        private System.Windows.Forms.ListBox LBOX_NUMEROS;
        private System.Windows.Forms.Button BUT_PARES;
        private System.Windows.Forms.Button BUT_IMPARES;
        private System.Windows.Forms.Button BUT_PRIMOS;
    }
}

