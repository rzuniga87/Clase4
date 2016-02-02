namespace Clase4
{
    partial class Form1
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
            this.bton_Procesar = new System.Windows.Forms.Button();
            this.txt_Datos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bton_Procesar
            // 
            this.bton_Procesar.Location = new System.Drawing.Point(205, 22);
            this.bton_Procesar.Name = "bton_Procesar";
            this.bton_Procesar.Size = new System.Drawing.Size(100, 68);
            this.bton_Procesar.TabIndex = 0;
            this.bton_Procesar.Text = "Procesar";
            this.bton_Procesar.UseVisualStyleBackColor = true;
            this.bton_Procesar.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_Datos
            // 
            this.txt_Datos.Location = new System.Drawing.Point(20, 57);
            this.txt_Datos.Name = "txt_Datos";
            this.txt_Datos.Size = new System.Drawing.Size(116, 22);
            this.txt_Datos.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Datos de la tabla:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bton_Procesar);
            this.groupBox1.Controls.Add(this.txt_Datos);
            this.groupBox1.Location = new System.Drawing.Point(28, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(328, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 201);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bton_Procesar;
        private System.Windows.Forms.TextBox txt_Datos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}

