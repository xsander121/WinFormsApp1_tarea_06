
namespace WinFormsApp1_tarea_06
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.bttn_contar = new System.Windows.Forms.Button();
            this.txtBx_entrada = new System.Windows.Forms.TextBox();
            this.txtBx_salida = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bttn_contar
            // 
            this.bttn_contar.Location = new System.Drawing.Point(257, 40);
            this.bttn_contar.Name = "bttn_contar";
            this.bttn_contar.Size = new System.Drawing.Size(94, 29);
            this.bttn_contar.TabIndex = 0;
            this.bttn_contar.Text = "Contar";
            this.bttn_contar.UseVisualStyleBackColor = true;
            this.bttn_contar.Click += new System.EventHandler(this.bttn_contar_Click);
            // 
            // txtBx_entrada
            // 
            this.txtBx_entrada.Location = new System.Drawing.Point(126, 40);
            this.txtBx_entrada.Name = "txtBx_entrada";
            this.txtBx_entrada.Size = new System.Drawing.Size(125, 27);
            this.txtBx_entrada.TabIndex = 1;
            this.txtBx_entrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_entrada_KeyPress);
            // 
            // txtBx_salida
            // 
            this.txtBx_salida.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.txtBx_salida.Location = new System.Drawing.Point(126, 75);
            this.txtBx_salida.Multiline = true;
            this.txtBx_salida.Name = "txtBx_salida";
            this.txtBx_salida.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBx_salida.Size = new System.Drawing.Size(225, 97);
            this.txtBx_salida.TabIndex = 2;
            this.txtBx_salida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBx_salida_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese numero";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 184);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBx_salida);
            this.Controls.Add(this.txtBx_entrada);
            this.Controls.Add(this.bttn_contar);
            this.Name = "Form1";
            this.Text = "Contador de numeros";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bttn_contar;
        private System.Windows.Forms.TextBox txtBx_entrada;
        private System.Windows.Forms.TextBox txtBx_salida;
        private System.Windows.Forms.Label label1;
    }
}

