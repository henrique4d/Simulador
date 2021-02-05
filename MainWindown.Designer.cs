using System.ComponentModel;

namespace Simulador
{
    partial class MainWindown
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindown));
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlHeaderRight = new System.Windows.Forms.Panel();
            this.pnlHeaderActionsRight = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlHeaderActionsLeft = new System.Windows.Forms.FlowLayoutPanel();
            this.nviPreescricoes = new Simulador.Components.NavbarItem();
            this.navPenalidades = new Simulador.Components.NavbarItem();
            this.pnlHeaderLeft = new System.Windows.Forms.Panel();
            this.lblMiniLogo = new System.Windows.Forms.Label();
            this.tabMain = new Simulador.Components.TabControlWithoutHeader();
            this.tpPanilha = new System.Windows.Forms.TabPage();
            this.lblPlanilhaNomeArquivo = new System.Windows.Forms.Label();
            this.ssMainNomeArquivo = new System.Windows.Forms.StatusStrip();
            this.slblTpMainEnderecoArquivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tpLogo = new System.Windows.Forms.TabPage();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.lblMainLogo = new System.Windows.Forms.Label();
            this.tabSidebar = new Simulador.Components.TabControlWithoutHeader();
            this.tpPreescricoes = new System.Windows.Forms.TabPage();
            this.flpPre = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPreImportarTabelas = new System.Windows.Forms.Label();
            this.flpPreImportarTabelas = new System.Windows.Forms.FlowLayoutPanel();
            this.sbiPreDadosInventario = new Simulador.Components.SidebarItem(this.components);
            this.sbiPreCoeficienteMAI = new Simulador.Components.SidebarItem(this.components);
            this.sbiPreSortimentos = new Simulador.Components.SidebarItem(this.components);
            this.sbiPrePanilhaCustos = new Simulador.Components.SidebarItem(this.components);
            this.sbiPreCenarios = new Simulador.Components.SidebarItem(this.components);
            this.lblPreDadosPreescricao = new System.Windows.Forms.Label();
            this.flpPreDadosPreescricao = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlPreTaxaDesconto = new System.Windows.Forms.Panel();
            this.txtPreTaxaDesconto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlPreTipoDesbaste = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbPreTipoDesbaste = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.pnlPreControleDesbaste = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.cmbPreControleDesbaste = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.pnlPreIntervaloSistematico = new System.Windows.Forms.Panel();
            this.txtPreIntervaloSistematico = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.lblPreGerarPreescricoes = new System.Windows.Forms.Label();
            this.flpPreGerarPreescricoes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel10 = new System.Windows.Forms.Panel();
            this.txtPrePreTitulo = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.sbiPrePre = new Simulador.Components.SidebarItem(this.components);
            this.tpPenalidades = new System.Windows.Forms.TabPage();
            this.flpPen = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPenDadosCompartilhados = new System.Windows.Forms.Label();
            this.flpPenDadosCompartilhados = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPenHorizonte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblPenMaximizacoes = new System.Windows.Forms.Label();
            this.flpPenMaximizacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPenMaxNumPlanejamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPenMaxTitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.sbiPenMax = new Simulador.Components.SidebarItem(this.components);
            this.lblPenSortimentos = new System.Windows.Forms.Label();
            this.flpPenSortimentos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtPenSorTitulo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.sbiPenSor = new Simulador.Components.SidebarItem(this.components);
            this.lblPenBinaria = new System.Windows.Forms.Label();
            this.flpPenBinaria = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtPenBinTitulo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.sbiPenBin = new Simulador.Components.SidebarItem(this.components);
            this.lblPenRegulacao = new System.Windows.Forms.Label();
            this.flpPenRegulacao = new System.Windows.Forms.FlowLayoutPanel();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtPenRegIdadeRegulacao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtPenRegTitulo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.sbiPenReg = new Simulador.Components.SidebarItem(this.components);
            this.tbOther = new System.Windows.Forms.TabPage();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.pnlHeaderActionsLeft.SuspendLayout();
            this.pnlHeaderLeft.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpPanilha.SuspendLayout();
            this.ssMainNomeArquivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tpLogo.SuspendLayout();
            this.tabSidebar.SuspendLayout();
            this.tpPreescricoes.SuspendLayout();
            this.flpPre.SuspendLayout();
            this.flpPreImportarTabelas.SuspendLayout();
            this.flpPreDadosPreescricao.SuspendLayout();
            this.pnlPreTaxaDesconto.SuspendLayout();
            this.pnlPreTipoDesbaste.SuspendLayout();
            this.panel4.SuspendLayout();
            this.pnlPreControleDesbaste.SuspendLayout();
            this.panel8.SuspendLayout();
            this.pnlPreIntervaloSistematico.SuspendLayout();
            this.flpPreGerarPreescricoes.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel10.SuspendLayout();
            this.tpPenalidades.SuspendLayout();
            this.flpPen.SuspendLayout();
            this.flpPenDadosCompartilhados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.flpPenMaximizacoes.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.flpPenSortimentos.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.flpPenBinaria.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.flpPenRegulacao.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.pnlHeader.Controls.Add(this.pnlHeaderRight);
            this.pnlHeader.Controls.Add(this.pnlHeaderLeft);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Padding = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.pnlHeader.Size = new System.Drawing.Size(784, 56);
            this.pnlHeader.TabIndex = 2;
            // 
            // pnlHeaderRight
            // 
            this.pnlHeaderRight.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderRight.Controls.Add(this.pnlHeaderActionsRight);
            this.pnlHeaderRight.Controls.Add(this.pnlHeaderActionsLeft);
            this.pnlHeaderRight.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlHeaderRight.Location = new System.Drawing.Point(99, 7);
            this.pnlHeaderRight.Name = "pnlHeaderRight";
            this.pnlHeaderRight.Size = new System.Drawing.Size(685, 42);
            this.pnlHeaderRight.TabIndex = 2;
            // 
            // pnlHeaderActionsRight
            // 
            this.pnlHeaderActionsRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlHeaderActionsRight.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.pnlHeaderActionsRight.Location = new System.Drawing.Point(545, 0);
            this.pnlHeaderActionsRight.Name = "pnlHeaderActionsRight";
            this.pnlHeaderActionsRight.Size = new System.Drawing.Size(140, 42);
            this.pnlHeaderActionsRight.TabIndex = 2;
            // 
            // pnlHeaderActionsLeft
            // 
            this.pnlHeaderActionsLeft.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlHeaderActionsLeft.Controls.Add(this.nviPreescricoes);
            this.pnlHeaderActionsLeft.Controls.Add(this.navPenalidades);
            this.pnlHeaderActionsLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeaderActionsLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlHeaderActionsLeft.Name = "pnlHeaderActionsLeft";
            this.pnlHeaderActionsLeft.Padding = new System.Windows.Forms.Padding(3);
            this.pnlHeaderActionsLeft.Size = new System.Drawing.Size(615, 42);
            this.pnlHeaderActionsLeft.TabIndex = 1;
            // 
            // nviPreescricoes
            // 
            this.nviPreescricoes.Active = false;
            this.nviPreescricoes.AutoSize = true;
            this.nviPreescricoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nviPreescricoes.Location = new System.Drawing.Point(6, 6);
            this.nviPreescricoes.Name = "nviPreescricoes";
            this.nviPreescricoes.Size = new System.Drawing.Size(104, 32);
            this.nviPreescricoes.TabIndex = 3;
            this.nviPreescricoes.TextItem = "Preescrições";
            this.nviPreescricoes.Click += new System.EventHandler(this.nviPreescricoes_Click);
            // 
            // navPenalidades
            // 
            this.navPenalidades.Active = false;
            this.navPenalidades.AutoSize = true;
            this.navPenalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.navPenalidades.Location = new System.Drawing.Point(116, 6);
            this.navPenalidades.Name = "navPenalidades";
            this.navPenalidades.Size = new System.Drawing.Size(100, 32);
            this.navPenalidades.TabIndex = 4;
            this.navPenalidades.TextItem = "Penalidades";
            this.navPenalidades.Click += new System.EventHandler(this.navPenalidades_Click);
            // 
            // pnlHeaderLeft
            // 
            this.pnlHeaderLeft.BackColor = System.Drawing.Color.Transparent;
            this.pnlHeaderLeft.Controls.Add(this.lblMiniLogo);
            this.pnlHeaderLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlHeaderLeft.Location = new System.Drawing.Point(0, 7);
            this.pnlHeaderLeft.Name = "pnlHeaderLeft";
            this.pnlHeaderLeft.Size = new System.Drawing.Size(99, 42);
            this.pnlHeaderLeft.TabIndex = 0;
            // 
            // lblMiniLogo
            // 
            this.lblMiniLogo.AutoSize = true;
            this.lblMiniLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMiniLogo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblMiniLogo.Location = new System.Drawing.Point(18, 11);
            this.lblMiniLogo.Name = "lblMiniLogo";
            this.lblMiniLogo.Size = new System.Drawing.Size(66, 25);
            this.lblMiniLogo.TabIndex = 0;
            this.lblMiniLogo.Text = "GMPf";
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpPanilha);
            this.tabMain.Controls.Add(this.tpLogo);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(230, 56);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(554, 535);
            this.tabMain.TabIndex = 4;
            // 
            // tpPanilha
            // 
            this.tpPanilha.Controls.Add(this.lblPlanilhaNomeArquivo);
            this.tpPanilha.Controls.Add(this.ssMainNomeArquivo);
            this.tpPanilha.Controls.Add(this.dataGridView1);
            this.tpPanilha.Location = new System.Drawing.Point(4, 22);
            this.tpPanilha.Name = "tpPanilha";
            this.tpPanilha.Padding = new System.Windows.Forms.Padding(3);
            this.tpPanilha.Size = new System.Drawing.Size(546, 509);
            this.tpPanilha.TabIndex = 0;
            this.tpPanilha.Text = "Panilha";
            this.tpPanilha.UseVisualStyleBackColor = true;
            // 
            // lblPlanilhaNomeArquivo
            // 
            this.lblPlanilhaNomeArquivo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblPlanilhaNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilhaNomeArquivo.Location = new System.Drawing.Point(3, 3);
            this.lblPlanilhaNomeArquivo.Name = "lblPlanilhaNomeArquivo";
            this.lblPlanilhaNomeArquivo.Size = new System.Drawing.Size(540, 25);
            this.lblPlanilhaNomeArquivo.TabIndex = 2;
            this.lblPlanilhaNomeArquivo.Text = "Nome do arquivo carregado";
            this.lblPlanilhaNomeArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ssMainNomeArquivo
            // 
            this.ssMainNomeArquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblTpMainEnderecoArquivo});
            this.ssMainNomeArquivo.Location = new System.Drawing.Point(3, 484);
            this.ssMainNomeArquivo.Name = "ssMainNomeArquivo";
            this.ssMainNomeArquivo.Size = new System.Drawing.Size(540, 22);
            this.ssMainNomeArquivo.TabIndex = 1;
            this.ssMainNomeArquivo.Text = "statusStrip1";
            // 
            // slblTpMainEnderecoArquivo
            // 
            this.slblTpMainEnderecoArquivo.Name = "slblTpMainEnderecoArquivo";
            this.slblTpMainEnderecoArquivo.Size = new System.Drawing.Size(55, 17);
            this.slblTpMainEnderecoArquivo.Text = "Arquivo: ";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(540, 503);
            this.dataGridView1.TabIndex = 0;
            // 
            // tpLogo
            // 
            this.tpLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tpLogo.Controls.Add(this.lblMainInfo);
            this.tpLogo.Controls.Add(this.lblMainLogo);
            this.tpLogo.Location = new System.Drawing.Point(4, 22);
            this.tpLogo.Name = "tpLogo";
            this.tpLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogo.Size = new System.Drawing.Size(555, 390);
            this.tpLogo.TabIndex = 1;
            this.tpLogo.Text = "Logo";
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMainInfo.ForeColor = System.Drawing.Color.White;
            this.lblMainInfo.Location = new System.Drawing.Point(3, 3);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(549, 136);
            this.lblMainInfo.TabIndex = 1;
            this.lblMainInfo.Text = "Aguarde até o processamento ser concluído";
            this.lblMainInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMainInfo.Visible = false;
            // 
            // lblMainLogo
            // 
            this.lblMainLogo.AutoSize = true;
            this.lblMainLogo.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainLogo.ForeColor = System.Drawing.Color.White;
            this.lblMainLogo.Location = new System.Drawing.Point(159, 194);
            this.lblMainLogo.Name = "lblMainLogo";
            this.lblMainLogo.Size = new System.Drawing.Size(358, 120);
            this.lblMainLogo.TabIndex = 0;
            this.lblMainLogo.Text = "GMPF";
            // 
            // tabSidebar
            // 
            this.tabSidebar.Controls.Add(this.tpPreescricoes);
            this.tabSidebar.Controls.Add(this.tpPenalidades);
            this.tabSidebar.Controls.Add(this.tbOther);
            this.tabSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.tabSidebar.Location = new System.Drawing.Point(0, 56);
            this.tabSidebar.Multiline = true;
            this.tabSidebar.Name = "tabSidebar";
            this.tabSidebar.SelectedIndex = 0;
            this.tabSidebar.Size = new System.Drawing.Size(230, 535);
            this.tabSidebar.TabIndex = 3;
            // 
            // tpPreescricoes
            // 
            this.tpPreescricoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tpPreescricoes.Controls.Add(this.flpPre);
            this.tpPreescricoes.Location = new System.Drawing.Point(4, 22);
            this.tpPreescricoes.Margin = new System.Windows.Forms.Padding(0);
            this.tpPreescricoes.Name = "tpPreescricoes";
            this.tpPreescricoes.Size = new System.Drawing.Size(222, 509);
            this.tpPreescricoes.TabIndex = 0;
            this.tpPreescricoes.Text = "Preescricoes";
            // 
            // flpPre
            // 
            this.flpPre.AutoScroll = true;
            this.flpPre.AutoSize = true;
            this.flpPre.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPre.Controls.Add(this.lblPreImportarTabelas);
            this.flpPre.Controls.Add(this.flpPreImportarTabelas);
            this.flpPre.Controls.Add(this.lblPreDadosPreescricao);
            this.flpPre.Controls.Add(this.flpPreDadosPreescricao);
            this.flpPre.Controls.Add(this.lblPreGerarPreescricoes);
            this.flpPre.Controls.Add(this.flpPreGerarPreescricoes);
            this.flpPre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPre.Location = new System.Drawing.Point(0, 0);
            this.flpPre.Name = "flpPre";
            this.flpPre.Size = new System.Drawing.Size(222, 509);
            this.flpPre.TabIndex = 0;
            // 
            // lblPreImportarTabelas
            // 
            this.lblPreImportarTabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPreImportarTabelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreImportarTabelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreImportarTabelas.ForeColor = System.Drawing.Color.White;
            this.lblPreImportarTabelas.Location = new System.Drawing.Point(0, 0);
            this.lblPreImportarTabelas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblPreImportarTabelas.Name = "lblPreImportarTabelas";
            this.lblPreImportarTabelas.Size = new System.Drawing.Size(213, 22);
            this.lblPreImportarTabelas.TabIndex = 0;
            this.lblPreImportarTabelas.Text = "Importar Tabelas";
            this.lblPreImportarTabelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreImportarTabelas.Click += new System.EventHandler(this.lblPreImportarTabelas_Click);
            // 
            // flpPreImportarTabelas
            // 
            this.flpPreImportarTabelas.AutoSize = true;
            this.flpPreImportarTabelas.Controls.Add(this.sbiPreDadosInventario);
            this.flpPreImportarTabelas.Controls.Add(this.sbiPreCoeficienteMAI);
            this.flpPreImportarTabelas.Controls.Add(this.sbiPreSortimentos);
            this.flpPreImportarTabelas.Controls.Add(this.sbiPrePanilhaCustos);
            this.flpPreImportarTabelas.Controls.Add(this.sbiPreCenarios);
            this.flpPreImportarTabelas.Location = new System.Drawing.Point(0, 29);
            this.flpPreImportarTabelas.Margin = new System.Windows.Forms.Padding(0);
            this.flpPreImportarTabelas.Name = "flpPreImportarTabelas";
            this.flpPreImportarTabelas.Size = new System.Drawing.Size(209, 150);
            this.flpPreImportarTabelas.TabIndex = 15;
            // 
            // sbiPreDadosInventario
            // 
            this.sbiPreDadosInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreDadosInventario.FlatAppearance.BorderSize = 0;
            this.sbiPreDadosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreDadosInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreDadosInventario.ForeColor = System.Drawing.Color.White;
            this.sbiPreDadosInventario.Location = new System.Drawing.Point(0, 0);
            this.sbiPreDadosInventario.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreDadosInventario.Name = "sbiPreDadosInventario";
            this.sbiPreDadosInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreDadosInventario.Size = new System.Drawing.Size(209, 30);
            this.sbiPreDadosInventario.TabIndex = 1;
            this.sbiPreDadosInventario.TabStop = false;
            this.sbiPreDadosInventario.Text = "Dados de Inventário";
            this.sbiPreDadosInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreDadosInventario.UseVisualStyleBackColor = true;
            // 
            // sbiPreCoeficienteMAI
            // 
            this.sbiPreCoeficienteMAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreCoeficienteMAI.FlatAppearance.BorderSize = 0;
            this.sbiPreCoeficienteMAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreCoeficienteMAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreCoeficienteMAI.ForeColor = System.Drawing.Color.White;
            this.sbiPreCoeficienteMAI.Location = new System.Drawing.Point(0, 30);
            this.sbiPreCoeficienteMAI.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreCoeficienteMAI.Name = "sbiPreCoeficienteMAI";
            this.sbiPreCoeficienteMAI.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreCoeficienteMAI.Size = new System.Drawing.Size(209, 30);
            this.sbiPreCoeficienteMAI.TabIndex = 4;
            this.sbiPreCoeficienteMAI.TabStop = false;
            this.sbiPreCoeficienteMAI.Text = "Coeficientes - MAI";
            this.sbiPreCoeficienteMAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreCoeficienteMAI.UseVisualStyleBackColor = true;
            // 
            // sbiPreSortimentos
            // 
            this.sbiPreSortimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreSortimentos.FlatAppearance.BorderSize = 0;
            this.sbiPreSortimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreSortimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreSortimentos.ForeColor = System.Drawing.Color.White;
            this.sbiPreSortimentos.Location = new System.Drawing.Point(0, 60);
            this.sbiPreSortimentos.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreSortimentos.Name = "sbiPreSortimentos";
            this.sbiPreSortimentos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreSortimentos.Size = new System.Drawing.Size(209, 30);
            this.sbiPreSortimentos.TabIndex = 5;
            this.sbiPreSortimentos.TabStop = false;
            this.sbiPreSortimentos.Text = "Sortimentos";
            this.sbiPreSortimentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreSortimentos.UseVisualStyleBackColor = true;
            // 
            // sbiPrePanilhaCustos
            // 
            this.sbiPrePanilhaCustos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPrePanilhaCustos.FlatAppearance.BorderSize = 0;
            this.sbiPrePanilhaCustos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPrePanilhaCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPrePanilhaCustos.ForeColor = System.Drawing.Color.White;
            this.sbiPrePanilhaCustos.Location = new System.Drawing.Point(0, 90);
            this.sbiPrePanilhaCustos.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPrePanilhaCustos.Name = "sbiPrePanilhaCustos";
            this.sbiPrePanilhaCustos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPrePanilhaCustos.Size = new System.Drawing.Size(209, 30);
            this.sbiPrePanilhaCustos.TabIndex = 3;
            this.sbiPrePanilhaCustos.TabStop = false;
            this.sbiPrePanilhaCustos.Text = "Planilhas de Custos";
            this.sbiPrePanilhaCustos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPrePanilhaCustos.UseVisualStyleBackColor = true;
            // 
            // sbiPreCenarios
            // 
            this.sbiPreCenarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreCenarios.FlatAppearance.BorderSize = 0;
            this.sbiPreCenarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreCenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreCenarios.ForeColor = System.Drawing.Color.White;
            this.sbiPreCenarios.Location = new System.Drawing.Point(0, 120);
            this.sbiPreCenarios.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreCenarios.Name = "sbiPreCenarios";
            this.sbiPreCenarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreCenarios.Size = new System.Drawing.Size(209, 30);
            this.sbiPreCenarios.TabIndex = 2;
            this.sbiPreCenarios.TabStop = false;
            this.sbiPreCenarios.Text = "Cenários";
            this.sbiPreCenarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreCenarios.UseVisualStyleBackColor = true;
            // 
            // lblPreDadosPreescricao
            // 
            this.lblPreDadosPreescricao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPreDadosPreescricao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreDadosPreescricao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreDadosPreescricao.ForeColor = System.Drawing.Color.White;
            this.lblPreDadosPreescricao.Location = new System.Drawing.Point(0, 186);
            this.lblPreDadosPreescricao.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPreDadosPreescricao.Name = "lblPreDadosPreescricao";
            this.lblPreDadosPreescricao.Size = new System.Drawing.Size(213, 22);
            this.lblPreDadosPreescricao.TabIndex = 1;
            this.lblPreDadosPreescricao.Text = "Dados da Prescrição";
            this.lblPreDadosPreescricao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreDadosPreescricao.Click += new System.EventHandler(this.lblPreDadosPreescricao_Click);
            // 
            // flpPreDadosPreescricao
            // 
            this.flpPreDadosPreescricao.AutoSize = true;
            this.flpPreDadosPreescricao.Controls.Add(this.pnlPreTaxaDesconto);
            this.flpPreDadosPreescricao.Controls.Add(this.pnlPreTipoDesbaste);
            this.flpPreDadosPreescricao.Controls.Add(this.pnlPreControleDesbaste);
            this.flpPreDadosPreescricao.Controls.Add(this.pnlPreIntervaloSistematico);
            this.flpPreDadosPreescricao.Location = new System.Drawing.Point(0, 215);
            this.flpPreDadosPreescricao.Margin = new System.Windows.Forms.Padding(0);
            this.flpPreDadosPreescricao.Name = "flpPreDadosPreescricao";
            this.flpPreDadosPreescricao.Size = new System.Drawing.Size(215, 180);
            this.flpPreDadosPreescricao.TabIndex = 14;
            // 
            // pnlPreTaxaDesconto
            // 
            this.pnlPreTaxaDesconto.Controls.Add(this.txtPreTaxaDesconto);
            this.pnlPreTaxaDesconto.Controls.Add(this.label8);
            this.pnlPreTaxaDesconto.Location = new System.Drawing.Point(3, 3);
            this.pnlPreTaxaDesconto.Name = "pnlPreTaxaDesconto";
            this.pnlPreTaxaDesconto.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlPreTaxaDesconto.Size = new System.Drawing.Size(209, 30);
            this.pnlPreTaxaDesconto.TabIndex = 12;
            // 
            // txtPreTaxaDesconto
            // 
            this.txtPreTaxaDesconto.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPreTaxaDesconto.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreTaxaDesconto.Location = new System.Drawing.Point(141, 0);
            this.txtPreTaxaDesconto.Multiline = true;
            this.txtPreTaxaDesconto.Name = "txtPreTaxaDesconto";
            this.txtPreTaxaDesconto.Size = new System.Drawing.Size(58, 30);
            this.txtPreTaxaDesconto.TabIndex = 1;
            this.txtPreTaxaDesconto.Text = "0";
            this.txtPreTaxaDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreTaxaDesconto.WordWrap = false;
            // 
            // label8
            // 
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(10, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(189, 30);
            this.label8.TabIndex = 0;
            this.label8.Text = "Taxa de Desconto";
            // 
            // pnlPreTipoDesbaste
            // 
            this.pnlPreTipoDesbaste.Controls.Add(this.panel4);
            this.pnlPreTipoDesbaste.Controls.Add(this.label9);
            this.pnlPreTipoDesbaste.Location = new System.Drawing.Point(3, 39);
            this.pnlPreTipoDesbaste.Name = "pnlPreTipoDesbaste";
            this.pnlPreTipoDesbaste.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlPreTipoDesbaste.Size = new System.Drawing.Size(209, 48);
            this.pnlPreTipoDesbaste.TabIndex = 13;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.cmbPreTipoDesbaste);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(10, 13);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel4.Size = new System.Drawing.Size(189, 35);
            this.panel4.TabIndex = 1;
            // 
            // cmbPreTipoDesbaste
            // 
            this.cmbPreTipoDesbaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPreTipoDesbaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreTipoDesbaste.FormattingEnabled = true;
            this.cmbPreTipoDesbaste.Items.AddRange(new object[] {
            "Seletivo",
            "Misto"});
            this.cmbPreTipoDesbaste.Location = new System.Drawing.Point(0, 5);
            this.cmbPreTipoDesbaste.Name = "cmbPreTipoDesbaste";
            this.cmbPreTipoDesbaste.Size = new System.Drawing.Size(189, 24);
            this.cmbPreTipoDesbaste.TabIndex = 2;
            this.cmbPreTipoDesbaste.SelectedIndexChanged += new System.EventHandler(this.cmbPreTipoDesbaste_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.Dock = System.Windows.Forms.DockStyle.Top;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(10, 0);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(189, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Tipo de Desbaste";
            // 
            // pnlPreControleDesbaste
            // 
            this.pnlPreControleDesbaste.Controls.Add(this.panel8);
            this.pnlPreControleDesbaste.Controls.Add(this.label12);
            this.pnlPreControleDesbaste.Location = new System.Drawing.Point(3, 93);
            this.pnlPreControleDesbaste.Name = "pnlPreControleDesbaste";
            this.pnlPreControleDesbaste.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlPreControleDesbaste.Size = new System.Drawing.Size(209, 48);
            this.pnlPreControleDesbaste.TabIndex = 14;
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.cmbPreControleDesbaste);
            this.panel8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel8.Location = new System.Drawing.Point(10, 13);
            this.panel8.Name = "panel8";
            this.panel8.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel8.Size = new System.Drawing.Size(189, 35);
            this.panel8.TabIndex = 1;
            // 
            // cmbPreControleDesbaste
            // 
            this.cmbPreControleDesbaste.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPreControleDesbaste.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbPreControleDesbaste.FormattingEnabled = true;
            this.cmbPreControleDesbaste.Items.AddRange(new object[] {
            "Árvore",
            "Área basal"});
            this.cmbPreControleDesbaste.Location = new System.Drawing.Point(0, 5);
            this.cmbPreControleDesbaste.Name = "cmbPreControleDesbaste";
            this.cmbPreControleDesbaste.Size = new System.Drawing.Size(189, 24);
            this.cmbPreControleDesbaste.TabIndex = 2;
            // 
            // label12
            // 
            this.label12.Dock = System.Windows.Forms.DockStyle.Top;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(10, 0);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(189, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Controle de Desbaste";
            // 
            // pnlPreIntervaloSistematico
            // 
            this.pnlPreIntervaloSistematico.Controls.Add(this.txtPreIntervaloSistematico);
            this.pnlPreIntervaloSistematico.Controls.Add(this.label23);
            this.pnlPreIntervaloSistematico.Location = new System.Drawing.Point(3, 147);
            this.pnlPreIntervaloSistematico.Name = "pnlPreIntervaloSistematico";
            this.pnlPreIntervaloSistematico.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.pnlPreIntervaloSistematico.Size = new System.Drawing.Size(209, 30);
            this.pnlPreIntervaloSistematico.TabIndex = 15;
            this.pnlPreIntervaloSistematico.Visible = false;
            // 
            // txtPreIntervaloSistematico
            // 
            this.txtPreIntervaloSistematico.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPreIntervaloSistematico.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreIntervaloSistematico.Location = new System.Drawing.Point(154, 0);
            this.txtPreIntervaloSistematico.Multiline = true;
            this.txtPreIntervaloSistematico.Name = "txtPreIntervaloSistematico";
            this.txtPreIntervaloSistematico.Size = new System.Drawing.Size(45, 30);
            this.txtPreIntervaloSistematico.TabIndex = 1;
            this.txtPreIntervaloSistematico.Text = "10";
            this.txtPreIntervaloSistematico.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPreIntervaloSistematico.WordWrap = false;
            // 
            // label23
            // 
            this.label23.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(10, 0);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(189, 30);
            this.label23.TabIndex = 0;
            this.label23.Text = "Intervalo Sistematico";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreGerarPreescricoes
            // 
            this.lblPreGerarPreescricoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPreGerarPreescricoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreGerarPreescricoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreGerarPreescricoes.ForeColor = System.Drawing.Color.White;
            this.lblPreGerarPreescricoes.Location = new System.Drawing.Point(0, 402);
            this.lblPreGerarPreescricoes.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPreGerarPreescricoes.Name = "lblPreGerarPreescricoes";
            this.lblPreGerarPreescricoes.Size = new System.Drawing.Size(213, 22);
            this.lblPreGerarPreescricoes.TabIndex = 10;
            this.lblPreGerarPreescricoes.Text = "Gerar Prescrição";
            this.lblPreGerarPreescricoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreGerarPreescricoes.Click += new System.EventHandler(this.lblPreGerarPreescricoes_Click);
            // 
            // flpPreGerarPreescricoes
            // 
            this.flpPreGerarPreescricoes.AutoSize = true;
            this.flpPreGerarPreescricoes.Controls.Add(this.panel9);
            this.flpPreGerarPreescricoes.Controls.Add(this.sbiPrePre);
            this.flpPreGerarPreescricoes.Location = new System.Drawing.Point(0, 431);
            this.flpPreGerarPreescricoes.Margin = new System.Windows.Forms.Padding(0);
            this.flpPreGerarPreescricoes.Name = "flpPreGerarPreescricoes";
            this.flpPreGerarPreescricoes.Size = new System.Drawing.Size(215, 84);
            this.flpPreGerarPreescricoes.TabIndex = 16;
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Controls.Add(this.label15);
            this.panel9.Location = new System.Drawing.Point(3, 3);
            this.panel9.Name = "panel9";
            this.panel9.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel9.Size = new System.Drawing.Size(209, 48);
            this.panel9.TabIndex = 12;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.txtPrePreTitulo);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel10.Location = new System.Drawing.Point(10, 13);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel10.Size = new System.Drawing.Size(189, 35);
            this.panel10.TabIndex = 1;
            // 
            // txtPrePreTitulo
            // 
            this.txtPrePreTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPrePreTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrePreTitulo.Location = new System.Drawing.Point(0, 5);
            this.txtPrePreTitulo.Multiline = true;
            this.txtPrePreTitulo.Name = "txtPrePreTitulo";
            this.txtPrePreTitulo.Size = new System.Drawing.Size(189, 30);
            this.txtPrePreTitulo.TabIndex = 0;
            // 
            // label15
            // 
            this.label15.Dock = System.Windows.Forms.DockStyle.Top;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(10, 0);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(189, 13);
            this.label15.TabIndex = 0;
            this.label15.Text = "Título";
            // 
            // sbiPrePre
            // 
            this.sbiPrePre.BackColor = System.Drawing.Color.White;
            this.sbiPrePre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPrePre.FlatAppearance.BorderSize = 0;
            this.sbiPrePre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPrePre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPrePre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPrePre.Location = new System.Drawing.Point(0, 54);
            this.sbiPrePre.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPrePre.Name = "sbiPrePre";
            this.sbiPrePre.Size = new System.Drawing.Size(199, 30);
            this.sbiPrePre.TabIndex = 5;
            this.sbiPrePre.TabStop = false;
            this.sbiPrePre.Text = "Simular";
            this.sbiPrePre.UseVisualStyleBackColor = false;
            this.sbiPrePre.Click += new System.EventHandler(this.sbiPrePre_Click);
            // 
            // tpPenalidades
            // 
            this.tpPenalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tpPenalidades.Controls.Add(this.flpPen);
            this.tpPenalidades.Location = new System.Drawing.Point(4, 22);
            this.tpPenalidades.Margin = new System.Windows.Forms.Padding(0);
            this.tpPenalidades.Name = "tpPenalidades";
            this.tpPenalidades.Size = new System.Drawing.Size(222, 509);
            this.tpPenalidades.TabIndex = 1;
            this.tpPenalidades.Text = "Penalidades";
            // 
            // flpPen
            // 
            this.flpPen.AutoScroll = true;
            this.flpPen.AutoSize = true;
            this.flpPen.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPen.Controls.Add(this.lblPenDadosCompartilhados);
            this.flpPen.Controls.Add(this.flpPenDadosCompartilhados);
            this.flpPen.Controls.Add(this.lblPenMaximizacoes);
            this.flpPen.Controls.Add(this.flpPenMaximizacoes);
            this.flpPen.Controls.Add(this.lblPenSortimentos);
            this.flpPen.Controls.Add(this.flpPenSortimentos);
            this.flpPen.Controls.Add(this.lblPenBinaria);
            this.flpPen.Controls.Add(this.flpPenBinaria);
            this.flpPen.Controls.Add(this.lblPenRegulacao);
            this.flpPen.Controls.Add(this.flpPenRegulacao);
            this.flpPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPen.Location = new System.Drawing.Point(0, 0);
            this.flpPen.Name = "flpPen";
            this.flpPen.Size = new System.Drawing.Size(222, 509);
            this.flpPen.TabIndex = 1;
            // 
            // lblPenDadosCompartilhados
            // 
            this.lblPenDadosCompartilhados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenDadosCompartilhados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenDadosCompartilhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenDadosCompartilhados.ForeColor = System.Drawing.Color.White;
            this.lblPenDadosCompartilhados.Location = new System.Drawing.Point(0, 0);
            this.lblPenDadosCompartilhados.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblPenDadosCompartilhados.Name = "lblPenDadosCompartilhados";
            this.lblPenDadosCompartilhados.Size = new System.Drawing.Size(210, 22);
            this.lblPenDadosCompartilhados.TabIndex = 0;
            this.lblPenDadosCompartilhados.Text = "Dados Compartilhados";
            this.lblPenDadosCompartilhados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenDadosCompartilhados.Click += new System.EventHandler(this.lblPenDadosCompartilhados_Click);
            // 
            // flpPenDadosCompartilhados
            // 
            this.flpPenDadosCompartilhados.AutoSize = true;
            this.flpPenDadosCompartilhados.Controls.Add(this.panel1);
            this.flpPenDadosCompartilhados.Location = new System.Drawing.Point(0, 29);
            this.flpPenDadosCompartilhados.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenDadosCompartilhados.Name = "flpPenDadosCompartilhados";
            this.flpPenDadosCompartilhados.Size = new System.Drawing.Size(212, 35);
            this.flpPenDadosCompartilhados.TabIndex = 25;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPenHorizonte);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel1.Size = new System.Drawing.Size(206, 29);
            this.panel1.TabIndex = 13;
            // 
            // txtPenHorizonte
            // 
            this.txtPenHorizonte.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPenHorizonte.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenHorizonte.Location = new System.Drawing.Point(151, 0);
            this.txtPenHorizonte.Multiline = true;
            this.txtPenHorizonte.Name = "txtPenHorizonte";
            this.txtPenHorizonte.Size = new System.Drawing.Size(45, 29);
            this.txtPenHorizonte.TabIndex = 1;
            this.txtPenHorizonte.Text = "0";
            this.txtPenHorizonte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPenHorizonte.WordWrap = false;
            // 
            // label7
            // 
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(10, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(186, 29);
            this.label7.TabIndex = 0;
            this.label7.Text = "Horizonte";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPenMaximizacoes
            // 
            this.lblPenMaximizacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenMaximizacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenMaximizacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenMaximizacoes.ForeColor = System.Drawing.Color.White;
            this.lblPenMaximizacoes.Location = new System.Drawing.Point(0, 71);
            this.lblPenMaximizacoes.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenMaximizacoes.Name = "lblPenMaximizacoes";
            this.lblPenMaximizacoes.Size = new System.Drawing.Size(209, 22);
            this.lblPenMaximizacoes.TabIndex = 1;
            this.lblPenMaximizacoes.Text = "Maximizações";
            this.lblPenMaximizacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenMaximizacoes.Click += new System.EventHandler(this.lblPenMaximizacoes_Click);
            // 
            // flpPenMaximizacoes
            // 
            this.flpPenMaximizacoes.AutoSize = true;
            this.flpPenMaximizacoes.Controls.Add(this.panel5);
            this.flpPenMaximizacoes.Controls.Add(this.panel6);
            this.flpPenMaximizacoes.Controls.Add(this.sbiPenMax);
            this.flpPenMaximizacoes.Location = new System.Drawing.Point(0, 100);
            this.flpPenMaximizacoes.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenMaximizacoes.Name = "flpPenMaximizacoes";
            this.flpPenMaximizacoes.Size = new System.Drawing.Size(212, 125);
            this.flpPenMaximizacoes.TabIndex = 0;
            this.flpPenMaximizacoes.Visible = false;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPenMaxNumPlanejamento);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(3, 3);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel5.Size = new System.Drawing.Size(206, 29);
            this.panel5.TabIndex = 13;
            // 
            // txtPenMaxNumPlanejamento
            // 
            this.txtPenMaxNumPlanejamento.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPenMaxNumPlanejamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenMaxNumPlanejamento.Location = new System.Drawing.Point(151, 0);
            this.txtPenMaxNumPlanejamento.Multiline = true;
            this.txtPenMaxNumPlanejamento.Name = "txtPenMaxNumPlanejamento";
            this.txtPenMaxNumPlanejamento.Size = new System.Drawing.Size(45, 29);
            this.txtPenMaxNumPlanejamento.TabIndex = 1;
            this.txtPenMaxNumPlanejamento.Text = "0";
            this.txtPenMaxNumPlanejamento.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPenMaxNumPlanejamento.WordWrap = false;
            // 
            // label10
            // 
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(10, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(186, 29);
            this.label10.TabIndex = 0;
            this.label10.Text = "N° de Planejamentos";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(3, 38);
            this.panel6.Name = "panel6";
            this.panel6.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel6.Size = new System.Drawing.Size(206, 48);
            this.panel6.TabIndex = 14;
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.txtPenMaxTitulo);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel11.Location = new System.Drawing.Point(10, 13);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel11.Size = new System.Drawing.Size(186, 35);
            this.panel11.TabIndex = 1;
            // 
            // txtPenMaxTitulo
            // 
            this.txtPenMaxTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPenMaxTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenMaxTitulo.Location = new System.Drawing.Point(0, 5);
            this.txtPenMaxTitulo.Multiline = true;
            this.txtPenMaxTitulo.Name = "txtPenMaxTitulo";
            this.txtPenMaxTitulo.Size = new System.Drawing.Size(186, 30);
            this.txtPenMaxTitulo.TabIndex = 0;
            // 
            // label14
            // 
            this.label14.Dock = System.Windows.Forms.DockStyle.Top;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(10, 0);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(186, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Título";
            // 
            // sbiPenMax
            // 
            this.sbiPenMax.BackColor = System.Drawing.Color.White;
            this.sbiPenMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenMax.FlatAppearance.BorderSize = 0;
            this.sbiPenMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenMax.Location = new System.Drawing.Point(0, 92);
            this.sbiPenMax.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenMax.Name = "sbiPenMax";
            this.sbiPenMax.Size = new System.Drawing.Size(206, 30);
            this.sbiPenMax.TabIndex = 15;
            this.sbiPenMax.TabStop = false;
            this.sbiPenMax.Text = "Simular";
            this.sbiPenMax.UseVisualStyleBackColor = false;
            this.sbiPenMax.Click += new System.EventHandler(this.sbiPenMax_Click);
            // 
            // lblPenSortimentos
            // 
            this.lblPenSortimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenSortimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenSortimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenSortimentos.ForeColor = System.Drawing.Color.White;
            this.lblPenSortimentos.Location = new System.Drawing.Point(0, 232);
            this.lblPenSortimentos.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenSortimentos.Name = "lblPenSortimentos";
            this.lblPenSortimentos.Size = new System.Drawing.Size(209, 22);
            this.lblPenSortimentos.TabIndex = 10;
            this.lblPenSortimentos.Text = "Sortimentos";
            this.lblPenSortimentos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenSortimentos.Click += new System.EventHandler(this.lblPenSortimentos_Click);
            // 
            // flpPenSortimentos
            // 
            this.flpPenSortimentos.AutoSize = true;
            this.flpPenSortimentos.Controls.Add(this.panel12);
            this.flpPenSortimentos.Controls.Add(this.sbiPenSor);
            this.flpPenSortimentos.Location = new System.Drawing.Point(0, 261);
            this.flpPenSortimentos.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenSortimentos.Name = "flpPenSortimentos";
            this.flpPenSortimentos.Size = new System.Drawing.Size(212, 90);
            this.flpPenSortimentos.TabIndex = 26;
            this.flpPenSortimentos.Visible = false;
            // 
            // panel12
            // 
            this.panel12.Controls.Add(this.panel13);
            this.panel12.Controls.Add(this.label16);
            this.panel12.Location = new System.Drawing.Point(3, 3);
            this.panel12.Name = "panel12";
            this.panel12.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel12.Size = new System.Drawing.Size(206, 48);
            this.panel12.TabIndex = 15;
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.txtPenSorTitulo);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel13.Location = new System.Drawing.Point(10, 13);
            this.panel13.Name = "panel13";
            this.panel13.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel13.Size = new System.Drawing.Size(186, 35);
            this.panel13.TabIndex = 1;
            // 
            // txtPenSorTitulo
            // 
            this.txtPenSorTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPenSorTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenSorTitulo.Location = new System.Drawing.Point(0, 5);
            this.txtPenSorTitulo.Multiline = true;
            this.txtPenSorTitulo.Name = "txtPenSorTitulo";
            this.txtPenSorTitulo.Size = new System.Drawing.Size(186, 30);
            this.txtPenSorTitulo.TabIndex = 0;
            // 
            // label16
            // 
            this.label16.Dock = System.Windows.Forms.DockStyle.Top;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(10, 0);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(186, 13);
            this.label16.TabIndex = 0;
            this.label16.Text = "Título";
            // 
            // sbiPenSor
            // 
            this.sbiPenSor.BackColor = System.Drawing.Color.White;
            this.sbiPenSor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenSor.FlatAppearance.BorderSize = 0;
            this.sbiPenSor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenSor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenSor.Location = new System.Drawing.Point(0, 57);
            this.sbiPenSor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenSor.Name = "sbiPenSor";
            this.sbiPenSor.Size = new System.Drawing.Size(206, 30);
            this.sbiPenSor.TabIndex = 16;
            this.sbiPenSor.TabStop = false;
            this.sbiPenSor.Text = "Simular";
            this.sbiPenSor.UseVisualStyleBackColor = false;
            this.sbiPenSor.Click += new System.EventHandler(this.sbiPenSor_Click);
            // 
            // lblPenBinaria
            // 
            this.lblPenBinaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenBinaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenBinaria.ForeColor = System.Drawing.Color.White;
            this.lblPenBinaria.Location = new System.Drawing.Point(0, 358);
            this.lblPenBinaria.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenBinaria.Name = "lblPenBinaria";
            this.lblPenBinaria.Size = new System.Drawing.Size(209, 22);
            this.lblPenBinaria.TabIndex = 17;
            this.lblPenBinaria.Text = "Binária";
            this.lblPenBinaria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenBinaria.Click += new System.EventHandler(this.lblPenBinaria_Click);
            // 
            // flpPenBinaria
            // 
            this.flpPenBinaria.AutoSize = true;
            this.flpPenBinaria.Controls.Add(this.panel14);
            this.flpPenBinaria.Controls.Add(this.sbiPenBin);
            this.flpPenBinaria.Location = new System.Drawing.Point(0, 387);
            this.flpPenBinaria.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenBinaria.Name = "flpPenBinaria";
            this.flpPenBinaria.Size = new System.Drawing.Size(206, 90);
            this.flpPenBinaria.TabIndex = 27;
            this.flpPenBinaria.Visible = false;
            // 
            // panel14
            // 
            this.panel14.Controls.Add(this.panel15);
            this.panel14.Controls.Add(this.label18);
            this.panel14.Location = new System.Drawing.Point(3, 3);
            this.panel14.Name = "panel14";
            this.panel14.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel14.Size = new System.Drawing.Size(196, 48);
            this.panel14.TabIndex = 18;
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.txtPenBinTitulo);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel15.Location = new System.Drawing.Point(10, 13);
            this.panel15.Name = "panel15";
            this.panel15.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel15.Size = new System.Drawing.Size(176, 35);
            this.panel15.TabIndex = 1;
            // 
            // txtPenBinTitulo
            // 
            this.txtPenBinTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPenBinTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenBinTitulo.Location = new System.Drawing.Point(0, 5);
            this.txtPenBinTitulo.Multiline = true;
            this.txtPenBinTitulo.Name = "txtPenBinTitulo";
            this.txtPenBinTitulo.Size = new System.Drawing.Size(176, 30);
            this.txtPenBinTitulo.TabIndex = 0;
            // 
            // label18
            // 
            this.label18.Dock = System.Windows.Forms.DockStyle.Top;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(10, 0);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(176, 13);
            this.label18.TabIndex = 0;
            this.label18.Text = "Título";
            // 
            // sbiPenBin
            // 
            this.sbiPenBin.BackColor = System.Drawing.Color.White;
            this.sbiPenBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenBin.FlatAppearance.BorderSize = 0;
            this.sbiPenBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenBin.Location = new System.Drawing.Point(0, 57);
            this.sbiPenBin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenBin.Name = "sbiPenBin";
            this.sbiPenBin.Size = new System.Drawing.Size(206, 30);
            this.sbiPenBin.TabIndex = 20;
            this.sbiPenBin.TabStop = false;
            this.sbiPenBin.Text = "Simular";
            this.sbiPenBin.UseVisualStyleBackColor = false;
            this.sbiPenBin.Click += new System.EventHandler(this.sbiPenBin_Click);
            // 
            // lblPenRegulacao
            // 
            this.lblPenRegulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenRegulacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenRegulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenRegulacao.ForeColor = System.Drawing.Color.White;
            this.lblPenRegulacao.Location = new System.Drawing.Point(0, 484);
            this.lblPenRegulacao.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenRegulacao.Name = "lblPenRegulacao";
            this.lblPenRegulacao.Size = new System.Drawing.Size(209, 22);
            this.lblPenRegulacao.TabIndex = 20;
            this.lblPenRegulacao.Text = "Regulação";
            this.lblPenRegulacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenRegulacao.Click += new System.EventHandler(this.lblPenRegulacao_Click);
            // 
            // flpPenRegulacao
            // 
            this.flpPenRegulacao.AutoSize = true;
            this.flpPenRegulacao.Controls.Add(this.panel16);
            this.flpPenRegulacao.Controls.Add(this.panel17);
            this.flpPenRegulacao.Controls.Add(this.sbiPenReg);
            this.flpPenRegulacao.Location = new System.Drawing.Point(0, 513);
            this.flpPenRegulacao.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenRegulacao.Name = "flpPenRegulacao";
            this.flpPenRegulacao.Size = new System.Drawing.Size(202, 125);
            this.flpPenRegulacao.TabIndex = 28;
            this.flpPenRegulacao.Visible = false;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtPenRegIdadeRegulacao);
            this.panel16.Controls.Add(this.label20);
            this.panel16.Location = new System.Drawing.Point(3, 3);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel16.Size = new System.Drawing.Size(196, 29);
            this.panel16.TabIndex = 24;
            // 
            // txtPenRegIdadeRegulacao
            // 
            this.txtPenRegIdadeRegulacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPenRegIdadeRegulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenRegIdadeRegulacao.Location = new System.Drawing.Point(141, 0);
            this.txtPenRegIdadeRegulacao.Multiline = true;
            this.txtPenRegIdadeRegulacao.Name = "txtPenRegIdadeRegulacao";
            this.txtPenRegIdadeRegulacao.Size = new System.Drawing.Size(45, 29);
            this.txtPenRegIdadeRegulacao.TabIndex = 1;
            this.txtPenRegIdadeRegulacao.Text = "0";
            this.txtPenRegIdadeRegulacao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPenRegIdadeRegulacao.WordWrap = false;
            // 
            // label20
            // 
            this.label20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(10, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(176, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Idade Regulação";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Controls.Add(this.label21);
            this.panel17.Location = new System.Drawing.Point(3, 38);
            this.panel17.Name = "panel17";
            this.panel17.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel17.Size = new System.Drawing.Size(196, 48);
            this.panel17.TabIndex = 25;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.txtPenRegTitulo);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(10, 13);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel18.Size = new System.Drawing.Size(176, 35);
            this.panel18.TabIndex = 1;
            // 
            // txtPenRegTitulo
            // 
            this.txtPenRegTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPenRegTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenRegTitulo.Location = new System.Drawing.Point(0, 5);
            this.txtPenRegTitulo.Multiline = true;
            this.txtPenRegTitulo.Name = "txtPenRegTitulo";
            this.txtPenRegTitulo.Size = new System.Drawing.Size(176, 30);
            this.txtPenRegTitulo.TabIndex = 0;
            // 
            // label21
            // 
            this.label21.Dock = System.Windows.Forms.DockStyle.Top;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(10, 0);
            this.label21.Margin = new System.Windows.Forms.Padding(0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(176, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Título";
            // 
            // sbiPenReg
            // 
            this.sbiPenReg.BackColor = System.Drawing.Color.White;
            this.sbiPenReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenReg.FlatAppearance.BorderSize = 0;
            this.sbiPenReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenReg.Location = new System.Drawing.Point(0, 92);
            this.sbiPenReg.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenReg.Name = "sbiPenReg";
            this.sbiPenReg.Size = new System.Drawing.Size(196, 30);
            this.sbiPenReg.TabIndex = 26;
            this.sbiPenReg.TabStop = false;
            this.sbiPenReg.Text = "Simular";
            this.sbiPenReg.UseVisualStyleBackColor = false;
            this.sbiPenReg.Click += new System.EventHandler(this.sbiPenReg_Click);
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(4, 22);
            this.tbOther.Name = "tbOther";
            this.tbOther.Padding = new System.Windows.Forms.Padding(3);
            this.tbOther.Size = new System.Drawing.Size(213, 390);
            this.tbOther.TabIndex = 2;
            this.tbOther.Text = "Other";
            this.tbOther.UseVisualStyleBackColor = true;
            // 
            // MainWindown
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 591);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.tabSidebar);
            this.Controls.Add(this.pnlHeader);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainWindown";
            this.Text = "Gerador de Preescrições";
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeaderRight.ResumeLayout(false);
            this.pnlHeaderActionsLeft.ResumeLayout(false);
            this.pnlHeaderActionsLeft.PerformLayout();
            this.pnlHeaderLeft.ResumeLayout(false);
            this.pnlHeaderLeft.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tpPanilha.ResumeLayout(false);
            this.tpPanilha.PerformLayout();
            this.ssMainNomeArquivo.ResumeLayout(false);
            this.ssMainNomeArquivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tpLogo.ResumeLayout(false);
            this.tpLogo.PerformLayout();
            this.tabSidebar.ResumeLayout(false);
            this.tpPreescricoes.ResumeLayout(false);
            this.tpPreescricoes.PerformLayout();
            this.flpPre.ResumeLayout(false);
            this.flpPre.PerformLayout();
            this.flpPreImportarTabelas.ResumeLayout(false);
            this.flpPreDadosPreescricao.ResumeLayout(false);
            this.pnlPreTaxaDesconto.ResumeLayout(false);
            this.pnlPreTaxaDesconto.PerformLayout();
            this.pnlPreTipoDesbaste.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.pnlPreControleDesbaste.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.pnlPreIntervaloSistematico.ResumeLayout(false);
            this.pnlPreIntervaloSistematico.PerformLayout();
            this.flpPreGerarPreescricoes.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            this.tpPenalidades.ResumeLayout(false);
            this.tpPenalidades.PerformLayout();
            this.flpPen.ResumeLayout(false);
            this.flpPen.PerformLayout();
            this.flpPenDadosCompartilhados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.flpPenMaximizacoes.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.flpPenSortimentos.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.flpPenBinaria.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.flpPenRegulacao.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderRight;
        private System.Windows.Forms.FlowLayoutPanel pnlHeaderActionsRight;
        private System.Windows.Forms.FlowLayoutPanel pnlHeaderActionsLeft;
        private System.Windows.Forms.Panel pnlHeaderLeft;
        private System.Windows.Forms.Label lblMiniLogo;
        private Components.NavbarItem nviPreescricoes;
        private Components.NavbarItem navPenalidades;
        private Components.TabControlWithoutHeader tabSidebar;
        private System.Windows.Forms.TabPage tpPreescricoes;
        private System.Windows.Forms.FlowLayoutPanel flpPre;
        private System.Windows.Forms.Label lblPreImportarTabelas;
        private System.Windows.Forms.TabPage tpPenalidades;
        private Components.TabControlWithoutHeader tabMain;
        private System.Windows.Forms.TabPage tpPanilha;
        private System.Windows.Forms.TabPage tpLogo;
        private System.Windows.Forms.Label lblPlanilhaNomeArquivo;
        private System.Windows.Forms.StatusStrip ssMainNomeArquivo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Components.SidebarItem sbiPreDadosInventario;
        private Components.SidebarItem sbiPreCenarios;
        private Components.SidebarItem sbiPrePanilhaCustos;
        private Components.SidebarItem sbiPreCoeficienteMAI;
        private System.Windows.Forms.Label lblPreDadosPreescricao;
        private Components.SidebarItem sbiPrePre;
        private System.Windows.Forms.FlowLayoutPanel flpPen;
        private System.Windows.Forms.Label lblPenDadosCompartilhados;
        private System.Windows.Forms.Label lblPenMaximizacoes;
        private System.Windows.Forms.Label lblPreGerarPreescricoes;
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.TextBox txtPrePreTitulo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label lblPenSortimentos;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txtPenMaxNumPlanejamento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel11;
        private System.Windows.Forms.TextBox txtPenMaxTitulo;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel12;
        private System.Windows.Forms.Panel panel13;
        private System.Windows.Forms.TextBox txtPenSorTitulo;
        private System.Windows.Forms.Label label16;
        private Components.SidebarItem sbiPenSor;
        private System.Windows.Forms.Label lblPenBinaria;
        private System.Windows.Forms.Label lblPenRegulacao;
        private System.Windows.Forms.TabPage tbOther;
        private System.Windows.Forms.FlowLayoutPanel flpPreDadosPreescricao;
        private System.Windows.Forms.Panel pnlPreTaxaDesconto;
        private System.Windows.Forms.TextBox txtPreTaxaDesconto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlPreTipoDesbaste;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbPreTipoDesbaste;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel pnlPreControleDesbaste;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.ComboBox cmbPreControleDesbaste;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.FlowLayoutPanel flpPreImportarTabelas;
        private System.Windows.Forms.FlowLayoutPanel flpPreGerarPreescricoes;
        private System.Windows.Forms.FlowLayoutPanel flpPenDadosCompartilhados;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtPenHorizonte;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.FlowLayoutPanel flpPenMaximizacoes;
        private Components.SidebarItem sbiPenMax;
        private System.Windows.Forms.FlowLayoutPanel flpPenSortimentos;
        private System.Windows.Forms.FlowLayoutPanel flpPenBinaria;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtPenBinTitulo;
        private System.Windows.Forms.Label label18;
        private Components.SidebarItem sbiPenBin;
        private System.Windows.Forms.FlowLayoutPanel flpPenRegulacao;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtPenRegIdadeRegulacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtPenRegTitulo;
        private System.Windows.Forms.Label label21;
        private Components.SidebarItem sbiPenReg;
        private System.Windows.Forms.Label lblMainLogo;
        private System.Windows.Forms.Panel pnlPreIntervaloSistematico;
        private System.Windows.Forms.TextBox txtPreIntervaloSistematico;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.ToolStripStatusLabel slblTpMainEnderecoArquivo;
        private Components.SidebarItem sbiPreSortimentos;
    }
}