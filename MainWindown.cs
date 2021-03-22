using System;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using Simulador.Classes;
using Simulador.Components;
using Simulador.Models;

namespace Simulador
{
    public sealed partial class MainWindown : Form
    {
        public delegate void SetClickSimulateEventHandler(object sender, SetClickSimulateEventArgs e);

        public MainWindown()
        {
            InitializeComponent();

            // Inicializando classe responsável pelo GMPF
            GmpfManager = new Gmpfanager();

            // Inicializa Logo
            InitializeLogo();

            // Inicializa eventos de carregar Tabela
            InitializeClicks();

            // Inicializa na TabPage Preescrições
            InitializeNavbar();

            // Deixando todos itens SideBar com width Full
            InitializeSidebar();

            GmpfManager.Update += (s, e) =>
            {
                lblMainInfo.Text = e.Message;
                if (e.Progress == 0)
                {
                    lblMainAcao.Text = e.Name;
                    pnlMainInfos.Visible = true;
                    tabMain.SelectedTab = tpLogo;
                }
                else if (e.Progress == 100)
                {
                    // Após acabar processamento
                    pnlMainInfos.Visible = false;
                    if (e.Spreedsheet == GmpfManager.SprdMax)
                    {
                        Process.Start(GmpfManager.SprdMax.FileName);
                        tabMain.SelectedTab = tpLogo;
                    }
                    else
                    {
                        tabMain.SelectedTab = tpPanilha;
                        Spreedsheet = e.Spreedsheet;
                        LoadExcelData(Spreedsheet, false);
                    }

                    // if(e.Spreedsheet.FileName!=null) Process.Start(e.Spreedsheet.FileName);
                }

                // DebugLoadFiles();
            };

            btnPlanilhaOpen.Click += (s, e) => { Process.Start(Spreedsheet.FileName); };
            btnPlanilhaUpdate.Click += (s, e) => { LoadExcelData(Spreedsheet); };
        }

        private Gmpfanager GmpfManager { get; }
        private Spreedsheet Spreedsheet { get; set; }
        private NavbarItem SelectedNavbarItem { get; set; }

        private void InitializeNavbar()
        {
            tabSidebar.SelectedTab = tpPreescricoes;
            SelectedNavbarItem = nviPreescricoes;
            SelectedNavbarItem.Active = true;
        }

        private void DebugLoadFiles()
        {
            // Já caregando para ser mais rápido
            GmpfManager.SprdSimDadosInventario.FileName =
                "F:\\places\\viçosa\\estagios\\Others\\docs\\Dados_de_inventario2 (1).xlsx";
            GmpfManager.SprdSimCoeficienteMai.FileName =
                "F:\\places\\viçosa\\estagios\\Others\\docs\\Coeficientes - MAI.xlsx";
            GmpfManager.SprdSimSortimentos.FileName = "F:\\places\\viçosa\\estagios\\Others\\docs\\Sortimentos.xlsx";
            GmpfManager.SprdSimPlanilhaCustos.FileName =
                "F:\\places\\viçosa\\estagios\\Others\\docs\\Planilha_de_custos.xlsx";
            GmpfManager.SprdSimCenarios.FileName = "F:\\places\\viçosa\\estagios\\Others\\docs\\Cenários.xlsx";
            txtPreTaxaDesconto.Text = "0.10";
            cmbPreTipoDesbaste.SelectedIndex = 1;
            cmbPreControleDesbaste.SelectedIndex = 1;
            txtPrePreTitulo.Text = "5";
        }

        private void OpenDialog(Spreedsheet sprd, Control ctl)
        {
            try
            {
                if (sprd.OpenFile())
                {
                    Spreedsheet = sprd;
                    LoadExcelData(Spreedsheet);
                    ctl.Visible = true;
                }
            }
            catch (Exception e)
            {
                ctl.Visible = false;
                MessageBox.Show(e.Message);
            }
        }

        private void LoadExcelData(Spreedsheet sprd, bool planilhaUpdateVisibility = true)
        {
            sprd.GetTabelaExcel();
            lblPlanilhaNomeArquivo.Text = sprd.Title;
            slblTpMainEnderecoArquivo.Text = "Arquivo: " + sprd.FileName;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.DataSource = sprd.DataTable;
            sprd.DataTable.Dispose();

            btnPlanilhaUpdate.Visible = planilhaUpdateVisibility;
            tabMain.SelectedTab = tpPanilha;
        }

        private void cmbPreTipoDesbaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPreTipoDesbaste.Text == "Seletivo")
                pnlPreIntervaloSistematico.Visible = false;
            else if (cmbPreTipoDesbaste.Text == "Misto") pnlPreIntervaloSistematico.Visible = true;
        }

        // Mudar Navbar Item
        private void nviPreescricoes_Click(object sender, EventArgs e)
        {
            SelectedNavbarItem.Active = false;
            SelectedNavbarItem = nviPreescricoes;
            SelectedNavbarItem.Active = true;
            tabSidebar.SelectedTab = tpPreescricoes;
            tabMain.SelectedTab = tpLogo;
        }

        private void navPenalidades_Click(object sender, EventArgs e)
        {
            SelectedNavbarItem.Active = false;
            SelectedNavbarItem = nviPenalidades;
            SelectedNavbarItem.Active = true;
            tabSidebar.SelectedTab = tpPenalidades;
            tabMain.SelectedTab = tpLogo;
        }

        // Expandir e Maximizar FlowLayouts
        private void lblPreImportarTabelas_Click(object sender, EventArgs e)
        {
            flpPreImportarTabelas.Visible = !flpPreImportarTabelas.Visible;
        }

        private void lblPreDadosPreescricao_Click(object sender, EventArgs e)
        {
            flpPreDadosPreescricao.Visible = !flpPreDadosPreescricao.Visible;
        }

        private void lblPreGerarPreescricoes_Click(object sender, EventArgs e)
        {
            flpPreGerarPreescricoes.Visible = !flpPreGerarPreescricoes.Visible;
        }

        private void lblPenDadosCompartilhados_Click(object sender, EventArgs e)
        {
            flpPenDadosCompartilhados.Visible = !flpPenDadosCompartilhados.Visible;
        }

        private void lblPenMaximizacoes_Click(object sender, EventArgs e)
        {
            flpPenMaximizacoes.Visible = !flpPenMaximizacoes.Visible;
        }

        private void lblPenSortimentos_Click(object sender, EventArgs e)
        {
            flpPenSortimentos.Visible = !flpPenSortimentos.Visible;
        }

        private void lblPenBinaria_Click(object sender, EventArgs e)
        {
            flpPenBinaria.Visible = !flpPenBinaria.Visible;
        }

        private void lblPenRegulacao_Click(object sender, EventArgs e)
        {
            flpPenRegulacao.Visible = !flpPenRegulacao.Visible;
        }

        private void SetClickOpenSpreedsheet(Spreedsheet sprd, Control ctl1, Control ctl2)
        {
            ctl2.Click += (s, e) => { LoadExcelData(sprd); };
            ctl1.Click += (s, e) => { OpenDialog(sprd, ctl2); };
        }

        private void SetClickSimulate(Spreedsheet sprd, Control ctl1, Control ctl2,
            SetClickSimulateEventHandler handler)
        {
            ctl1.Click += (s, e) =>
            {
                try
                {
                    handler?.Invoke(this, new SetClickSimulateEventArgs(sprd, ctl1, ctl2));
                    ctl2.Visible = true;
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message, $@"Erro ao gerar {sprd.Title}", MessageBoxButtons.OK);
                    tabMain.SelectedTab = tpLogo;
                    pnlMainInfos.Visible = false;
                    ctl2.Visible = false;
                }
            };
        }

        private void InitializeClicks()
        {
            // Botões de carregar arquivo
            SetClickOpenSpreedsheet(GmpfManager.SprdSimDadosInventario, sbiPreDadosInventario,
                btnOpenPreDadosInventario);
            SetClickOpenSpreedsheet(GmpfManager.SprdSimCoeficienteMai, sbiPreCoeficienteMAI,
                btnOpenPreCoeficienteMAI);
            SetClickOpenSpreedsheet(GmpfManager.SprdSimSortimentos, sbiPreSortimentos,
                btnOpenPreSortimentos);
            SetClickOpenSpreedsheet(GmpfManager.SprdSimPlanilhaCustos, sbiPrePlanilhaCustos,
                btnOpenPrePlanilhaCustos);
            SetClickOpenSpreedsheet(GmpfManager.SprdSimCenarios, sbiPreCenarios,
                btnOpenPreCenarios);

            // Botoões de processamento de dados
            btnOpenPrePre.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdSim, false); };
            SetClickSimulate(GmpfManager.SprdSim, sbiPrePre, btnOpenPrePre, (s, e) =>
            {
                GmpfManager.print_simular(
                    txtPreTaxaDesconto.Text,
                    cmbPreTipoDesbaste.Text,
                    cmbPreControleDesbaste.Text,
                    txtPreIntervaloSistematico.Text,
                    txtPrePreTitulo.Text);
            });

            btnOpenPenMax.Click += (sender, eventArgs) =>
            {
                Process.Start(GmpfManager.SprdMax.FileName);
                tabMain.SelectedTab = tpLogo;
            };
            SetClickSimulate(GmpfManager.SprdMax, sbiPenMax, btnOpenPenMax,
                (s, e) =>
                {
                    GmpfManager.print_maximizaçao(txtPenHorizonte.Text, txtPenMaxNumPlanejamento.Text,
                        txtPenMaxTitulo.Text);
                });

            btnOpenPenSor.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdSor, false); };
            SetClickSimulate(GmpfManager.SprdSor, sbiPenSor, btnOpenPenSor,
                (s, e) => { GmpfManager.print_Sortimentos(txtPenHorizonte.Text, txtPenSorTitulo.Text); });

            btnOpenPenBin.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdBin, false); };
            SetClickSimulate(GmpfManager.SprdBin, sbiPenBin, btnOpenPenBin,
                (s, e) => { GmpfManager.print_Binary(txtPenHorizonte.Text, txtPenBinTitulo.Text); });

            btnOpenPenReg.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdReg, false); };
            SetClickSimulate(GmpfManager.SprdReg, sbiPenReg, btnOpenPenReg,
                (s, e) =>
                {
                    GmpfManager.print_Regulação(txtPenHorizonte.Text, txtPenRegIdadeRegulacao.Text,
                        txtPenRegTitulo.Text);
                });
        }

        private void InitializeLogo()
        {
            tabMain.SelectedTab = tpLogo;
            Resize += (s, e) => // Deixa centralizada
            {
                lblMainLogo.Location = new Point((tpLogo.Width - lblMainLogo.Width) / 2,
                    (tpLogo.Height - lblMainLogo.Height) / 2);
            };
            OnResize(null);
        }

        private void InitializeSidebar()
        {
            // Atualizando nome
            lblPreGerarPreescricoes.Text = GmpfManager.SprdSim.Title;
            lblPenMaximizacoes.Text = GmpfManager.SprdMax.Title;
            lblPenSortimentos.Text = GmpfManager.SprdSor.Title;
            lblPenBinaria.Text = GmpfManager.SprdBin.Title;
            lblPenRegulacao.Text = GmpfManager.SprdReg.Title;

            // Deixando largura igual tabControl
            var widthSideBarItem = tabSidebar.Width;
            foreach (Control control in flpPre.Controls) control.Width = widthSideBarItem;
            foreach (Control control in flpPen.Controls) control.Width = widthSideBarItem;

            foreach (Control control in flpPreImportarTabelas.Controls) control.Width = flpPre.Width;
            foreach (Control control in flpPreDadosPreescricao.Controls) control.Width = flpPre.Width;
            foreach (Control control in flpPreGerarPreescricoes.Controls) control.Width = flpPre.Width;

            foreach (Control control in flpPenDadosCompartilhados.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenMaximizacoes.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenSortimentos.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenBinaria.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenRegulacao.Controls) control.Width = flpPen.Width;

            sbiPrePre.Width = widthSideBarItem;
            sbiPenMax.Width = widthSideBarItem - sbiPenMax.Margin.Left - sbiPenMax.Margin.Right - 3;
            sbiPenSor.Width = widthSideBarItem - sbiPenSor.Margin.Left - sbiPenSor.Margin.Right - 3;
            sbiPenBin.Width = widthSideBarItem - sbiPenBin.Margin.Left - sbiPenBin.Margin.Right - 3;
            sbiPenReg.Width = widthSideBarItem - sbiPenReg.Margin.Left - sbiPenReg.Margin.Right - 3;
        }

        public class SetClickSimulateEventArgs : EventArgs
        {
            public Control Ctl1;
            public Control Ctl2;

            public Spreedsheet Spreedsheet;

            public SetClickSimulateEventArgs(Spreedsheet spreedsheet, Control ctl1, Control ctl2)
            {
                Spreedsheet = spreedsheet;
                Ctl1 = ctl1;
                Ctl2 = ctl2;
            }
        }
    }
}