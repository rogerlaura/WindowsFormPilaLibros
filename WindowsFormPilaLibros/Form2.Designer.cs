namespace WindowsFormPilaLibros
{
    partial class Form2
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
            this.txtcapacidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btncomenzar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtcapacidad
            // 
            this.txtcapacidad.Location = new System.Drawing.Point(82, 41);
            this.txtcapacidad.Name = "txtcapacidad";
            this.txtcapacidad.Size = new System.Drawing.Size(100, 20);
            this.txtcapacidad.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cap. Max.";
            // 
            // btncomenzar
            // 
            this.btncomenzar.BackColor = System.Drawing.Color.Lime;
            this.btncomenzar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btncomenzar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncomenzar.ForeColor = System.Drawing.Color.White;
            this.btncomenzar.Location = new System.Drawing.Point(82, 67);
            this.btncomenzar.Name = "btncomenzar";
            this.btncomenzar.Size = new System.Drawing.Size(100, 30);
            this.btncomenzar.TabIndex = 2;
            this.btncomenzar.Text = "COMENZAR";
            this.btncomenzar.UseVisualStyleBackColor = false;
            this.btncomenzar.Click += new System.EventHandler(this.btncomenzar_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 119);
            this.Controls.Add(this.btncomenzar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcapacidad);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PILA CAPACIDAD MAXIMA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtcapacidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btncomenzar;
    }
}