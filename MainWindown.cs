using System;
using System.Windows.Forms;
using Simulador.Classes;
using Simulador.Components;
using Simulador.Models;

namespace Simulador
{
    public partial class MainWindown : Form
    {
        private Gmpfanager GmpfManager { get; set; }
        private NavbarItem ActiveNavbarItem { get; set; }
        public MainWindown()
        {
            InitializeComponent();

            // Inicializando classe responsável pelo GMPF
            GmpfManager = new Gmpfanager();
            
            // Inicializa na TabPage Preescrições
            tabSidebar.SelectedTab = tpPreescricoes;
            ActiveNavbarItem = nviPreescricoes;
            ActiveNavbarItem.Active = true;

            // Inicializa Logo
            tabMain.SelectedTab = tpLogo;
            this.Resize += (s,e) => // Deixa centralizada
            {
                lblMainLogo.Location = new System.Drawing.Point((tpLogo.Width - lblMainLogo.Width) / 2, (tpLogo.Height - lblMainLogo.Height) / 2);
            };
            this.OnResize(null);

            // Inicializa eventos de carregar Tabela
            sbiPreDadosInventario.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimDadosInventario); };
            sbiPreCoeficienteMAI.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimCoeficienteMai); };
            sbiPreSortimentos.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimSortimentos); };
            sbiPrePanilhaCustos.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimPlanilhaCustos); };
            sbiPreCenarios.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimCenarios); };

            // Deixando todos itens SideBar com width Full
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
            sbiPenSor.Width = widthSideBarItem - sbiPenSor.Margin.Left - sbiPenSor.Margin.Right -3;
            sbiPenBin.Width = widthSideBarItem - sbiPenBin.Margin.Left - sbiPenBin.Margin.Right - 3;
            sbiPenReg.Width = widthSideBarItem - sbiPenReg.Margin.Left - sbiPenReg.Margin.Right - 3;

        }

        private void LoadExcelData(Spreedsheet sprd)
        {
            try
            {
                if (sprd.OpenFile())
                {
                    sprd.GetTabelaExcel();

                    lblPlanilhaNomeArquivo.Text = sprd.Title;
                    slblTpMainEnderecoArquivo.Text = "Arquivo: "+sprd.FileName;

                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.DataSource = sprd.DataTable;
                    sprd.DataTable.Dispose();
                    tabMain.SelectedTab = tpPanilha;
                    
                }
                else
                {
                    throw new Exception("Erro a carregar o arquivo");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void cmbPreTipoDesbaste_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbPreTipoDesbaste.Text == "Seletivo")
            {
                pnlPreIntervaloSistematico.Visible = false;
            }
            else if (cmbPreTipoDesbaste.Text == "Misto")
            {
                pnlPreIntervaloSistematico.Visible = true;
            }
        }

        // Mudar Navbar Item
        private void nviPreescricoes_Click(object sender, EventArgs e)
        {
            ActiveNavbarItem.Active = false;
            ActiveNavbarItem = nviPreescricoes;
            ActiveNavbarItem.Active = true;
            tabSidebar.SelectedTab = tpPreescricoes;
            tabMain.SelectedTab = tpLogo;
        }

        private void navPenalidades_Click(object sender, EventArgs e)
        {
            ActiveNavbarItem.Active = false;
            ActiveNavbarItem = navPenalidades;
            ActiveNavbarItem.Active = true;
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

        private void sbiPrePre_Click(object sender, EventArgs e)
        {
            try
            {
                GmpfManager.print_simular(
                    txtPreTaxaDesconto.Text,
                    cmbPreTipoDesbaste.Text,
                    cmbPreControleDesbaste.Text,
                    txtPreIntervaloSistematico.Text, 
                    txtPrePreTitulo.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao simular os dados", MessageBoxButtons.OK);
            }
        }

        private void sbiPenMax_Click(object sender, EventArgs e)
        {
            try
            {
                GmpfManager.print_maximizaçao(txtPenHorizonte.Text, txtPenMaxNumPlanejamento.Text, txtPenMaxTitulo.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
        }

        private void sbiPenSor_Click(object sender, EventArgs e)
        {
            try
            {
                GmpfManager.print_Sortimentos(txtPenHorizonte.Text, txtPenSorTitulo.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
        }

        private void sbiPenBin_Click(object sender, EventArgs e)
        {
            try
            {
                GmpfManager.print_Binary(txtPenHorizonte.Text, txtPenBinTitulo.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
        }

        private void sbiPenReg_Click(object sender, EventArgs e)
        {
            try
            {
                GmpfManager.print_Regulação(txtPenHorizonte.Text, txtPenRegIdadeRegulacao.Text, txtPenRegTitulo.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
        }
    }
}