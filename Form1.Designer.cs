namespace Simulador
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Botao_Arvore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botao_produto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Botao_Coeficientes = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // Botao_Arvore
            // 
            this.Botao_Arvore.BackColor = System.Drawing.Color.White;
            this.Botao_Arvore.ForeColor = System.Drawing.Color.Black;
            this.Botao_Arvore.Location = new System.Drawing.Point(676, 12);
            this.Botao_Arvore.Name = "Botao_Arvore";
            this.Botao_Arvore.Size = new System.Drawing.Size(99, 40);
            this.Botao_Arvore.TabIndex = 1;
            this.Botao_Arvore.Text = "ÁRVORES";
            this.Botao_Arvore.UseVisualStyleBackColor = false;
            this.Botao_Arvore.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(676, 397);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 41);
            this.button2.TabIndex = 3;
            this.button2.Text = "SIMULAR";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // botao_produto
            // 
            this.botao_produto.BackColor = System.Drawing.Color.White;
            this.botao_produto.Location = new System.Drawing.Point(676, 132);
            this.botao_produto.Name = "botao_produto";
            this.botao_produto.Size = new System.Drawing.Size(99, 41);
            this.botao_produto.TabIndex = 8;
            this.botao_produto.Text = "PRODUTOS";
            this.botao_produto.UseVisualStyleBackColor = false;
            this.botao_produto.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(661, 450);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Botao_Coeficientes
            // 
            this.Botao_Coeficientes.BackColor = System.Drawing.Color.White;
            this.Botao_Coeficientes.ForeColor = System.Drawing.Color.Black;
            this.Botao_Coeficientes.Location = new System.Drawing.Point(676, 70);
            this.Botao_Coeficientes.Name = "Botao_Coeficientes";
            this.Botao_Coeficientes.Size = new System.Drawing.Size(99, 41);
            this.Botao_Coeficientes.TabIndex = 11;
            this.Botao_Coeficientes.Text = "COEFICIENTES";
            this.Botao_Coeficientes.UseVisualStyleBackColor = false;
            this.Botao_Coeficientes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(676, 193);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 41);
            this.button1.TabIndex = 12;
            this.button1.Text = "DADOS ECONÔMICOS";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "SELETIVO",
            "SISTEMÁTICO"});
            this.comboBox1.Location = new System.Drawing.Point(676, 253);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(82, 21);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "DESBASTE";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(764, 253);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(676, 335);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(99, 41);
            this.button3.TabIndex = 16;
            this.button3.Text = "SIMULÇÔES";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "ÁRVORE",
            "ÁREA BASAL"});
            this.comboBox2.Location = new System.Drawing.Point(676, 294);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(99, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "          POR";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Botao_Coeficientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botao_produto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Botao_Arvore);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Botao_Arvore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botao_produto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Botao_Coeficientes;
        private System.Windows.Forms.Button button1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ComboBox comboBox2;
    }
}

