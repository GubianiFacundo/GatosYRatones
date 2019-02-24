namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario, false.</param>
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbancho = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tblargo = new System.Windows.Forms.TextBox();
            this.craton = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btgenerar = new System.Windows.Forms.Button();
            this.btpaso = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cgato = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.info = new System.Windows.Forms.ListBox();
            this.grilla = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbrvivos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbgvivos = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbdias = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).BeginInit();
            this.SuspendLayout();
            // 
            // tbancho
            // 
            this.tbancho.Location = new System.Drawing.Point(121, 19);
            this.tbancho.MaxLength = 2;
            this.tbancho.Name = "tbancho";
            this.tbancho.Size = new System.Drawing.Size(100, 20);
            this.tbancho.TabIndex = 1;
            this.tbancho.TextChanged += new System.EventHandler(this.tbancho_TextChanged);
            this.tbancho.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbancho_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ancho de la Isla";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Largo de la Isla";
            // 
            // tblargo
            // 
            this.tblargo.Location = new System.Drawing.Point(121, 41);
            this.tblargo.MaxLength = 2;
            this.tblargo.Name = "tblargo";
            this.tblargo.Size = new System.Drawing.Size(100, 20);
            this.tblargo.TabIndex = 4;
            this.tblargo.TextChanged += new System.EventHandler(this.tbancho_TextChanged);
            this.tblargo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tblargo_KeyPress);
            // 
            // craton
            // 
            this.craton.Location = new System.Drawing.Point(121, 63);
            this.craton.MaxLength = 2;
            this.craton.Name = "craton";
            this.craton.Size = new System.Drawing.Size(100, 20);
            this.craton.TabIndex = 6;
            this.craton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.craton_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Cantidad de Ratones";
            // 
            // btgenerar
            // 
            this.btgenerar.Location = new System.Drawing.Point(267, 55);
            this.btgenerar.Name = "btgenerar";
            this.btgenerar.Size = new System.Drawing.Size(79, 23);
            this.btgenerar.TabIndex = 8;
            this.btgenerar.Text = "Generar Isla";
            this.btgenerar.UseVisualStyleBackColor = true;
            this.btgenerar.Click += new System.EventHandler(this.btgenerar_Click);
            // 
            // btpaso
            // 
            this.btpaso.Enabled = false;
            this.btpaso.Location = new System.Drawing.Point(267, 86);
            this.btpaso.Name = "btpaso";
            this.btpaso.Size = new System.Drawing.Size(79, 23);
            this.btpaso.TabIndex = 9;
            this.btpaso.Text = "Paso";
            this.btpaso.UseVisualStyleBackColor = true;
            this.btpaso.Click += new System.EventHandler(this.btpaso_Click);
            this.btpaso.Enter += new System.EventHandler(this.btpaso_Enter);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cgato);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.craton);
            this.groupBox1.Controls.Add(this.tblargo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbancho);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(228, 115);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Isla";
            // 
            // cgato
            // 
            this.cgato.Location = new System.Drawing.Point(121, 87);
            this.cgato.MaxLength = 2;
            this.cgato.Name = "cgato";
            this.cgato.Size = new System.Drawing.Size(100, 20);
            this.cgato.TabIndex = 9;
            this.cgato.Text = "0";
            this.cgato.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cgato_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Cantidad de Gatos";
            // 
            // info
            // 
            this.info.FormattingEnabled = true;
            this.info.Location = new System.Drawing.Point(12, 133);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(354, 511);
            this.info.TabIndex = 11;
            // 
            // grilla
            // 
            this.grilla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grilla.Location = new System.Drawing.Point(372, 12);
            this.grilla.Name = "grilla";
            this.grilla.Size = new System.Drawing.Size(988, 656);
            this.grilla.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(267, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(79, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cargar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 656);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Ratones Vivos:";
            // 
            // tbrvivos
            // 
            this.tbrvivos.AutoSize = true;
            this.tbrvivos.Location = new System.Drawing.Point(97, 656);
            this.tbrvivos.Name = "tbrvivos";
            this.tbrvivos.Size = new System.Drawing.Size(13, 13);
            this.tbrvivos.TabIndex = 16;
            this.tbrvivos.Text = "--";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(144, 656);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Gatos Vivos:";
            // 
            // tbgvivos
            // 
            this.tbgvivos.AutoSize = true;
            this.tbgvivos.Location = new System.Drawing.Point(217, 655);
            this.tbgvivos.Name = "tbgvivos";
            this.tbgvivos.Size = new System.Drawing.Size(13, 13);
            this.tbgvivos.TabIndex = 18;
            this.tbgvivos.Text = "--";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 656);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Dias Ttranscurridos:";
            // 
            // lbdias
            // 
            this.lbdias.AutoSize = true;
            this.lbdias.Location = new System.Drawing.Point(343, 656);
            this.lbdias.Name = "lbdias";
            this.lbdias.Size = new System.Drawing.Size(13, 13);
            this.lbdias.TabIndex = 20;
            this.lbdias.Text = "--";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1372, 678);
            this.Controls.Add(this.lbdias);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbgvivos);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tbrvivos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.grilla);
            this.Controls.Add(this.info);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btpaso);
            this.Controls.Add(this.btgenerar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delta del Paraná v1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grilla)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tblargo;
        private System.Windows.Forms.TextBox craton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btgenerar;
        private System.Windows.Forms.Button btpaso;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cgato;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ListBox info;
        private System.Windows.Forms.DataGridView grilla;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label tbrvivos;
        public System.Windows.Forms.Label tbgvivos;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label lbdias;

    }
}

