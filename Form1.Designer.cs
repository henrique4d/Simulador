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
            this.components = new System.ComponentModel.Container();
            this.Botao_Arvore = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.botao_produto = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.Botao_Coeficientes = new System.Windows.Forms.Button();
            this.Botao_custos = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Botao_cenarios = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.simularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.maximizaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sortimentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bináriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.regulaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.button7 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Botao_Arvore
            // 
            this.Botao_Arvore.BackColor = System.Drawing.Color.White;
            this.Botao_Arvore.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_Arvore.FlatAppearance.BorderSize = 3;
            this.Botao_Arvore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Arvore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Arvore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_Arvore.Location = new System.Drawing.Point(624, 38);
            this.Botao_Arvore.Name = "Botao_Arvore";
            this.Botao_Arvore.Size = new System.Drawing.Size(164, 40);
            this.Botao_Arvore.TabIndex = 1;
            this.Botao_Arvore.Text = "Dados de inventário";
            this.Botao_Arvore.UseVisualStyleBackColor = false;
            this.Botao_Arvore.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.button2.Location = new System.Drawing.Point(328, 397);
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
            this.botao_produto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botao_produto.FlatAppearance.BorderSize = 3;
            this.botao_produto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botao_produto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botao_produto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botao_produto.Location = new System.Drawing.Point(624, 131);
            this.botao_produto.Name = "botao_produto";
            this.botao_produto.Size = new System.Drawing.Size(164, 41);
            this.botao_produto.TabIndex = 8;
            this.botao_produto.Text = "Sortimentos";
            this.botao_produto.UseVisualStyleBackColor = false;
            this.botao_produto.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // Botao_Coeficientes
            // 
            this.Botao_Coeficientes.BackColor = System.Drawing.Color.White;
            this.Botao_Coeficientes.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_Coeficientes.FlatAppearance.BorderSize = 3;
            this.Botao_Coeficientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_Coeficientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_Coeficientes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_Coeficientes.Location = new System.Drawing.Point(624, 84);
            this.Botao_Coeficientes.Name = "Botao_Coeficientes";
            this.Botao_Coeficientes.Size = new System.Drawing.Size(164, 41);
            this.Botao_Coeficientes.TabIndex = 11;
            this.Botao_Coeficientes.Text = "Coeficientes - MAI";
            this.Botao_Coeficientes.UseVisualStyleBackColor = false;
            this.Botao_Coeficientes.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Botao_custos
            // 
            this.Botao_custos.BackColor = System.Drawing.Color.White;
            this.Botao_custos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Botao_custos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_custos.FlatAppearance.BorderSize = 3;
            this.Botao_custos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_custos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_custos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_custos.Location = new System.Drawing.Point(624, 178);
            this.Botao_custos.Name = "Botao_custos";
            this.Botao_custos.Size = new System.Drawing.Size(164, 41);
            this.Botao_custos.TabIndex = 12;
            this.Botao_custos.Text = "Planilha de custos";
            this.Botao_custos.UseVisualStyleBackColor = false;
            this.Botao_custos.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Seletivo",
            "Misto"});
            this.comboBox1.Location = new System.Drawing.Point(624, 267);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 28);
            this.comboBox1.TabIndex = 14;
            this.comboBox1.Text = "Tipo de desbaste";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox1.Location = new System.Drawing.Point(760, 301);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(31, 20);
            this.textBox1.TabIndex = 15;
            this.textBox1.Text = "5";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Visible = false;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Botao_cenarios
            // 
            this.Botao_cenarios.BackColor = System.Drawing.Color.White;
            this.Botao_cenarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_cenarios.FlatAppearance.BorderSize = 3;
            this.Botao_cenarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Botao_cenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botao_cenarios.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Botao_cenarios.Location = new System.Drawing.Point(627, 330);
            this.Botao_cenarios.Name = "Botao_cenarios";
            this.Botao_cenarios.Size = new System.Drawing.Size(164, 41);
            this.Botao_cenarios.TabIndex = 16;
            this.Botao_cenarios.Text = "Cenários";
            this.Botao_cenarios.UseVisualStyleBackColor = false;
            this.Botao_cenarios.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Árvore",
            "Área basal"});
            this.comboBox2.Location = new System.Drawing.Point(627, 301);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(138, 23);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.Text = "Controle de desbaste";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox2.Location = new System.Drawing.Point(757, 235);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(31, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(621, 494);
            this.dataGridView1.TabIndex = 10;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.White;
            this.button5.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.FlatAppearance.BorderSize = 3;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button5.Location = new System.Drawing.Point(627, 409);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 41);
            this.button5.TabIndex = 24;
            this.button5.Text = "Simular";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button4.Location = new System.Drawing.Point(624, 223);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(136, 41);
            this.button4.TabIndex = 23;
            this.button4.Text = "Taxa de descontos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox3.Location = new System.Drawing.Point(627, 377);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(164, 26);
            this.textBox3.TabIndex = 25;
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.textBox4.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.Location = new System.Drawing.Point(232, 163);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(195, 73);
            this.textBox4.TabIndex = 26;
            this.textBox4.Text = "GPMf";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.simularToolStripMenuItem,
            this.maximizaçãoToolStripMenuItem,
            this.sortimentosToolStripMenuItem,
            this.bináriaToolStripMenuItem,
            this.regulaçãoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // simularToolStripMenuItem
            // 
            this.simularToolStripMenuItem.Name = "simularToolStripMenuItem";
            this.simularToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.simularToolStripMenuItem.Text = "Simular";
            this.simularToolStripMenuItem.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // maximizaçãoToolStripMenuItem
            // 
            this.maximizaçãoToolStripMenuItem.Name = "maximizaçãoToolStripMenuItem";
            this.maximizaçãoToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.maximizaçãoToolStripMenuItem.Text = "Maximização";
            this.maximizaçãoToolStripMenuItem.Click += new System.EventHandler(this.maximizaçãoToolStripMenuItem_Click);
            // 
            // sortimentosToolStripMenuItem
            // 
            this.sortimentosToolStripMenuItem.Name = "sortimentosToolStripMenuItem";
            this.sortimentosToolStripMenuItem.Size = new System.Drawing.Size(83, 20);
            this.sortimentosToolStripMenuItem.Text = "Sortimentos";
            this.sortimentosToolStripMenuItem.Click += new System.EventHandler(this.sortimentosToolStripMenuItem_Click);
            // 
            // bináriaToolStripMenuItem
            // 
            this.bináriaToolStripMenuItem.Name = "bináriaToolStripMenuItem";
            this.bináriaToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.bináriaToolStripMenuItem.Text = "Binária";
            this.bináriaToolStripMenuItem.Click += new System.EventHandler(this.bináriaToolStripMenuItem_Click);
            // 
            // regulaçãoToolStripMenuItem
            // 
            this.regulaçãoToolStripMenuItem.Name = "regulaçãoToolStripMenuItem";
            this.regulaçãoToolStripMenuItem.Size = new System.Drawing.Size(74, 20);
            this.regulaçãoToolStripMenuItem.Text = "Regulação";
            this.regulaçãoToolStripMenuItem.Click += new System.EventHandler(this.regulaçãoToolStripMenuItem_Click);
            // 
            // textBox8
            // 
            this.textBox8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox8.Location = new System.Drawing.Point(629, 223);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(164, 26);
            this.textBox8.TabIndex = 32;
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox8.Visible = false;
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(628, 131);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(161, 20);
            this.textBox9.TabIndex = 33;
            this.textBox9.Visible = false;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(627, 178);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(164, 20);
            this.textBox10.TabIndex = 34;
            this.textBox10.Visible = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.BorderSize = 3;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button1.Location = new System.Drawing.Point(629, 268);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 41);
            this.button1.TabIndex = 35;
            this.button1.Text = "Simular";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_3);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(630, 152);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(161, 20);
            this.textBox11.TabIndex = 36;
            this.textBox11.Visible = false;
            // 
            // textBox12
            // 
            this.textBox12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox12.Location = new System.Drawing.Point(625, 193);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(164, 26);
            this.textBox12.TabIndex = 37;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox12.Visible = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.FlatAppearance.BorderSize = 3;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button3.Location = new System.Drawing.Point(627, 235);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 41);
            this.button3.TabIndex = 38;
            this.button3.Text = "Simular";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Visible = false;
            this.button3.Click += new System.EventHandler(this.button3_Click_2);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(626, 152);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(164, 20);
            this.textBox13.TabIndex = 39;
            this.textBox13.Visible = false;
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.FlatAppearance.BorderSize = 3;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button6.Location = new System.Drawing.Point(627, 235);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 41);
            this.button6.TabIndex = 41;
            this.button6.Text = "Simular";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox14
            // 
            this.textBox14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox14.Location = new System.Drawing.Point(627, 191);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(164, 26);
            this.textBox14.TabIndex = 42;
            this.textBox14.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox14.Visible = false;
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(627, 131);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(164, 20);
            this.textBox15.TabIndex = 43;
            this.textBox15.Visible = false;
            this.textBox15.TextChanged += new System.EventHandler(this.textBox15_TextChanged);
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(627, 178);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(164, 20);
            this.textBox16.TabIndex = 44;
            this.textBox16.Visible = false;
            // 
            // textBox17
            // 
            this.textBox17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.textBox17.Location = new System.Drawing.Point(629, 223);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(164, 26);
            this.textBox17.TabIndex = 45;
            this.textBox17.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox17.Visible = false;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.FlatAppearance.BorderSize = 3;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button7.Location = new System.Drawing.Point(627, 268);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 41);
            this.button7.TabIndex = 46;
            this.button7.Text = "Simular";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Visible = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(808, 492);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.textBox17);
            this.Controls.Add(this.textBox16);
            this.Controls.Add(this.textBox15);
            this.Controls.Add(this.textBox14);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.Botao_cenarios);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Botao_custos);
            this.Controls.Add(this.Botao_Coeficientes);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.botao_produto);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Botao_Arvore);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Entradas e premissas";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button Botao_Arvore;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button botao_produto;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button Botao_Coeficientes;
        private System.Windows.Forms.Button Botao_custos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Botao_cenarios;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem simularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem maximizaçãoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolStripMenuItem sortimentosToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ToolStripMenuItem bináriaToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox14;
        private System.Windows.Forms.ToolStripMenuItem regulaçãoToolStripMenuItem;
        private System.Windows.Forms.TextBox textBox15;
        private System.Windows.Forms.TextBox textBox16;
        private System.Windows.Forms.TextBox textBox17;
        private System.Windows.Forms.Button button7;
    }
}

