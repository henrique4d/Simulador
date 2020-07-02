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


// multiplicar o volume por 10k e dividir pela area da parcela;
// desbaste sistematico (linha)
// converter metro cubico pra hectare
// lucro em 400... passar para 10000
// swap sistematico, seletivo
// porcentagem no sistematico whatever
// processar por talhao


namespace Simulador
{
    public partial class Form1 : Form
    {
        string arquivo_arvores;     // arquivo com os dados das árvores
        string arquivo_coeficientes;    // arquivo com os coeficientes
        string arquivo_produtos;    // arquivo com os produtos
        string arquivo_economico;   // arquivo com os dados economicos
        string arquivo_simulacoes;


        List<Regiao> regioes_original;  // armazena as arvores em estado original
        Coeficientes coeficientes;  //armazena os coeficientes
        List<Produto> produtos;     // armazena dados dos produtos
        List<Custos> custos;   // armazena os custos economicos
        Simulacoes simulacoes;
        string tipo_desbaste;   // tipo de desbaste
        string desbaste_por;
        int intervalo_sistematico;     // intervalo de corte para o desbaste seletivo
        double taxa_juros;

        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_arvores = excel.FileName;
            if ( arquivo_arvores != null)
            CarregaDadosExcel(arquivo_arvores);
        }
        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {
            processamento();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_produtos = excel.FileName;
            
            if (arquivo_produtos != null)
            CarregaDadosExcel(arquivo_produtos);

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_coeficientes = excel.FileName;
            if (arquivo_coeficientes != null)
            CarregaDadosExcel(arquivo_coeficientes);

        }
        private void button1_Click_2(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_economico = excel.FileName;
            if (arquivo_economico != null)
            CarregaDadosExcel(arquivo_economico);

        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tipo_desbaste = comboBox1.Text;
            if (comboBox1.Text == "SELETIVO")
            {
                textBox1.Visible = false;
            }
            if (comboBox1.Text == "MISTO")
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
            intervalo_sistematico = int.Parse(textBox1.Text);
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            taxa_juros = double.Parse(textBox2.Text);
        }
        private void button3_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo_simulacoes = excel.FileName;
            if (arquivo_simulacoes != null)
            CarregaDadosExcel(arquivo_simulacoes);

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
                int numero = int.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString());
                double min = double.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString());
                double max = double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString());
                double l = double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString());
                double preco = double.Parse(planilha.Cell("E" + linha.ToString()).Value.ToString());
                Produto aux = new Produto(numero, min, max, l, preco);
                produtos.Add(aux);
            }
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
        }
        private void Importar_coeficientes()
        {
            coeficientes = new Coeficientes();
            var excel = new XLWorkbook(arquivo_coeficientes);
            var planilha = excel.Worksheet(1);
            coeficientes.B0_dap = double.Parse(planilha.Cell("B" + 2.ToString()).Value.ToString());
            coeficientes.B1_dap = double.Parse(planilha.Cell("C" + 2.ToString()).Value.ToString());
            coeficientes.B0_altura = double.Parse(planilha.Cell("D" + 2.ToString()).Value.ToString());
            coeficientes.B1_altura = double.Parse(planilha.Cell("E" + 2.ToString()).Value.ToString());

            coeficientes.B0 = new List<double>();
            coeficientes.B1 = new List<double>();
            coeficientes.B2 = new List<double>();
            coeficientes.B3 = new List<double>();

            for (int linha = 4; ; linha++)          //percorre o xls
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

        }
        private void Importar_simulacoes()
        {
            var excel = new XLWorkbook(arquivo_simulacoes);
            var planilha = excel.Worksheet(1);

            simulacoes = new Simulacoes();
            simulacoes.idade_corte_final = new List<double>();
            simulacoes.idade_desbaste = new List<double>();
            simulacoes.porcentagem = new List<double>();

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
            foreach (Regiao reg in nova)
            {
                reg.set_dados();
            }
        }
        private void projetar_idade( ref List<Regiao> regioes, double idade )
        {
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Arvore arv in parc.arvores)
                        {
                            arv.dap = simula_dap(arv.idade, idade, arv.dap, coeficientes.B0_dap, coeficientes.B1_dap);
                            arv.altura = simula_altura(arv.idade, idade, arv.altura, coeficientes.B0_altura, coeficientes.B1_altura);
                            arv.area_basal = arv.area_basal = Math.PI * Math.Pow(arv.dap, 2) / 40000;
                            arv.idade = idade;
                        }

                    }
                }
            }
            foreach(Regiao reg in regioes)
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
        private double simula_altura( double idade1, double idade2, double altura1, double B1, double B2)
        {
            double altura2;
            altura2 = altura1 * Math.Exp(-B1 * (Math.Pow(idade2, B2) - Math.Pow(idade1, B2)));
            return altura2;
        }
        
        private List<Regiao> desbaste(ref List<Regiao> regioes, double porcentagem)
        {
    
            if (tipo_desbaste == "SELETIVO" && desbaste_por == "ÁRVORE" )
            {
                return seletivo_arvore(ref regioes, porcentagem);
            }
            if (tipo_desbaste == "SELETIVO" && desbaste_por == "ÁREA BASAL")
            {
                return seletivo_area_basal(ref regioes, porcentagem);
            }
            if (tipo_desbaste == "MISTO" && desbaste_por == "ÁRVORE")
            {
                return sistematico_arvore(ref regioes, porcentagem, intervalo_sistematico);
            }
            if (tipo_desbaste == "MISTO" && desbaste_por == "ÁREA BASAL")
            {
                return sistematico_area_basal(ref regioes, porcentagem, intervalo_sistematico);
            }
            return sistematico_area_basal(ref regioes, porcentagem, intervalo_sistematico);
        }
        private List <Regiao> seletivo_area_basal(ref List<Regiao> regioes, double porcentagem)
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
        private List <Regiao> seletivo_arvore(ref List<Regiao> regioes, double porcentagem)
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
                                area_basal_limite-= arv.area_basal;
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
                            area_basal_limite-= arv.area_basal;
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

                                    
                                    parc.volume[prod.numero] += gerar_tora(arv.dap,arv.altura,altura_atual,prod.l,B0,B1,B2,B3,parc.area_parcela);

                                    altura_atual += prod.l;
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
            for (double i=0.10; i<l; i+=0.10)
            {
                double d1 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i-0.10, B3) * Math.Pow(altura_arvore, -B3)));
                double d2 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i, B3) * Math.Pow(altura_arvore, -B3)));

                double as1 = Math.PI * Math.Pow(d1, 2) / 40000;
                double as2 = Math.PI * Math.Pow(d2, 2) / 40000;

                volume += (as1 + as2) * 0.10 / 2;
            
                if (i+0.10 >= l)
                {
                    double diferenca = l - i;
                    i = l;
                    d1 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i - diferenca, B3) * Math.Pow(altura_arvore, -B3)));
                    d2 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i, B3) * Math.Pow(altura_arvore, -B3)));

                    as1 = Math.PI * Math.Pow(d1, 2) / 40000;
                    as2 = Math.PI * Math.Pow(d2, 2) / 40000;

                    volume += (as1 + as2) * diferenca / 2;

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
                        for (int i=1; i < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].volume.Count(); i++)
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
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl -= calcular_VPL(custos[idade].manutencao, taxa_juros,idade);
                        }
                    }
                }
            }
        }
        private double calcular_VPL(double receita, double i, double intervalo)
        {
            return receita * Math.Pow((1 + i), - intervalo);
        }


        private void gerar_VAE_infinito(ref List<Regiao> regioes_corte_final)
        {
            for (int indice_Regiao = 0; indice_Regiao < regioes_corte_final.Count(); indice_Regiao++)
            {
                for (int indice_Talhao = 0; indice_Talhao < regioes_corte_final[indice_Regiao].talhoes.Count(); indice_Talhao++)
                {
                    for (int Indice_Parcela = 0; Indice_Parcela < regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas.Count(); Indice_Parcela++)
                    {
                        double vpl = regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl;
                        double idade = regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].idade;
                        regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vae = calcular_VAE(vpl, taxa_juros, idade);
                        double vae = regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vae;
                        regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl_infinito = calcular_VPL_infinito(vae, taxa_juros);
                    }
                }
            }
        }
        private double calcular_VAE(double vpl, double i, double intervalo)
        {
            return (vpl*i)/(1- Math.Pow(1+i,-intervalo));
        }

        private double calcular_VPL_infinito(double vae, double i)
        {
            return vae/i;
        }




        private void simular(double idade_desbaste, double idade_corte_final, double porcentagem)
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

            gerar_VAE_infinito(ref regioes);
        
            foreach (Regiao reg in regioes)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        Console.WriteLine(parc.vpl + "    " + parc.vae + "     " + parc.vpl_infinito);
                    }
                }
            }
        }
        private void processamento()
        {
            Importar_produtos();                                 //exporta os dados de cada produto do xls
            Importar_arvores();                                  //exporta as arvores do xls
            Importar_coeficientes();                             //exporta os coeficientes do xls
            Importar_economica();                                //exporta os dados relacionado à simulação economica
            Importar_simulacoes();                               //exporta todos os dados que devem ser simulados
            
            
            foreach (int desbaste in simulacoes.idade_desbaste)
            {
                foreach(int final in simulacoes.idade_corte_final)
                {
                    foreach( int porcentagem in simulacoes.porcentagem)
                    {
                        simular(desbaste, final, porcentagem);
                    }
                }
            }
        }

        
    }
}
