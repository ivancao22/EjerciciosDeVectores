namespace PruebasConVector
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
            this.btnVectormayor = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGauss = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBuscador = new System.Windows.Forms.Button();
            this.lblindice = new System.Windows.Forms.Label();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.btnMasVeces = new System.Windows.Forms.Button();
            this.lblMasVeces = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVectormayor
            // 
            this.btnVectormayor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVectormayor.Location = new System.Drawing.Point(44, 13);
            this.btnVectormayor.Name = "btnVectormayor";
            this.btnVectormayor.Size = new System.Drawing.Size(107, 46);
            this.btnVectormayor.TabIndex = 0;
            this.btnVectormayor.Text = "mayor valor del vector";
            this.btnVectormayor.UseVisualStyleBackColor = true;
            this.btnVectormayor.Click += new System.EventHandler(this.Button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(201, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // btnGauss
            // 
            this.btnGauss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGauss.Location = new System.Drawing.Point(44, 71);
            this.btnGauss.Name = "btnGauss";
            this.btnGauss.Size = new System.Drawing.Size(107, 46);
            this.btnGauss.TabIndex = 2;
            this.btnGauss.Text = "Suma de gauss faltante";
            this.btnGauss.UseVisualStyleBackColor = true;
            this.btnGauss.Click += new System.EventHandler(this.BtnGauss_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "label2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(44, 133);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(107, 33);
            this.button1.TabIndex = 4;
            this.button1.Text = "Bubble sort";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(201, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnBuscador
            // 
            this.btnBuscador.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscador.Location = new System.Drawing.Point(44, 208);
            this.btnBuscador.Name = "btnBuscador";
            this.btnBuscador.Size = new System.Drawing.Size(107, 33);
            this.btnBuscador.TabIndex = 6;
            this.btnBuscador.Text = "Buscador";
            this.btnBuscador.UseVisualStyleBackColor = true;
            this.btnBuscador.Click += new System.EventHandler(this.btnBuscador_Click);
            // 
            // lblindice
            // 
            this.lblindice.AutoSize = true;
            this.lblindice.Location = new System.Drawing.Point(201, 218);
            this.lblindice.Name = "lblindice";
            this.lblindice.Size = new System.Drawing.Size(35, 13);
            this.lblindice.TabIndex = 7;
            this.lblindice.Text = "label4";
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(48, 181);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(100, 20);
            this.txtNumero.TabIndex = 8;
            // 
            // btnMasVeces
            // 
            this.btnMasVeces.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMasVeces.Location = new System.Drawing.Point(44, 254);
            this.btnMasVeces.Name = "btnMasVeces";
            this.btnMasVeces.Size = new System.Drawing.Size(107, 46);
            this.btnMasVeces.TabIndex = 9;
            this.btnMasVeces.Text = "Numero mas repetido";
            this.btnMasVeces.UseVisualStyleBackColor = true;
            this.btnMasVeces.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblMasVeces
            // 
            this.lblMasVeces.AutoSize = true;
            this.lblMasVeces.Location = new System.Drawing.Point(201, 271);
            this.lblMasVeces.Name = "lblMasVeces";
            this.lblMasVeces.Size = new System.Drawing.Size(35, 13);
            this.lblMasVeces.TabIndex = 10;
            this.lblMasVeces.Text = "label4";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 312);
            this.Controls.Add(this.lblMasVeces);
            this.Controls.Add(this.btnMasVeces);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.lblindice);
            this.Controls.Add(this.btnBuscador);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnGauss);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnVectormayor);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVectormayor;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGauss;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBuscador;
        private System.Windows.Forms.Label lblindice;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Button btnMasVeces;
        private System.Windows.Forms.Label lblMasVeces;
    }
}

