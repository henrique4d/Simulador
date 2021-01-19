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
using System.Security.AccessControl;
using System.Management;
using System.Management.Instrumentation;
using System.Security.Principal;
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
        string error;

        List<Regiao> regioes_original;  // armazena as arvores em estado original
        Coeficientes coeficientes;  //armazena os coeficientes
        List<Produto> produtos;     // armazena dados dos produtos
        List<Custos> custos;   // armazena os custos economicos
        Simulacoes simulacoes;
        string tipo_desbaste;   // tipo de desbaste
        string desbaste_por;
        int intervalo_sistematico;     // intervalo de corte para o desbaste Seletivo
        double taxa_juros;
        double horizonte;
        int N_planejamento;
        int N_regulacao;

        public BorderStyle BorderStyle { get; private set; }

        public Form1()
        {
            InitializeComponent();
            textBox3.Text = "Título";
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
            try
            {
                processamento();
            }
            catch
            {
                const string message =
                "ERRO";
                const string caption = "ERRO";

                MessageBox.Show(message, caption, MessageBoxButtons.OK);
            }
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
            textBox4.Visible = false;
            try
            {
                DataTable dt = getTabelaExcel(arquivo);
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.DataSource = dt;
                string[] listaNomeColunas = dt.Columns.OfType<DataColumn>().Select(x => x.ColumnName).ToArray();
                dt.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("erro :" + ex.Message);
            }
        }


        private void importar_produtos(){   //importa os produtos
            produtos = new List<Produto>(); //lista de produtos
            XLWorkbook excel;   //variavel que ira guardar o excel
            IXLWorksheet planilha;  //variavel que ira guardar a planilha
            try{
                excel = new XLWorkbook(arquivo_produtos);   //acessa o xls informado pelo usuario
                planilha = excel.Worksheet(1);  //acessa a primeira planilha do xls
            }
            catch{
                throw new Exception("Nao foi possivel acessar a planilha de sortimentos");  // excessao se nao foi possivel acessar o arquivo selecionado
            }
            int linha = 0;  //salva a linha atual
            char coluna = 'A';  //salva a coluna atual
            try{
                for (linha = 2; ; linha++){  //percorre as linhas da planilha
                    string confere = planilha.Cell(coluna + linha.ToString()).Value.ToString(); //confere se a planilha terminou
                    if (string.IsNullOrEmpty(confere)) break;   //se tiver terminado
                    string nome = planilha.Cell(coluna + linha.ToString()).Value.ToString();    //le o nome
                    coluna++;   //vai para a proxima coluna
                    double min = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());   //le o minimo daquele produto
                    if (min < 0) throw new Exception("Erro na planilha de sortimentos, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido"); //trata min < 0
                    coluna++;   //vai para a proxima coluna
                    double max = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());   //le o maximo daquele produto
                    if (max < 0) throw new Exception("Erro na planilha de sortimentos, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido"); //trata max < 0
                    if (max < min) throw new Exception("Erro na planilha de sortimentos, Coluna: " + coluna + " linha: " + linha + "\nmáximo nao pode ser menor que o mínimo"); //trata max < 0
                    coluna++;   //vai para a proxima coluna
                    double l = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString()); //le o L daquele produto
                    if (l <= 0) throw new Exception("Erro na planilha de sortimentos, Coluna: " + coluna + " linha: " + linha + "\nvalor deve ser maior que zero");    //trata l <= 0
                    coluna++;   //vai para a proxima coluna
                    double preco = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString()); //le o preço daquele produto
                    if (preco <= 0) throw new Exception("Erro na planilha de sortimentos, Coluna: " + coluna + " linha: " + linha + "\nvalor deve ser maior que zero");    //trata preco <= 0
                    Produto aux = new Produto(0, min, max, l, preco, nome); //cria o produto
                    produtos.Add(aux);  //adiciona ele na lista de produtos
                    coluna = 'A';   //volta para o inicio da linha
                }
            }
            catch{
                throw new Exception("Erro na planilha de sortimentos, Coluna: " + coluna + " linha: " + linha); //excessao se nao foi possivel ler os dados   
            }
            produtos = produtos.OrderBy(x => -x.max).ToList();  //ordena os produtos de acordo com o max ( consequentemente pelo min tambem )
            for (int i=0; i<produtos.Count(); i++)  //para cada produto
            {
                produtos[i].numero = i + 1; //seta o numero do produto
            }
            excel.Dispose();    //fecha o acesso ao excel
        }

        private void importar_arvores(){ // importa os dados de inventário
            regioes_original = new List<Regiao>();  //lista que ira armazenar as arvores
            XLWorkbook excel;   //variavel que ira guardar o excel
            IXLWorksheet planilha;  //variavel que ira guardar a planilha
            try{
                excel = new XLWorkbook(arquivo_arvores);    //acessa o xls informado pelo usuário
                planilha = excel.Worksheet(1);  //acessa a primeira planilha do xls
            }
            catch{
                throw new Exception("Nao foi possivel acessar a planilha dados de inventário");  //excessao se nao foi possivel acessar o arquivo selecionado
            }
            int linha = 0; //salva a linha atual
            char coluna = 'A'; //salva a coluna atual
            try{
                for (linha = 2; ; linha++){ //percorre as linhas da planilha
                    string confere = planilha.Cell(coluna + linha.ToString()).Value.ToString();    //confere se a planilha terminou
                    if (string.IsNullOrEmpty(confere)) break;   //se tiver terminado
                    string regiao = planilha.Cell(coluna + linha.ToString()).Value.ToString(); //le a região
                    coluna++; // vai para a proxima coluna
                    string talhao = planilha.Cell(coluna + linha.ToString()).Value.ToString(); //le o talhão
                    coluna++;   // vai para a proxima coluna
                    double area_talhao = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());  //le a area do talhão
                    Console.WriteLine(area_talhao);
                    if (area_talhao < 0) throw new Exception("Erro na planilha de dados de inventário, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido");    //trata area do talhão < 0
                    coluna++;   // vai para a proxima coluna
                    string parcela = planilha.Cell(coluna + linha.ToString()).Value.ToString();    //le a parcela
                    coluna++;   // vai para a proxima coluna
                    string material_genetico = planilha.Cell(coluna + linha.ToString()).Value.ToString();  //le o material genetico
                    coluna++;   // vai para a proxima coluna
                    double idade = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());    //le a idade
                    if (idade < 0) throw new Exception("Erro na planilha de dados de inventário, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido");    //trata idade < 0
                    coluna++;   // vai para a proxima coluna
                    double area_parcela = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString()); //le a área da parcela
                    if (area_parcela < 0) throw new Exception("Erro na planilha de dados de inventário, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido");    //trata area da parcela < 0
                    coluna++;   // vai para a proxima coluna
                    int fila = int.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());   //le a fila
                    coluna++;   // vai para a proxima coluna
                    int arv = int.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());    //le o numero da arvore
                    coluna++;   // vai para a proxima coluna
                    double dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());  //le o dap
                    if (dap < 0) throw new Exception("Erro na planilha de dados de inventário, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido");    //trata dap < 0
                    coluna++;   // vai para a proxima coluna
                    double altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());   //le a altura
                    if (altura < 0) throw new Exception("Erro na planilha de dados de inventário, Coluna: " + coluna + " linha: " + linha + "\nvalor negativo inválido");    //trata altura < 0
                    coluna = 'A';   //volta para o inicio da linha
                    if (dap == 0 && altura == 0) continue;  // ignora arvores morta
                    Arvore auxiliar = new Arvore(regiao, talhao,area_talhao,parcela,material_genetico, idade, area_parcela, fila, arv, dap, altura);    // cria a arvore

                    bool aux = false;   // verifica se ja foi criada a regiao daquela arvore
                    foreach (Regiao reg in regioes_original){
                        if (reg.numero == auxiliar.regiao){  // regiao ja foi criada
                            reg.adiciona_arvore(auxiliar);  // adiciona a arvore a regiao
                            aux = true;
                            break;
                        }
                    }
                    if (!aux){   // regiao nao foi criada
                        Regiao nova_regiao = new Regiao(auxiliar.regiao, produtos.Count());   // cria a nova regiao
                        nova_regiao.adiciona_arvore(auxiliar);  // adiciona a arvore a regiao
                        regioes_original.Add(nova_regiao); // adiciona a nova região a lista de regiões original
                    }
                }
            }
            catch(Exception ex){
                if (ex.Message == "A cadeia de caracteres de entrada não estava em um formato correto.")
                    throw new Exception("Erro na planilha de dados de inventário, Coluna: " + coluna + " linha: " + linha); //excessao se nao foi possivel ler os dados   
                else throw new Exception(ex.Message);
            }
            excel.Dispose();    //fecha o acesso ao xls
            foreach (Regiao reg in regioes_original){   //percorre as regiões
                reg.set_dados();    //setando os dados
            }
        }

        private void importar_coeficientes()
        {
            
            if (comboBox1.Text == "Misto")
            {
                if (textBox1.Text == "")
                {
                    intervalo_sistematico = 5;
                }
                else
                {
                    try
                    {
                        intervalo_sistematico = int.Parse(textBox1.Text);
                    }
                    catch
                    {
                        error = "número de fila para o desbaste misto inválido";
                        throw new CustomException("");
                    }
                }
            }
            if (textBox2.Text == "")
            {
                taxa_juros = 0.10;
            }
            else
            {
                try
                {
                    taxa_juros = double.Parse(textBox2.Text) / 100;
                }
                catch
                {
                    error = "taxa de juros inválida";
                    throw new CustomException("");
                }
            }
            coeficientes = new Coeficientes();
            XLWorkbook excel;
            try
            {
                excel = new XLWorkbook(arquivo_coeficientes);
            }
            catch
            {
                error = "Não foi possivel acessar a planilha de coeficientes - MAI";
                throw new CustomException("");
            }
            var planilha = excel.Worksheet(1);

            int linha = 2;
            char coluna = 'A';
            try
            {
                for (linha = 2; ; linha++)
                {
                    coluna = 'A';
                    string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                    if (string.IsNullOrEmpty(confere)) break;                                  // testa se o xls acabou
                    if (confere == "idade") break;

                    string Regiao = (planilha.Cell("A" + linha.ToString()).Value.ToString());
                
                    coluna = 'B';
                    string Talhao = (planilha.Cell("B" + linha.ToString()).Value.ToString());
                    
                    if (Regiao == "all")
                    {
                        foreach (Regiao reg in regioes_original)
                        {
                            foreach (Talhao tal in reg.talhoes)
                            {
                                coluna = 'C';
                                tal.B0_dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                coluna++;
                                tal.B1_dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                coluna++;
                                tal.B0_altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                coluna++;
                                tal.B1_altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                coluna = 'C';
                            }
                        }
                    }
                    else
                    {
                        foreach (Regiao reg in regioes_original)
                        {
                            if (reg.numero == Regiao)
                            {
                                if (Talhao == "all")
                                {
                                    foreach (Talhao tal in reg.talhoes)
                                    {
                                        coluna = 'C';
                                        tal.B0_dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                        coluna++;
                                        tal.B1_dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                        coluna++;
                                        tal.B0_altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                        coluna++;
                                        tal.B1_altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                        coluna = 'C';
                                    }
                                }
                                else
                                {
                                    foreach (Talhao tal in reg.talhoes)
                                    {
                                        if (tal.numero == Talhao)
                                        {
                                            coluna = 'C';
                                            tal.B0_dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                            coluna++;
                                            tal.B1_dap = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                            coluna++;
                                            tal.B0_altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                            coluna++;
                                            tal.B1_altura = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                                            coluna = 'C';
                                            break;
                                        }

                                    }
                                }

                                break;
                            }
                        }
                    }
                }
            
                coeficientes.B0 = new List<double>();
                coeficientes.B1 = new List<double>();
                coeficientes.B2 = new List<double>();
                coeficientes.B3 = new List<double>();

                linha++;
                coluna = 'A';
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
                    coluna++;
                    coeficientes.B0[idade] = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna++;
                    coeficientes.B1[idade] = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna++;
                    coeficientes.B2[idade] = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna++;
                    coeficientes.B3[idade] = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna = 'A';
                }
            }
            catch
            {
                error = "Erro na planilha de coeficientes - MAI, Coluna: " + coluna + " linha: " + linha.ToString();
                throw new CustomException("");
            }
            excel.Dispose();
        }
        private void importar_economica()
        {
            custos = new List<Custos>();
            XLWorkbook excel;
            try
            {
                excel = new XLWorkbook(arquivo_economico);
            }
            catch
            {
                error = "Não foi possível acessar a planilha de custos";
                throw new CustomException("");
            }
            var planilha = excel.Worksheet(1);
            int linha = 0;
            char coluna = 'A';
            try
            {
                for (linha = 2; ; linha++)
                {
                    string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                    if (string.IsNullOrEmpty(confere)) break;
                    int periodo = int.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString());
                    while (periodo >= custos.Count())
                    {
                        Custos aux = new Custos();
                        custos.Add(aux);
                    }
                    coluna++;
                    custos[periodo].implantacao = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna++;
                    custos[periodo].manutencao = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna++;
                    custos[periodo].desbaste = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna++;
                    custos[periodo].cortefinal = double.Parse(planilha.Cell(coluna + linha.ToString()).Value.ToString());
                    coluna = 'A';
                }
            }
            catch
            {
                error = "Erro na planilha de custos, Coluna: " + coluna + " linha: " + linha.ToString();
                throw new CustomException("");
            }
            excel.Dispose();
        }
        private void importar_simulacoes()
        {
            XLWorkbook excel;
            try
            {
                excel = new XLWorkbook(arquivo_simulacoes);
            }
            catch
            {
                error = "Não foi possível acessar a planilha de cenários";
                throw new CustomException("");
            }

            var planilha = excel.Worksheet(1);

            simulacoes = new Simulacoes();
            
            simulacoes.idade_corte_final = new List<double>();
            simulacoes.idade_desbaste = new List<double>();
            simulacoes.porcentagem = new List<double>();
            simulacoes.corte_raso = new List<double>();

            int linha = 2;
            char coluna = 'A';
            try
            {
                for (linha = 2; ; linha++)          //percorre o xls
                {
                    string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                    if (string.IsNullOrEmpty(confere)) break;
                    simulacoes.idade_desbaste.Add(double.Parse(planilha.Cell("A" + linha.ToString()).Value.ToString()));
                }
                coluna++;
                for (linha = 2; ; linha++)          //percorre o xls
                {
                    string confere = planilha.Cell("B" + linha.ToString()).Value.ToString();
                    if (string.IsNullOrEmpty(confere)) break;
                    simulacoes.idade_corte_final.Add(double.Parse(planilha.Cell("B" + linha.ToString()).Value.ToString()));
                }
                coluna++;
                for (linha = 2; ; linha++)          //percorre o xls
                {
                    string confere = planilha.Cell("C" + linha.ToString()).Value.ToString();
                    if (string.IsNullOrEmpty(confere)) break;
                    simulacoes.porcentagem.Add(double.Parse(planilha.Cell("C" + linha.ToString()).Value.ToString()));
                }
                coluna++;

                for (linha = 2; ; linha++)          //percorre o xls
                {
                    string confere = planilha.Cell("D" + linha.ToString()).Value.ToString();
                    if (string.IsNullOrEmpty(confere)) break;
                    simulacoes.corte_raso.Add(double.Parse(planilha.Cell("D" + linha.ToString()).Value.ToString()));
                }
            }
            catch
            {
                error = "Erro na planilha de cenários, coluna: " + coluna + " linha: " + linha.ToString();
                throw new CustomException("");
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
                            Arvore projetada = new Arvore(arv.regiao, arv.talhao, arv.area_talhao, arv.parcela, arv.material_genetico, arv.idade, arv.area_parcela, arv.fila, arv.numero, arv.dap, arv.altura);

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
                            arv.area_basal = Math.PI * Math.Pow(arv.dap, 2) / 40000;
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
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao,parc.area_talhao,parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
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
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
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
                                    Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
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
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
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
                                    Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
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
                                Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
                                parc.arvores.Add(lixo);
                            }
                            tem_uma = true;
                        }
                        if (!tem_uma)
                        {
                            Arvore lixo = new Arvore(parc.regiao, parc.talhao, parc.area_talhao, parc.numero, parc.material_genetico, 0, parc.area_parcela, 0, 0, 0, 0);
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

                                    parc.volume[prod.numero] += gerar_tora(arv.dap, arv.altura, altura_atual, prod.l, B0, B1, B2, B3, parc.area_parcela);

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
            for (double i = 0.1; i < l; i += 0.1)
            {
                double d1 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i - 0.1, B3) * Math.Pow(altura_arvore, -B3)));
                double d2 = dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_inicial + i, B3) * Math.Pow(altura_arvore, -B3)));

                double as1 = Math.PI * Math.Pow(d1, 2) / 40000;
                double as2 = Math.PI * Math.Pow(d2, 2) / 40000;

                volume += (as1 + as2) * 0.1 / 2;
                if (i + 0.10 >= l)
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
                        double idade_original = regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].idade_original;

                        for (int i = 1; i < regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].lucro.Count(); i++)
                        {

                            double receita = regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].lucro[i];
                            
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl += calcular_VPL(receita, taxa_juros, regioes_desbaste[indice_Regiao].idade);
                            
                            receita = regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].lucro[i];
                            
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl += calcular_VPL(receita, taxa_juros, regioes_corte_final[indice_Regiao].idade);
                        }

                        for (int idade = 0; idade < regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].idade; idade++)
                        {
                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl -= calcular_VPL(custos[idade].manutencao, taxa_juros, idade);

                            regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl -= calcular_VPL(custos[idade].implantacao, taxa_juros, idade);
                        }

                        regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl2 = 0;
                        regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl2 -= calcular_VPL(custos[0].implantacao, taxa_juros, - idade_original); ;
                       
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

                        for (int idade = 0; idade < parc.idade; idade++)
                        {
                            parc.vpl -= calcular_VPL(custos[idade].manutencao, taxa_juros, idade);
                            parc.vpl -= calcular_VPL(custos[idade].implantacao, taxa_juros, idade);
                        }

                        parc.vpl2 = 0;
                        parc.vpl2 -= calcular_VPL(custos[0].implantacao, taxa_juros, -parc.idade_original);
                            
                        int idade_corte_final = (int)parc.idade;
                        double receita = 0;
                            
                        for (int i=1; i<parc.lucro.Count(); i++)
                        {
                            receita += parc.lucro[i];
                        }
                      
                        int idade_aux = 1;
                        for (int idade_atual = 1; idade_atual<= horizonte +parc.idade_original; idade_atual++)
                        {
                            if (idade_aux % idade_corte_final == 0)
                            {
                                parc.vpl2 += calcular_VPL(receita, taxa_juros, idade_atual - parc.idade_original);
                                if (idade_atual + idade_corte_final > horizonte + parc.idade_original)
                                {
                                    parc.vae2 = calcular_VAE(parc.vpl2, taxa_juros, idade_atual - parc.idade_original);
                                    parc.vpl_infinito2 = calcular_VPL_infinito(parc.vae2, taxa_juros);
                                    parc.vet2 = calcular_VET(parc.vpl2, taxa_juros, idade_atual - parc.idade_original);
                                    break;
                                }
                                idade_aux = 1;
                                continue;
                            }
                            parc.vpl2 -= calcular_VPL(custos[idade_aux].manutencao, taxa_juros, idade_atual - parc.idade_original);
                            idade_aux++;
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
                        cenario.VPL2.Add(-1);

                        cenario.VAE.Add(-1);
                        cenario.VAE2.Add(-1);

                        cenario.VPL_infinito.Add(-1);
                        cenario.VPL_infinito2.Add(-1);

                        cenario.VET.Add(-1);
                        cenario.VET2.Add(-1);


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
                        cenario.VPL2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl2);

                        cenario.VAE.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vae);
                        cenario.VAE2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vae2);

                        cenario.VPL_infinito.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl_infinito);
                        cenario.VPL_infinito2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vpl_infinito2);

                        cenario.VET.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vet);
                        cenario.VET2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[Indice_Parcela].vet2);
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
                        cenario.VPL2.Add(parc.vpl2);
                        cenario.VAE.Add(parc.vae);
                        cenario.VAE2.Add(parc.vae2);

                        cenario.VPL_infinito.Add(parc.vpl_infinito);
                        cenario.VPL_infinito2.Add(parc.vpl_infinito2);


                        cenario.VET.Add(parc.vet);
                        cenario.VET2.Add(parc.vet2);

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
                    cenario.area_talhao.Add(regioes_desbaste[indice_Regiao].talhoes[indice_Talhao].area_talhao);
                    cenario.VPL.Add(-1);
                    cenario.VPL2.Add(-1);

                    cenario.VAE.Add(-1);
                    cenario.VAE2.Add(-1);

                    cenario.VPL_infinito.Add(-1);
                    cenario.VPL_infinito2.Add(-1);

                    cenario.VET.Add(-1);
                    cenario.VET2.Add(-1);

                    cenario.regiao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].regiao);
                    cenario.talhao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].numero);
                    cenario.idade.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].idade);
                    cenario.porcentagem.Add(porcentagem.ToString());
                    cenario.media_dap.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].dap_medio);
                    cenario.media_altura.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].altura_media);
                    cenario.volumes.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].volume);
                    cenario.IMA.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].ima);
                    cenario.area_talhao.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].area_talhao);

                    cenario.VPL.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl);
                    cenario.VPL2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl2);

                    
                    cenario.VAE.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vae);
                    cenario.VAE2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vae2);

                    cenario.VPL_infinito.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl_infinito);
                    cenario.VPL_infinito2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vpl_infinito2);

                    cenario.VET.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vet);
                    cenario.VET2.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].vet2);

                    cenario.idade_original.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[0].idade_original);
                    cenario.idade_original.Add(regioes_corte_final[indice_Regiao].talhoes[indice_Talhao].parcelas[0].idade_original);

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
                    cenario.VPL2.Add(tal.vpl2);
                    cenario.area_talhao.Add(tal.area_talhao);
                    cenario.VAE.Add(tal.vae);
                    cenario.VAE2.Add(tal.vae2);

                    cenario.VPL_infinito.Add(tal.vpl_infinito);
                    cenario.VPL_infinito2.Add(tal.vpl_infinito2);



                    cenario.VET.Add(tal.vet);
                    cenario.VET2.Add(tal.vet2);
                    cenario.idade_original.Add(tal.parcelas[0].idade_original);
                    cenario.vpl_sort += tal.vpl_infinito;
                }
            }
            return cenario;
        }


        private void simular(double idade_desbaste, double idade_corte_final, double porcentagem, ref List<Cenario_Parcela> parcela_final, ref List<Cenario_Talhao> talhao_final)
        {
            List<Regiao> regioes = new List<Regiao>();
            clonar(ref regioes_original, ref regioes);
            try
            {
                projetar_idade(ref regioes, idade_desbaste);
            }
            catch
            {
                error = "erro ao projetar para a idade de desbaste";
                throw new CustomException("");
            }

            List<Regiao> desbastadas = null;
            try
            {
                desbastadas = desbaste(ref regioes, porcentagem);
            }
            catch
            {
                error = "erro ao realizar o desbaste";
                throw new CustomException("");
            }
            try
            {
                gerar_volumes(ref desbastadas);
            }
            catch
            {
                error = "erro ao gerar volumes de desbaste";
                throw new CustomException("");
            }
            try
            {
                gerar_lucros(ref desbastadas, false);
            }
            catch 
            {
                error = "erro ao gerar receita no desbaste";
                throw new CustomException("");
            }
            try
            {
                projetar_idade(ref regioes, idade_corte_final);
            }
            catch
            {
                error = "erro ao projetar para a idade de corte raso";
                throw new CustomException("");
            }
            try
            {
                gerar_volumes(ref regioes);
            }
            catch
            {
                error = "erro ao gerar volumes no corte raso";
                throw new CustomException("");
            }
            try
            {
                gerar_lucros(ref regioes, true);
            }
            catch
            {
                error = "erro ao gerar receita no corte raso";
                throw new CustomException("");
            }
            try
            {
                gerar_IMA(ref desbastadas, ref regioes);
            }
            catch
            {
                error = "erro ao gerar IMA";
                throw new CustomException("");
            }
            try
            {
                gerar_VPL(ref desbastadas, ref regioes);
            }
            catch
            {
                error = "erro ao gerar VPL";
                throw new CustomException("");
            }
            try
            {
                gerar_VAE_infinito_vet(ref regioes);
            }
            catch 
            {
                error = "erro ao gerar dados econômicos";
                throw new CustomException("");
            }
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
            Excel.Worksheets[2].cells[coluna][1] = "Volume total";

            Excel.Worksheets[2].cells[coluna + 1][1] = "IMA";
            Excel.Worksheets[2].cells[coluna + 2][1] = "VPL";
            Excel.Worksheets[2].cells[coluna + 3][1] = "VAE";
            Excel.Worksheets[2].cells[coluna + 4][1] = "VPL∞";
            Excel.Worksheets[2].cells[coluna + 5][1] = "VET";

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
                    double total = 0;

                    for (int j = 1; j <= produtos.Count(); j++)
                    {
                        Excel.Worksheets[2].cells[coluna][linha] = cenario.volumes[i][j];
                        total = cenario.volumes[i][j];
                        coluna++;
                    }

                    Excel.Worksheets[2].cells[coluna][linha] = total;

                    Excel.Worksheets[2].cells[coluna + 1][linha] = cenario.IMA[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        Excel.Worksheets[2].cells[coluna + 2][linha] = "-";
                        Excel.Worksheets[2].cells[coluna + 3][linha] = "-";
                        Excel.Worksheets[2].cells[coluna + 4][linha] = "-";
                        Excel.Worksheets[2].cells[coluna + 5][linha] = "-";

                    }
                    else
                    {
                        Excel.Worksheets[2].cells[coluna + 2][linha] = cenario.VPL[i];
                        Excel.Worksheets[2].cells[coluna + 3][linha] = cenario.VAE[i];
                        Excel.Worksheets[2].cells[coluna + 4][linha] = cenario.VPL_infinito[i];
                        Excel.Worksheets[2].cells[coluna + 5][linha] = cenario.VET[i];
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
            Excel.Worksheets[1].cells[coluna][1] = "Volume total";

            Excel.Worksheets[1].cells[coluna + 1][1] = "IMA";
            Excel.Worksheets[1].cells[coluna + 2][1] = "VPL";
            Excel.Worksheets[1].cells[coluna + 3][1] = "VAE";
            Excel.Worksheets[1].cells[coluna + 4][1] = "VPL∞";
            Excel.Worksheets[1].cells[coluna + 5][1] = "VET";

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
                    double total = 0;
                    for (int j = 1; j <= produtos.Count(); j++)
                    {
                        Excel.Worksheets[1].cells[coluna][linha] = cenario.volumes[i][j];
                        total += cenario.volumes[i][j];
                        coluna++;
                    }

                    Excel.Worksheets[1].cells[coluna][linha] = total;

                    Excel.Worksheets[1].cells[coluna + 1][linha] = cenario.IMA[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        Excel.Worksheets[1].cells[coluna + 2][linha] = "-";
                        Excel.Worksheets[1].cells[coluna + 3][linha] = "-";
                        Excel.Worksheets[1].cells[coluna + 4][linha] = "-";
                        Excel.Worksheets[1].cells[coluna + 5][linha] = "-";

                    }
                    else
                    {
                        Excel.Worksheets[1].cells[coluna + 2][linha] = cenario.VPL[i];
                        Excel.Worksheets[1].cells[coluna + 3][linha] = cenario.VAE[i];
                        Excel.Worksheets[1].cells[coluna + 4][linha] = cenario.VPL_infinito[i];
                        Excel.Worksheets[1].cells[coluna + 5][linha] = cenario.VET[i];
                    }
                    linha++;

                }
                linha++;
            }
        }

        private void print_Sortimentos(ref List<Cenario_Talhao> final_talhao)
        {
            var Excel_Sortimentos = new Microsoft.Office.Interop.Excel.Application();
            Excel_Sortimentos.Workbooks.Add();
            Excel_Sortimentos.Workbooks[1].Worksheets[1].Name = "Sortimentos";
            var aux_sortimento = Excel_Sortimentos.Workbooks.Item[1];
            
            Excel_Sortimentos.Worksheets[1].cells[1][1] = "X";
            int num_sortimentos = final_talhao[0].volumes[0].Count();
            for (int i=0; i<final_talhao[0].volumes[0].Count(); i++)
            {
                Console.WriteLine(final_talhao[0].volumes[0][i]);
            }
            for (int i = 0; i <= horizonte; i++)
            {
                for (int j = 1; j < num_sortimentos; j++)
                {
                    Excel_Sortimentos.Worksheets[1].cells[i * (num_sortimentos-1) + j + 1][1] = i;
                }
            }

            int linha = 2;
           
            foreach (Cenario_Talhao cenario in final_talhao)
            {
                for (int i = 0; i < cenario.regiao.Count(); i++)
                {
                    string registro;
                    registro = "R" + cenario.regiao[i] + "_T" + cenario.talhao[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    { 
                        registro += "_D" + cenario.idade[i] + "-" + cenario.porcentagem[i];
                        if (desbaste_por == "Árvore")
                        {
                            registro += "N";
                        }

                        if (desbaste_por == "Área basal")
                        {
                            registro += "B";
                        }
                        registro += "_CR" + cenario.idade[i + 1];
                    }
                    else registro += "_CR" + cenario.idade[i];

                    Excel_Sortimentos.Worksheets[1].cells[1][linha] = registro;
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                    for (int idade_atual = 0; idade_atual <= horizonte; idade_atual++)
                    {
                        if ((idade_atual + cenario.idade_original[i]) % cenario.idade[i + 1] == 0)
                        {
                            for (int j = 1; j < num_sortimentos; j++)
                            {
                                    Excel_Sortimentos.Worksheets[1].cells[ idade_atual * (num_sortimentos - 1) + j + 1][linha] = cenario.volumes[i + 1][j];
                            }
                        }
                        else if ((idade_atual + cenario.idade_original[i]) % cenario.idade[i + 1] == cenario.idade[i])
                        {
                            for (int j = 1; j < num_sortimentos; j++)
                            {
                                    Excel_Sortimentos.Worksheets[1].cells[idade_atual * (num_sortimentos - 1) + j + 1][linha] = cenario.volumes[i][j];
                            }
                        }
                        else
                        {
                            for (int j = 1; j < num_sortimentos; j++)
                            {
                                    Excel_Sortimentos.Worksheets[1].cells[idade_atual * (num_sortimentos - 1) + j + 1][linha] = 0;
                            }
                        }
                    }
                    linha++;
                    i++;
                }
                else
                {
                    for (int idade_atual = 0; idade_atual <= horizonte; idade_atual++)
                    {
                        if ( (idade_atual + cenario.idade_original[i])%cenario.idade[i] == 0)
                        {
                            for (int j=1; j< num_sortimentos; j++)
                            {
                                    Excel_Sortimentos.Worksheets[1].cells[idade_atual * (num_sortimentos - 1) + j + 1][linha] = cenario.volumes[i][j];
                            }
                        }
                        else
                        {
                            for (int j = 1; j < num_sortimentos; j++)
                            {
                                    Excel_Sortimentos.Worksheets[1].cells[idade_atual * (num_sortimentos - 1) + j + 1][linha] = 0;
                            }
                        }
                    }
                }

                }
            }
            string path = Directory.GetCurrentDirectory();
            string pathString_Sortimentos = System.IO.Path.Combine(path, "Sortimentos");
            System.IO.Directory.CreateDirectory(pathString_Sortimentos);
            Excel_Sortimentos.Workbooks[1].SaveAs(pathString_Sortimentos + "/" + arquivo_saida);
            Excel_Sortimentos.Workbooks[1].Save();
            Excel_Sortimentos.Quit();
        }

        private void print_Binary(ref List<Cenario_Talhao> final_talhao)
        {
            var Excel_Binary = new Microsoft.Office.Interop.Excel.Application();
            Excel_Binary.Workbooks.Add();
            Excel_Binary.Workbooks[1].Worksheets[1].Name = "Binária";
            var aux_binary = Excel_Binary.Workbooks.Item[1];



            Excel_Binary.Worksheets[1].cells[1][1] = "X";
            
            for (int i = 0; i <= horizonte; i++)
            {
                Excel_Binary.Worksheets[1].cells[i+2][1] = i;
            }

            int linha = 2;

            foreach (Cenario_Talhao cenario in final_talhao)
            {
                for (int i = 0; i < cenario.regiao.Count(); i++)
                {
                    string registro;
                    registro = "R" + cenario.regiao[i] + "_T" + cenario.talhao[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        registro += "_D" + cenario.idade[i] + "-" + cenario.porcentagem[i];
                        if (desbaste_por == "Árvore")
                        {
                            registro += "N";
                        }

                        if (desbaste_por == "Área basal")
                        {
                            registro += "B";
                        }
                        registro += "_CR" + cenario.idade[i + 1];
                    }
                    else registro += "_CR" + cenario.idade[i];
                    Excel_Binary.Worksheets[1].cells[1][linha] = registro;

                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        for (int idade_atual = 0; idade_atual <= horizonte; idade_atual++)
                        {
                            if ((idade_atual + cenario.idade_original[i]) % cenario.idade[i + 1] == 0)
                            {
                                Excel_Binary.Worksheets[1].cells[idade_atual+2][linha] = 1;
                            }
                            else if ((idade_atual + cenario.idade_original[i]) % cenario.idade[i + 1] == cenario.idade[i])
                            {
                                Excel_Binary.Worksheets[1].cells[idade_atual+2][linha] = 1;
                            }
                            else
                            {
                                Excel_Binary.Worksheets[1].cells[idade_atual+2][linha] = 0;
                            }
                        }
                        linha++;
                        i++;
                    }
                    else
                    {
                        for (int idade_atual = 0; idade_atual <= horizonte; idade_atual++)
                        {
                            if ((idade_atual + cenario.idade_original[i]) % cenario.idade[i] == 0)
                            {
                                Excel_Binary.Worksheets[1].cells[idade_atual+2][linha] = 1;
                            }
                            else
                            {
                                Excel_Binary.Worksheets[1].cells[idade_atual+2][linha] = 0;
                            
                            }
                        }
                    }
                     
                }
            }
            string path = Directory.GetCurrentDirectory();
            string pathString_Binary = System.IO.Path.Combine(path, "Tabela Binária");
            System.IO.Directory.CreateDirectory(pathString_Binary);
            Excel_Binary.Workbooks[1].SaveAs(pathString_Binary + "/" + arquivo_saida);
            Excel_Binary.Workbooks[1].Save();
            Excel_Binary.Quit();
        }

        private void print_Regulação(ref List<Cenario_Talhao> final_talhao)
        {
            var Excel_Regulacao = new Microsoft.Office.Interop.Excel.Application();
            Excel_Regulacao.Workbooks.Add();
            Excel_Regulacao.Workbooks[1].Worksheets[1].Name = "Regulação";
            var aux_regulacao = Excel_Regulacao.Workbooks.Item[1];

            Excel_Regulacao.Worksheets[1].cells[1][1] = "X";

            for (int i = 1; i <= N_regulacao; i++)
            {
                Excel_Regulacao.Worksheets[1].cells[i + 1][1] = i;
            }

            int linha = 2;

            foreach (Cenario_Talhao cenario in final_talhao)
            {
                for (int i = 0; i < cenario.regiao.Count(); i++)
                {
                    string registro;
                    registro = "R" + cenario.regiao[i] + "_T" + cenario.talhao[i];
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        registro += "_D" + cenario.idade[i] + "-" + cenario.porcentagem[i];
                        if (desbaste_por == "Árvore")
                        {
                            registro += "N";
                        }

                        if (desbaste_por == "Área basal")
                        {
                            registro += "B";
                        }
                        registro += "_CR" + cenario.idade[i + 1];
                    }
                    else registro += "_CR" + cenario.idade[i];
                    Excel_Regulacao.Worksheets[1].cells[1][linha] = registro;

                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        for (int idade_atual = 1; idade_atual <= N_regulacao; idade_atual++)
                        {
                            Excel_Regulacao.Worksheets[1].cells[idade_atual + 1][linha] = 0;
                        }
                        int idade_final = (int)(cenario.idade_original[i] + horizonte + 1);
                        idade_final %= (int)cenario.idade[i + 1];
                        idade_final %= (int)cenario.idade[i];

                        if (idade_final <= N_regulacao)
                        {
                            Excel_Regulacao.Worksheets[1].cells[idade_final + 1][linha] = cenario.area_talhao[i];
                        }
                        i++;
                    }
                    else
                    {
                        for (int idade_atual = 1; idade_atual <= N_regulacao; idade_atual++)
                        {
                            Excel_Regulacao.Worksheets[1].cells[idade_atual + 1][linha] = 0;
                        }
                        int idade_final = (int)(cenario.idade_original[i] + horizonte+1);
                        idade_final %= (int)cenario.idade[i];
                        if (idade_final <= N_regulacao)
                        {
                            Excel_Regulacao.Worksheets[1].cells[idade_final + 1][linha] = cenario.area_talhao[i];
                        }
                    }
                    linha++;
                }
            }
            string path = Directory.GetCurrentDirectory();
            string pathString_Regulacao = System.IO.Path.Combine(path, "Regulação");
            System.IO.Directory.CreateDirectory(pathString_Regulacao);
            Excel_Regulacao.Workbooks[1].SaveAs(pathString_Regulacao + "/" + arquivo_saida);
            Excel_Regulacao.Workbooks[1].Save();
            Excel_Regulacao.Quit();

        }


        public struct aux_maximizacao
        {
            public string regiao;
            public string talhao;
            public double idade;
            public string porcentagem;
            public double VPL;
            public double VAE;
            public double VPL_infinito;
            public double VET;
            public double idade_desbaste;
            public bool tem_desbaste;
        }
        private void gerar_economicos2(ref List<Cenario_Talhao> final_talhao)
        {
            foreach (Cenario_Talhao cenario in final_talhao)
            {      
                for (int i=0; i<cenario.regiao.Count(); i++)
                {       
                    double receita1 = -1;
                    double receita2 = -1;
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1)
                    {
                        receita1 = 0;
                        receita2 = 0;
                        cenario.VPL2[i + 1] = 0;
                        cenario.VAE2[i + 1] = 0;
                        cenario.VPL_infinito2[i + 1] = 0;
                        cenario.VET2[i + 1] = 0;
                        foreach (Produto prod in produtos)
                        {
                            receita1 += cenario.volumes[i][prod.numero] * (prod.preco - custos[(int)cenario.idade[i]].desbaste);
                            receita2 += cenario.volumes[i][prod.numero] * (prod.preco - custos[(int)cenario.idade[i + 1]].cortefinal);
                        }
                        int idade_aux = 1;
                        for (int idade_atual = 1; idade_atual <= horizonte + cenario.idade_original[i]; idade_atual++)
                        {
                            if (idade_aux % cenario.idade[i+1] == 0)
                            {
                                cenario.VPL2[i+1] += calcular_VPL(receita2, taxa_juros, idade_atual - cenario.idade_original[i]);
                                if (idade_atual + cenario.idade[i] > horizonte + cenario.idade_original[i])
                                {
                                    cenario.VAE2[i+1] = calcular_VAE(cenario.VPL2[i+1], taxa_juros, idade_atual - cenario.idade_original[i]);
                                    cenario.VPL_infinito2[i+1] = calcular_VPL_infinito(cenario.VAE2[i+1], taxa_juros);
                                    cenario.VET2[i+1] = calcular_VET(cenario.VPL2[i+1], taxa_juros, idade_atual - cenario.idade_original[i]);
                                    break;
                                }
                                idade_aux = 1;
                                continue;
                            }
                            cenario.VPL2[i + 1] -= calcular_VPL(custos[idade_aux].manutencao, taxa_juros, idade_atual - cenario.idade_original[i]);
                            if (idade_aux % cenario.idade[i + 1] == cenario.idade[i]);
                            {
                                cenario.VPL2[i+1] += calcular_VPL(receita1, taxa_juros, idade_atual - cenario.idade_original[i]);
                                if (idade_atual + cenario.idade[i+1] - cenario.idade[i] > horizonte + cenario.idade_original[i])
                                {
                                    cenario.VAE2[i+1] = calcular_VAE(cenario.VPL2[i+1], taxa_juros, idade_atual - cenario.idade_original[i]);
                                    cenario.VPL_infinito2[i+1] = calcular_VPL_infinito(cenario.VAE2[i+1], taxa_juros);
                                    cenario.VET2[i+1] = calcular_VET(cenario.VPL2[i+1], taxa_juros, idade_atual - cenario.idade_original[i]);
                                    break;
                                }
                            }
                            idade_aux++;
                        }
                        i++;
                    }
                }
            }
        }
        private void print_maximizaçao(ref List<Cenario_Talhao> final_talhao)
        {
            horizonte = double.Parse(textBox9.Text);
            N_planejamento = int.Parse(textBox10.Text);
            arquivo_saida = textBox8.Text;
            List<aux_maximizacao> casos = new List<aux_maximizacao>();
            aux_maximizacao aux = new aux_maximizacao();
            gerar_economicos2(ref final_talhao);
            
            foreach (Cenario_Talhao cenario in final_talhao)
            {
                for (int i = 0; i < cenario.regiao.Count(); i++)
                {
                    if (cenario.VPL[i] == -1 && cenario.VAE[i] == -1 && cenario.VPL_infinito[i] == -1 && cenario.VET[i] == -1) 
                    {
                        aux.idade_desbaste = cenario.idade[i];
                        aux.tem_desbaste = true;
                        continue;
                    }
                    aux.regiao = cenario.regiao[i];
                    aux.talhao = cenario.talhao[i];
                    aux.idade = cenario.idade[i];
                    aux.porcentagem = cenario.porcentagem[i];
                    aux.VPL = cenario.VPL2[i];
                    aux.VAE = cenario.VAE2[i];
                    aux.VPL_infinito = cenario.VPL_infinito2[i];
                    aux.VET = cenario.VET2[i];
                    if (aux.porcentagem == "-") aux.tem_desbaste = false;
                    casos.Add(aux);
                }
            }
           
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
                if (j == 0)
                {
                    casos = casos.OrderBy(x => -x.VPL).ToList();
                }
                if (j == 1)
                {
                    casos = casos.OrderBy(x => -x.VAE).ToList();
                    txt.Close();
                    txt = new StreamWriter(pathVAE + "/" + arquivo_saida + "_VAE.txt");
                }
                if (j == 2)
                {
                    casos = casos.OrderBy(x => -x.VPL_infinito).ToList();
                    txt.Close();
                    txt = new StreamWriter(pathVPL_infinito + "/" + arquivo_saida + "_VPL∞.txt");
                }
                if (j == 3)
                {
                    casos = casos.OrderBy(x => -x.VET).ToList();
                    txt.Close();
                    txt = new StreamWriter(pathVET + "/" + arquivo_saida + "_VET.txt");
                }
                bool is_first = true;
                txt.Write("MAX = ");

                casos = casos.OrderBy(x => x.regiao).ToList();
                casos = casos.OrderBy(x => x.talhao).ToList();


                produtos = produtos.OrderBy(x => -x.max).ToList();

                int i = 0;

                while (true)
                {
                    List<aux_maximizacao> atual = new List<aux_maximizacao>();
                    atual.Add(casos[i]);
                    i++;
                    for (; i < casos.Count(); i++)
                    {
                        if (casos[i].regiao != casos[i - 1].regiao || casos[i].talhao != casos[i - 1].talhao) break;
                        atual.Add(casos[i]);
                    }
                    int cont = 0;
                    foreach (aux_maximizacao cenario in atual)
                    {
                        if (!is_first)
                        {
                            txt.Write(" + ");
                        }
                        if (j == 0)
                            txt.Write(cenario.VPL + " * R" + cenario.regiao + "_T" + cenario.talhao);
                        if (j == 1)
                            txt.Write(cenario.VAE + " * R" + cenario.regiao + "_T" + cenario.talhao);
                        if (j == 2)
                            txt.Write(cenario.VPL_infinito + " * R" + cenario.regiao + "_T" + cenario.talhao);
                        if (j == 3)
                            txt.Write(cenario.VET + " * R" + cenario.regiao + "_T" + cenario.talhao);

                        if (cenario.tem_desbaste)
                        {
                            txt.Write("_D" + cenario.idade_desbaste + "-" + cenario.porcentagem);
                            if (desbaste_por == "Árvore")
                            {
                                txt.Write("N");
                            }

                            if (desbaste_por == "Área basal")
                            {
                                txt.Write("B");
                            }
                        }
                        txt.Write("_CR" + cenario.idade);
                        is_first = false;
                        cont++;
                        if (cont == N_planejamento) break;                    
                    }
                    if (i == casos.Count()) break;
                }
            }
            txt.Close();
        }


        List<Cenario_Parcela> Final_parcela = new List<Cenario_Parcela>();
        List<Cenario_Talhao> final_talhao = new List<Cenario_Talhao>();
        private void processamento()
        {
            importar_produtos();                                 //exporta os dados de cada produto do xls
            importar_arvores();                                  //exporta as arvores do xls
            importar_coeficientes();                             //exporta os coeficientes do xls
            importar_economica();                                //exporta os dados relacionado à simulação economica
            importar_simulacoes();                               //exporta todos os dados que devem ser simulados
            textBox4.Visible = true;
            
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
            try
            {
                foreach (double idade in simulacoes.corte_raso)
                {
                    simular(idade, ref Final_parcela, ref final_talhao);
                }
            }
            catch{
                error = "erro ao simular corte raso";
                throw new CustomException("");
            }

            var Excel = new Microsoft.Office.Interop.Excel.Application();

            try
            {
                Excel.Workbooks.Add();
                Excel.Worksheets.Add();
                
                Excel.Workbooks[1].Worksheets[1].Name = "Talhão";
                Excel.Workbooks[1].Worksheets[2].Name = "Parcela";
                
                var aux = Excel.Workbooks.Item[1];

                string path = Directory.GetCurrentDirectory();

                string pathString = System.IO.Path.Combine(path, "Simulações");
                System.IO.Directory.CreateDirectory(pathString);
                
                Excel.Workbooks[1].SaveAs(pathString + "/" + arquivo_saida);
            }
            catch
            {
                error = "nao foi possivel gerar o excel";
                throw new CustomException("");
            }
            try
            {
                print_parcela(ref Final_parcela, ref Excel);
                print_talhao(ref final_talhao, ref Excel);
            }
            catch
            {
                error = "erro ao gerar simulações";
                throw new CustomException("");
            }
            //print_maximizaçao(ref final_talhao);
            Excel.Workbooks[1].Save();
            Excel.Quit();         
        }
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                processamento();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"ERRO", MessageBoxButtons.OK);
            }
            this.Text = "Entradas e premissas";

        }
        private void button4_Click(object sender, EventArgs e)
        {

        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            arquivo_saida = textBox3.Text;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void maximizaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Botao_Arvore.Visible = false; //arvores ( geral )
            Botao_cenarios.Visible = false; //cenarios ( geral )
            Botao_Coeficientes.Visible = false; //coeficientes ( geral ) 
            botao_produto.Visible = false;  //sortimentos ( geral )
            Botao_custos.Visible = false; //custos ( geral )
            button4.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button3.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button6.Visible = false;

            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            button7.Visible = false;


            textBox9.Visible = true;
            textBox10.Visible = true;
            textBox8.Visible = true;
            button1.Visible = true;


            textBox9.Text = "Horizonte";
            textBox10.Text = "N_Planejamento";
            textBox8.Text = "Título";
            button1.Text = "Gerar Maximização";
        }

        private void button1_Click_3(object sender, EventArgs e)
        {
            print_maximizaçao(ref final_talhao);
        }

        private void sortimentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Botao_Arvore.Visible = false; //arvores ( geral )
            Botao_cenarios.Visible = false; //cenarios ( geral )
            Botao_Coeficientes.Visible = false; //coeficientes ( geral ) 
            botao_produto.Visible = false;  //sortimentos ( geral )
            Botao_custos.Visible = false; //custos ( geral )
            button4.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox8.Visible = false;
            button1.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button6.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            button7.Visible = false;

            textBox11.Visible = true;
            textBox12.Visible = true;
            button3.Visible = true;

            textBox11.Text = "Horizonte";
            textBox12.Text = "Título";
            button3.Text = "Gerar Sortimentos";
        }

        private void button3_Click_2(object sender, EventArgs e)
        {
            horizonte = double.Parse(textBox11.Text);
            arquivo_saida = textBox12.Text;
            print_Sortimentos(ref final_talhao);
        }

        private void bináriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Botao_Arvore.Visible = false; //arvores ( geral )
            Botao_cenarios.Visible = false; //cenarios ( geral )
            Botao_Coeficientes.Visible = false; //coeficientes ( geral ) 
            botao_produto.Visible = false;  //sortimentos ( geral )
            Botao_custos.Visible = false; //custos ( geral )
            button4.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox8.Visible = false;
            button1.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button3.Visible = false;
            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            button7.Visible = false;


            textBox13.Visible = true;
            textBox14.Visible = true;
            button6.Visible = true;
            textBox13.Text = "Horizonte";
            textBox14.Text = "Titulo";
            button6.Text = "Gerarar binária";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            horizonte = double.Parse(textBox13.Text);
            arquivo_saida = textBox14.Text;
            print_Binary(ref final_talhao);
        }

        private void regulaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Botao_Arvore.Visible = false; //arvores ( geral )
            Botao_cenarios.Visible = false; //cenarios ( geral )
            Botao_Coeficientes.Visible = false; //coeficientes ( geral ) 
            botao_produto.Visible = false;  //sortimentos ( geral )
            Botao_custos.Visible = false; //custos ( geral )
            button4.Visible = false;
            textBox2.Visible = false;
            comboBox1.Visible = false;
            comboBox2.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox8.Visible = false;
            button1.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button3.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button6.Visible = false;

            textBox15.Visible = true;
            textBox16.Visible = true;
            textBox17.Visible = true;
            button7.Visible = true;


            textBox15.Text = "Horizonte";
            textBox16.Text = "Idade Regulação";
            textBox17.Text = "Titulo";
            button7.Text = "Gerar Regulação";
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            horizonte = double.Parse(textBox15.Text);
            N_regulacao = int.Parse(textBox16.Text);
            arquivo_saida = textBox17.Text;
            print_Regulação(ref final_talhao);
        }

        private void simularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Botao_Arvore.Visible = true; //arvores ( geral )
            Botao_cenarios.Visible = true; //cenarios ( geral )
            Botao_Coeficientes.Visible = true; //coeficientes ( geral ) 
            botao_produto.Visible = true;  //sortimentos ( geral )
            Botao_custos.Visible = true; //custos ( geral )
            button4.Visible = true;
            textBox2.Visible = true;
            comboBox1.Visible = true;
            comboBox2.Visible = true;
            textBox3.Visible = true;
            button5.Visible = true;
            textBox9.Visible = false;
            textBox10.Visible = false;
            textBox8.Visible = false;
            button1.Visible = false;
            textBox11.Visible = false;
            textBox12.Visible = false;
            button3.Visible = false;
            textBox13.Visible = false;
            textBox14.Visible = false;
            button6.Visible = false;

            textBox15.Visible = false;
            textBox16.Visible = false;
            textBox17.Visible = false;
            button7.Visible = false;
        }
    }
}