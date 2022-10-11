namespace WindowsFormPilaLibros
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
            this.txttitulo = new System.Windows.Forms.TextBox();
            this.txtautor = new System.Windows.Forms.TextBox();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.btnapilar = new System.Windows.Forms.Button();
            this.btndesapilar = new System.Windows.Forms.Button();
            this.btnvaciar = new System.Windows.Forms.Button();
            this.label20 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.listalibros = new System.Windows.Forms.ListView();
            this.titulo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.autor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.paginas = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtid = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // txttitulo
            // 
            this.txttitulo.Location = new System.Drawing.Point(162, 58);
            this.txttitulo.Name = "txttitulo";
            this.txttitulo.Size = new System.Drawing.Size(100, 20);
            this.txttitulo.TabIndex = 1;
            this.txttitulo.TextChanged += new System.EventHandler(this.txttitulo_TextChanged);
            // 
            // txtautor
            // 
            this.txtautor.Location = new System.Drawing.Point(37, 111);
            this.txtautor.Name = "txtautor";
            this.txtautor.Size = new System.Drawing.Size(100, 20);
            this.txtautor.TabIndex = 2;
            // 
            // txtcantidad
            // 
            this.txtcantidad.Location = new System.Drawing.Point(159, 109);
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(100, 20);
            this.txtcantidad.TabIndex = 3;
            // 
            // btnapilar
            // 
            this.btnapilar.BackColor = System.Drawing.Color.Lime;
            this.btnapilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnapilar.ForeColor = System.Drawing.Color.White;
            this.btnapilar.Location = new System.Drawing.Point(309, 39);
            this.btnapilar.Name = "btnapilar";
            this.btnapilar.Size = new System.Drawing.Size(123, 28);
            this.btnapilar.TabIndex = 4;
            this.btnapilar.Text = "APILAR";
            this.btnapilar.UseVisualStyleBackColor = false;
            this.btnapilar.Click += new System.EventHandler(this.btnapilar_Click);
            // 
            // btndesapilar
            // 
            this.btndesapilar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btndesapilar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btndesapilar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndesapilar.ForeColor = System.Drawing.Color.White;
            this.btndesapilar.Location = new System.Drawing.Point(309, 73);
            this.btndesapilar.Name = "btndesapilar";
            this.btndesapilar.Size = new System.Drawing.Size(123, 33);
            this.btndesapilar.TabIndex = 5;
            this.btndesapilar.Text = "DESAPILAR";
            this.btndesapilar.UseVisualStyleBackColor = false;
            this.btndesapilar.Click += new System.EventHandler(this.btndesapilar_Click);
            // 
            // btnvaciar
            // 
            this.btnvaciar.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btnvaciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnvaciar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvaciar.ForeColor = System.Drawing.Color.White;
            this.btnvaciar.Location = new System.Drawing.Point(309, 112);
            this.btnvaciar.Name = "btnvaciar";
            this.btnvaciar.Size = new System.Drawing.Size(123, 27);
            this.btnvaciar.TabIndex = 6;
            this.btnvaciar.Text = "VACIAR";
            this.btnvaciar.UseVisualStyleBackColor = false;
            this.btnvaciar.Click += new System.EventHandler(this.btnvaciar_Click);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(162, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(43, 15);
            this.label20.TabIndex = 3;
            this.label20.Text = "Titulo";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(157, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Lista de pila de libros";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cooper Black", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(159, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 15);
            this.label5.TabIndex = 3;
            this.label5.Text = "PILA DE LIBROS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(34, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Autor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(159, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Cant. Paginas";
            // 
            // listalibros
            // 
            this.listalibros.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.titulo,
            this.autor,
            this.paginas});
            this.listalibros.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listalibros.HideSelection = false;
            this.listalibros.Location = new System.Drawing.Point(34, 162);
            this.listalibros.Name = "listalibros";
            this.listalibros.Size = new System.Drawing.Size(398, 136);
            this.listalibros.TabIndex = 4;
            this.listalibros.UseCompatibleStateImageBehavior = false;
            this.listalibros.View = System.Windows.Forms.View.Details;
            // 
            // titulo
            // 
            this.titulo.Text = "Titulo";
            this.titulo.Width = 120;
            // 
            // autor
            // 
            this.autor.Text = "Autor";
            this.autor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.autor.Width = 120;
            // 
            // paginas
            // 
            this.paginas.Text = "Paginas";
            this.paginas.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.paginas.Width = 80;
            // 
            // txtid
            // 
            this.txtid.Enabled = false;
            this.txtid.Location = new System.Drawing.Point(37, 58);
            this.txtid.Name = "txtid";
            this.txtid.Size = new System.Drawing.Size(100, 20);
            this.txtid.TabIndex = 0;
            this.txtid.TextChanged += new System.EventHandler(this.txttitulo_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Identificador";
            this.label3.Click += new System.EventHandler(this.label20_Click);
            // 
            // id
            // 
            this.id.Text = "ID";
            this.id.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 358);
            this.Controls.Add(this.listalibros);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnvaciar);
            this.Controls.Add(this.btndesapilar);
            this.Controls.Add(this.btnapilar);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.txtautor);
            this.Controls.Add(this.txtid);
            this.Controls.Add(this.txttitulo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PILA LIBROS";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txttitulo;
        private System.Windows.Forms.TextBox txtautor;
        private System.Windows.Forms.TextBox txtcantidad;
        private System.Windows.Forms.Button btnapilar;
        private System.Windows.Forms.Button btndesapilar;
        private System.Windows.Forms.Button btnvaciar;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListView listalibros;
        private System.Windows.Forms.ColumnHeader titulo;
        private System.Windows.Forms.ColumnHeader autor;
        private System.Windows.Forms.ColumnHeader paginas;
        private System.Windows.Forms.TextBox txtid;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ColumnHeader id;
    }
}

