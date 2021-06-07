using System.ComponentModel;

namespace Simulador
{
    sealed partial class MainWindown
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
            this.nviPenalidades = new Simulador.Components.NavbarItem();
            this.pnlHeaderLeft = new System.Windows.Forms.Panel();
            this.lblMiniLogo = new System.Windows.Forms.Label();
            this.tipPreescricoes = new System.Windows.Forms.ToolTip(this.components);
            this.btnPlanilhaUpdate = new System.Windows.Forms.Button();
            this.btnPlanilhaOpen = new System.Windows.Forms.Button();
            this.btnOpenPreDadosInventario = new System.Windows.Forms.Button();
            this.btnOpenPreCoeficienteMAI = new System.Windows.Forms.Button();
            this.btnOpenPreSortimentos = new System.Windows.Forms.Button();
            this.btnOpenPrePlanilhaCustos = new System.Windows.Forms.Button();
            this.btnOpenPreCenarios = new System.Windows.Forms.Button();
            this.btnOpenPrePre = new System.Windows.Forms.Button();
            this.btnOpenPenMax = new System.Windows.Forms.Button();
            this.btnOpenPenSor = new System.Windows.Forms.Button();
            this.btnOpenPenBin = new System.Windows.Forms.Button();
            this.btnOpenPenReg = new System.Windows.Forms.Button();
            this.btnOpenPenAdjacencia = new System.Windows.Forms.Button();
            this.btnOpenPenDistancia = new System.Windows.Forms.Button();
            this.btnOpenPreShapeFile = new System.Windows.Forms.Button();
            this.btnOpenPenTabHeu = new System.Windows.Forms.Button();
            this.btnOpenPenSorUni = new System.Windows.Forms.Button();
            this.tipPenalidades = new System.Windows.Forms.ToolTip(this.components);
            this.tabMain = new Simulador.Components.TabControlWithoutHeader();
            this.tpPanilha = new System.Windows.Forms.TabPage();
            this.ssWorkSheets = new System.Windows.Forms.StatusStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ssMainNomeArquivo = new System.Windows.Forms.StatusStrip();
            this.slblTpMainEnderecoArquivo = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlPlanilhaHeader = new System.Windows.Forms.Panel();
            this.pnlPlanilhaHeaderActions = new System.Windows.Forms.Panel();
            this.pnlBtnPlanilhaUpdate = new System.Windows.Forms.Panel();
            this.pnlBtnPlanilhaOpen = new System.Windows.Forms.Panel();
            this.lblPlanilhaNomeArquivo = new System.Windows.Forms.Label();
            this.tpLogo = new System.Windows.Forms.TabPage();
            this.pnlMainInfos = new System.Windows.Forms.Panel();
            this.lblMainInfo = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblMainAcao = new System.Windows.Forms.Label();
            this.lblMainLogo = new System.Windows.Forms.Label();
            this.tpMapa = new System.Windows.Forms.TabPage();
            this.sfMap1 = new EGIS.Controls.SFMap();
            this.tabSidebar = new Simulador.Components.TabControlWithoutHeader();
            this.tpPreescricoes = new System.Windows.Forms.TabPage();
            this.flpPre = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPreImportarTabelas = new System.Windows.Forms.Label();
            this.flpPreImportarTabelas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel19 = new System.Windows.Forms.Panel();
            this.panel20 = new System.Windows.Forms.Panel();
            this.sbiPreDadosInventario = new Simulador.Components.SidebarItem(this.components);
            this.panel21 = new System.Windows.Forms.Panel();
            this.panel22 = new System.Windows.Forms.Panel();
            this.sbiPreCoeficienteMAI = new Simulador.Components.SidebarItem(this.components);
            this.panel23 = new System.Windows.Forms.Panel();
            this.panel24 = new System.Windows.Forms.Panel();
            this.sbiPreSortimentos = new Simulador.Components.SidebarItem(this.components);
            this.panel25 = new System.Windows.Forms.Panel();
            this.panel26 = new System.Windows.Forms.Panel();
            this.sbiPrePlanilhaCustos = new Simulador.Components.SidebarItem(this.components);
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.sbiPrePre = new Simulador.Components.SidebarItem(this.components);
            this.tpPenalidades = new System.Windows.Forms.TabPage();
            this.flpPen = new System.Windows.Forms.FlowLayoutPanel();
            this.lblPenDadosCompartilhados = new System.Windows.Forms.Label();
            this.flpPenDadosCompartilhados = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtPenHorizonte = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtPenMaxNumPlanejamento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.txtPenRegIdadeRegulacao = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblPenMaximizacoes = new System.Windows.Forms.Label();
            this.flpPenMaximizacoes = new System.Windows.Forms.FlowLayoutPanel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.txtPenMaxTitulo = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel29 = new System.Windows.Forms.Panel();
            this.panel30 = new System.Windows.Forms.Panel();
            this.sbiPenMax = new Simulador.Components.SidebarItem(this.components);
            this.lblPenSortimentos = new System.Windows.Forms.Label();
            this.flpPenSortimentos = new System.Windows.Forms.FlowLayoutPanel();
            this.panel12 = new System.Windows.Forms.Panel();
            this.panel13 = new System.Windows.Forms.Panel();
            this.txtPenSorTitulo = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.panel31 = new System.Windows.Forms.Panel();
            this.panel32 = new System.Windows.Forms.Panel();
            this.sbiPenSor = new Simulador.Components.SidebarItem(this.components);
            this.lblPenSortimentosUnificados = new System.Windows.Forms.Label();
            this.flpPenSortimentosUnificados = new System.Windows.Forms.FlowLayoutPanel();
            this.panel42 = new System.Windows.Forms.Panel();
            this.panel43 = new System.Windows.Forms.Panel();
            this.txtPenSorUniTitulo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel44 = new System.Windows.Forms.Panel();
            this.panel45 = new System.Windows.Forms.Panel();
            this.sbiPenSorUni = new Simulador.Components.SidebarItem(this.components);
            this.lblPenBinaria = new System.Windows.Forms.Label();
            this.flpPenBinaria = new System.Windows.Forms.FlowLayoutPanel();
            this.panel14 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.txtPenBinTitulo = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.panel33 = new System.Windows.Forms.Panel();
            this.panel34 = new System.Windows.Forms.Panel();
            this.sbiPenBin = new Simulador.Components.SidebarItem(this.components);
            this.lblPenRegulacao = new System.Windows.Forms.Label();
            this.flpPenRegulacao = new System.Windows.Forms.FlowLayoutPanel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.txtPenRegTitulo = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.panel35 = new System.Windows.Forms.Panel();
            this.panel36 = new System.Windows.Forms.Panel();
            this.sbiPenReg = new Simulador.Components.SidebarItem(this.components);
            this.lblPenImportarTabelas = new System.Windows.Forms.Label();
            this.flpPenImportarTabelas = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel37 = new System.Windows.Forms.Panel();
            this.sbiPenAdjacencia = new Simulador.Components.SidebarItem(this.components);
            this.panel38 = new System.Windows.Forms.Panel();
            this.panel39 = new System.Windows.Forms.Panel();
            this.sbiPenDistancia = new Simulador.Components.SidebarItem(this.components);
            this.lblPenImportarShapeFile = new System.Windows.Forms.Label();
            this.flpPenShapeFile = new System.Windows.Forms.FlowLayoutPanel();
            this.panel40 = new System.Windows.Forms.Panel();
            this.panel41 = new System.Windows.Forms.Panel();
            this.sbiPreShapeFile = new Simulador.Components.SidebarItem(this.components);
            this.lblPenTabelaHeuristica = new System.Windows.Forms.Label();
            this.flpPenTabelaHeuristica = new System.Windows.Forms.FlowLayoutPanel();
            this.panel48 = new System.Windows.Forms.Panel();
            this.panel49 = new System.Windows.Forms.Panel();
            this.sbiPenTabHeu = new Simulador.Components.SidebarItem(this.components);
            this.tbOther = new System.Windows.Forms.TabPage();
            this.pnlHeader.SuspendLayout();
            this.pnlHeaderRight.SuspendLayout();
            this.pnlHeaderActionsLeft.SuspendLayout();
            this.pnlHeaderLeft.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tpPanilha.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.ssMainNomeArquivo.SuspendLayout();
            this.pnlPlanilhaHeader.SuspendLayout();
            this.pnlPlanilhaHeaderActions.SuspendLayout();
            this.pnlBtnPlanilhaUpdate.SuspendLayout();
            this.pnlBtnPlanilhaOpen.SuspendLayout();
            this.tpLogo.SuspendLayout();
            this.pnlMainInfos.SuspendLayout();
            this.tpMapa.SuspendLayout();
            this.tabSidebar.SuspendLayout();
            this.tpPreescricoes.SuspendLayout();
            this.flpPre.SuspendLayout();
            this.flpPreImportarTabelas.SuspendLayout();
            this.panel19.SuspendLayout();
            this.panel20.SuspendLayout();
            this.panel21.SuspendLayout();
            this.panel22.SuspendLayout();
            this.panel23.SuspendLayout();
            this.panel24.SuspendLayout();
            this.panel25.SuspendLayout();
            this.panel26.SuspendLayout();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
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
            this.panel3.SuspendLayout();
            this.panel7.SuspendLayout();
            this.tpPenalidades.SuspendLayout();
            this.flpPen.SuspendLayout();
            this.flpPenDadosCompartilhados.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel16.SuspendLayout();
            this.flpPenMaximizacoes.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel11.SuspendLayout();
            this.panel29.SuspendLayout();
            this.panel30.SuspendLayout();
            this.flpPenSortimentos.SuspendLayout();
            this.panel12.SuspendLayout();
            this.panel13.SuspendLayout();
            this.panel31.SuspendLayout();
            this.panel32.SuspendLayout();
            this.flpPenSortimentosUnificados.SuspendLayout();
            this.panel42.SuspendLayout();
            this.panel43.SuspendLayout();
            this.panel44.SuspendLayout();
            this.panel45.SuspendLayout();
            this.flpPenBinaria.SuspendLayout();
            this.panel14.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel33.SuspendLayout();
            this.panel34.SuspendLayout();
            this.flpPenRegulacao.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel35.SuspendLayout();
            this.panel36.SuspendLayout();
            this.flpPenImportarTabelas.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel37.SuspendLayout();
            this.panel38.SuspendLayout();
            this.panel39.SuspendLayout();
            this.flpPenShapeFile.SuspendLayout();
            this.panel40.SuspendLayout();
            this.panel41.SuspendLayout();
            this.flpPenTabelaHeuristica.SuspendLayout();
            this.panel48.SuspendLayout();
            this.panel49.SuspendLayout();
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
            this.pnlHeaderActionsLeft.Controls.Add(this.nviPenalidades);
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
            // nviPenalidades
            // 
            this.nviPenalidades.Active = false;
            this.nviPenalidades.AutoSize = true;
            this.nviPenalidades.Cursor = System.Windows.Forms.Cursors.Hand;
            this.nviPenalidades.Location = new System.Drawing.Point(116, 6);
            this.nviPenalidades.Name = "nviPenalidades";
            this.nviPenalidades.Size = new System.Drawing.Size(75, 32);
            this.nviPenalidades.TabIndex = 4;
            this.nviPenalidades.TextItem = "Modelos";
            this.nviPenalidades.Click += new System.EventHandler(this.navPenalidades_Click);
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
            this.lblMiniLogo.Size = new System.Drawing.Size(73, 25);
            this.lblMiniLogo.TabIndex = 0;
            this.lblMiniLogo.Text = "GPMF";
            // 
            // btnPlanilhaUpdate
            // 
            this.btnPlanilhaUpdate.BackColor = System.Drawing.Color.White;
            this.btnPlanilhaUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanilhaUpdate.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlanilhaUpdate.Image = global::Simulador.Properties.Resources.update_16x16;
            this.btnPlanilhaUpdate.Location = new System.Drawing.Point(0, 0);
            this.btnPlanilhaUpdate.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlanilhaUpdate.Name = "btnPlanilhaUpdate";
            this.btnPlanilhaUpdate.Size = new System.Drawing.Size(37, 30);
            this.btnPlanilhaUpdate.TabIndex = 9;
            this.tipPreescricoes.SetToolTip(this.btnPlanilhaUpdate, "Recarregar Planilha");
            this.btnPlanilhaUpdate.UseVisualStyleBackColor = false;
            // 
            // btnPlanilhaOpen
            // 
            this.btnPlanilhaOpen.BackColor = System.Drawing.Color.White;
            this.btnPlanilhaOpen.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlanilhaOpen.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlanilhaOpen.Image = global::Simulador.Properties.Resources.open_16x16;
            this.btnPlanilhaOpen.Location = new System.Drawing.Point(0, 0);
            this.btnPlanilhaOpen.Margin = new System.Windows.Forms.Padding(0);
            this.btnPlanilhaOpen.Name = "btnPlanilhaOpen";
            this.btnPlanilhaOpen.Size = new System.Drawing.Size(37, 30);
            this.btnPlanilhaOpen.TabIndex = 8;
            this.tipPreescricoes.SetToolTip(this.btnPlanilhaOpen, "Abrir Planilha no Excel");
            this.btnPlanilhaOpen.UseVisualStyleBackColor = false;
            // 
            // btnOpenPreDadosInventario
            // 
            this.btnOpenPreDadosInventario.BackColor = System.Drawing.Color.White;
            this.btnOpenPreDadosInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPreDadosInventario.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPreDadosInventario.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPreDadosInventario.Image")));
            this.btnOpenPreDadosInventario.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPreDadosInventario.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPreDadosInventario.Name = "btnOpenPreDadosInventario";
            this.btnOpenPreDadosInventario.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPreDadosInventario.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPreDadosInventario, "Abrir Planilha");
            this.btnOpenPreDadosInventario.UseVisualStyleBackColor = false;
            this.btnOpenPreDadosInventario.Visible = false;
            // 
            // btnOpenPreCoeficienteMAI
            // 
            this.btnOpenPreCoeficienteMAI.BackColor = System.Drawing.Color.White;
            this.btnOpenPreCoeficienteMAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPreCoeficienteMAI.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPreCoeficienteMAI.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPreCoeficienteMAI.Image")));
            this.btnOpenPreCoeficienteMAI.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPreCoeficienteMAI.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPreCoeficienteMAI.Name = "btnOpenPreCoeficienteMAI";
            this.btnOpenPreCoeficienteMAI.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPreCoeficienteMAI.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPreCoeficienteMAI, "Abrir Planilha");
            this.btnOpenPreCoeficienteMAI.UseVisualStyleBackColor = false;
            this.btnOpenPreCoeficienteMAI.Visible = false;
            // 
            // btnOpenPreSortimentos
            // 
            this.btnOpenPreSortimentos.BackColor = System.Drawing.Color.White;
            this.btnOpenPreSortimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPreSortimentos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPreSortimentos.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPreSortimentos.Image")));
            this.btnOpenPreSortimentos.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPreSortimentos.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPreSortimentos.Name = "btnOpenPreSortimentos";
            this.btnOpenPreSortimentos.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPreSortimentos.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPreSortimentos, "Abrir Planilha");
            this.btnOpenPreSortimentos.UseVisualStyleBackColor = false;
            this.btnOpenPreSortimentos.Visible = false;
            // 
            // btnOpenPrePlanilhaCustos
            // 
            this.btnOpenPrePlanilhaCustos.BackColor = System.Drawing.Color.White;
            this.btnOpenPrePlanilhaCustos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPrePlanilhaCustos.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPrePlanilhaCustos.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPrePlanilhaCustos.Image")));
            this.btnOpenPrePlanilhaCustos.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPrePlanilhaCustos.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPrePlanilhaCustos.Name = "btnOpenPrePlanilhaCustos";
            this.btnOpenPrePlanilhaCustos.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPrePlanilhaCustos.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPrePlanilhaCustos, "Abrir Planilha");
            this.btnOpenPrePlanilhaCustos.UseVisualStyleBackColor = false;
            this.btnOpenPrePlanilhaCustos.Visible = false;
            // 
            // btnOpenPreCenarios
            // 
            this.btnOpenPreCenarios.BackColor = System.Drawing.Color.White;
            this.btnOpenPreCenarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPreCenarios.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPreCenarios.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPreCenarios.Image")));
            this.btnOpenPreCenarios.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPreCenarios.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPreCenarios.Name = "btnOpenPreCenarios";
            this.btnOpenPreCenarios.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPreCenarios.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPreCenarios, "Abrir Planilha");
            this.btnOpenPreCenarios.UseVisualStyleBackColor = false;
            this.btnOpenPreCenarios.Visible = false;
            // 
            // btnOpenPrePre
            // 
            this.btnOpenPrePre.BackColor = System.Drawing.Color.White;
            this.btnOpenPrePre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPrePre.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPrePre.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPrePre.Image")));
            this.btnOpenPrePre.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPrePre.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPrePre.Name = "btnOpenPrePre";
            this.btnOpenPrePre.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPrePre.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPrePre, "Abrir Planilha");
            this.btnOpenPrePre.UseVisualStyleBackColor = false;
            this.btnOpenPrePre.Visible = false;
            // 
            // btnOpenPenMax
            // 
            this.btnOpenPenMax.BackColor = System.Drawing.Color.White;
            this.btnOpenPenMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenMax.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenMax.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenMax.Image")));
            this.btnOpenPenMax.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPenMax.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenMax.Name = "btnOpenPenMax";
            this.btnOpenPenMax.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenMax.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenMax, "Abrir Pasta");
            this.btnOpenPenMax.UseVisualStyleBackColor = false;
            this.btnOpenPenMax.Visible = false;
            // 
            // btnOpenPenSor
            // 
            this.btnOpenPenSor.BackColor = System.Drawing.Color.White;
            this.btnOpenPenSor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenSor.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenSor.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenSor.Image")));
            this.btnOpenPenSor.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPenSor.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenSor.Name = "btnOpenPenSor";
            this.btnOpenPenSor.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenSor.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenSor, "Abrir Planilha");
            this.btnOpenPenSor.UseVisualStyleBackColor = false;
            this.btnOpenPenSor.Visible = false;
            // 
            // btnOpenPenBin
            // 
            this.btnOpenPenBin.BackColor = System.Drawing.Color.White;
            this.btnOpenPenBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenBin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenBin.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenBin.Image")));
            this.btnOpenPenBin.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPenBin.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenBin.Name = "btnOpenPenBin";
            this.btnOpenPenBin.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenBin.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenBin, "Abrir Planilha");
            this.btnOpenPenBin.UseVisualStyleBackColor = false;
            this.btnOpenPenBin.Visible = false;
            // 
            // btnOpenPenReg
            // 
            this.btnOpenPenReg.BackColor = System.Drawing.Color.White;
            this.btnOpenPenReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenReg.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenReg.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenReg.Image")));
            this.btnOpenPenReg.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPenReg.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenReg.Name = "btnOpenPenReg";
            this.btnOpenPenReg.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenReg.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenReg, "Abrir Planilha");
            this.btnOpenPenReg.UseVisualStyleBackColor = false;
            this.btnOpenPenReg.Visible = false;
            // 
            // btnOpenPenAdjacencia
            // 
            this.btnOpenPenAdjacencia.BackColor = System.Drawing.Color.White;
            this.btnOpenPenAdjacencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenAdjacencia.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenAdjacencia.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenAdjacencia.Image")));
            this.btnOpenPenAdjacencia.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPenAdjacencia.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenAdjacencia.Name = "btnOpenPenAdjacencia";
            this.btnOpenPenAdjacencia.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenAdjacencia.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenAdjacencia, "Abrir Planilha");
            this.tipPenalidades.SetToolTip(this.btnOpenPenAdjacencia, "Abrir Planilha");
            this.btnOpenPenAdjacencia.UseVisualStyleBackColor = false;
            this.btnOpenPenAdjacencia.Visible = false;
            // 
            // btnOpenPenDistancia
            // 
            this.btnOpenPenDistancia.BackColor = System.Drawing.Color.White;
            this.btnOpenPenDistancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenDistancia.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenDistancia.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenDistancia.Image")));
            this.btnOpenPenDistancia.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPenDistancia.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenDistancia.Name = "btnOpenPenDistancia";
            this.btnOpenPenDistancia.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenDistancia.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenDistancia, "Abrir Planilha");
            this.tipPenalidades.SetToolTip(this.btnOpenPenDistancia, "Abrir Planilha");
            this.btnOpenPenDistancia.UseVisualStyleBackColor = false;
            this.btnOpenPenDistancia.Visible = false;
            // 
            // btnOpenPreShapeFile
            // 
            this.btnOpenPreShapeFile.BackColor = System.Drawing.Color.White;
            this.btnOpenPreShapeFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPreShapeFile.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPreShapeFile.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPreShapeFile.Image")));
            this.btnOpenPreShapeFile.Location = new System.Drawing.Point(172, 0);
            this.btnOpenPreShapeFile.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPreShapeFile.Name = "btnOpenPreShapeFile";
            this.btnOpenPreShapeFile.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPreShapeFile.TabIndex = 7;
            this.tipPreescricoes.SetToolTip(this.btnOpenPreShapeFile, "Abrir Planilha");
            this.btnOpenPreShapeFile.UseVisualStyleBackColor = false;
            this.btnOpenPreShapeFile.Visible = false;
            // 
            // btnOpenPenTabHeu
            // 
            this.btnOpenPenTabHeu.BackColor = System.Drawing.Color.White;
            this.btnOpenPenTabHeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenTabHeu.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenTabHeu.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenTabHeu.Image")));
            this.btnOpenPenTabHeu.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPenTabHeu.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenTabHeu.Name = "btnOpenPenTabHeu";
            this.btnOpenPenTabHeu.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenTabHeu.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenTabHeu, "Abrir Planilha");
            this.btnOpenPenTabHeu.UseVisualStyleBackColor = false;
            this.btnOpenPenTabHeu.Visible = false;
            // 
            // btnOpenPenSorUni
            // 
            this.btnOpenPenSorUni.BackColor = System.Drawing.Color.White;
            this.btnOpenPenSorUni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOpenPenSorUni.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnOpenPenSorUni.Image = ((System.Drawing.Image)(resources.GetObject("btnOpenPenSorUni.Image")));
            this.btnOpenPenSorUni.Location = new System.Drawing.Point(175, 0);
            this.btnOpenPenSorUni.Margin = new System.Windows.Forms.Padding(0);
            this.btnOpenPenSorUni.Name = "btnOpenPenSorUni";
            this.btnOpenPenSorUni.Size = new System.Drawing.Size(37, 30);
            this.btnOpenPenSorUni.TabIndex = 6;
            this.tipPreescricoes.SetToolTip(this.btnOpenPenSorUni, "Abrir Planilha");
            this.btnOpenPenSorUni.UseVisualStyleBackColor = false;
            this.btnOpenPenSorUni.Visible = false;
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tpPanilha);
            this.tabMain.Controls.Add(this.tpLogo);
            this.tabMain.Controls.Add(this.tpMapa);
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMain.Location = new System.Drawing.Point(242, 56);
            this.tabMain.Multiline = true;
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(542, 535);
            this.tabMain.TabIndex = 4;
            // 
            // tpPanilha
            // 
            this.tpPanilha.Controls.Add(this.ssWorkSheets);
            this.tpPanilha.Controls.Add(this.dataGridView1);
            this.tpPanilha.Controls.Add(this.ssMainNomeArquivo);
            this.tpPanilha.Controls.Add(this.pnlPlanilhaHeader);
            this.tpPanilha.Location = new System.Drawing.Point(4, 22);
            this.tpPanilha.Name = "tpPanilha";
            this.tpPanilha.Padding = new System.Windows.Forms.Padding(3);
            this.tpPanilha.Size = new System.Drawing.Size(534, 509);
            this.tpPanilha.TabIndex = 0;
            this.tpPanilha.Text = "Panilha";
            this.tpPanilha.UseVisualStyleBackColor = true;
            // 
            // ssWorkSheets
            // 
            this.ssWorkSheets.Location = new System.Drawing.Point(3, 462);
            this.ssWorkSheets.Name = "ssWorkSheets";
            this.ssWorkSheets.Size = new System.Drawing.Size(528, 22);
            this.ssWorkSheets.TabIndex = 5;
            this.ssWorkSheets.Text = "statusStrip1";
            this.ssWorkSheets.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 33);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(528, 451);
            this.dataGridView1.TabIndex = 0;
            // 
            // ssMainNomeArquivo
            // 
            this.ssMainNomeArquivo.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slblTpMainEnderecoArquivo});
            this.ssMainNomeArquivo.Location = new System.Drawing.Point(3, 484);
            this.ssMainNomeArquivo.Name = "ssMainNomeArquivo";
            this.ssMainNomeArquivo.Size = new System.Drawing.Size(528, 22);
            this.ssMainNomeArquivo.TabIndex = 1;
            this.ssMainNomeArquivo.Text = "statusStrip1";
            // 
            // slblTpMainEnderecoArquivo
            // 
            this.slblTpMainEnderecoArquivo.ActiveLinkColor = System.Drawing.Color.Red;
            this.slblTpMainEnderecoArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.slblTpMainEnderecoArquivo.Name = "slblTpMainEnderecoArquivo";
            this.slblTpMainEnderecoArquivo.Size = new System.Drawing.Size(55, 17);
            this.slblTpMainEnderecoArquivo.Text = "Arquivo: ";
            // 
            // pnlPlanilhaHeader
            // 
            this.pnlPlanilhaHeader.Controls.Add(this.pnlPlanilhaHeaderActions);
            this.pnlPlanilhaHeader.Controls.Add(this.lblPlanilhaNomeArquivo);
            this.pnlPlanilhaHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlPlanilhaHeader.Location = new System.Drawing.Point(3, 3);
            this.pnlPlanilhaHeader.Name = "pnlPlanilhaHeader";
            this.pnlPlanilhaHeader.Size = new System.Drawing.Size(528, 30);
            this.pnlPlanilhaHeader.TabIndex = 4;
            // 
            // pnlPlanilhaHeaderActions
            // 
            this.pnlPlanilhaHeaderActions.Controls.Add(this.pnlBtnPlanilhaUpdate);
            this.pnlPlanilhaHeaderActions.Controls.Add(this.pnlBtnPlanilhaOpen);
            this.pnlPlanilhaHeaderActions.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlPlanilhaHeaderActions.Location = new System.Drawing.Point(452, 0);
            this.pnlPlanilhaHeaderActions.Name = "pnlPlanilhaHeaderActions";
            this.pnlPlanilhaHeaderActions.Size = new System.Drawing.Size(76, 30);
            this.pnlPlanilhaHeaderActions.TabIndex = 3;
            // 
            // pnlBtnPlanilhaUpdate
            // 
            this.pnlBtnPlanilhaUpdate.Controls.Add(this.btnPlanilhaUpdate);
            this.pnlBtnPlanilhaUpdate.Location = new System.Drawing.Point(0, 0);
            this.pnlBtnPlanilhaUpdate.Name = "pnlBtnPlanilhaUpdate";
            this.pnlBtnPlanilhaUpdate.Size = new System.Drawing.Size(37, 30);
            this.pnlBtnPlanilhaUpdate.TabIndex = 10;
            // 
            // pnlBtnPlanilhaOpen
            // 
            this.pnlBtnPlanilhaOpen.Controls.Add(this.btnPlanilhaOpen);
            this.pnlBtnPlanilhaOpen.Location = new System.Drawing.Point(39, 0);
            this.pnlBtnPlanilhaOpen.Name = "pnlBtnPlanilhaOpen";
            this.pnlBtnPlanilhaOpen.Size = new System.Drawing.Size(37, 30);
            this.pnlBtnPlanilhaOpen.TabIndex = 11;
            // 
            // lblPlanilhaNomeArquivo
            // 
            this.lblPlanilhaNomeArquivo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblPlanilhaNomeArquivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlanilhaNomeArquivo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPlanilhaNomeArquivo.Location = new System.Drawing.Point(0, 0);
            this.lblPlanilhaNomeArquivo.Name = "lblPlanilhaNomeArquivo";
            this.lblPlanilhaNomeArquivo.Size = new System.Drawing.Size(528, 30);
            this.lblPlanilhaNomeArquivo.TabIndex = 2;
            this.lblPlanilhaNomeArquivo.Text = "Nome do arquivo carregado";
            this.lblPlanilhaNomeArquivo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tpLogo
            // 
            this.tpLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tpLogo.Controls.Add(this.pnlMainInfos);
            this.tpLogo.Controls.Add(this.lblMainLogo);
            this.tpLogo.Location = new System.Drawing.Point(4, 22);
            this.tpLogo.Name = "tpLogo";
            this.tpLogo.Padding = new System.Windows.Forms.Padding(3);
            this.tpLogo.Size = new System.Drawing.Size(534, 509);
            this.tpLogo.TabIndex = 1;
            this.tpLogo.Text = "Logo";
            // 
            // pnlMainInfos
            // 
            this.pnlMainInfos.Controls.Add(this.lblMainInfo);
            this.pnlMainInfos.Controls.Add(this.progressBar1);
            this.pnlMainInfos.Controls.Add(this.lblMainAcao);
            this.pnlMainInfos.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainInfos.Location = new System.Drawing.Point(3, 3);
            this.pnlMainInfos.Name = "pnlMainInfos";
            this.pnlMainInfos.Size = new System.Drawing.Size(528, 123);
            this.pnlMainInfos.TabIndex = 3;
            this.pnlMainInfos.Visible = false;
            // 
            // lblMainInfo
            // 
            this.lblMainInfo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblMainInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.lblMainInfo.ForeColor = System.Drawing.Color.White;
            this.lblMainInfo.Location = new System.Drawing.Point(0, 33);
            this.lblMainInfo.Name = "lblMainInfo";
            this.lblMainInfo.Size = new System.Drawing.Size(528, 67);
            this.lblMainInfo.TabIndex = 3;
            this.lblMainInfo.Text = "Gerando Preescrições";
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 100);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(528, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.progressBar1.TabIndex = 2;
            // 
            // lblMainAcao
            // 
            this.lblMainAcao.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMainAcao.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.lblMainAcao.ForeColor = System.Drawing.Color.White;
            this.lblMainAcao.Location = new System.Drawing.Point(0, 0);
            this.lblMainAcao.Name = "lblMainAcao";
            this.lblMainAcao.Size = new System.Drawing.Size(528, 33);
            this.lblMainAcao.TabIndex = 1;
            this.lblMainAcao.Text = "Gerando Preescrições";
            this.lblMainAcao.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.lblMainLogo.Text = "GPMF";
            // 
            // tpMapa
            // 
            this.tpMapa.Controls.Add(this.sfMap1);
            this.tpMapa.Location = new System.Drawing.Point(4, 22);
            this.tpMapa.Name = "tpMapa";
            this.tpMapa.Padding = new System.Windows.Forms.Padding(3);
            this.tpMapa.Size = new System.Drawing.Size(534, 509);
            this.tpMapa.TabIndex = 2;
            this.tpMapa.Text = "Mapa";
            this.tpMapa.UseVisualStyleBackColor = true;
            // 
            // sfMap1
            // 
            this.sfMap1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sfMap1.CentrePoint2D = ((EGIS.ShapeFileLib.PointD)(resources.GetObject("sfMap1.CentrePoint2D")));
            this.sfMap1.Cursor = System.Windows.Forms.Cursors.Default;
            this.sfMap1.DefaultMapCursor = System.Windows.Forms.Cursors.Default;
            this.sfMap1.DefaultSelectionCursor = System.Windows.Forms.Cursors.Hand;
            this.sfMap1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sfMap1.Enabled = false;
            this.sfMap1.Location = new System.Drawing.Point(3, 3);
            this.sfMap1.MapBackColor = System.Drawing.SystemColors.Control;
            this.sfMap1.Name = "sfMap1";
            this.sfMap1.PanSelectMode = EGIS.Controls.PanSelectMode.Pan;
            this.sfMap1.RenderQuality = EGIS.ShapeFileLib.RenderQuality.Auto;
            this.sfMap1.Size = new System.Drawing.Size(528, 503);
            this.sfMap1.TabIndex = 0;
            this.sfMap1.UseMemoryStreams = false;
            this.sfMap1.UseMercatorProjection = false;
            this.sfMap1.ZoomLevel = 1.0022172949002217D;
            this.sfMap1.ZoomToSelectedExtentWhenCtrlKeydown = false;
            this.sfMap1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.sfMap1_MouseClick_1);
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
            this.tabSidebar.Size = new System.Drawing.Size(242, 535);
            this.tabSidebar.TabIndex = 3;
            // 
            // tpPreescricoes
            // 
            this.tpPreescricoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tpPreescricoes.Controls.Add(this.flpPre);
            this.tpPreescricoes.Location = new System.Drawing.Point(4, 22);
            this.tpPreescricoes.Margin = new System.Windows.Forms.Padding(0);
            this.tpPreescricoes.Name = "tpPreescricoes";
            this.tpPreescricoes.Size = new System.Drawing.Size(234, 509);
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
            this.flpPre.Size = new System.Drawing.Size(234, 509);
            this.flpPre.TabIndex = 0;
            // 
            // lblPreImportarTabelas
            // 
            this.lblPreImportarTabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPreImportarTabelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreImportarTabelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreImportarTabelas.ForeColor = System.Drawing.Color.White;
            this.lblPreImportarTabelas.Image = global::Simulador.Properties.Resources.arrow_up_16x16;
            this.lblPreImportarTabelas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPreImportarTabelas.Location = new System.Drawing.Point(0, 0);
            this.lblPreImportarTabelas.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblPreImportarTabelas.Name = "lblPreImportarTabelas";
            this.lblPreImportarTabelas.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPreImportarTabelas.Size = new System.Drawing.Size(213, 22);
            this.lblPreImportarTabelas.TabIndex = 0;
            this.lblPreImportarTabelas.Text = "Importar Tabelas";
            this.lblPreImportarTabelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreImportarTabelas.Click += new System.EventHandler(this.lblPreImportarTabelas_Click);
            // 
            // flpPreImportarTabelas
            // 
            this.flpPreImportarTabelas.AutoSize = true;
            this.flpPreImportarTabelas.Controls.Add(this.panel19);
            this.flpPreImportarTabelas.Controls.Add(this.panel21);
            this.flpPreImportarTabelas.Controls.Add(this.panel23);
            this.flpPreImportarTabelas.Controls.Add(this.panel25);
            this.flpPreImportarTabelas.Controls.Add(this.panel27);
            this.flpPreImportarTabelas.Location = new System.Drawing.Point(0, 29);
            this.flpPreImportarTabelas.Margin = new System.Windows.Forms.Padding(0);
            this.flpPreImportarTabelas.Name = "flpPreImportarTabelas";
            this.flpPreImportarTabelas.Size = new System.Drawing.Size(209, 150);
            this.flpPreImportarTabelas.TabIndex = 15;
            // 
            // panel19
            // 
            this.panel19.Controls.Add(this.panel20);
            this.panel19.Controls.Add(this.btnOpenPreDadosInventario);
            this.panel19.Location = new System.Drawing.Point(0, 0);
            this.panel19.Margin = new System.Windows.Forms.Padding(0);
            this.panel19.Name = "panel19";
            this.panel19.Size = new System.Drawing.Size(209, 30);
            this.panel19.TabIndex = 6;
            // 
            // panel20
            // 
            this.panel20.Controls.Add(this.sbiPreDadosInventario);
            this.panel20.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel20.Location = new System.Drawing.Point(0, 0);
            this.panel20.Name = "panel20";
            this.panel20.Size = new System.Drawing.Size(172, 30);
            this.panel20.TabIndex = 0;
            // 
            // sbiPreDadosInventario
            // 
            this.sbiPreDadosInventario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreDadosInventario.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbiPreDadosInventario.FlatAppearance.BorderSize = 0;
            this.sbiPreDadosInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreDadosInventario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreDadosInventario.ForeColor = System.Drawing.Color.White;
            this.sbiPreDadosInventario.Location = new System.Drawing.Point(0, 0);
            this.sbiPreDadosInventario.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreDadosInventario.Name = "sbiPreDadosInventario";
            this.sbiPreDadosInventario.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreDadosInventario.Size = new System.Drawing.Size(172, 30);
            this.sbiPreDadosInventario.TabIndex = 2;
            this.sbiPreDadosInventario.TabStop = false;
            this.sbiPreDadosInventario.Text = "Dados de Inventário";
            this.sbiPreDadosInventario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreDadosInventario.UseVisualStyleBackColor = true;
            // 
            // panel21
            // 
            this.panel21.Controls.Add(this.panel22);
            this.panel21.Controls.Add(this.btnOpenPreCoeficienteMAI);
            this.panel21.Location = new System.Drawing.Point(0, 30);
            this.panel21.Margin = new System.Windows.Forms.Padding(0);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(209, 30);
            this.panel21.TabIndex = 7;
            // 
            // panel22
            // 
            this.panel22.Controls.Add(this.sbiPreCoeficienteMAI);
            this.panel22.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel22.Location = new System.Drawing.Point(0, 0);
            this.panel22.Name = "panel22";
            this.panel22.Size = new System.Drawing.Size(172, 30);
            this.panel22.TabIndex = 0;
            // 
            // sbiPreCoeficienteMAI
            // 
            this.sbiPreCoeficienteMAI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreCoeficienteMAI.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPreCoeficienteMAI.FlatAppearance.BorderSize = 0;
            this.sbiPreCoeficienteMAI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreCoeficienteMAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreCoeficienteMAI.ForeColor = System.Drawing.Color.White;
            this.sbiPreCoeficienteMAI.Location = new System.Drawing.Point(0, 0);
            this.sbiPreCoeficienteMAI.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreCoeficienteMAI.Name = "sbiPreCoeficienteMAI";
            this.sbiPreCoeficienteMAI.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreCoeficienteMAI.Size = new System.Drawing.Size(172, 30);
            this.sbiPreCoeficienteMAI.TabIndex = 5;
            this.sbiPreCoeficienteMAI.TabStop = false;
            this.sbiPreCoeficienteMAI.Text = "Coeficientes - MAI";
            this.sbiPreCoeficienteMAI.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreCoeficienteMAI.UseVisualStyleBackColor = true;
            // 
            // panel23
            // 
            this.panel23.Controls.Add(this.panel24);
            this.panel23.Controls.Add(this.btnOpenPreSortimentos);
            this.panel23.Location = new System.Drawing.Point(0, 60);
            this.panel23.Margin = new System.Windows.Forms.Padding(0);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(209, 30);
            this.panel23.TabIndex = 8;
            // 
            // panel24
            // 
            this.panel24.Controls.Add(this.sbiPreSortimentos);
            this.panel24.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel24.Location = new System.Drawing.Point(0, 0);
            this.panel24.Name = "panel24";
            this.panel24.Size = new System.Drawing.Size(172, 30);
            this.panel24.TabIndex = 0;
            // 
            // sbiPreSortimentos
            // 
            this.sbiPreSortimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreSortimentos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPreSortimentos.FlatAppearance.BorderSize = 0;
            this.sbiPreSortimentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreSortimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreSortimentos.ForeColor = System.Drawing.Color.White;
            this.sbiPreSortimentos.Location = new System.Drawing.Point(0, 0);
            this.sbiPreSortimentos.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreSortimentos.Name = "sbiPreSortimentos";
            this.sbiPreSortimentos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreSortimentos.Size = new System.Drawing.Size(172, 30);
            this.sbiPreSortimentos.TabIndex = 6;
            this.sbiPreSortimentos.TabStop = false;
            this.sbiPreSortimentos.Text = "Sortimentos";
            this.sbiPreSortimentos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreSortimentos.UseVisualStyleBackColor = true;
            // 
            // panel25
            // 
            this.panel25.Controls.Add(this.panel26);
            this.panel25.Controls.Add(this.btnOpenPrePlanilhaCustos);
            this.panel25.Location = new System.Drawing.Point(0, 90);
            this.panel25.Margin = new System.Windows.Forms.Padding(0);
            this.panel25.Name = "panel25";
            this.panel25.Size = new System.Drawing.Size(209, 30);
            this.panel25.TabIndex = 9;
            // 
            // panel26
            // 
            this.panel26.Controls.Add(this.sbiPrePlanilhaCustos);
            this.panel26.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel26.Location = new System.Drawing.Point(0, 0);
            this.panel26.Name = "panel26";
            this.panel26.Size = new System.Drawing.Size(172, 30);
            this.panel26.TabIndex = 0;
            // 
            // sbiPrePlanilhaCustos
            // 
            this.sbiPrePlanilhaCustos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPrePlanilhaCustos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPrePlanilhaCustos.FlatAppearance.BorderSize = 0;
            this.sbiPrePlanilhaCustos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPrePlanilhaCustos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPrePlanilhaCustos.ForeColor = System.Drawing.Color.White;
            this.sbiPrePlanilhaCustos.Location = new System.Drawing.Point(0, 0);
            this.sbiPrePlanilhaCustos.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPrePlanilhaCustos.Name = "sbiPrePlanilhaCustos";
            this.sbiPrePlanilhaCustos.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPrePlanilhaCustos.Size = new System.Drawing.Size(172, 30);
            this.sbiPrePlanilhaCustos.TabIndex = 4;
            this.sbiPrePlanilhaCustos.TabStop = false;
            this.sbiPrePlanilhaCustos.Text = "Planilhas de Custos";
            this.sbiPrePlanilhaCustos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPrePlanilhaCustos.UseVisualStyleBackColor = true;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Controls.Add(this.btnOpenPreCenarios);
            this.panel27.Location = new System.Drawing.Point(0, 120);
            this.panel27.Margin = new System.Windows.Forms.Padding(0);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(209, 30);
            this.panel27.TabIndex = 10;
            // 
            // panel28
            // 
            this.panel28.Controls.Add(this.sbiPreCenarios);
            this.panel28.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel28.Location = new System.Drawing.Point(0, 0);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(172, 30);
            this.panel28.TabIndex = 0;
            // 
            // sbiPreCenarios
            // 
            this.sbiPreCenarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreCenarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPreCenarios.FlatAppearance.BorderSize = 0;
            this.sbiPreCenarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreCenarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreCenarios.ForeColor = System.Drawing.Color.White;
            this.sbiPreCenarios.Location = new System.Drawing.Point(0, 0);
            this.sbiPreCenarios.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreCenarios.Name = "sbiPreCenarios";
            this.sbiPreCenarios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreCenarios.Size = new System.Drawing.Size(172, 30);
            this.sbiPreCenarios.TabIndex = 3;
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
            this.lblPreDadosPreescricao.Image = global::Simulador.Properties.Resources.arrow_up_16x16;
            this.lblPreDadosPreescricao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPreDadosPreescricao.Location = new System.Drawing.Point(0, 186);
            this.lblPreDadosPreescricao.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPreDadosPreescricao.Name = "lblPreDadosPreescricao";
            this.lblPreDadosPreescricao.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
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
            this.label23.Text = "Linhas";
            this.label23.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPreGerarPreescricoes
            // 
            this.lblPreGerarPreescricoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPreGerarPreescricoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPreGerarPreescricoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPreGerarPreescricoes.ForeColor = System.Drawing.Color.White;
            this.lblPreGerarPreescricoes.Image = global::Simulador.Properties.Resources.arrow_up_16x16;
            this.lblPreGerarPreescricoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPreGerarPreescricoes.Location = new System.Drawing.Point(0, 402);
            this.lblPreGerarPreescricoes.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPreGerarPreescricoes.Name = "lblPreGerarPreescricoes";
            this.lblPreGerarPreescricoes.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPreGerarPreescricoes.Size = new System.Drawing.Size(213, 22);
            this.lblPreGerarPreescricoes.TabIndex = 10;
            this.lblPreGerarPreescricoes.Text = "Simulação";
            this.lblPreGerarPreescricoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPreGerarPreescricoes.Click += new System.EventHandler(this.lblPreGerarPreescricoes_Click);
            // 
            // flpPreGerarPreescricoes
            // 
            this.flpPreGerarPreescricoes.AutoSize = true;
            this.flpPreGerarPreescricoes.Controls.Add(this.panel9);
            this.flpPreGerarPreescricoes.Controls.Add(this.panel3);
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
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.btnOpenPrePre);
            this.panel3.Location = new System.Drawing.Point(0, 54);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 30);
            this.panel3.TabIndex = 13;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.sbiPrePre);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel7.Location = new System.Drawing.Point(0, 0);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(175, 30);
            this.panel7.TabIndex = 7;
            // 
            // sbiPrePre
            // 
            this.sbiPrePre.BackColor = System.Drawing.Color.White;
            this.sbiPrePre.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPrePre.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPrePre.FlatAppearance.BorderSize = 0;
            this.sbiPrePre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPrePre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPrePre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPrePre.Location = new System.Drawing.Point(0, 0);
            this.sbiPrePre.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPrePre.Name = "sbiPrePre";
            this.sbiPrePre.Size = new System.Drawing.Size(175, 30);
            this.sbiPrePre.TabIndex = 5;
            this.sbiPrePre.TabStop = false;
            this.sbiPrePre.Text = "Simular";
            this.sbiPrePre.UseVisualStyleBackColor = false;
            // 
            // tpPenalidades
            // 
            this.tpPenalidades.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(115)))), ((int)(((byte)(70)))));
            this.tpPenalidades.Controls.Add(this.flpPen);
            this.tpPenalidades.Location = new System.Drawing.Point(4, 22);
            this.tpPenalidades.Margin = new System.Windows.Forms.Padding(0);
            this.tpPenalidades.Name = "tpPenalidades";
            this.tpPenalidades.Size = new System.Drawing.Size(234, 509);
            this.tpPenalidades.TabIndex = 1;
            this.tpPenalidades.Text = "Penalidades";
            // 
            // flpPen
            // 
            this.flpPen.AutoScroll = true;
            this.flpPen.Controls.Add(this.lblPenDadosCompartilhados);
            this.flpPen.Controls.Add(this.flpPenDadosCompartilhados);
            this.flpPen.Controls.Add(this.lblPenMaximizacoes);
            this.flpPen.Controls.Add(this.flpPenMaximizacoes);
            this.flpPen.Controls.Add(this.lblPenSortimentos);
            this.flpPen.Controls.Add(this.flpPenSortimentos);
            this.flpPen.Controls.Add(this.lblPenSortimentosUnificados);
            this.flpPen.Controls.Add(this.flpPenSortimentosUnificados);
            this.flpPen.Controls.Add(this.lblPenBinaria);
            this.flpPen.Controls.Add(this.flpPenBinaria);
            this.flpPen.Controls.Add(this.lblPenRegulacao);
            this.flpPen.Controls.Add(this.flpPenRegulacao);
            this.flpPen.Controls.Add(this.lblPenImportarTabelas);
            this.flpPen.Controls.Add(this.flpPenImportarTabelas);
            this.flpPen.Controls.Add(this.lblPenImportarShapeFile);
            this.flpPen.Controls.Add(this.flpPenShapeFile);
            this.flpPen.Controls.Add(this.lblPenTabelaHeuristica);
            this.flpPen.Controls.Add(this.flpPenTabelaHeuristica);
            this.flpPen.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flpPen.Location = new System.Drawing.Point(0, 0);
            this.flpPen.Name = "flpPen";
            this.flpPen.Size = new System.Drawing.Size(234, 509);
            this.flpPen.TabIndex = 1;
            // 
            // lblPenDadosCompartilhados
            // 
            this.lblPenDadosCompartilhados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenDadosCompartilhados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenDadosCompartilhados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenDadosCompartilhados.ForeColor = System.Drawing.Color.White;
            this.lblPenDadosCompartilhados.Image = global::Simulador.Properties.Resources.arrow_up_16x16;
            this.lblPenDadosCompartilhados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenDadosCompartilhados.Location = new System.Drawing.Point(0, 0);
            this.lblPenDadosCompartilhados.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblPenDadosCompartilhados.Name = "lblPenDadosCompartilhados";
            this.lblPenDadosCompartilhados.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenDadosCompartilhados.Size = new System.Drawing.Size(210, 22);
            this.lblPenDadosCompartilhados.TabIndex = 0;
            this.lblPenDadosCompartilhados.Text = "Dados Compartilhados";
            this.lblPenDadosCompartilhados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenDadosCompartilhados.Click += new System.EventHandler(this.lblPenDadosCompartilhados_Click);
            // 
            // flpPenDadosCompartilhados
            // 
            this.flpPenDadosCompartilhados.AutoSize = true;
            this.flpPenDadosCompartilhados.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flpPenDadosCompartilhados.Controls.Add(this.panel1);
            this.flpPenDadosCompartilhados.Controls.Add(this.panel5);
            this.flpPenDadosCompartilhados.Controls.Add(this.panel16);
            this.flpPenDadosCompartilhados.Location = new System.Drawing.Point(0, 29);
            this.flpPenDadosCompartilhados.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenDadosCompartilhados.Name = "flpPenDadosCompartilhados";
            this.flpPenDadosCompartilhados.Size = new System.Drawing.Size(213, 105);
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
            this.label7.Text = "Horizonte planejamento";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.txtPenMaxNumPlanejamento);
            this.panel5.Controls.Add(this.label10);
            this.panel5.Location = new System.Drawing.Point(3, 38);
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
            this.label10.Text = " N° Preescrições";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.txtPenRegIdadeRegulacao);
            this.panel16.Controls.Add(this.label20);
            this.panel16.Location = new System.Drawing.Point(3, 73);
            this.panel16.Name = "panel16";
            this.panel16.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel16.Size = new System.Drawing.Size(207, 29);
            this.panel16.TabIndex = 25;
            // 
            // txtPenRegIdadeRegulacao
            // 
            this.txtPenRegIdadeRegulacao.Dock = System.Windows.Forms.DockStyle.Right;
            this.txtPenRegIdadeRegulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenRegIdadeRegulacao.Location = new System.Drawing.Point(152, 0);
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
            this.label20.Size = new System.Drawing.Size(187, 29);
            this.label20.TabIndex = 0;
            this.label20.Text = "Idade Regulação";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPenMaximizacoes
            // 
            this.lblPenMaximizacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenMaximizacoes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenMaximizacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenMaximizacoes.ForeColor = System.Drawing.Color.White;
            this.lblPenMaximizacoes.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenMaximizacoes.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenMaximizacoes.Location = new System.Drawing.Point(0, 141);
            this.lblPenMaximizacoes.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenMaximizacoes.Name = "lblPenMaximizacoes";
            this.lblPenMaximizacoes.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenMaximizacoes.Size = new System.Drawing.Size(209, 22);
            this.lblPenMaximizacoes.TabIndex = 1;
            this.lblPenMaximizacoes.Text = "Função objetivo";
            this.lblPenMaximizacoes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenMaximizacoes.Click += new System.EventHandler(this.lblPenMaximizacoes_Click);
            // 
            // flpPenMaximizacoes
            // 
            this.flpPenMaximizacoes.AutoSize = true;
            this.flpPenMaximizacoes.Controls.Add(this.panel6);
            this.flpPenMaximizacoes.Controls.Add(this.panel29);
            this.flpPenMaximizacoes.Location = new System.Drawing.Point(0, 170);
            this.flpPenMaximizacoes.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenMaximizacoes.Name = "flpPenMaximizacoes";
            this.flpPenMaximizacoes.Size = new System.Drawing.Size(212, 84);
            this.flpPenMaximizacoes.TabIndex = 0;
            this.flpPenMaximizacoes.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.panel11);
            this.panel6.Controls.Add(this.label14);
            this.panel6.Location = new System.Drawing.Point(3, 3);
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
            // panel29
            // 
            this.panel29.Controls.Add(this.panel30);
            this.panel29.Controls.Add(this.btnOpenPenMax);
            this.panel29.Location = new System.Drawing.Point(0, 54);
            this.panel29.Margin = new System.Windows.Forms.Padding(0);
            this.panel29.Name = "panel29";
            this.panel29.Size = new System.Drawing.Size(212, 30);
            this.panel29.TabIndex = 16;
            // 
            // panel30
            // 
            this.panel30.Controls.Add(this.sbiPenMax);
            this.panel30.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel30.Location = new System.Drawing.Point(0, 0);
            this.panel30.Name = "panel30";
            this.panel30.Size = new System.Drawing.Size(175, 30);
            this.panel30.TabIndex = 7;
            // 
            // sbiPenMax
            // 
            this.sbiPenMax.BackColor = System.Drawing.Color.White;
            this.sbiPenMax.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenMax.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenMax.FlatAppearance.BorderSize = 0;
            this.sbiPenMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenMax.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenMax.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenMax.Location = new System.Drawing.Point(0, 0);
            this.sbiPenMax.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenMax.Name = "sbiPenMax";
            this.sbiPenMax.Size = new System.Drawing.Size(175, 30);
            this.sbiPenMax.TabIndex = 16;
            this.sbiPenMax.TabStop = false;
            this.sbiPenMax.Text = "Simular";
            this.sbiPenMax.UseVisualStyleBackColor = false;
            // 
            // lblPenSortimentos
            // 
            this.lblPenSortimentos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenSortimentos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenSortimentos.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenSortimentos.ForeColor = System.Drawing.Color.White;
            this.lblPenSortimentos.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenSortimentos.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenSortimentos.Location = new System.Drawing.Point(0, 261);
            this.lblPenSortimentos.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenSortimentos.Name = "lblPenSortimentos";
            this.lblPenSortimentos.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
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
            this.flpPenSortimentos.Controls.Add(this.panel31);
            this.flpPenSortimentos.Location = new System.Drawing.Point(0, 290);
            this.flpPenSortimentos.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenSortimentos.Name = "flpPenSortimentos";
            this.flpPenSortimentos.Size = new System.Drawing.Size(212, 84);
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
            // panel31
            // 
            this.panel31.Controls.Add(this.panel32);
            this.panel31.Controls.Add(this.btnOpenPenSor);
            this.panel31.Location = new System.Drawing.Point(0, 54);
            this.panel31.Margin = new System.Windows.Forms.Padding(0);
            this.panel31.Name = "panel31";
            this.panel31.Size = new System.Drawing.Size(212, 30);
            this.panel31.TabIndex = 17;
            // 
            // panel32
            // 
            this.panel32.Controls.Add(this.sbiPenSor);
            this.panel32.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel32.Location = new System.Drawing.Point(0, 0);
            this.panel32.Name = "panel32";
            this.panel32.Size = new System.Drawing.Size(175, 30);
            this.panel32.TabIndex = 7;
            // 
            // sbiPenSor
            // 
            this.sbiPenSor.BackColor = System.Drawing.Color.White;
            this.sbiPenSor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenSor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenSor.FlatAppearance.BorderSize = 0;
            this.sbiPenSor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenSor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenSor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenSor.Location = new System.Drawing.Point(0, 0);
            this.sbiPenSor.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenSor.Name = "sbiPenSor";
            this.sbiPenSor.Size = new System.Drawing.Size(175, 30);
            this.sbiPenSor.TabIndex = 17;
            this.sbiPenSor.TabStop = false;
            this.sbiPenSor.Text = "Simular";
            this.sbiPenSor.UseVisualStyleBackColor = false;
            // 
            // lblPenSortimentosUnificados
            // 
            this.lblPenSortimentosUnificados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenSortimentosUnificados.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenSortimentosUnificados.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenSortimentosUnificados.ForeColor = System.Drawing.Color.White;
            this.lblPenSortimentosUnificados.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenSortimentosUnificados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenSortimentosUnificados.Location = new System.Drawing.Point(0, 381);
            this.lblPenSortimentosUnificados.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenSortimentosUnificados.Name = "lblPenSortimentosUnificados";
            this.lblPenSortimentosUnificados.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenSortimentosUnificados.Size = new System.Drawing.Size(209, 22);
            this.lblPenSortimentosUnificados.TabIndex = 37;
            this.lblPenSortimentosUnificados.Text = "Sortimentos Unificados";
            this.lblPenSortimentosUnificados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenSortimentosUnificados.Click += new System.EventHandler(this.lblPenSortimentosUnificados_Click);
            // 
            // flpPenSortimentosUnificados
            // 
            this.flpPenSortimentosUnificados.AutoSize = true;
            this.flpPenSortimentosUnificados.Controls.Add(this.panel42);
            this.flpPenSortimentosUnificados.Controls.Add(this.panel44);
            this.flpPenSortimentosUnificados.Location = new System.Drawing.Point(0, 410);
            this.flpPenSortimentosUnificados.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenSortimentosUnificados.Name = "flpPenSortimentosUnificados";
            this.flpPenSortimentosUnificados.Size = new System.Drawing.Size(212, 84);
            this.flpPenSortimentosUnificados.TabIndex = 38;
            this.flpPenSortimentosUnificados.Visible = false;
            // 
            // panel42
            // 
            this.panel42.Controls.Add(this.panel43);
            this.panel42.Controls.Add(this.label2);
            this.panel42.Location = new System.Drawing.Point(3, 3);
            this.panel42.Name = "panel42";
            this.panel42.Padding = new System.Windows.Forms.Padding(10, 0, 10, 0);
            this.panel42.Size = new System.Drawing.Size(206, 48);
            this.panel42.TabIndex = 15;
            // 
            // panel43
            // 
            this.panel43.Controls.Add(this.txtPenSorUniTitulo);
            this.panel43.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel43.Location = new System.Drawing.Point(10, 13);
            this.panel43.Name = "panel43";
            this.panel43.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.panel43.Size = new System.Drawing.Size(186, 35);
            this.panel43.TabIndex = 1;
            // 
            // txtPenSorUniTitulo
            // 
            this.txtPenSorUniTitulo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtPenSorUniTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPenSorUniTitulo.Location = new System.Drawing.Point(0, 5);
            this.txtPenSorUniTitulo.Multiline = true;
            this.txtPenSorUniTitulo.Name = "txtPenSorUniTitulo";
            this.txtPenSorUniTitulo.Size = new System.Drawing.Size(186, 30);
            this.txtPenSorUniTitulo.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 0);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Título";
            // 
            // panel44
            // 
            this.panel44.Controls.Add(this.panel45);
            this.panel44.Controls.Add(this.btnOpenPenSorUni);
            this.panel44.Location = new System.Drawing.Point(0, 54);
            this.panel44.Margin = new System.Windows.Forms.Padding(0);
            this.panel44.Name = "panel44";
            this.panel44.Size = new System.Drawing.Size(212, 30);
            this.panel44.TabIndex = 17;
            // 
            // panel45
            // 
            this.panel45.Controls.Add(this.sbiPenSorUni);
            this.panel45.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel45.Location = new System.Drawing.Point(0, 0);
            this.panel45.Name = "panel45";
            this.panel45.Size = new System.Drawing.Size(175, 30);
            this.panel45.TabIndex = 7;
            // 
            // sbiPenSorUni
            // 
            this.sbiPenSorUni.BackColor = System.Drawing.Color.White;
            this.sbiPenSorUni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenSorUni.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenSorUni.FlatAppearance.BorderSize = 0;
            this.sbiPenSorUni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenSorUni.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenSorUni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenSorUni.Location = new System.Drawing.Point(0, 0);
            this.sbiPenSorUni.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenSorUni.Name = "sbiPenSorUni";
            this.sbiPenSorUni.Size = new System.Drawing.Size(175, 30);
            this.sbiPenSorUni.TabIndex = 17;
            this.sbiPenSorUni.TabStop = false;
            this.sbiPenSorUni.Text = "Simular";
            this.sbiPenSorUni.UseVisualStyleBackColor = false;
            // 
            // lblPenBinaria
            // 
            this.lblPenBinaria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenBinaria.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenBinaria.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenBinaria.ForeColor = System.Drawing.Color.White;
            this.lblPenBinaria.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenBinaria.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenBinaria.Location = new System.Drawing.Point(0, 501);
            this.lblPenBinaria.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenBinaria.Name = "lblPenBinaria";
            this.lblPenBinaria.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
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
            this.flpPenBinaria.Controls.Add(this.panel33);
            this.flpPenBinaria.Location = new System.Drawing.Point(0, 530);
            this.flpPenBinaria.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenBinaria.Name = "flpPenBinaria";
            this.flpPenBinaria.Size = new System.Drawing.Size(212, 84);
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
            // panel33
            // 
            this.panel33.Controls.Add(this.panel34);
            this.panel33.Controls.Add(this.btnOpenPenBin);
            this.panel33.Location = new System.Drawing.Point(0, 54);
            this.panel33.Margin = new System.Windows.Forms.Padding(0);
            this.panel33.Name = "panel33";
            this.panel33.Size = new System.Drawing.Size(212, 30);
            this.panel33.TabIndex = 21;
            // 
            // panel34
            // 
            this.panel34.Controls.Add(this.sbiPenBin);
            this.panel34.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel34.Location = new System.Drawing.Point(0, 0);
            this.panel34.Name = "panel34";
            this.panel34.Size = new System.Drawing.Size(175, 30);
            this.panel34.TabIndex = 7;
            // 
            // sbiPenBin
            // 
            this.sbiPenBin.BackColor = System.Drawing.Color.White;
            this.sbiPenBin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenBin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenBin.FlatAppearance.BorderSize = 0;
            this.sbiPenBin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenBin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenBin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenBin.Location = new System.Drawing.Point(0, 0);
            this.sbiPenBin.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenBin.Name = "sbiPenBin";
            this.sbiPenBin.Size = new System.Drawing.Size(175, 30);
            this.sbiPenBin.TabIndex = 21;
            this.sbiPenBin.TabStop = false;
            this.sbiPenBin.Text = "Simular";
            this.sbiPenBin.UseVisualStyleBackColor = false;
            // 
            // lblPenRegulacao
            // 
            this.lblPenRegulacao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenRegulacao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenRegulacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenRegulacao.ForeColor = System.Drawing.Color.White;
            this.lblPenRegulacao.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenRegulacao.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenRegulacao.Location = new System.Drawing.Point(0, 621);
            this.lblPenRegulacao.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenRegulacao.Name = "lblPenRegulacao";
            this.lblPenRegulacao.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenRegulacao.Size = new System.Drawing.Size(209, 22);
            this.lblPenRegulacao.TabIndex = 20;
            this.lblPenRegulacao.Text = "Regulação";
            this.lblPenRegulacao.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenRegulacao.Click += new System.EventHandler(this.lblPenRegulacao_Click);
            // 
            // flpPenRegulacao
            // 
            this.flpPenRegulacao.AutoSize = true;
            this.flpPenRegulacao.Controls.Add(this.panel17);
            this.flpPenRegulacao.Controls.Add(this.panel35);
            this.flpPenRegulacao.Location = new System.Drawing.Point(0, 650);
            this.flpPenRegulacao.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenRegulacao.Name = "flpPenRegulacao";
            this.flpPenRegulacao.Size = new System.Drawing.Size(212, 84);
            this.flpPenRegulacao.TabIndex = 28;
            this.flpPenRegulacao.Visible = false;
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.panel18);
            this.panel17.Controls.Add(this.label21);
            this.panel17.Location = new System.Drawing.Point(3, 3);
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
            // panel35
            // 
            this.panel35.Controls.Add(this.panel36);
            this.panel35.Controls.Add(this.btnOpenPenReg);
            this.panel35.Location = new System.Drawing.Point(0, 54);
            this.panel35.Margin = new System.Windows.Forms.Padding(0);
            this.panel35.Name = "panel35";
            this.panel35.Size = new System.Drawing.Size(212, 30);
            this.panel35.TabIndex = 27;
            // 
            // panel36
            // 
            this.panel36.Controls.Add(this.sbiPenReg);
            this.panel36.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel36.Location = new System.Drawing.Point(0, 0);
            this.panel36.Name = "panel36";
            this.panel36.Size = new System.Drawing.Size(175, 30);
            this.panel36.TabIndex = 7;
            // 
            // sbiPenReg
            // 
            this.sbiPenReg.BackColor = System.Drawing.Color.White;
            this.sbiPenReg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenReg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenReg.FlatAppearance.BorderSize = 0;
            this.sbiPenReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenReg.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenReg.Location = new System.Drawing.Point(0, 0);
            this.sbiPenReg.Margin = new System.Windows.Forms.Padding(0, 3, 0, 3);
            this.sbiPenReg.Name = "sbiPenReg";
            this.sbiPenReg.Size = new System.Drawing.Size(175, 30);
            this.sbiPenReg.TabIndex = 27;
            this.sbiPenReg.TabStop = false;
            this.sbiPenReg.Text = "Simular";
            this.sbiPenReg.UseVisualStyleBackColor = false;
            // 
            // lblPenImportarTabelas
            // 
            this.lblPenImportarTabelas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenImportarTabelas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenImportarTabelas.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenImportarTabelas.ForeColor = System.Drawing.Color.White;
            this.lblPenImportarTabelas.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenImportarTabelas.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenImportarTabelas.Location = new System.Drawing.Point(0, 741);
            this.lblPenImportarTabelas.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenImportarTabelas.Name = "lblPenImportarTabelas";
            this.lblPenImportarTabelas.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenImportarTabelas.Size = new System.Drawing.Size(213, 22);
            this.lblPenImportarTabelas.TabIndex = 29;
            this.lblPenImportarTabelas.Text = "Importar Tabelas";
            this.lblPenImportarTabelas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenImportarTabelas.Click += new System.EventHandler(this.lblPenImportarTabelas_Click);
            // 
            // flpPenImportarTabelas
            // 
            this.flpPenImportarTabelas.AutoSize = true;
            this.flpPenImportarTabelas.Controls.Add(this.panel2);
            this.flpPenImportarTabelas.Controls.Add(this.panel38);
            this.flpPenImportarTabelas.Location = new System.Drawing.Point(0, 770);
            this.flpPenImportarTabelas.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenImportarTabelas.Name = "flpPenImportarTabelas";
            this.flpPenImportarTabelas.Size = new System.Drawing.Size(209, 60);
            this.flpPenImportarTabelas.TabIndex = 30;
            this.flpPenImportarTabelas.Visible = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel37);
            this.panel2.Controls.Add(this.btnOpenPenAdjacencia);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(209, 30);
            this.panel2.TabIndex = 6;
            // 
            // panel37
            // 
            this.panel37.Controls.Add(this.sbiPenAdjacencia);
            this.panel37.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel37.Location = new System.Drawing.Point(0, 0);
            this.panel37.Name = "panel37";
            this.panel37.Size = new System.Drawing.Size(172, 30);
            this.panel37.TabIndex = 0;
            // 
            // sbiPenAdjacencia
            // 
            this.sbiPenAdjacencia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenAdjacencia.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbiPenAdjacencia.FlatAppearance.BorderSize = 0;
            this.sbiPenAdjacencia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenAdjacencia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPenAdjacencia.ForeColor = System.Drawing.Color.White;
            this.sbiPenAdjacencia.Location = new System.Drawing.Point(0, 0);
            this.sbiPenAdjacencia.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPenAdjacencia.Name = "sbiPenAdjacencia";
            this.sbiPenAdjacencia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPenAdjacencia.Size = new System.Drawing.Size(172, 30);
            this.sbiPenAdjacencia.TabIndex = 2;
            this.sbiPenAdjacencia.TabStop = false;
            this.sbiPenAdjacencia.Text = "Adjacência";
            this.sbiPenAdjacencia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPenAdjacencia.UseVisualStyleBackColor = true;
            // 
            // panel38
            // 
            this.panel38.Controls.Add(this.panel39);
            this.panel38.Controls.Add(this.btnOpenPenDistancia);
            this.panel38.Location = new System.Drawing.Point(0, 30);
            this.panel38.Margin = new System.Windows.Forms.Padding(0);
            this.panel38.Name = "panel38";
            this.panel38.Size = new System.Drawing.Size(209, 30);
            this.panel38.TabIndex = 7;
            // 
            // panel39
            // 
            this.panel39.Controls.Add(this.sbiPenDistancia);
            this.panel39.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel39.Location = new System.Drawing.Point(0, 0);
            this.panel39.Name = "panel39";
            this.panel39.Size = new System.Drawing.Size(172, 30);
            this.panel39.TabIndex = 0;
            // 
            // sbiPenDistancia
            // 
            this.sbiPenDistancia.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenDistancia.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenDistancia.FlatAppearance.BorderSize = 0;
            this.sbiPenDistancia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenDistancia.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPenDistancia.ForeColor = System.Drawing.Color.White;
            this.sbiPenDistancia.Location = new System.Drawing.Point(0, 0);
            this.sbiPenDistancia.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPenDistancia.Name = "sbiPenDistancia";
            this.sbiPenDistancia.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPenDistancia.Size = new System.Drawing.Size(172, 30);
            this.sbiPenDistancia.TabIndex = 5;
            this.sbiPenDistancia.TabStop = false;
            this.sbiPenDistancia.Text = "Distância";
            this.sbiPenDistancia.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPenDistancia.UseVisualStyleBackColor = true;
            // 
            // lblPenImportarShapeFile
            // 
            this.lblPenImportarShapeFile.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenImportarShapeFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenImportarShapeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenImportarShapeFile.ForeColor = System.Drawing.Color.White;
            this.lblPenImportarShapeFile.Image = global::Simulador.Properties.Resources.arrow_down_16x16;
            this.lblPenImportarShapeFile.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenImportarShapeFile.Location = new System.Drawing.Point(0, 830);
            this.lblPenImportarShapeFile.Margin = new System.Windows.Forms.Padding(0, 0, 0, 7);
            this.lblPenImportarShapeFile.Name = "lblPenImportarShapeFile";
            this.lblPenImportarShapeFile.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenImportarShapeFile.Size = new System.Drawing.Size(213, 22);
            this.lblPenImportarShapeFile.TabIndex = 35;
            this.lblPenImportarShapeFile.Text = "Importar ShapeFile";
            this.lblPenImportarShapeFile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenImportarShapeFile.Click += new System.EventHandler(this.lblPenImportarShapeFile_Click);
            // 
            // flpPenShapeFile
            // 
            this.flpPenShapeFile.AutoSize = true;
            this.flpPenShapeFile.Controls.Add(this.panel40);
            this.flpPenShapeFile.Location = new System.Drawing.Point(0, 859);
            this.flpPenShapeFile.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenShapeFile.Name = "flpPenShapeFile";
            this.flpPenShapeFile.Size = new System.Drawing.Size(209, 30);
            this.flpPenShapeFile.TabIndex = 36;
            this.flpPenShapeFile.Visible = false;
            // 
            // panel40
            // 
            this.panel40.Controls.Add(this.panel41);
            this.panel40.Controls.Add(this.btnOpenPreShapeFile);
            this.panel40.Location = new System.Drawing.Point(0, 0);
            this.panel40.Margin = new System.Windows.Forms.Padding(0);
            this.panel40.Name = "panel40";
            this.panel40.Size = new System.Drawing.Size(209, 30);
            this.panel40.TabIndex = 6;
            // 
            // panel41
            // 
            this.panel41.Controls.Add(this.sbiPreShapeFile);
            this.panel41.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel41.Location = new System.Drawing.Point(0, 0);
            this.panel41.Name = "panel41";
            this.panel41.Size = new System.Drawing.Size(172, 30);
            this.panel41.TabIndex = 0;
            // 
            // sbiPreShapeFile
            // 
            this.sbiPreShapeFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPreShapeFile.Dock = System.Windows.Forms.DockStyle.Top;
            this.sbiPreShapeFile.FlatAppearance.BorderSize = 0;
            this.sbiPreShapeFile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPreShapeFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.sbiPreShapeFile.ForeColor = System.Drawing.Color.White;
            this.sbiPreShapeFile.Location = new System.Drawing.Point(0, 0);
            this.sbiPreShapeFile.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPreShapeFile.Name = "sbiPreShapeFile";
            this.sbiPreShapeFile.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.sbiPreShapeFile.Size = new System.Drawing.Size(172, 30);
            this.sbiPreShapeFile.TabIndex = 2;
            this.sbiPreShapeFile.TabStop = false;
            this.sbiPreShapeFile.Text = "ShapeFile";
            this.sbiPreShapeFile.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sbiPreShapeFile.UseVisualStyleBackColor = true;
            // 
            // lblPenTabelaHeuristica
            // 
            this.lblPenTabelaHeuristica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.lblPenTabelaHeuristica.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblPenTabelaHeuristica.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenTabelaHeuristica.ForeColor = System.Drawing.Color.White;
            this.lblPenTabelaHeuristica.Image = global::Simulador.Properties.Resources.arrow_up_16x16;
            this.lblPenTabelaHeuristica.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblPenTabelaHeuristica.Location = new System.Drawing.Point(0, 896);
            this.lblPenTabelaHeuristica.Margin = new System.Windows.Forms.Padding(0, 7, 0, 7);
            this.lblPenTabelaHeuristica.Name = "lblPenTabelaHeuristica";
            this.lblPenTabelaHeuristica.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.lblPenTabelaHeuristica.Size = new System.Drawing.Size(213, 22);
            this.lblPenTabelaHeuristica.TabIndex = 33;
            this.lblPenTabelaHeuristica.Text = "Heurística";
            this.lblPenTabelaHeuristica.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPenTabelaHeuristica.Click += new System.EventHandler(this.lblPenTabelaHeuristica_Click);
            // 
            // flpPenTabelaHeuristica
            // 
            this.flpPenTabelaHeuristica.AutoSize = true;
            this.flpPenTabelaHeuristica.Controls.Add(this.panel48);
            this.flpPenTabelaHeuristica.Location = new System.Drawing.Point(0, 925);
            this.flpPenTabelaHeuristica.Margin = new System.Windows.Forms.Padding(0);
            this.flpPenTabelaHeuristica.Name = "flpPenTabelaHeuristica";
            this.flpPenTabelaHeuristica.Size = new System.Drawing.Size(212, 30);
            this.flpPenTabelaHeuristica.TabIndex = 34;
            // 
            // panel48
            // 
            this.panel48.Controls.Add(this.panel49);
            this.panel48.Controls.Add(this.btnOpenPenTabHeu);
            this.panel48.Location = new System.Drawing.Point(0, 0);
            this.panel48.Margin = new System.Windows.Forms.Padding(0);
            this.panel48.Name = "panel48";
            this.panel48.Size = new System.Drawing.Size(212, 30);
            this.panel48.TabIndex = 13;
            // 
            // panel49
            // 
            this.panel49.Controls.Add(this.sbiPenTabHeu);
            this.panel49.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel49.Location = new System.Drawing.Point(0, 0);
            this.panel49.Name = "panel49";
            this.panel49.Size = new System.Drawing.Size(175, 30);
            this.panel49.TabIndex = 7;
            // 
            // sbiPenTabHeu
            // 
            this.sbiPenTabHeu.BackColor = System.Drawing.Color.White;
            this.sbiPenTabHeu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sbiPenTabHeu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sbiPenTabHeu.FlatAppearance.BorderSize = 0;
            this.sbiPenTabHeu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sbiPenTabHeu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.sbiPenTabHeu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(92)))), ((int)(((byte)(47)))));
            this.sbiPenTabHeu.Location = new System.Drawing.Point(0, 0);
            this.sbiPenTabHeu.Margin = new System.Windows.Forms.Padding(0);
            this.sbiPenTabHeu.Name = "sbiPenTabHeu";
            this.sbiPenTabHeu.Size = new System.Drawing.Size(175, 30);
            this.sbiPenTabHeu.TabIndex = 5;
            this.sbiPenTabHeu.TabStop = false;
            this.sbiPenTabHeu.Text = "Simular";
            this.sbiPenTabHeu.UseVisualStyleBackColor = false;
            // 
            // tbOther
            // 
            this.tbOther.Location = new System.Drawing.Point(4, 22);
            this.tbOther.Name = "tbOther";
            this.tbOther.Padding = new System.Windows.Forms.Padding(3);
            this.tbOther.Size = new System.Drawing.Size(234, 509);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ssMainNomeArquivo.ResumeLayout(false);
            this.ssMainNomeArquivo.PerformLayout();
            this.pnlPlanilhaHeader.ResumeLayout(false);
            this.pnlPlanilhaHeaderActions.ResumeLayout(false);
            this.pnlBtnPlanilhaUpdate.ResumeLayout(false);
            this.pnlBtnPlanilhaOpen.ResumeLayout(false);
            this.tpLogo.ResumeLayout(false);
            this.tpLogo.PerformLayout();
            this.pnlMainInfos.ResumeLayout(false);
            this.tpMapa.ResumeLayout(false);
            this.tabSidebar.ResumeLayout(false);
            this.tpPreescricoes.ResumeLayout(false);
            this.tpPreescricoes.PerformLayout();
            this.flpPre.ResumeLayout(false);
            this.flpPre.PerformLayout();
            this.flpPreImportarTabelas.ResumeLayout(false);
            this.panel19.ResumeLayout(false);
            this.panel20.ResumeLayout(false);
            this.panel21.ResumeLayout(false);
            this.panel22.ResumeLayout(false);
            this.panel23.ResumeLayout(false);
            this.panel24.ResumeLayout(false);
            this.panel25.ResumeLayout(false);
            this.panel26.ResumeLayout(false);
            this.panel27.ResumeLayout(false);
            this.panel28.ResumeLayout(false);
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
            this.panel3.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.tpPenalidades.ResumeLayout(false);
            this.flpPen.ResumeLayout(false);
            this.flpPen.PerformLayout();
            this.flpPenDadosCompartilhados.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.flpPenMaximizacoes.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            this.panel11.PerformLayout();
            this.panel29.ResumeLayout(false);
            this.panel30.ResumeLayout(false);
            this.flpPenSortimentos.ResumeLayout(false);
            this.panel12.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.panel13.PerformLayout();
            this.panel31.ResumeLayout(false);
            this.panel32.ResumeLayout(false);
            this.flpPenSortimentosUnificados.ResumeLayout(false);
            this.panel42.ResumeLayout(false);
            this.panel43.ResumeLayout(false);
            this.panel43.PerformLayout();
            this.panel44.ResumeLayout(false);
            this.panel45.ResumeLayout(false);
            this.flpPenBinaria.ResumeLayout(false);
            this.panel14.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel33.ResumeLayout(false);
            this.panel34.ResumeLayout(false);
            this.flpPenRegulacao.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            this.panel35.ResumeLayout(false);
            this.panel36.ResumeLayout(false);
            this.flpPenImportarTabelas.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel37.ResumeLayout(false);
            this.panel38.ResumeLayout(false);
            this.panel39.ResumeLayout(false);
            this.flpPenShapeFile.ResumeLayout(false);
            this.panel40.ResumeLayout(false);
            this.panel41.ResumeLayout(false);
            this.flpPenTabelaHeuristica.ResumeLayout(false);
            this.panel48.ResumeLayout(false);
            this.panel49.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        private System.Windows.Forms.Button btnOpenPrePlanilhaCustos;
        private Simulador.Components.SidebarItem sbiPrePlanilhaCustos;

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlHeaderRight;
        private System.Windows.Forms.FlowLayoutPanel pnlHeaderActionsRight;
        private System.Windows.Forms.FlowLayoutPanel pnlHeaderActionsLeft;
        private System.Windows.Forms.Panel pnlHeaderLeft;
        private System.Windows.Forms.Label lblMiniLogo;
        private Components.NavbarItem nviPreescricoes;
        private Components.NavbarItem nviPenalidades;
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
        private System.Windows.Forms.FlowLayoutPanel flpPenSortimentos;
        private System.Windows.Forms.FlowLayoutPanel flpPenBinaria;
        private System.Windows.Forms.Panel panel14;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox txtPenBinTitulo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.FlowLayoutPanel flpPenRegulacao;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox txtPenRegTitulo;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label lblMainLogo;
        private System.Windows.Forms.Panel pnlPreIntervaloSistematico;
        private System.Windows.Forms.TextBox txtPreIntervaloSistematico;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label lblMainAcao;
        private System.Windows.Forms.ToolStripStatusLabel slblTpMainEnderecoArquivo;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Panel pnlMainInfos;
        private System.Windows.Forms.Label lblMainInfo;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel19;
        private System.Windows.Forms.Panel panel20;
        private System.Windows.Forms.Button btnOpenPreDadosInventario;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnOpenPrePre;
        private Components.SidebarItem sbiPreDadosInventario;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Panel panel22;
        private Components.SidebarItem sbiPreCoeficienteMAI;
        private System.Windows.Forms.Button btnOpenPreCoeficienteMAI;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.Panel panel24;
        private Components.SidebarItem sbiPreSortimentos;
        private System.Windows.Forms.Button btnOpenPreSortimentos;
        private System.Windows.Forms.Panel panel25;
        private System.Windows.Forms.Panel panel26;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private Components.SidebarItem sbiPreCenarios;
        private System.Windows.Forms.Button btnOpenPreCenarios;
        private System.Windows.Forms.Panel panel29;
        private System.Windows.Forms.Panel panel30;
        private Components.SidebarItem sbiPenMax;
        private System.Windows.Forms.Button btnOpenPenMax;
        private System.Windows.Forms.Panel panel31;
        private System.Windows.Forms.Panel panel32;
        private Components.SidebarItem sbiPenSor;
        private System.Windows.Forms.Button btnOpenPenSor;
        private System.Windows.Forms.Panel panel33;
        private System.Windows.Forms.Panel panel34;
        private System.Windows.Forms.Button btnOpenPenBin;
        private Components.SidebarItem sbiPenBin;
        private System.Windows.Forms.Panel panel35;
        private System.Windows.Forms.Panel panel36;
        private Components.SidebarItem sbiPenReg;
        private System.Windows.Forms.Button btnOpenPenReg;
        private System.Windows.Forms.Panel pnlPlanilhaHeader;
        private System.Windows.Forms.Button btnPlanilhaOpen;
        private System.Windows.Forms.Panel pnlPlanilhaHeaderActions;
        private System.Windows.Forms.Button btnPlanilhaUpdate;
        private System.Windows.Forms.Panel pnlBtnPlanilhaUpdate;
        private System.Windows.Forms.Panel pnlBtnPlanilhaOpen;
        private System.Windows.Forms.Label lblPenImportarTabelas;
        private System.Windows.Forms.FlowLayoutPanel flpPenImportarTabelas;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel37;
        private Components.SidebarItem sbiPenAdjacencia;
        private System.Windows.Forms.Button btnOpenPenAdjacencia;
        private System.Windows.Forms.Panel panel38;
        private System.Windows.Forms.Panel panel39;
        private Components.SidebarItem sbiPenDistancia;
        private System.Windows.Forms.Button btnOpenPenDistancia;
        private System.Windows.Forms.Label lblPenTabelaHeuristica;
        private System.Windows.Forms.FlowLayoutPanel flpPenTabelaHeuristica;
        private System.Windows.Forms.Panel panel48;
        private System.Windows.Forms.Panel panel49;
        private Components.SidebarItem sbiPenTabHeu;
        private System.Windows.Forms.Button btnOpenPenTabHeu;
        private System.Windows.Forms.ToolTip tipPreescricoes;
        private System.Windows.Forms.ToolTip tipPenalidades;
        private System.Windows.Forms.StatusStrip ssWorkSheets;
        private System.Windows.Forms.TabPage tpMapa;
        private EGIS.Controls.SFMap sfMap1;
        private System.Windows.Forms.Label lblPenImportarShapeFile;
        private System.Windows.Forms.FlowLayoutPanel flpPenShapeFile;
        private System.Windows.Forms.Panel panel40;
        private System.Windows.Forms.Panel panel41;
        private Components.SidebarItem sbiPreShapeFile;
        private System.Windows.Forms.Button btnOpenPreShapeFile;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox txtPenRegIdadeRegulacao;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label lblPenSortimentosUnificados;
        private System.Windows.Forms.FlowLayoutPanel flpPenSortimentosUnificados;
        private System.Windows.Forms.Panel panel42;
        private System.Windows.Forms.Panel panel43;
        private System.Windows.Forms.TextBox txtPenSorUniTitulo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel44;
        private System.Windows.Forms.Panel panel45;
        private Components.SidebarItem sbiPenSorUni;
        private System.Windows.Forms.Button btnOpenPenSorUni;
    }
}