using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Simulador.Classes;
using Simulador.Models;

namespace Simulador
{
    public partial class Form1 : Form
    {
        public BorderStyle BorderStyle { get; set; }
        private Gmpfanager GmpfManager { get; set; }

        public Form1()
        {
            InitializeComponent();
            GmpfManager = new Gmpfanager();
            InitilizeTpSim();

            // Deixar o DataGrid em modo apenas leitura
            dataGridView1.ReadOnly = true;
        }

        private void InitilizeTpSim()
        {
            // Quando clicar nos botões, carregar os arquivos do Excel
            btnSimDadosInventario.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimDadosInventario); };
            btnSimCoeficientesMAI.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimCoeficienteMai); };
            btnSimSortimentos.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimSortimentos); };
            btnSimPalhanilhaCustos.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimPlanilhaCustos); };
            btnSimCenarios.Click += (sender, e) => { LoadExcelData(GmpfManager.SprdSimCenarios); };

            // Textos
            txtSimTitle.Text = @"Título";
            DebugLoadFiles();
        }

        private void DebugLoadFiles()
        {
            // Já caregando para ser mais rápido
            GmpfManager.SprdSimDadosInventario.FileName =
                "F:\\places\\viçosa\\estagios\\docs\\Dados_de_inventario.xlsx";
            GmpfManager.SprdSimCoeficienteMai.FileName = "F:\\places\\viçosa\\estagios\\docs\\Coeficientes - MAI.xlsx";
            GmpfManager.SprdSimSortimentos.FileName = "F:\\places\\viçosa\\estagios\\docs\\Sortimentos.xlsx";
            GmpfManager.SprdSimPlanilhaCustos.FileName = "F:\\places\\viçosa\\estagios\\docs\\Planilha_de_custos.xlsx";
            GmpfManager.SprdSimCenarios.FileName = "F:\\places\\viçosa\\estagios\\docs\\Cenários.xlsx";
        }
        
        // Todo, passar função de validação
        private void LoadExcelData(Spreedsheet sprd)
        {
            try
            {
                if (sprd.OpenFile())
                {
                    dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dataGridView1.DataSource = sprd.DataTable;

                    //lblRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
                    sprd.DataTable.Dispose();
                    txtLogo.Visible = false;
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
        private void maximizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trocando para a Tab Maximização
            tabNavibar.SelectedTab = tpMax;
            
            // Deixando texto no TextView semelhante a Placeholder
            txtMaxHorizonte.Text = @"Horizonte";
            txtMaxNumPlanejamento.Text = @"N_Planejamento";
            txtMaxTitle.Text = @"Título";
            btnMax.Text = @"Gerar Maximização";
        }
        
        private void sortimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trocando para a Tab Sortimentos
            tabNavibar.SelectedTab = tpSor;

            // Deixando texto no TextView semelhante a Placeholder
            txtSorHorizonte.Text = @"Horizonte";
            txtSorTitle.Text = @"Título";
            btnSor.Text = @"Gerar Sortimentos";
        }

        private void bináriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trocando para a Tab Binária
            tabNavibar.SelectedTab = tpBin;
            
            // Deixando texto no TextView semelhante a Placeholder
            txtBinHorizonte.Text = @"Horizonte";
            txtBinTitle.Text = @"Titulo";
            btnBin.Text = @"Gerarar binária";
        }
        
        private void regulaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trocando para a Tab Regulação
            tabNavibar.SelectedTab = tpReg;
            
            // Deixando texto no TextView semelhante a Placeholder
            txtRegHorizonte.Text = @"Horizonte";
            txtRegIdadeRegulacao.Text = @"Idade Regulação";
            txtRegTitle.Text = @"Titulo";
            btnReg.Text = @"Gerar Regulação";
        }
        
        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // Trocando para a Tab Simular
            tabNavibar.SelectedTab = tpSim;
            txtSimTitle.Text = @"Título";
        }

        private void btnSim_Click(object sender, EventArgs e)
        {
            // Indicando que está processando 
            Text = @"Gerando Simulações";
            try
            {
                // Chamando processamento
                GmpfManager.print_simular(
                    txtSimTaxaDesconto.Text,
                    cmbSimTipoDesbaste.Text,
                    cmbSimControleDesbaste.Text,
                    txtSimIntervaloSistematico.Text, txtSimTitle.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao simular os dados", MessageBoxButtons.OK);
            }
            // 
            Text = @"Entradas e premissas";
        }

        private void btnMax_Click(object sender, EventArgs e)
        {
            Text = @"Gerando Maximização";
            try
            {
                GmpfManager.print_maximizaçao(txtMaxHorizonte.Text, txtMaxNumPlanejamento.Text, txtSimTitle.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
            Text = @"Entradas e premissas";
        }

        private void btnReg_Click(object sender, EventArgs e)
        {
            Text = @"Gerando Regulação";
            try
            {
                GmpfManager.print_maximizaçao(txtRegHorizonte.Text,txtRegIdadeRegulacao.Text,txtRegTitle.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
            Text = @"Entradas e premissas";
        }

        private void btnSor_Click(object sender, EventArgs e)
        {
            Text = @"Gerando Sortimentos";
            try
            {
                GmpfManager.print_Sortimentos(txtSorHorizonte.Text,txtSorTitle.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
            Text = @"Entradas e premissas";
        }

        private void btnBin_Click(object sender, EventArgs e)
        {
            Text = @"Gerando Binária";
            try
            {
                GmpfManager.print_Binary(txtBinHorizonte.Text,txtBinTitle.Text);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, @"Erro ao gerar maximização", MessageBoxButtons.OK);
            }
            Text = @"Entradas e premissas";
        }
    }
}