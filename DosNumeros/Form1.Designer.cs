namespace DosNumeros
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lbSalida = new System.Windows.Forms.ListBox();
            this.bValorarNumeros = new System.Windows.Forms.Button();
            this.tDato1 = new System.Windows.Forms.TextBox();
            this.tDato2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbSalida
            // 
            this.lbSalida.FormattingEnabled = true;
            this.lbSalida.Location = new System.Drawing.Point(270, 212);
            this.lbSalida.Name = "lbSalida";
            this.lbSalida.Size = new System.Drawing.Size(271, 95);
            this.lbSalida.TabIndex = 0;
            // 
            // bValorarNumeros
            // 
            this.bValorarNumeros.Location = new System.Drawing.Point(336, 143);
            this.bValorarNumeros.Name = "bValorarNumeros";
            this.bValorarNumeros.Size = new System.Drawing.Size(135, 40);
            this.bValorarNumeros.TabIndex = 1;
            this.bValorarNumeros.Text = "VALORAR NÚMEROS";
            this.bValorarNumeros.UseVisualStyleBackColor = true;
            this.bValorarNumeros.Click += new System.EventHandler(this.bValorarNumeros_Click);
            // 
            // tDato1
            // 
            this.tDato1.Location = new System.Drawing.Point(206, 154);
            this.tDato1.Name = "tDato1";
            this.tDato1.Size = new System.Drawing.Size(100, 20);
            this.tDato1.TabIndex = 2;
            // 
            // tDato2
            // 
            this.tDato2.Location = new System.Drawing.Point(494, 154);
            this.tDato2.Name = "tDato2";
            this.tDato2.Size = new System.Drawing.Size(100, 20);
            this.tDato2.TabIndex = 3;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tDato2);
            this.Controls.Add(this.tDato1);
            this.Controls.Add(this.bValorarNumeros);
            this.Controls.Add(this.lbSalida);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Valoración de dos números";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbSalida;
        private System.Windows.Forms.Button bValorarNumeros;
        private System.Windows.Forms.TextBox tDato1;
        private System.Windows.Forms.TextBox tDato2;
    }
}

