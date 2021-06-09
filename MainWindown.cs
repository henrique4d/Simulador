using System;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using ClosedXML.Excel;
using Simulador.Classes;
using Simulador.Components;
using Simulador.Models;

namespace Simulador
{
    public sealed partial class MainWindown : Form
    {
        public delegate void SetClickSimulateEventHandler(object sender, SetClickSimulateEventArgs e);
        public bool isSimulating { get; set; } = false;

        public MainWindown()
        {
            InitializeComponent();

            // Inicializando classe responsável pelo GMPF
            GmpfManager = new GmpfManager();

            //DebugLoadModelsFiles();

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

                
            };

            btnPlanilhaOpen.Click += (s, e) => { Process.Start(Spreedsheet.FileName); };
            btnPlanilhaUpdate.Click += (s, e) => { LoadExcelData(Spreedsheet); };
        }

        private GmpfManager GmpfManager { get; }
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

        private void DebugLoadModelsFiles()
        {
            // Carregar plánilhas do modelo
            GmpfManager.SprdBin.FileName = @"D:\institutions\viçosa\estagios\Docs\Tabela Binária\c.xlsx";
            GmpfManager.SprdSor.FileName = @"D:\institutions\viçosa\estagios\Docs\Sortimentos\c.xlsx";
            GmpfManager.SprdReg.FileName = @"D:\institutions\viçosa\estagios\Docs\Regulação\c.xlsx";
            GmpfManager.SprdPenAdjacencia.FileName = @"D:\institutions\viçosa\estagios\Docs\Adjacencia.xlsx";
            GmpfManager.SprdPenDistancia.FileName = @"D:\institutions\viçosa\estagios\Docs\Distancia.xlsx";
            GmpfManager.SprdSim.FileName = @"D:\institutions\viçosa\estagios\Docs\Simulações\a.xlsx";
        }

        private void OpenDialog(Spreedsheet sprd, Control ctl, string worksheetName = "")
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
            /*
            if (!GmpfManager.isSimulated)
            {
                MessageBox.Show("Simule antes de prosseguir.");
                return;
            }
            */

            SelectedNavbarItem.Active = false;
            SelectedNavbarItem = nviPenalidades;
            SelectedNavbarItem.Active = true;
            tabSidebar.SelectedTab = tpPenalidades;
            tabMain.SelectedTab = tpLogo;
        }

        // Expandir e Maximizar FlowLayouts
        private void lblPreImportarTabelas_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPreImportarTabelas, lblPreImportarTabelas);
        }

        private void lblPreDadosPreescricao_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPreDadosPreescricao, lblPreDadosPreescricao);
        }

        private void lblPreGerarPreescricoes_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPreGerarPreescricoes, lblPreGerarPreescricoes);
        }

        private void lblPenDadosCompartilhados_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenDadosCompartilhados, lblPenDadosCompartilhados);
        }

        private void lblPenMaximizacoes_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenMaximizacoes, lblPenMaximizacoes);
        }

        private void lblPenSortimentos_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenSortimentos, lblPenSortimentos);
        }

        private void lblPenSortimentosUnificados_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenSortimentosUnificados, lblPenSortimentosUnificados);
        }

        private void lblPenBinaria_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenBinaria, lblPenBinaria);
        }

        private void lblPenRegulacao_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenRegulacao, lblPenRegulacao);
        }

        private void lblPenImportarTabelas_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenImportarTabelas, lblPenImportarTabelas);
        }

        private void lblPenTabelaHeuristica_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenTabelaHeuristica, lblPenTabelaHeuristica);
        }

        private void lblPenImportarShapeFile_Click(object sender, EventArgs e)
        {
            SetOpenAndCloseAccordion(flpPenShapeFile, lblPenImportarShapeFile);
        }


        private void SetOpenAndCloseAccordion(FlowLayoutPanel flp, Label lbl)
        {
            flp.Visible = !flp.Visible;
            if (flp.Visible) lbl.Image = Properties.Resources.arrow_up_16x16;
            else lbl.Image = Properties.Resources.arrow_down_16x16;
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
                isSimulating = true;
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
            SetClickOpenSpreedsheet(GmpfManager.SprdPenAdjacencia, sbiPenAdjacencia, btnOpenPenAdjacencia);
            SetClickOpenSpreedsheet(GmpfManager.SprdPenDistancia, sbiPenDistancia, btnOpenPenDistancia);

            // Botoões de processamento de dados
            btnOpenPrePre.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdSim, false); };
            SetClickSimulate(GmpfManager.SprdSim, sbiPrePre, btnOpenPrePre, (s, e) =>
            {
                // cmbPreModelo.SelectedIndex (-1,0,1,2,3)
                GmpfManager.print_simular(
                    txtPreTaxaDesconto.Text,
                    cmbPreTipoDesbaste.Text,
                    cmbPreControleDesbaste.Text,
                    txtPreIntervaloSistematico.Text,
                    txtPrePreTitulo.Text,
                    cmbPreModelo.SelectedIndex
                    );
                nviPenalidades.Enabled = true;
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

            btnOpenPenSorUni.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdSorUni, false); };
            SetClickSimulate(GmpfManager.SprdSorUni, sbiPenSorUni, btnOpenPenSorUni,
                (s, e) => { GmpfManager.print_Sortimentos_unificados(txtPenHorizonte.Text, txtPenSorUniTitulo.Text); });
            
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

            btnOpenPenTabHeu.Click += (sender, eventArgs) => { LoadExcelData(GmpfManager.SprdTabHeu, false); };
            SetClickSimulate(GmpfManager.SprdReg, sbiPenTabHeu, btnOpenPenTabHeu,
                (s, e) =>
                {
                    GmpfManager.print_heuristica(txtPenRegTitulo.Text);
                });

            // ShapeFile
            sbiPreShapeFile.Click += (sender, EventArgs) =>
            {
                OpenFileDialog ofdShapefile = new OpenFileDialog();
                if (ofdShapefile.ShowDialog(this) == DialogResult.OK)
                {
                    try
                    {
                        OpenShapefile(ofdShapefile.FileName);
                        tabMain.SelectedTab = tpMapa;
                        sfMap1.Enabled = true;
                        btnOpenPreShapeFile.Visible = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(this, "Error : " + ex.Message);
                    }
                }
            };
            btnOpenPreShapeFile.Click += (sender, EventArgs) =>
            {
                if(sfMap1.Enabled) tabMain.SelectedTab = tpMapa;
            };
            
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
            foreach (Control control in flpPenSortimentosUnificados.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenBinaria.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenRegulacao.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenImportarTabelas.Controls) control.Width = flpPen.Width;
            foreach (Control control in flpPenTabelaHeuristica.Controls) control.Width = flpPen.Width;

            sbiPrePre.Width = widthSideBarItem;
            sbiPenMax.Width = widthSideBarItem - sbiPenMax.Margin.Left - sbiPenMax.Margin.Right - 3;
            sbiPenSor.Width = widthSideBarItem - sbiPenSor.Margin.Left - sbiPenSor.Margin.Right - 3;
            sbiPenSorUni.Width = widthSideBarItem - sbiPenSorUni.Margin.Left - sbiPenSorUni.Margin.Right - 3;
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



        private void OpenShapefile(string path)
        {
            // clear any shapefiles the map is currently displaying
            this.sfMap1.ClearShapeFiles();

            // open the shapefile passing in the path, display name of the shapefile and
            // the field name to be used when rendering the shapes (we use an empty string
            // as the field name (3rd parameter) can not be null)
            this.sfMap1.AddShapeFile(path, "ShapeFile", "");

            // read the shapefile dbf field names and set the shapefiles's RenderSettings
            // to use the first field to label the shapes.
            EGIS.ShapeFileLib.ShapeFile sf = this.sfMap1[0];
            sf.RenderSettings.FieldName = sf.RenderSettings.DbfReader.GetFieldNames()[4];
            sf.RenderSettings.UseToolTip = true;
            sf.RenderSettings.ToolTipFieldName = sf.RenderSettings.FieldName;
            sf.RenderSettings.IsSelectable = true;

            //select the first record
            sf.SelectRecord(0, true);

        }

        

        private void sfMap1_MouseClick_1(object sender, MouseEventArgs e)
        {
            if (sfMap1.ShapeFileCount == 0) return;
            int recordIndex = sfMap1.GetShapeIndexAtPixelCoord(0, e.Location, 8);
            if (recordIndex >= 0)
            {
                string[] recordAttributes = sfMap1[0].GetAttributeFieldValues(recordIndex);
                string[] attributeNames = sfMap1[0].GetAttributeFieldNames();
                StringBuilder sb = new StringBuilder();
                for (int n = 0; n < attributeNames.Length; ++n)
                {
                    sb.Append(attributeNames[n]).Append(':').AppendLine(recordAttributes[n].Trim());
                }
                MessageBox.Show(this, sb.ToString(), "record attributes", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
            }
        }
    }
}