namespace Estadistica
{
    partial class Estadística
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
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtColumnas = new System.Windows.Forms.TextBox();
            this.txtFilas = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbFilas = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnEvaluar = new System.Windows.Forms.Button();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chkFila = new System.Windows.Forms.CheckBox();
            this.chkColumna = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNumFila = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNumColumna = new System.Windows.Forms.TextBox();
            this.chkMixto = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtColumnas);
            this.groupBox1.Controls.Add(this.txtFilas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lbFilas);
            this.groupBox1.Controls.Add(this.btnCrear);
            this.groupBox1.Location = new System.Drawing.Point(12, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(455, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Tabla";
            // 
            // txtColumnas
            // 
            this.txtColumnas.Location = new System.Drawing.Point(68, 57);
            this.txtColumnas.Name = "txtColumnas";
            this.txtColumnas.Size = new System.Drawing.Size(192, 20);
            this.txtColumnas.TabIndex = 7;
            // 
            // txtFilas
            // 
            this.txtFilas.Location = new System.Drawing.Point(68, 23);
            this.txtFilas.Name = "txtFilas";
            this.txtFilas.Size = new System.Drawing.Size(192, 20);
            this.txtFilas.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Columnas";
            // 
            // lbFilas
            // 
            this.lbFilas.AutoSize = true;
            this.lbFilas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbFilas.Location = new System.Drawing.Point(6, 26);
            this.lbFilas.Name = "lbFilas";
            this.lbFilas.Size = new System.Drawing.Size(28, 13);
            this.lbFilas.TabIndex = 4;
            this.lbFilas.Text = "Filas";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(360, 39);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(75, 23);
            this.btnCrear.TabIndex = 3;
            this.btnCrear.Text = "Crear";
            this.btnCrear.UseVisualStyleBackColor = true;
            this.btnCrear.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(156, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Estadística";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.chkMixto);
            this.groupBox2.Controls.Add(this.txtNumColumna);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txtNumFila);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.chkColumna);
            this.groupBox2.Controls.Add(this.chkFila);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNum);
            this.groupBox2.Controls.Add(this.btnEvaluar);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(12, 153);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(455, 221);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Probabilidades";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(9, 16);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(432, 121);
            this.dataGridView1.TabIndex = 0;
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // btnEvaluar
            // 
            this.btnEvaluar.Location = new System.Drawing.Point(360, 184);
            this.btnEvaluar.Name = "btnEvaluar";
            this.btnEvaluar.Size = new System.Drawing.Size(75, 23);
            this.btnEvaluar.TabIndex = 3;
            this.btnEvaluar.Text = "Evaluar";
            this.btnEvaluar.UseVisualStyleBackColor = true;
            this.btnEvaluar.Click += new System.EventHandler(this.btnEvaluar_Click);
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(60, 152);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(200, 20);
            this.txtNum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Número";
            // 
            // chkFila
            // 
            this.chkFila.AutoSize = true;
            this.chkFila.Location = new System.Drawing.Point(291, 188);
            this.chkFila.Name = "chkFila";
            this.chkFila.Size = new System.Drawing.Size(42, 17);
            this.chkFila.TabIndex = 6;
            this.chkFila.Text = "Fila";
            this.chkFila.UseVisualStyleBackColor = true;
            this.chkFila.CheckedChanged += new System.EventHandler(this.chkFila_CheckedChanged);
            // 
            // chkColumna
            // 
            this.chkColumna.AutoSize = true;
            this.chkColumna.Location = new System.Drawing.Point(291, 154);
            this.chkColumna.Name = "chkColumna";
            this.chkColumna.Size = new System.Drawing.Size(67, 17);
            this.chkColumna.TabIndex = 7;
            this.chkColumna.Text = "Columna";
            this.chkColumna.UseVisualStyleBackColor = true;
            this.chkColumna.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Núm Fila";
            // 
            // txtNumFila
            // 
            this.txtNumFila.Location = new System.Drawing.Point(60, 186);
            this.txtNumFila.Name = "txtNumFila";
            this.txtNumFila.Size = new System.Drawing.Size(69, 20);
            this.txtNumFila.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(135, 189);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Núm Columna";
            // 
            // txtNumColumna
            // 
            this.txtNumColumna.Location = new System.Drawing.Point(214, 186);
            this.txtNumColumna.Name = "txtNumColumna";
            this.txtNumColumna.Size = new System.Drawing.Size(69, 20);
            this.txtNumColumna.TabIndex = 11;
            // 
            // chkMixto
            // 
            this.chkMixto.AutoSize = true;
            this.chkMixto.Location = new System.Drawing.Point(360, 154);
            this.chkMixto.Name = "chkMixto";
            this.chkMixto.Size = new System.Drawing.Size(51, 17);
            this.chkMixto.TabIndex = 12;
            this.chkMixto.Text = "Mixto";
            this.chkMixto.UseVisualStyleBackColor = true;
            this.chkMixto.CheckedChanged += new System.EventHandler(this.chkMixto_CheckedChanged);
            // 
            // Estadística
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(479, 386);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Estadística";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estadística";
            this.Load += new System.EventHandler(this.Estadística_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.TextBox txtColumnas;
        private System.Windows.Forms.TextBox txtFilas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbFilas;
        private System.Windows.Forms.ErrorProvider error;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox chkColumna;
        private System.Windows.Forms.CheckBox chkFila;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Button btnEvaluar;
        private System.Windows.Forms.TextBox txtNumColumna;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNumFila;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkMixto;
    }
}

