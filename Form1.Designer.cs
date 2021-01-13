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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtLogo = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSim = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiMax = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSor = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBin = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiReg = new System.Windows.Forms.ToolStripMenuItem();
            this.tabNavibar = new Simulador.Components.TabControlWithoutHeader();
            this.tpSim = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel7 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnSimDadosInventario = new System.Windows.Forms.Button();
            this.btnSimCoeficientesMAI = new System.Windows.Forms.Button();
            this.btnSimSortimentos = new System.Windows.Forms.Button();
            this.btnSimPalhanilhaCustos = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.txtSimTaxaDesconto = new System.Windows.Forms.TextBox();
            this.cmbSimTipoDesbaste = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbSimControleDesbaste = new System.Windows.Forms.ComboBox();
            this.txtSimIntervaloSistematico = new System.Windows.Forms.TextBox();
            this.btnSimCenarios = new System.Windows.Forms.Button();
            this.txtSimTitle = new System.Windows.Forms.TextBox();
            this.btnSim = new System.Windows.Forms.Button();
            this.tpMax = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtMaxHorizonte = new System.Windows.Forms.TextBox();
            this.txtMaxNumPlanejamento = new System.Windows.Forms.TextBox();
            this.txtMaxTitle = new System.Windows.Forms.TextBox();
            this.btnMax = new System.Windows.Forms.Button();
            this.tpReg = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtRegHorizonte = new System.Windows.Forms.TextBox();
            this.txtRegIdadeRegulacao = new System.Windows.Forms.TextBox();
            this.txtRegTitle = new System.Windows.Forms.TextBox();
            this.btnReg = new System.Windows.Forms.Button();
            this.tpSor = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSorHorizonte = new System.Windows.Forms.TextBox();
            this.txtSorTitle = new System.Windows.Forms.TextBox();
            this.btnSor = new System.Windows.Forms.Button();
            this.tpBin = new System.Windows.Forms.TabPage();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtBinHorizonte = new System.Windows.Forms.TextBox();
            this.txtBinTitle = new System.Windows.Forms.TextBox();
            this.btnBin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.tabNavibar.SuspendLayout();
            this.tpSim.SuspendLayout();
            this.flowLayoutPanel7.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.tpMax.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.tpReg.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.tpSor.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.tpBin.SuspendLayout();
            this.flowLayoutPanel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(808, 567);
            this.dataGridView1.TabIndex = 10;
            // 
            // txtLogo
            // 
            this.txtLogo.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (192)))), ((int) (((byte) (255)))), ((int) (((byte) (192)))));
            this.txtLogo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtLogo.Location = new System.Drawing.Point(208, 212);
            this.txtLogo.Name = "txtLogo";
            this.txtLogo.Size = new System.Drawing.Size(195, 73);
            this.txtLogo.TabIndex = 26;
            this.txtLogo.Text = "GPMf";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {this.tsmiSim, this.tsmiMax, this.tsmiSor, this.tsmiBin, this.tsmiReg});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(808, 24);
            this.menuStrip1.TabIndex = 31;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSim
            // 
            this.tsmiSim.Name = "tsmiSim";
            this.tsmiSim.Size = new System.Drawing.Size(59, 20);
            this.tsmiSim.Text = "Simular";
            this.tsmiSim.Click += new System.EventHandler(this.simularToolStripMenuItem_Click);
            // 
            // tsmiMax
            // 
            this.tsmiMax.Name = "tsmiMax";
            this.tsmiMax.Size = new System.Drawing.Size(89, 20);
            this.tsmiMax.Text = "Maximização";
            this.tsmiMax.Click += new System.EventHandler(this.maximizaçãoToolStripMenuItem_Click);
            // 
            // tsmiSor
            // 
            this.tsmiSor.Name = "tsmiSor";
            this.tsmiSor.Size = new System.Drawing.Size(83, 20);
            this.tsmiSor.Text = "Sortimentos";
            this.tsmiSor.Click += new System.EventHandler(this.sortimentosToolStripMenuItem_Click);
            // 
            // tsmiBin
            // 
            this.tsmiBin.Name = "tsmiBin";
            this.tsmiBin.Size = new System.Drawing.Size(55, 20);
            this.tsmiBin.Text = "Binária";
            this.tsmiBin.Click += new System.EventHandler(this.bináriaToolStripMenuItem_Click);
            // 
            // tsmiReg
            // 
            this.tsmiReg.Name = "tsmiReg";
            this.tsmiReg.Size = new System.Drawing.Size(74, 20);
            this.tsmiReg.Text = "Regulação";
            this.tsmiReg.Click += new System.EventHandler(this.regulaçãoToolStripMenuItem_Click);
            // 
            // tabNavibar
            // 
            this.tabNavibar.Controls.Add(this.tpSim);
            this.tabNavibar.Controls.Add(this.tpMax);
            this.tabNavibar.Controls.Add(this.tpReg);
            this.tabNavibar.Controls.Add(this.tpSor);
            this.tabNavibar.Controls.Add(this.tpBin);
            this.tabNavibar.Dock = System.Windows.Forms.DockStyle.Right;
            this.tabNavibar.Location = new System.Drawing.Point(607, 24);
            this.tabNavibar.Multiline = true;
            this.tabNavibar.Name = "tabNavibar";
            this.tabNavibar.SelectedIndex = 0;
            this.tabNavibar.Size = new System.Drawing.Size(201, 543);
            this.tabNavibar.TabIndex = 47;
            // 
            // tpSim
            // 
            this.tpSim.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.tpSim.Controls.Add(this.flowLayoutPanel7);
            this.tpSim.ForeColor = System.Drawing.SystemColors.Control;
            this.tpSim.Location = new System.Drawing.Point(4, 40);
            this.tpSim.Margin = new System.Windows.Forms.Padding(0);
            this.tpSim.Name = "tpSim";
            this.tpSim.Size = new System.Drawing.Size(193, 499);
            this.tpSim.TabIndex = 0;
            this.tpSim.Text = "Simular";
            // 
            // flowLayoutPanel7
            // 
            this.flowLayoutPanel7.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel7.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel7.Controls.Add(this.btnSimDadosInventario);
            this.flowLayoutPanel7.Controls.Add(this.btnSimCoeficientesMAI);
            this.flowLayoutPanel7.Controls.Add(this.btnSimSortimentos);
            this.flowLayoutPanel7.Controls.Add(this.btnSimPalhanilhaCustos);
            this.flowLayoutPanel7.Controls.Add(this.panel1);
            this.flowLayoutPanel7.Controls.Add(this.cmbSimTipoDesbaste);
            this.flowLayoutPanel7.Controls.Add(this.panel2);
            this.flowLayoutPanel7.Controls.Add(this.btnSimCenarios);
            this.flowLayoutPanel7.Controls.Add(this.txtSimTitle);
            this.flowLayoutPanel7.Controls.Add(this.btnSim);
            this.flowLayoutPanel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel7.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel7.ForeColor = System.Drawing.Color.Black;
            this.flowLayoutPanel7.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel7.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel7.Name = "flowLayoutPanel7";
            this.flowLayoutPanel7.Padding = new System.Windows.Forms.Padding(5);
            this.flowLayoutPanel7.Size = new System.Drawing.Size(193, 499);
            this.flowLayoutPanel7.TabIndex = 1;
            // 
            // btnSimDadosInventario
            // 
            this.btnSimDadosInventario.BackColor = System.Drawing.Color.White;
            this.btnSimDadosInventario.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimDadosInventario.FlatAppearance.BorderSize = 3;
            this.btnSimDadosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimDadosInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSimDadosInventario.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimDadosInventario.Location = new System.Drawing.Point(8, 8);
            this.btnSimDadosInventario.Name = "btnSimDadosInventario";
            this.btnSimDadosInventario.Size = new System.Drawing.Size(181, 40);
            this.btnSimDadosInventario.TabIndex = 2;
            this.btnSimDadosInventario.Text = "Dados de inventário";
            this.btnSimDadosInventario.UseVisualStyleBackColor = false;
            // 
            // btnSimCoeficientesMAI
            // 
            this.btnSimCoeficientesMAI.BackColor = System.Drawing.Color.White;
            this.btnSimCoeficientesMAI.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimCoeficientesMAI.FlatAppearance.BorderSize = 3;
            this.btnSimCoeficientesMAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimCoeficientesMAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSimCoeficientesMAI.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimCoeficientesMAI.Location = new System.Drawing.Point(8, 54);
            this.btnSimCoeficientesMAI.Name = "btnSimCoeficientesMAI";
            this.btnSimCoeficientesMAI.Size = new System.Drawing.Size(181, 41);
            this.btnSimCoeficientesMAI.TabIndex = 12;
            this.btnSimCoeficientesMAI.Text = "Coeficientes - MAI";
            this.btnSimCoeficientesMAI.UseVisualStyleBackColor = false;
            // 
            // btnSimSortimentos
            // 
            this.btnSimSortimentos.BackColor = System.Drawing.Color.White;
            this.btnSimSortimentos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimSortimentos.FlatAppearance.BorderSize = 3;
            this.btnSimSortimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimSortimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSimSortimentos.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimSortimentos.Location = new System.Drawing.Point(8, 101);
            this.btnSimSortimentos.Name = "btnSimSortimentos";
            this.btnSimSortimentos.Size = new System.Drawing.Size(181, 41);
            this.btnSimSortimentos.TabIndex = 8;
            this.btnSimSortimentos.Text = "Sortimentos";
            this.btnSimSortimentos.UseVisualStyleBackColor = false;
            // 
            // btnSimPalhanilhaCustos
            // 
            this.btnSimPalhanilhaCustos.BackColor = System.Drawing.Color.White;
            this.btnSimPalhanilhaCustos.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSimPalhanilhaCustos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimPalhanilhaCustos.FlatAppearance.BorderSize = 3;
            this.btnSimPalhanilhaCustos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimPalhanilhaCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSimPalhanilhaCustos.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimPalhanilhaCustos.Location = new System.Drawing.Point(8, 148);
            this.btnSimPalhanilhaCustos.Name = "btnSimPalhanilhaCustos";
            this.btnSimPalhanilhaCustos.Size = new System.Drawing.Size(181, 41);
            this.btnSimPalhanilhaCustos.TabIndex = 12;
            this.btnSimPalhanilhaCustos.Text = "Planilha de custos";
            this.btnSimPalhanilhaCustos.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.txtSimTaxaDesconto);
            this.panel1.Location = new System.Drawing.Point(8, 195);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(181, 36);
            this.panel1.TabIndex = 13;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.White;
            this.button4.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.button4.FlatAppearance.BorderSize = 3;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.button4.Location = new System.Drawing.Point(0, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 36);
            this.button4.TabIndex = 23;
            this.button4.Text = "Taxa de descontos";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // txtSimTaxaDesconto
            // 
            this.txtSimTaxaDesconto.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSimTaxaDesconto.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtSimTaxaDesconto.Location = new System.Drawing.Point(150, 0);
            this.txtSimTaxaDesconto.Name = "txtSimTaxaDesconto";
            this.txtSimTaxaDesconto.Size = new System.Drawing.Size(31, 20);
            this.txtSimTaxaDesconto.TabIndex = 18;
            this.txtSimTaxaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cmbSimTipoDesbaste
            // 
            this.cmbSimTipoDesbaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbSimTipoDesbaste.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.cmbSimTipoDesbaste.FormattingEnabled = true;
            this.cmbSimTipoDesbaste.Items.AddRange(new object[] {"Seletivo", "Misto"});
            this.cmbSimTipoDesbaste.Location = new System.Drawing.Point(8, 237);
            this.cmbSimTipoDesbaste.Name = "cmbSimTipoDesbaste";
            this.cmbSimTipoDesbaste.Size = new System.Drawing.Size(181, 28);
            this.cmbSimTipoDesbaste.TabIndex = 14;
            this.cmbSimTipoDesbaste.Text = "Tipo de desbaste";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbSimControleDesbaste);
            this.panel2.Controls.Add(this.txtSimIntervaloSistematico);
            this.panel2.Location = new System.Drawing.Point(8, 271);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(181, 41);
            this.panel2.TabIndex = 15;
            // 
            // cmbSimControleDesbaste
            // 
            this.cmbSimControleDesbaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbSimControleDesbaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.cmbSimControleDesbaste.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.cmbSimControleDesbaste.FormattingEnabled = true;
            this.cmbSimControleDesbaste.Items.AddRange(new object[] {"Árvore", "Área basal"});
            this.cmbSimControleDesbaste.Location = new System.Drawing.Point(0, 0);
            this.cmbSimControleDesbaste.Name = "cmbSimControleDesbaste";
            this.cmbSimControleDesbaste.Size = new System.Drawing.Size(150, 23);
            this.cmbSimControleDesbaste.TabIndex = 17;
            this.cmbSimControleDesbaste.Text = "Controle de desbaste";
            // 
            // txtSimIntervaloSistematico
            // 
            this.txtSimIntervaloSistematico.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtSimIntervaloSistematico.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtSimIntervaloSistematico.Location = new System.Drawing.Point(150, 0);
            this.txtSimIntervaloSistematico.Name = "txtSimIntervaloSistematico";
            this.txtSimIntervaloSistematico.Size = new System.Drawing.Size(31, 20);
            this.txtSimIntervaloSistematico.TabIndex = 15;
            this.txtSimIntervaloSistematico.Text = "5";
            this.txtSimIntervaloSistematico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSimIntervaloSistematico.Visible = false;
            // 
            // btnSimCenarios
            // 
            this.btnSimCenarios.BackColor = System.Drawing.Color.White;
            this.btnSimCenarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimCenarios.FlatAppearance.BorderSize = 3;
            this.btnSimCenarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSimCenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSimCenarios.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSimCenarios.Location = new System.Drawing.Point(8, 318);
            this.btnSimCenarios.Name = "btnSimCenarios";
            this.btnSimCenarios.Size = new System.Drawing.Size(181, 41);
            this.btnSimCenarios.TabIndex = 16;
            this.btnSimCenarios.Text = "Cenários";
            this.btnSimCenarios.UseVisualStyleBackColor = false;
            // 
            // txtSimTitle
            // 
            this.txtSimTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtSimTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtSimTitle.Location = new System.Drawing.Point(8, 365);
            this.txtSimTitle.Name = "txtSimTitle";
            this.txtSimTitle.Size = new System.Drawing.Size(181, 26);
            this.txtSimTitle.TabIndex = 25;
            this.txtSimTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSim
            // 
            this.btnSim.BackColor = System.Drawing.Color.White;
            this.btnSim.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSim.FlatAppearance.BorderSize = 3;
            this.btnSim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSim.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSim.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSim.Location = new System.Drawing.Point(8, 397);
            this.btnSim.Name = "btnSim";
            this.btnSim.Size = new System.Drawing.Size(181, 41);
            this.btnSim.TabIndex = 24;
            this.btnSim.Text = "Simular";
            this.btnSim.UseVisualStyleBackColor = false;
            this.btnSim.Click += new System.EventHandler(this.btnSim_Click);
            // 
            // tpMax
            // 
            this.tpMax.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.tpMax.Controls.Add(this.flowLayoutPanel1);
            this.tpMax.Location = new System.Drawing.Point(4, 40);
            this.tpMax.Name = "tpMax";
            this.tpMax.Padding = new System.Windows.Forms.Padding(3);
            this.tpMax.Size = new System.Drawing.Size(193, 499);
            this.tpMax.TabIndex = 1;
            this.tpMax.Text = "Maximização";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.txtMaxHorizonte);
            this.flowLayoutPanel1.Controls.Add(this.txtMaxNumPlanejamento);
            this.flowLayoutPanel1.Controls.Add(this.txtMaxTitle);
            this.flowLayoutPanel1.Controls.Add(this.btnMax);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(187, 493);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // txtMaxHorizonte
            // 
            this.txtMaxHorizonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtMaxHorizonte.Location = new System.Drawing.Point(3, 3);
            this.txtMaxHorizonte.Name = "txtMaxHorizonte";
            this.txtMaxHorizonte.Size = new System.Drawing.Size(179, 26);
            this.txtMaxHorizonte.TabIndex = 33;
            // 
            // txtMaxNumPlanejamento
            // 
            this.txtMaxNumPlanejamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtMaxNumPlanejamento.Location = new System.Drawing.Point(3, 35);
            this.txtMaxNumPlanejamento.Name = "txtMaxNumPlanejamento";
            this.txtMaxNumPlanejamento.Size = new System.Drawing.Size(179, 26);
            this.txtMaxNumPlanejamento.TabIndex = 34;
            // 
            // txtMaxTitle
            // 
            this.txtMaxTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtMaxTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtMaxTitle.Location = new System.Drawing.Point(3, 67);
            this.txtMaxTitle.Name = "txtMaxTitle";
            this.txtMaxTitle.Size = new System.Drawing.Size(179, 26);
            this.txtMaxTitle.TabIndex = 32;
            this.txtMaxTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnMax
            // 
            this.btnMax.BackColor = System.Drawing.Color.White;
            this.btnMax.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnMax.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnMax.FlatAppearance.BorderSize = 3;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnMax.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnMax.Location = new System.Drawing.Point(3, 99);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(179, 41);
            this.btnMax.TabIndex = 35;
            this.btnMax.Text = "Simular";
            this.btnMax.UseVisualStyleBackColor = false;
            this.btnMax.Click += new System.EventHandler(this.btnMax_Click);
            // 
            // tpReg
            // 
            this.tpReg.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.tpReg.Controls.Add(this.flowLayoutPanel5);
            this.tpReg.Location = new System.Drawing.Point(4, 40);
            this.tpReg.Name = "tpReg";
            this.tpReg.Padding = new System.Windows.Forms.Padding(3);
            this.tpReg.Size = new System.Drawing.Size(193, 499);
            this.tpReg.TabIndex = 4;
            this.tpReg.Text = "Regulação";
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.Controls.Add(this.txtRegHorizonte);
            this.flowLayoutPanel5.Controls.Add(this.txtRegIdadeRegulacao);
            this.flowLayoutPanel5.Controls.Add(this.txtRegTitle);
            this.flowLayoutPanel5.Controls.Add(this.btnReg);
            this.flowLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel5.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Size = new System.Drawing.Size(187, 493);
            this.flowLayoutPanel5.TabIndex = 1;
            // 
            // txtRegHorizonte
            // 
            this.txtRegHorizonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtRegHorizonte.Location = new System.Drawing.Point(3, 3);
            this.txtRegHorizonte.Name = "txtRegHorizonte";
            this.txtRegHorizonte.Size = new System.Drawing.Size(179, 26);
            this.txtRegHorizonte.TabIndex = 43;
            // 
            // txtRegIdadeRegulacao
            // 
            this.txtRegIdadeRegulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtRegIdadeRegulacao.Location = new System.Drawing.Point(3, 35);
            this.txtRegIdadeRegulacao.Name = "txtRegIdadeRegulacao";
            this.txtRegIdadeRegulacao.Size = new System.Drawing.Size(179, 26);
            this.txtRegIdadeRegulacao.TabIndex = 44;
            // 
            // txtRegTitle
            // 
            this.txtRegTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtRegTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtRegTitle.Location = new System.Drawing.Point(3, 67);
            this.txtRegTitle.Name = "txtRegTitle";
            this.txtRegTitle.Size = new System.Drawing.Size(179, 26);
            this.txtRegTitle.TabIndex = 45;
            this.txtRegTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnReg
            // 
            this.btnReg.BackColor = System.Drawing.Color.White;
            this.btnReg.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnReg.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnReg.FlatAppearance.BorderSize = 3;
            this.btnReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnReg.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnReg.Location = new System.Drawing.Point(3, 99);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(179, 41);
            this.btnReg.TabIndex = 46;
            this.btnReg.Text = "Simular";
            this.btnReg.UseVisualStyleBackColor = false;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // tpSor
            // 
            this.tpSor.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.tpSor.Controls.Add(this.flowLayoutPanel3);
            this.tpSor.Location = new System.Drawing.Point(4, 40);
            this.tpSor.Name = "tpSor";
            this.tpSor.Padding = new System.Windows.Forms.Padding(3);
            this.tpSor.Size = new System.Drawing.Size(193, 499);
            this.tpSor.TabIndex = 2;
            this.tpSor.Text = "Sortimentos";
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Controls.Add(this.txtSorHorizonte);
            this.flowLayoutPanel3.Controls.Add(this.txtSorTitle);
            this.flowLayoutPanel3.Controls.Add(this.btnSor);
            this.flowLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(187, 493);
            this.flowLayoutPanel3.TabIndex = 1;
            // 
            // txtSorHorizonte
            // 
            this.txtSorHorizonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtSorHorizonte.Location = new System.Drawing.Point(3, 3);
            this.txtSorHorizonte.Name = "txtSorHorizonte";
            this.txtSorHorizonte.Size = new System.Drawing.Size(179, 26);
            this.txtSorHorizonte.TabIndex = 36;
            // 
            // txtSorTitle
            // 
            this.txtSorTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtSorTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtSorTitle.Location = new System.Drawing.Point(3, 35);
            this.txtSorTitle.Name = "txtSorTitle";
            this.txtSorTitle.Size = new System.Drawing.Size(179, 26);
            this.txtSorTitle.TabIndex = 37;
            this.txtSorTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnSor
            // 
            this.btnSor.BackColor = System.Drawing.Color.White;
            this.btnSor.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnSor.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSor.FlatAppearance.BorderSize = 3;
            this.btnSor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnSor.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnSor.Location = new System.Drawing.Point(3, 67);
            this.btnSor.Name = "btnSor";
            this.btnSor.Size = new System.Drawing.Size(179, 41);
            this.btnSor.TabIndex = 38;
            this.btnSor.Text = "Simular";
            this.btnSor.UseVisualStyleBackColor = false;
            this.btnSor.Click += new System.EventHandler(this.btnSor_Click);
            // 
            // tpBin
            // 
            this.tpBin.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.tpBin.Controls.Add(this.flowLayoutPanel4);
            this.tpBin.Location = new System.Drawing.Point(4, 40);
            this.tpBin.Name = "tpBin";
            this.tpBin.Padding = new System.Windows.Forms.Padding(3);
            this.tpBin.Size = new System.Drawing.Size(193, 499);
            this.tpBin.TabIndex = 3;
            this.tpBin.Text = "Binária";
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Controls.Add(this.txtBinHorizonte);
            this.flowLayoutPanel4.Controls.Add(this.txtBinTitle);
            this.flowLayoutPanel4.Controls.Add(this.btnBin);
            this.flowLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(187, 493);
            this.flowLayoutPanel4.TabIndex = 1;
            // 
            // txtBinHorizonte
            // 
            this.txtBinHorizonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtBinHorizonte.Location = new System.Drawing.Point(3, 3);
            this.txtBinHorizonte.Name = "txtBinHorizonte";
            this.txtBinHorizonte.Size = new System.Drawing.Size(181, 26);
            this.txtBinHorizonte.TabIndex = 39;
            // 
            // txtBinTitle
            // 
            this.txtBinTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.txtBinTitle.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.txtBinTitle.Location = new System.Drawing.Point(3, 35);
            this.txtBinTitle.Name = "txtBinTitle";
            this.txtBinTitle.Size = new System.Drawing.Size(181, 26);
            this.txtBinTitle.TabIndex = 42;
            this.txtBinTitle.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBin
            // 
            this.btnBin.BackColor = System.Drawing.Color.White;
            this.btnBin.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnBin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnBin.FlatAppearance.BorderSize = 3;
            this.btnBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (0)));
            this.btnBin.ForeColor = System.Drawing.Color.FromArgb(((int) (((byte) (0)))), ((int) (((byte) (192)))), ((int) (((byte) (0)))));
            this.btnBin.Location = new System.Drawing.Point(3, 67);
            this.btnBin.Name = "btnBin";
            this.btnBin.Size = new System.Drawing.Size(184, 41);
            this.btnBin.TabIndex = 41;
            this.btnBin.Text = "Simular";
            this.btnBin.UseVisualStyleBackColor = false;
            this.btnBin.Click += new System.EventHandler(this.btnBin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (255)))), ((int) (((byte) (255)))), ((int) (((byte) (128)))));
            this.ClientSize = new System.Drawing.Size(808, 567);
            this.Controls.Add(this.tabNavibar);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.txtLogo);
            this.Controls.Add(this.dataGridView1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Entradas e premissas";
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabNavibar.ResumeLayout(false);
            this.tpSim.ResumeLayout(false);
            this.flowLayoutPanel7.ResumeLayout(false);
            this.flowLayoutPanel7.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.tpMax.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.tpReg.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.tpSor.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.tpBin.ResumeLayout(false);
            this.flowLayoutPanel4.ResumeLayout(false);
            this.flowLayoutPanel4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtLogo;

        #endregion
        private System.Windows.Forms.Button btnSimSortimentos;
        private System.Windows.Forms.Button btnSimPalhanilhaCustos;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ComboBox cmbSimTipoDesbaste;
        private System.Windows.Forms.TextBox txtSimIntervaloSistematico;
        private System.Windows.Forms.Button btnSimCenarios;
        private System.Windows.Forms.ComboBox cmbSimControleDesbaste;
        private System.Windows.Forms.TextBox txtSimTaxaDesconto;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.TextBox txtSimTitle;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSim;
        private System.Windows.Forms.ToolStripMenuItem tsmiMax;
        private System.Windows.Forms.TextBox txtMaxTitle;
        private System.Windows.Forms.TextBox txtMaxHorizonte;
        private System.Windows.Forms.TextBox txtMaxNumPlanejamento;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.ToolStripMenuItem tsmiSor;
        private System.Windows.Forms.TextBox txtSorHorizonte;
        private System.Windows.Forms.TextBox txtSorTitle;
        private System.Windows.Forms.Button btnSor;
        private System.Windows.Forms.ToolStripMenuItem tsmiBin;
        private System.Windows.Forms.TextBox txtBinHorizonte;
        private System.Windows.Forms.Button btnBin;
        private System.Windows.Forms.TextBox txtBinTitle;
        private System.Windows.Forms.ToolStripMenuItem tsmiReg;
        private System.Windows.Forms.TextBox txtRegHorizonte;
        private System.Windows.Forms.TextBox txtRegIdadeRegulacao;
        private System.Windows.Forms.TextBox txtRegTitle;
        private System.Windows.Forms.Button btnReg;
        private Components.TabControlWithoutHeader tabNavibar;
        private System.Windows.Forms.TabPage tpSim;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel7;
        private System.Windows.Forms.Button btnSimDadosInventario;
        private System.Windows.Forms.Button btnSimCoeficientesMAI;
        private System.Windows.Forms.TabPage tpMax;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TabPage tpReg;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.TabPage tpSor;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.TabPage tpBin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSim;
    }
}

