using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;
using System.Data.OleDb;
using System.IO;



namespace Simulador
{
    public partial class Form1 : Form
    {
        string arquivo_arvores;     // arquivo com os dados das árvores
        string arquivo_coeficientes;    // arquivo com os coeficientes
        string arquivo_produtos;    // arquivo com os produtos
        string arquivo_economico;   // arquivo com os dados economicos
        string arquivo_simulacoes;
        string arquivo_saida;

        List<Regiao> regioes_original;  // armazena as arvores em estado original
        Coeficientes coeficientes;  //armazena os coeficientes
        List<Produto> produtos;     // armazena dados dos produtos
        List<Custos> custos;   // armazena os custos economicos
        Simulacoes simulacoes;
        string tipo_desbaste;   // tipo de desbaste
        string desbaste_por;
        int intervalo_sistematico;     // intervalo de corte para o desbaste Seletivo
        double taxa_juros;

        public BorderStyle BorderStyle { get; private set; }

        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "Título";
            //textBox2.Validating += new CancelEventHandler(radTextBox1_Validating);
            //textBox2.Validated += new EventHandler(radTextBox1_Validated);

        }        
        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Title = "Dados de inventário";
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_arvores = excel.FileName;
            if (arquivo_arvores != null)
            {
                CarregaDadosExcel(arquivo_arvores);
                this.Text =  Botao_Arvore.Text;
            }
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                processamento();
            /*}
            catch
            {
                const string message =
                "ERRO";
                const string caption = "ERRO";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }*/
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Title = "Sortimentos";
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_produtos = excel.FileName;

            if (arquivo_produtos != null)
            {
                CarregaDadosExcel(arquivo_produtos);
                this.Text = botao_produto.Text;

            }
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Title = "Coeficientes - MAI";
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_coeficientes = excel.FileName;
            if (arquivo_coeficientes != null)
            {
                CarregaDadosExcel(arquivo_coeficientes);
                this.Text = Botao_Coeficientes.Text;
            }
        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Title = "Planiha de custos";
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_economico = excel.FileName;
            if (arquivo_economico != null)
            {
                CarregaDadosExcel(arquivo_economico);
                this.Text = Botao_custos.Text;

            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo_desbaste = comboBox1.Text;
            if (comboBox1.Text == "Seletivo")
            {
                textBox1.Visible = false;
            }
            if (comboBox1.Text == "Misto")
            {
                textBox1.Visible = true;
            }
        }
        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            desbaste_por = comboBox2.Text;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            excel.Title = "Cenários";
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_simulacoes = excel.FileName;
            if (arquivo_simulacoes != null)
            {
                CarregaDadosExcel(arquivo_simulacoes);
                this.Text = Botao_cenarios.Text;
            }
        }
        private DataTable getTabelaExcel(string arquivo)
        {
            DataTable dt = new DataTable();
            try
            {
                string Ext = Path.GetExtension(arquivo);
                string connectionString = "";
                if (Ext == ".xls")
                {
                    connectionString = "Provider=Microsoft.Jet.OLEDB.4.0; Data Source =" + arquivo + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                else if (Ext == ".xlsx")
                {
                    connectionString = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source =" + arquivo + "; Extended Properties = 'Excel 8.0;HDR=YES'";
                }
                OleDbConnection conn = new OleDbConnection(connectionString);
                OleDbCommand cmd = new OleDbCommand();
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter();
                cmd.Connection = conn;
                conn.Open();
                DataTable dtSchema;
                dtSchema = conn.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                string nomePlanilha = dtSchema.Rows[0]["TABLE_NAME"].ToString();
                conn.Close();
                conn.Open();
                cmd.CommandText = "SELECT * from [" + nomePlanilha + "]";
                dataAdapter.SelectCommand = cmd;
                dataAdapter.Fill(dt);
                conn.Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return dt;
        }
        private void CarregaDadosExcel(string arquivo)
        {
            try
            {
                DataTable dt = getTabelaExcel(arquivo);

                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DataSource = dt;

                //lblRegistros.Text = (dgvDados.Rows.Count - 1).ToString();
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
            }

            catch (Exception ex)
            {
                MessageBox.Show("erro :" + ex.Message);
            }
        }


        private void Importar_produtos()
        {
            produtos = new List<Produto>();
            var excel = new XLWorkbook(arquivo_produtos);
            var planilha = excel.Worksheet(1);
            for (int linha = 2; ; linha++)
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;
                string nome = planilha.Cell("A" + linha.ToString()).Value.ToString();
                //int numero = int.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString());
                double min = double.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString());
                double max = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                double l = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                double preco = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
                Produto aux = new Produto(0, min, max, l, preco, nome);
                produtos.Add(aux);
            }

            produtos = produtos.OrderBy(x => -x.max).ToList();
            for (int i=0; i<produtos.Count(); i++)
            {
                produtos[i].numero = i + 1;
            }

            excel.Dispose();
        }
        private void Importar_arvores()
        {
            regioes_original = new List<Regiao>();  //lista que ira armazenar as arvores
            var excel = new XLWorkbook(arquivo_arvores);        //acessa o xls
            var planilha = excel.Worksheet(1);
            dataGridView1.DataSource = planilha;
            for (int linha = 2; ; linha++)          //percorre o xls
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;                                  // testa se o xls acabou
                int regiao = int.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString());
                int talhao = int.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString());
                int parcela = int.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                string material_genetico = planilha.Cell("D" + linha.ToString()).Value.ToString();
                double idade = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
                double area_parcela = double.Parse(planilha.Cell("F" + linha.ToString()).Value.ToString());
                int fila = int.Parse(planilha.Cell("G" + linha.ToString()).Value.ToString());
                int arv = int.Parse(planilha.Cell("H" + linha.ToString()).Value.ToString());
                double dap = double.Parse(planilha.Cell("I" + linha.ToString()).Value.ToString());
                double altura = double.Parse(planilha.Cell("J" + linha.ToString()).Value.ToString());

                if (dap == 0 && altura == 0)    // ignora arvores mortas
                    continue;
                // cria a arvore
                Arvore auxiliar = new Arvore(regiao, talhao, idade, dap, altura, parcela, area_parcela, fila, arv, material_genetico);

                bool aux = false;   // verifica se ja foi criada a regiao daquela arvore
                foreach (Regiao reg in regioes_original)
                {
                    if (reg.numero == auxiliar.regiao)  // regiao ja foi criada
                    {
                        reg.adiciona_arvore(auxiliar);  // adiciona a arvore a regiao
                        aux = true;
                        break;
                    }
                }
                if (!aux)   // regiao nao foi criada
                {
                    Regiao nova_regiao = new Regiao(auxiliar.regiao, produtos.Count());   // cria a nova regiao
                    nova_regiao.adiciona_arvore(auxiliar);  // adiciona a arvore a regiao
                    regioes_original.Add(nova_regiao);
                }
            }
            excel.Dispose();
        }
        private void Importar_coeficientes()
        {
            if (comboBox1.Text == "Misto")
            {
                if (textBox1.Text == "")
                {
                    intervalo_sistematico = 5;
                }
                else
                {
                    intervalo_sistematico = int.Parse(textBox1.Text);
                }
            }
            if (textBox2.Text == "")
            {
                taxa_juros = 0.10;
            }
            else 
            {
                taxa_juros = double.Parse(textBox2.Text);
            }
            coeficientes = new Coeficientes();
            var excel = new XLWorkbook(arquivo_coeficientes);
            var planilha = excel.Worksheet(1);

            int linha = 2;
            for ( linha = 2; ; linha++)
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;                                  // testa se o xls acabou
                if (confere == "idade") break;

                string Regiao = (planilha.Cell("A" + linha.ToString()).Value.ToString());
                string Talhao = (planilha.Cell("B" + linha.ToString()).Value.ToString());

                if (Regiao == "all")
                {
                    foreach (Regiao reg in regioes_original)
                    {
                        foreach (Talhao tal in reg.talhoes)
                        {
                            tal.B0_dap = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                            tal.B1_dap = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                            tal.B0_altura = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
                            tal.B1_altura = double.Parse(planilha.Cell("F" + linha.ToString()).Value.ToString());
                        }
                    }
                }
                else
                {
                    foreach (Regiao reg in regioes_original)
                    {
                        if (reg.numero == int.Parse(Regiao))
                        {
                            if (Talhao == "all")
                            {
                                foreach (Talhao tal in reg.talhoes)
                                {
                                    tal.B0_dap = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                                    tal.B1_dap = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                                    tal.B0_altura = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
                                    tal.B1_altura = double.Parse(planilha.Cell("F" + linha.ToString()).Value.ToString());
                                }
                            }
                            else
                            {
                                foreach (Talhao tal in reg.talhoes)
                                {
                                    if (tal.numero == int.Parse(Talhao))
                                    {
                                        tal.B0_dap = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                                        tal.B1_dap = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                                        tal.B0_altura = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
                                        tal.B1_altura = double.Parse(planilha.Cell("F" + linha.ToString()).Value.ToString());
                                        break;
                                    }

                                }
                            }

                            break;
                        }
                    }
                }
            }

            /*coeficientes.B0_dap = double.Parse(planilha.Cell("B" + 2.ToString()).Value.ToString());
            coeficientes.B1_dap = double.Parse(planilha.Cell("C" + 2.ToString()).Value.ToString());
            coeficientes.B0_altura = double.Parse(planilha.Cell("D" + 2.ToString()).Value.ToString());
            coeficientes.B1_altura = double.Parse(planilha.Cell("E" + 2.ToString()).Value.ToString());
            */
            coeficientes.B0 = new List<double>();
            coeficientes.B1 = new List<double>();
            coeficientes.B2 = new List<double>();
            coeficientes.B3 = new List<double>();


            linha++;
            for (; ; linha++)          //percorre o xls
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;                                  // testa se o xls acabou
                int idade = int.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString());
                while (coeficientes.B0.Count() <= idade)    // trata o caso lista < idade
                {
                    coeficientes.B0.Add(0);
                    coeficientes.B1.Add(0);
                    coeficientes.B2.Add(0);
                    coeficientes.B3.Add(0);
                }
                coeficientes.B0[idade] = double.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString());
                coeficientes.B1[idade] = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                coeficientes.B2[idade] = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                coeficientes.B3[idade] = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
            }
            excel.Dispose();
        }
        private void Importar_economica()
        {
            custos = new List<Custos>();
            var excel = new XLWorkbook(arquivo_economico);
            var planilha = excel.Worksheet(1);
            for (int linha = 2; ; linha++)
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;
                int periodo = int.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString());
                while (periodo >= custos.Count())
                {
                    Custos aux = new Custos();
                    custos.Add(aux);
                }
                custos[periodo].implantacao = double.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString());
                custos[periodo].manutencao = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                custos[periodo].desbaste = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                custos[periodo].cortefinal = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
            }
            excel.Dispose();
        }
        private void Importar_simulacoes()
        {
            var excel = new XLWorkbook(arquivo_simulacoes);
            var planilha = excel.Worksheet(1);

            simulacoes = new Simulacoes();
            simulacoes.idade_corte_final = new List<double>();
            simulacoes.idade_desbaste = new List<double>();
            simulacoes.porcentagem = new List<double>();
            simulacoes.corte_raso = new List<double>();

            for (int linha = 2; ; linha++)          //percorre o xls
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;
                simulacoes.idade_desbaste.Add(double.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString()));
            }
            for (int linha = 2; ; linha++)          //percorre o xls
            {
                string confere = planilha.Cell("B" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;
                simulacoes.idade_corte_final.Add(double.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString()));
            }
            for (int linha = 2; ; linha++)          //percorre o xls
            {
                string confere = planilha.Cell("C" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;
                simulacoes.porcentagem.Add(double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString()));
            }

            for (int linha = 2; ; linha++)          //percorre o xls
            {
                string confere = planilha.Cell("D" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;
                simulacoes.corte_raso.Add(double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString()));
            }

            excel.Dispose();
        }


        private void clonar(ref List<Regiao> original, ref List<Regiao> nova)
        {
            foreach (Regiao reg in original)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Arvore arv in parc.arvores)
                        {
                            Arvore projetada = new Arvore(arv.regiao, arv.talhao, arv.idade, arv.dap, arv.altura, arv.parcela, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);

                            bool aux = false;   // verifica se ja foi criada a regiao daquela arvore
                            foreach (Regiao regi in nova)
                            {
                                if (regi.numero == arv.regiao)  // regiao ja foi criada
                                {
                                    regi.adiciona_arvore(projetada);  // adiciona a arvore a regiao
                                    aux = true;
                                    break;
                                }
                            }
                            if (!aux)   // regiao nao foi criada
                            {
                                Regiao nova_regiao = new Regiao(arv.regiao, produtos.Count());   // cria a nova regiao
                                nova_regiao.adiciona_arvore(projetada);  // adiciona a arvore a regiao
                                nova.Add(nova_regiao);
                            }
                        }
                    }
                }
            }
            for (int indice_Regiao = 0; indice_Regiao < original.Count(); indice_Regiao++)
            {
                for (int indice_Talhao = 0; indice_Talhao < original[indice_Regiao].talhoes.Count(); indice_Talhao++)
                {
                    nova[indice_Regiao].talhoes[indice_Talhao].B0_altura = original[indice_Regiao].talhoes[indice_Talhao].B0_altura;
                    nova[indice_Regiao].talhoes[indice_Talhao].B1_altura = original[indice_Regiao].talhoes[indice_Talhao].B1_altura;
                    nova[indice_Regiao].talhoes[indice_Talhao].B0_dap = original[indice_Regiao].talhoes[indice_Talhao].B0_dap;
                    nova[indice_Regiao].talhoes[indice_Talhao].B1_dap = original[indice_Regiao].talhoes[indice_Talhao].B1_dap;
                }
            }
            foreach (Regiao reg in nova)
            {
                reg.set_dados();
            }
        }
        private void projetar_idade(ref List<Regiao> regioes, double idade)
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Arvore arv in parc.arvores)
                        {
                            arv.dap = simula_dap(arv.idade, idade, arv.dap, tal.B0_dap, tal.B1_dap);
                            arv.altura = simula_altura(arv.idade, idade, arv.altura, tal.B0_altura, tal.B1_altura);
                            arv.area_basal = arv.area_basal = Math.PI * Math.Pow(arv.dap, 2) / 40000;
                            arv.idade = idade;
                        }

                    }
                }
            }
            foreach (Regiao reg in regioes)
            {
                reg.set_dados();
            }
        }

        private double simula_dap(double idade1, double idade2, double dap1, double B1, double B2)
        {
            double dap2;
            dap2 = dap1 * Math.Exp(-B1 * (Math.Pow(idade2, B2) - Math.Pow(idade1, B2)));
            return dap2;
        }
        private double simula_altura(double idade1, double idade2, double altura1, double B1, double B2)
        {
            double altura2;
            altura2 = altura1 * Math.Exp(-B1 * (Math.Pow(idade2, B2) - Math.Pow(idade1, B2)));
            return altura2;
        }

        private List<Regiao> desbaste(ref List<Regiao> regioes, double porcentagem)
        {

            if (tipo_desbaste == "Seletivo" && desbaste_por == "Árvore")
            {
                return Seletivo_arvore(ref regioes, porcentagem);
            }
            if (tipo_desbaste == "Seletivo" && desbaste_por == "Área basal")
            {
                return Seletivo_area_basal(ref regioes, porcentagem);
            }
            if (tipo_desbaste == "Misto" && desbaste_por == "Árvore")
            {
                return sistematico_arvore(ref regioes, porcentagem, intervalo_sistematico);
            }
            if (tipo_desbaste == "Misto" && desbaste_por == "Área basal")
            {
                return sistematico_area_basal(ref regioes, porcentagem, intervalo_sistematico);
            }
            return sistematico_area_basal(ref regioes, porcentagem, intervalo_sistematico);
        }
        private List<Regiao> Seletivo_area_basal(ref List<Regiao> regioes, double porcentagem)
        {
            ordena_dap(ref regioes);

            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in regioes)
            {
                Regiao auxiliar = new Regiao(reg.numero, produtos.Count());

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double area_basal_limite = parc.area_basal_total * porcentagem / 100;
                        bool tem_uma = false;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            area_basal_limite -= arv.area_basal;
                            if (area_basal_limite < -0.000000001)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                            if (parc.arvores.Count() == 0)
                            {
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, parc.arvores[0].area_parcela, parc.arvores[0].fila, parc.arvores[0].numero, parc.arvores[0].material_genetico);
                            auxiliar.adiciona_arvore(lixo);
                        }
                    }
                }
                auxiliar.set_dados();
                para_desbaste.Add(auxiliar);
            }
            return para_desbaste;
        }
        private List<Regiao> Seletivo_arvore(ref List<Regiao> regioes, double porcentagem)
        {
            ordena_dap(ref regioes);

            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in regioes)
            {
                Regiao auxiliar = new Regiao(reg.numero, produtos.Count());

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double arvores_limite = parc.arvores.Count() * porcentagem / 100;
                        bool tem_uma = false;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            arvores_limite--;
                            if (arvores_limite < 0)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                            if (parc.arvores.Count() == 0)
                            {
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, parc.arvores[0].area_parcela, parc.arvores[0].fila, parc.arvores[0].numero, parc.arvores[0].material_genetico);
                            auxiliar.adiciona_arvore(lixo);
                        }
                    }
                }
                auxiliar.set_dados();
                para_desbaste.Add(auxiliar);

            }
            return para_desbaste;
        }
        private List<Regiao> sistematico_arvore(ref List<Regiao> regioes, double porcentagem, int intervalo)
        {
            ordena_dap(ref regioes);
            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in regioes)
            {
                Regiao auxiliar = new Regiao(reg.numero, produtos.Count());

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double arvores_limite = parc.arvores.Count() * porcentagem / 100;
                        bool tem_uma = false;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            if (arv.fila % intervalo == 0)
                            {
                                arvores_limite--;
                                auxiliar.adiciona_arvore(arv);
                                parc.arvores.Remove(arv);
                                if (parc.arvores.Count() == 0)
                                {
                                    Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);
                                    parc.arvores.Add(lixo);
                                }
                                tem_uma = true;
                            }
                        }

                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            arvores_limite--;
                            if (arvores_limite < 0)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                            if (parc.arvores.Count() == 0)
                            {
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, parc.arvores[0].area_parcela, parc.arvores[0].fila, parc.arvores[0].numero, parc.arvores[0].material_genetico);
                            auxiliar.adiciona_arvore(lixo);
                        }
                    }
                }
                auxiliar.set_dados();
                para_desbaste.Add(auxiliar);
            }
            return para_desbaste;
        }
        private List<Regiao> sistematico_area_basal(ref List<Regiao> regioes, double porcentagem, int intervalo)
        {
            ordena_dap(ref regioes);
            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in regioes)
            {
                Regiao auxiliar = new Regiao(reg.numero, produtos.Count());

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {

                        double area_basal_limite = parc.area_basal_total * porcentagem / 100;
                        bool tem_uma = false;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            if (arv.fila % intervalo == 0)
                            {
                                area_basal_limite -= arv.area_basal;
                                auxiliar.adiciona_arvore(arv);
                                parc.arvores.Remove(arv);
                                if (parc.arvores.Count() == 0)
                                {
                                    Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);
                                    parc.arvores.Add(lixo);
                                }
                                tem_uma = true;
                            }
                        }

                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            area_basal_limite -= arv.area_basal;
                            if (area_basal_limite < -0.000000001)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                            if (parc.arvores.Count() == 0)
                            {
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, arv.area_parcela, arv.fila, arv.numero, arv.material_genetico);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.idade, 0, 0, parc.numero, parc.arvores[0].area_parcela, parc.arvores[0].fila, parc.arvores[0].numero, parc.arvores[0].material_genetico);
                            auxiliar.adiciona_arvore(lixo);
                        }
                    }
                }
                auxiliar.set_dados();
                para_desbaste.Add(auxiliar);
            }
            return para_desbaste;
        }
        void ordena_dap(ref List<Regiao> inicial)
        {
            foreach (Regiao reg in inicial)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        parc.arvores = parc.arvores.OrderBy(x => x.dap).ToList();

                    }
                }
            }
        }

        private void gerar_volumes(ref List<Regiao> regioes)
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Arvore arv in parc.arvores)
                        {
                            /*Console.WriteLine("------------------------");
                            Console.WriteLine("Arvore de dap " + arv.dap + " e altura " + arv.altura);
                            */
                            int idade = (int)arv.idade;
                            double B0 = coeficientes.B0[idade];
                            double B1 = coeficientes.B1[idade];
                            double B2 = coeficientes.B2[idade];
                            double B3 = coeficientes.B3[idade];

                            double altura_atual = 0.10;

                            double d_aux = 0;
                            bool usar_d_aux = false;

                            foreach (Produto prod in produtos)
                            {
                                while (true)
                                {
                                    if (altura_atual + prod.l > arv.altura)
                                        break;

                                    double d1 = arv.dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_atual, B3) * Math.Pow(arv.altura, -B3)));
                                    double d2 = arv.dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_atual + prod.l, B3) * Math.Pow(arv.altura, -B3)));

                                    if (usar_d_aux)
                                    {
                                        if (d_aux >= prod.max || d_aux < prod.min)
                                            break;
                                        usar_d_aux = false;
                                    }
                                    else if (d2 >= prod.max || d2 < prod.min)
                                    {
                                        usar_d_aux = true;
                                        d_aux = d2;
                                        break;
                                    }

                                    //        Console.WriteLine("Gerou tora do produto " + prod.numero);
                                    parc.volume[prod.numero] += gerar_tora(arv.dap, arv.altura, altura_atual, prod.l, B0, B1, B2, B3, parc.area_parcela);

                                    altura_atual += prod.l;
                                    //Console.WriteLine("e foi para a altura atual de " + altura_atual);
                                }
                                if (altura_atual + prod.l > arv.altura)
                                {
                                    break;
                                }
                            }
                        }
                    }
                }
            }
        }
        private double gerar_tora(double dap, double altura_arvore, double altura_inicial, double l, double B0, double B1, double B2, double B3, double area_parcela)
        {
            double volume = 0;
            for (double i = 0.1; i < l; i += 0.1)
            {
                double d1 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i - 0.1, B3) * Math.Pow(altura_arvore, -B3)));
                double d2 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i, B3) * Math.Pow(altura_arvore, -B3)));

                double as1 = Math.PI * Math.Pow(d1, 2) / 40000;
                double as2 = Math.PI * Math.Pow(d2, 2) / 40000;

                volume += (as1 + as2) * 0.1 / 2;
                //Console.WriteLine(i + " " + (i+0.1) + " " + l + " " +  (i+0.1 == l));
                //Console.WriteLine("Volume gerado entre as alturas: " + (altura_inicial + i - 0.1) + " e " + (altura_inicial + i) + " = " + ((as1 + as2) * 0.1 / 2));    
                if (i + 0.10 >= l)
                {
                    double diferenca = l - i;
                    i = l;
                    d1 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i - diferenca, B3) * Math.Pow(altura_arvore, -B3)));
                    d2 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i, B3) * Math.Pow(altura_arvore, -B3)));

                    as1 = Math.PI * Math.Pow(d1, 2) / 40000;
                    as2 = Math.PI * Math.Pow(d2, 2) / 40000;

                    volume += (as1 + as2) * diferenca / 2;
                    //Console.WriteLine("Volume gerado entre as alturas: " + (i - diferenca + altura_inicial) + " e " + (i + altura_inicial) + " = " + ((as1 + as2) * diferenca / 2));

                    break;
                }
            }

            volume = (volume / area_parcela) * 10000;

            return volume;
        }
        private void gerar_lucros(ref List<Regiao> regioes, bool corte_final)
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Produto prod in produtos)
                        {
                            if (corte_final)
                                parc.lucro[prod.numero] = parc.volume[prod.numero] * (prod.preco - custos[(int)parc.idade].cortefinal);
                            else
                                parc.lucro[prod.numero] = parc.volume[prod.numero] * (prod.preco - custos[(int)parc.idade].desbaste);

                        }
                    }
                }
            }
        }
        private void gerar_IMA(ref List<Regiao> regioes_desbaste, ref List<Regiao> regioes_corte_final)
        {
            for (int indice_Regiao = 0; indice_Regiao < regioes_desbaste.Count(); indice_Regiao++)
            {
                for (int indice_Talhao = 0; indice_Talhao < regioes_desbaste[indice_Regiao].talhoes.Count(); indice_Talhao++)
                {
                    for (int Indice_Parcela = 0; Indice_Parcela < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas.Count(); Indice_Parcela++)
                    {
                        for (int i = 1; i < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume.Count(); i++)
                        {
                            regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima += regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume[i];
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima += regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume[i];
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima += regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume[i];
                        }
                        regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima /= regioes_desbaste[indice_Regiao].idade;
                        regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima /= regioes_corte_final[indice_Regiao].idade;
                    }
                }
            }
        }
        private void gerar_IMA(ref List<Regiao> regioes)
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        for (int i = 1; i < parc.volume.Count(); i++)
                        {
                            parc.ima += parc.volume[i];
                        }
                        parc.ima /= parc.idade;
                    }
                }

            }

        }



        private void gerar_VPL(ref List<Regiao> regioes_desbaste, ref List<Regiao> regioes_corte_final)
        {
            for (int indice_Regiao = 0; indice_Regiao < regioes_desbaste.Count(); indice_Regiao++)
            {
                for (int indice_Talhao = 0; indice_Talhao < regioes_desbaste[indice_Regiao].talhoes.Count(); indice_Talhao++)
                {
                    for (int Indice_Parcela = 0; Indice_Parcela < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas.Count(); Indice_Parcela++)
                    {
                        for (int i = 1; i < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].lucro.Count(); i++)
                        {
                            double receita = regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].lucro[i];
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl += calcular_VPL(receita, taxa_juros, regioes_desbaste[indice_Regiao].idade);
                            receita = regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].lucro[i];
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl += calcular_VPL(receita, taxa_juros, regioes_corte_final[indice_Regiao].idade);
                        }

                        regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl -= custos[0].implantacao;

                        for (int idade = 1; idade <= regioes_corte_final[indice_Regiao].idade; idade++)
                        {
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl -= calcular_VPL(custos[idade].manutencao, taxa_juros, idade);
                        }
                    }
                }
            }
        }

        private void gerar_VPL(ref List<Regiao> regioes)
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        for (int i = 1; i < parc.lucro.Count(); i++)
                        {
                            parc.vpl += calcular_VPL(parc.lucro[i], taxa_juros, parc.idade);
                        }

                        parc.vpl -= custos[0].implantacao;
                        for (int idade = 1; idade <= parc.idade; idade++)
                        {
                            parc.vpl -= calcular_VPL(custos[idade].manutencao, taxa_juros, idade);
                        }
                    }
                }
            }
        }



        private double calcular_VPL(double receita, double i, double intervalo)
        {
            return receita * Math.Pow((1 + i), -intervalo);
        }


        private void gerar_VAE_infinito_vet(ref List<Regiao> regioes)
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        parc.vae = calcular_VAE(parc.vpl, taxa_juros, parc.idade);
                        parc.vpl_infinito = calcular_VPL_infinito(parc.vae, taxa_juros);
                        parc.vet = calcular_VET(parc.vpl, taxa_juros, parc.idade);
                    }
                }

            }

        }



        private double calcular_VAE(double vpl, double i, double intervalo)
        {
            return (vpl * i) / (1 - Math.Pow(1 + i, -intervalo));
        }
        private double calcular_VPL_infinito(double vae, double i)
        {
            return vae / i;
        }
        private double calcular_VET(double vpl, double i, double intervalo)
        {
            return vpl / Math.Pow((1 + i), (intervalo - 1));
        }

        private Cenario_Parcela gerar_cenario(ref List<Regiao> regioes_desbaste, ref List<Regiao> regioes_corte_final, double porcentagem)
        {
            Cenario_Parcela cenario = new Cenario_Parcela();
            for (int indice_Regiao = 0; indice_Regiao < regioes_desbaste.Count(); indice_Regiao++)
            {
                for (int indice_Talhao = 0; indice_Talhao < regioes_desbaste[indice_Regiao].talhoes.Count(); indice_Talhao++)
                {
                    for (int Indice_Parcela = 0; Indice_Parcela < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas.Count(); Indice_Parcela++)
                    {
                        cenario.regiao.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].regiao);
                        cenario.talhao.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].talhao);
                        cenario.parcela.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].numero);
                        cenario.idade.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].idade);
                        cenario.porcentagem.Add(porcentagem.ToString());
                        cenario.media_dap.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].dap_medio);
                        cenario.media_altura.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].altura_media);
                        cenario.volumes.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume);
                        cenario.IMA.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima);
                        cenario.VPL.Add(-1);
                        cenario.VAE.Add(-1);
                        cenario.VPL_infinito.Add(-1);
                        cenario.VET.Add(-1);


                        cenario.regiao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].regiao);
                        cenario.talhao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].talhao);
                        cenario.parcela.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].numero);
                        cenario.idade.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].idade);
                        cenario.porcentagem.Add(porcentagem.ToString());
                        cenario.media_dap.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].dap_medio);
                        cenario.media_altura.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].altura_media);
                        cenario.volumes.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume);
                        cenario.IMA.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].ima);
                        cenario.VPL.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl);
                        cenario.VAE.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vae);
                        cenario.VPL_infinito.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl_infinito);
                        cenario.VET.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vet);
                        cenario.vpl_sort += regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl_infinito;
                    }
                }
            }

            return cenario;
        }
        private Cenario_Parcela gerar_cenario(ref List<Regiao> regioes)
        {
            Cenario_Parcela cenario = new Cenario_Parcela();
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        cenario.regiao.Add(parc.regiao);
                        cenario.talhao.Add(parc.talhao);
                        cenario.parcela.Add(parc.numero);
                        cenario.idade.Add(parc.idade);
                        cenario.porcentagem.Add("-");
                        cenario.media_dap.Add(parc.dap_medio);
                        cenario.media_altura.Add(parc.altura_media);
                        cenario.volumes.Add(parc.volume);
                        cenario.IMA.Add(parc.ima);
                        cenario.VPL.Add(parc.vpl);
                        cenario.VAE.Add(parc.vae);
                        cenario.VPL_infinito.Add(parc.vpl_infinito);
                        cenario.VET.Add(parc.vet);
                        cenario.vpl_sort += parc.vpl_infinito;
                    }
                }
            }
            return cenario;
        }

        private Cenario_Talhao gerar_talhao(ref List<Regiao> regioes_desbaste, ref List<Regiao> regioes_corte_final, double porcentagem)
        {
            foreach (Regiao reg in regioes_desbaste)
                reg.set_dados();

            foreach (Regiao reg in regioes_corte_final)
            {
                reg.set_dados();
            }

            Cenario_Talhao cenario = new Cenario_Talhao();
            for (int indice_Regiao = 0; indice_Regiao < regioes_desbaste.Count(); indice_Regiao++)
            {
                for (int indice_Talhao = 0; indice_Talhao < regioes_desbaste[indice_Regiao].talhoes.Count(); indice_Talhao++)
                {
                    cenario.regiao.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].regiao);
                    cenario.talhao.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].numero);
                    cenario.idade.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].idade);
                    cenario.porcentagem.Add(porcentagem.ToString());
                    cenario.media_dap.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].dap_medio);
                    cenario.media_altura.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].altura_media);
                    cenario.volumes.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].volume);
                    cenario.IMA.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].ima);
                    cenario.VPL.Add(-1);
                    cenario.VAE.Add(-1);
                    cenario.VPL_infinito.Add(-1);
                    cenario.VET.Add(-1);

                    cenario.regiao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].regiao);
                    cenario.talhao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].numero);
                    cenario.idade.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].idade);
                    cenario.porcentagem.Add(porcentagem.ToString());
                    cenario.media_dap.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].dap_medio);
                    cenario.media_altura.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].altura_media);
                    cenario.volumes.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].volume);
                    cenario.IMA.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].ima);
                    cenario.VPL.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl);
                    cenario.VAE.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vae);
                    cenario.VPL_infinito.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl_infinito);
                    cenario.VET.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vet);
                    cenario.vpl_sort += regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl_infinito;
                }
            }

            return cenario;
        }
        private Cenario_Talhao gerar_talhao(ref List<Regiao> regioes)
        {
            foreach (Regiao reg in regioes)
            {
                reg.set_dados();
            }
            foreach (Regiao reg in regioes)
            {
                reg.set_dados();
            }

            Cenario_Talhao cenario = new Cenario_Talhao();
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    cenario.regiao.Add(tal.regiao);
                    cenario.talhao.Add(tal.numero);
                    cenario.idade.Add(tal.idade);
                    cenario.porcentagem.Add("-");
                    cenario.media_dap.Add(tal.dap_medio);
                    cenario.media_altura.Add(tal.altura_media);
                    cenario.volumes.Add(tal.volume);
                    cenario.IMA.Add(tal.ima);
                    cenario.VPL.Add(tal.vpl);
                    cenario.VAE.Add(tal.vae);
                    cenario.VPL_infinito.Add(tal.vpl_infinito);
                    cenario.VET.Add(tal.vet);
                    cenario.vpl_sort += tal.vpl_infinito;
                }
            }
            return cenario;
        }


        private void simular(double idade_desbaste, double idade_corte_final, double porcentagem, ref List<Cenario_Parcela> parcela_final, ref List<Cenario_Talhao> talhao_final)
        {
            List<Regiao> regioes = new List<Regiao>();
            clonar(ref regioes_original, ref regioes);
            projetar_idade(ref regioes, idade_desbaste);
            List<Regiao> desbastadas = desbaste(ref regioes, porcentagem);
            gerar_volumes(ref desbastadas);
            gerar_lucros(ref desbastadas, false);
            projetar_idade(ref regioes, idade_corte_final);
            gerar_volumes(ref regioes);
            gerar_lucros(ref regioes, true);
            gerar_IMA(ref desbastadas, ref regioes);
            gerar_VPL(ref desbastadas, ref regioes);
            gerar_VAE_infinito_vet(ref regioes);
            parcela_final.Add(gerar_cenario(ref desbastadas, ref regioes, porcentagem));
            talhao_final.Add(gerar_talhao(ref desbastadas, ref regioes, porcentagem));
        }
        private void simular(double idade, ref List<Cenario_Parcela> parcela_final, ref List<Cenario_Talhao> talhao_final)
        {
            List<Regiao> regioes = new List<Regiao>();
            clonar(ref regioes_original, ref regioes);
            projetar_idade(ref regioes, idade);
            gerar_volumes(ref regioes);
            gerar_lucros(ref regioes, true);
            gerar_IMA(ref regioes);
            gerar_VPL(ref regioes);
            gerar_VAE_infinito_vet(ref regioes);
            parcela_final.Add(gerar_cenario(ref regioes));
            talhao_final.Add(gerar_talhao(ref regioes));
        }

        private void print_parcela(ref List<Cenario_Parcela> final_parcela, ref Microsoft.Office.Interop.Excel.Application Excel)
        {
            Excel.Worksheets[2].cells[1][1] = "Região";
            Excel.Worksheets[2].cells[2][1] = "Talhão";
            Excel.Worksheets[2].cells[3][1] = "Parcela";
            Excel.Worksheets[2].cells[4][1] = "Idade";
            Excel.Worksheets[2].cells[5][1] = "Porcentagem";
            Excel.Worksheets[2].cells[6][1] = "Media dap";
            Excel.Worksheets[2].cells[7][1] = "Media altura";
            int coluna = 8;
            for (int i = 0; i < produtos.Count(); i++)
            {
                Excel.Worksheets[2].cells[coluna][1] = "Volume " + produtos[i].nome;
                coluna++;
            }
            Excel.Worksheets[2].cells[coluna][1] = "IMA";
            Excel.Worksheets[2].cells[coluna + 1][1] = "VPL";
            Excel.Worksheets[2].cells[coluna + 2][1] = "VAE";
            Excel.Worksheets[2].cells[coluna + 3][1] = "VPL∞";
            Excel.Worksheets[2].cells[coluna + 4][1] = "VET";

            int linha = 2;

            final_parcela = final_parcela.OrderBy(x => -x.vpl_sort).ToList();
            foreach (Cenario_Parcela cenario in final_parcela)
            {
                for (int i = 0; i < cenario.regiao.Count(); i++)
                {
                    Excel.Worksheets[2].cells[1][linha] = cenario.regiao[i];
                    Excel.Worksheets[2].cells[2][linha] = cenario.talhao[i];
                    Excel.Worksheets[2].cells[3][linha] = cenario.parcela[i];
                    Excel.Worksheets[2].cells[4][linha] = cenario.idade[i];
                    Excel.Worksheets[2].cells[5][linha] = cenario.porcentagem[i];
                    Excel.Worksheets[2].cells[6][linha] = cenario.media_dap[i];
                    Excel.Worksheets[2].cells[7][linha] = cenario.media_altura[i];

                    coluna = 8;
                    for (int j = 1; j <= produtos.Count(); j++)
                    {
                        Excel.Worksheets[2].cells[coluna][linha] = cenario.volumes[i][j];
                        coluna++;
                    }

                    Excel.Worksheets[2].cells[coluna][linha] = cenario.IMA[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        Excel.Worksheets[2].cells[coluna + 1][linha] = "-";
                        Excel.Worksheets[2].cells[coluna + 2][linha] = "-";
                        Excel.Worksheets[2].cells[coluna + 3][linha] = "-";
                        Excel.Worksheets[2].cells[coluna + 4][linha] = "-";

                    }
                    else
                    {
                        Excel.Worksheets[2].cells[coluna + 1][linha] = cenario.VPL[i];
                        Excel.Worksheets[2].cells[coluna + 2][linha] = cenario.VAE[i];
                        Excel.Worksheets[2].cells[coluna + 3][linha] = cenario.VPL_infinito[i];
                        Excel.Worksheets[2].cells[coluna + 4][linha] = cenario.VET[i];
                    }
                    linha++;

                }
                linha++;
            }

        }

        private void print_talhao(ref List<Cenario_Talhao> final_talhao, ref Microsoft.Office.Interop.Excel.Application Excel)
        {
            Excel.Worksheets[1].cells[1][1] = "Região";
            Excel.Worksheets[1].cells[2][1] = "Talhão";
            Excel.Worksheets[1].cells[3][1] = "Idade";
            Excel.Worksheets[1].cells[4][1] = "Porcentagem";
            Excel.Worksheets[1].cells[5][1] = "Media dap";
            Excel.Worksheets[1].cells[6][1] = "Media altura";
            int coluna = 7;
            for (int i = 0; i < produtos.Count(); i++)
            {
                Excel.Worksheets[1].cells[coluna][1] = "Volume " + produtos[i].nome;
                coluna++;
            }
            Excel.Worksheets[1].cells[coluna][1] = "IMA";
            Excel.Worksheets[1].cells[coluna + 1][1] = "VPL";
            Excel.Worksheets[1].cells[coluna + 2][1] = "VAE";
            Excel.Worksheets[1].cells[coluna + 3][1] = "VPL∞";
            Excel.Worksheets[1].cells[coluna + 4][1] = "VET";

            int linha = 2;
            final_talhao = final_talhao.OrderBy(x => -x.vpl_sort).ToList();

            foreach (Cenario_Talhao cenario in final_talhao)
            {
                for (int i = 0; i < cenario.regiao.Count(); i++)
                {
                    Excel.Worksheets[1].cells[1][linha] = cenario.regiao[i];
                    Excel.Worksheets[1].cells[2][linha] = cenario.talhao[i];
                    Excel.Worksheets[1].cells[3][linha] = cenario.idade[i];
                    Excel.Worksheets[1].cells[4][linha] = cenario.porcentagem[i];
                    Excel.Worksheets[1].cells[5][linha] = cenario.media_dap[i];
                    Excel.Worksheets[1].cells[6][linha] = cenario.media_altura[i];

                    coluna = 7;
                    for (int j = 1; j <= produtos.Count(); j++)
                    {
                        Excel.Worksheets[1].cells[coluna][linha] = cenario.volumes[i][j];
                        coluna++;
                    }

                    Excel.Worksheets[1].cells[coluna][linha] = cenario.IMA[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        Excel.Worksheets[1].cells[coluna + 1][linha] = "-";
                        Excel.Worksheets[1].cells[coluna + 2][linha] = "-";
                        Excel.Worksheets[1].cells[coluna + 3][linha] = "-";
                        Excel.Worksheets[1].cells[coluna + 4][linha] = "-";

                    }
                    else
                    {
                        Excel.Worksheets[1].cells[coluna + 1][linha] = cenario.VPL[i];
                        Excel.Worksheets[1].cells[coluna + 2][linha] = cenario.VAE[i];
                        Excel.Worksheets[1].cells[coluna + 3][linha] = cenario.VPL_infinito[i];
                        Excel.Worksheets[1].cells[coluna + 4][linha] = cenario.VET[i];
                    }
                    linha++;

                }
                linha++;
            }

            Excel.Visible = true;
        }

        private void print_maximizaçao(ref List<Cenario_Talhao> final_talhao)
        {
            
            string path = Directory.GetCurrentDirectory();
            string pathString = System.IO.Path.Combine(path, "Função_de_maximização");
            System.IO.Directory.CreateDirectory(pathString);

            string pathVPL = System.IO.Path.Combine(path, "Função_de_maximização/VPL");
            System.IO.Directory.CreateDirectory(pathVPL);

            string pathVAE = System.IO.Path.Combine(path, "Função_de_maximização/VAE");
            System.IO.Directory.CreateDirectory(pathVAE);

            string pathVPL_infinito = System.IO.Path.Combine(path, "Função_de_maximização/VPL∞");
            System.IO.Directory.CreateDirectory(pathVPL_infinito);

            string pathVET = System.IO.Path.Combine(path, "Função_de_maximização/VET");
            System.IO.Directory.CreateDirectory(pathVET);

            StreamWriter txt = new StreamWriter(pathVPL + "/" + arquivo_saida + "_VPL.txt");

            for (int j = 0; j < 4; j++)
            {
                if (j == 1)
                {
                    txt = new StreamWriter(pathVAE + "/" + arquivo_saida + "_VAE.txt");
                }
                if (j == 2)
                {
                    txt = new StreamWriter(pathVPL_infinito + "/" + arquivo_saida + "_VPL∞.txt");
                }
                if (j == 3)
                {
                    txt = new StreamWriter(pathVET + "/" + arquivo_saida + "_VET.txt");
                }
                bool is_first = true;
                txt.Write("MAX = ");
                double idade_aux = 0;

                foreach (Cenario_Talhao cenario in final_talhao)
                {
                    for (int i = 0; i < cenario.regiao.Count(); i++)
                    {
                        if (!(cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1))
                        {
                            if (!is_first)
                            {
                                txt.Write(" + ");
                            }
                            if (j == 0)
                            txt.Write(cenario.VPL[i] + " * R" + cenario.regiao[i] + "_T" + cenario.talhao[i]);
                            if (j == 1)
                                txt.Write(cenario.VAE[i] + " * R" + cenario.regiao[i] + "_T" + cenario.talhao[i]);
                            if (j == 2)
                                txt.Write(cenario.VPL_infinito[i] + " * R" + cenario.regiao[i] + "_T" + cenario.talhao[i]);
                            if (j == 3)
                                txt.Write(cenario.VET[i] + " * R" + cenario.regiao[i] + "_T" + cenario.talhao[i]);
                            if (cenario.porcentagem[i] != "-")
                            {
                                txt.Write("_D" + idade_aux + "-" + cenario.porcentagem[i]);
                                if (desbaste_por == "Árvore")
                                {
                                    txt.Write("N");
                                }

                                if (desbaste_por == "Área basal")
                                {
                                    txt.Write("B");
                                }
                            }

                            txt.Write("_CR" + cenario.idade[i]);

                            is_first = false;
                        }
                        idade_aux = cenario.idade[i];
                    }
                }
            }
            txt.Close();

        }
        private void processamento()
        {
            Importar_produtos();                                 //exporta os dados de cada produto do xls
            Importar_arvores();                                  //exporta as arvores do xls
            Importar_coeficientes();                             //exporta os coeficientes do xls
            Importar_economica();                                //exporta os dados relacionado à simulação economica
            Importar_simulacoes();                               //exporta todos os dados que devem ser simulados

            List<Cenario_Parcela> Final_parcela = new List<Cenario_Parcela>();
            List<Cenario_Talhao> final_talhao = new List<Cenario_Talhao>();

            foreach (double desbaste in simulacoes.idade_desbaste)
            {
                foreach (double final in simulacoes.idade_corte_final)
                {
                    foreach (double porcentagem in simulacoes.porcentagem)
                    {
                        simular(desbaste, final, porcentagem, ref Final_parcela, ref final_talhao);
                        //break;
                    }
                    //break;
                }
                //break;
            }

            foreach (double idade in simulacoes.corte_raso)
            {
                simular(idade, ref Final_parcela, ref final_talhao);
            }

            var Excel = new Microsoft.Office.Interop.Excel.Application();
            Excel.Workbooks.Add();
            Excel.Worksheets.Add();

            Excel.Workbooks[1].Worksheets[1].Name = "Talhão";
            Excel.Workbooks[1].Worksheets[2].Name = "Parcela";
            
            var aux = Excel.Workbooks.Item[1];


            string path = Directory.GetCurrentDirectory();
            string pathString = System.IO.Path.Combine(path, "Simulações");
            System.IO.Directory.CreateDirectory(pathString);

            //string path = System.IO.Path.Combine(path, "Função_de_maximização/VPL");
            //System.IO.Directory.CreateDirectory(pathVPL);
            Console.WriteLine(pathString + "/" + arquivo_saida);

            Excel.Workbooks[1].SaveAs(pathString + "/" + arquivo_saida);

            print_parcela(ref Final_parcela, ref Excel);
            print_talhao(ref final_talhao, ref Excel);

            print_maximizaçao(ref final_talhao);
            Excel.Visible = true;
              

         }

        
        private void button5_Click(object sender, EventArgs e)
        {
            /*try
            {*/
                processamento();
            /*}
            catch
            {
                const string message =
                "ERRO";
                const string caption = "ERRO";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }*/
            this.Text = "Entradas e premissas";

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            arquivo_saida = textBox3.Text;
        }
    }
}