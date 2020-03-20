﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClosedXML.Excel;


// multiplicar o volume por 10k e dividir pela area da parcela;
// desbaste sistematico (linha)

namespace Simulador
{
    public partial class Form1 : Form
    {
        string arquivo;
        string arquivo2;
        List<Produto> produtos;
        List<Resultado> resultados;
        public Form1()
        {
            InitializeComponent();
        } 
        private void produto_final(ref List<Regiao> regioes, double B0, double B1, double B2, double B3, bool desbastada)
        {
            foreach (Regiao reg in regioes){
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Produto prod in produtos)
                        {
                            prod.lucro_final = 0;
                        }
                        foreach (Arvore arv in parc.arvores)
                        {
                            
                            double altura_atual = 0.10;
                            foreach (Produto prod in produtos)
                            {
                                while (true)
                                { 
                                    if (altura_atual + prod.l > arv.altura)
                                        break;
                                    double d1 = arv.dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_atual, B3) * Math.Pow(arv.altura, -B3)));
                                    double d2 = arv.dap * B0 * (1 + B1 * Math.Log(1 - B2 * Math.Pow(altura_atual + prod.l, B3) * Math.Pow(arv.altura, -B3)));
                                    if (d2 > prod.max || d2 < prod.min)
                                        break; 
                                    altura_atual += prod.l;

                                    double as1 = Math.PI * Math.Pow(d1, 2) / 40000;
                                    double as2 = Math.PI * Math.Pow(d2, 2) / 40000;

                                    prod.volume += (as1 + as2) * prod.l / 2;
                                }
                                if (altura_atual + prod.l > arv.altura)
                                {
                                    break;
                                }
                            }
                        }
                        List <Tuple<int, double>> prod_volume = new List<Tuple<int, double>>();
                        foreach (Produto prod in produtos)
                        {
                            Tuple<int, double> auxiliar = new Tuple<int, double>(prod.numero,prod.volume);
                            prod_volume.Add(auxiliar);
                        }
                        Resultado aux = new Resultado(parc.regiao, parc.talhao, parc.numero, ref prod_volume, desbastada);
                        resultados.Add(aux);
                       }

                }
            }
        }
        private double simula_dap( ref double  idade1,ref double idade2,ref double dap1,ref double B1,ref double B2) 
        {   
            double dap2;
            dap2 = dap1 * Math.Exp(-B1 * (Math.Pow(idade2, B2) - Math.Pow(idade1, B2)));
            return dap2;
        }
        private double simula_altura(ref double idade1, ref double idade2, ref double altura1, ref double B1, ref double B2)
        {   
            double altura2;
            altura2 = altura1 * Math.Exp(-B1 * (Math.Pow(idade2, B2) - Math.Pow(idade1, B2)));
            return altura2;
        }
        void ordena_dap(ref List<Regiao> inicial) {
           foreach (Regiao reg in inicial){
                foreach (Talhao tal in reg.talhoes){
                    foreach (Parcela parc in tal.parcelas){
                        List<Arvore> auxiliar = parc.arvores.OrderBy(x => x.dap).ToList();
                        parc.arvores = auxiliar;
                    }
                }
            }
        }
        void ordena_arv(ref List<Regiao> inicial)
        {
            foreach (Regiao reg in inicial)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        List<Arvore> auxiliar = parc.arvores.OrderBy(x => x.numero).ToList();
                        parc.arvores = auxiliar;
                    }
                }
            }
        }
        void seletivo_dap (ref List<Regiao> inicial, int porcentagem, int intervalo)
        {
            ordena_arv(ref inicial);

            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in inicial)
            {
                Regiao auxiliar = new Regiao(reg.numero);

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double dap_limite = parc.area_basal_total * porcentagem / 100;
                        int cont = 1;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            if (cont % intervalo == 0)
                            {
                                dap_limite -= arv.area_basal;
                                if (dap_limite < 0)
                                    break;
                                auxiliar.adiciona_arvore(arv);
                                parc.arvores.Remove(arv);
                            }
                        }
                        List<Arvore> aux = parc.arvores.OrderBy(x => x.dap).ToList();
                        parc.arvores = aux;

                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            dap_limite -= arv.area_basal;
                            if (dap_limite < 0)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                        }
                    }
                }
                
                auxiliar.set_dados();
                para_desbaste.Add(auxiliar);
            }
        }
        void seletivo_arvore(ref List<Regiao> inicial, int porcentagem, int intervalo)
        {
            ordena_arv(ref inicial);

            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in inicial)
            {
                Regiao auxiliar = new Regiao(reg.numero);

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double dap_limite = parc.arvores.Count() * porcentagem / 100;
                        int cont = 1;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            if (cont % intervalo == 0)
                            {
                                dap_limite --;
                                if (dap_limite < 0)
                                    break;
                                auxiliar.adiciona_arvore(arv);
                                parc.arvores.Remove(arv);
                            }
                        }
                        List<Arvore> aux = parc.arvores.OrderBy(x => x.dap).ToList();
                        parc.arvores = aux;

                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            dap_limite--;
                            if (dap_limite < 0)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                        }
                    }
                }

                auxiliar.set_dados();
                para_desbaste.Add(auxiliar);
            }
        }
        void desbaste_dap( ref List<Regiao> inicial, int porcentagem)
        {
            ordena_dap(ref inicial);

            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in inicial)
            {
                Regiao auxiliar = new Regiao(reg.numero);

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double dap_limite = parc.area_basal_total * porcentagem / 100;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            dap_limite -= arv.area_basal;
                            if (dap_limite < 0)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                        }
                    }
                }
                auxiliar.set_dados();
//                Console.WriteLine(auxiliar.idade);
                para_desbaste.Add(auxiliar);
            }
            produto_final(ref para_desbaste, 1.319010, 0.289590, 1.000007, 0.251762, true);
        }
        private void desbaste_arvores(ref List<Regiao> inicial, int porcentagem)
        {
            ordena_dap(ref inicial);

            List<Regiao> para_desbaste = new List<Regiao>();
            foreach (Regiao reg in inicial)
            {
                Regiao auxiliar = new Regiao(reg.numero);

                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        double dap_limite = parc.arvores.Count() * porcentagem / 100;
                        foreach (Arvore arv in parc.arvores.ToList())
                        {
                            dap_limite --;
                            if (dap_limite < 0)
                                break;
                            auxiliar.adiciona_arvore(arv);
                            parc.arvores.Remove(arv);
                        }
                    }
                }
                auxiliar.set_dados();
                //Console.WriteLine(auxiliar.idade);
                para_desbaste.Add(auxiliar);
 
            }
            produto_final(ref para_desbaste, 1.319010, 0.289590, 1.000007, 0.251762, true);
        }
        class comp : IComparer< Resultado>
        {
            public int Compare(Resultado x, Resultado y)
            {
                    if (x.regiao < y.regiao)
                        return -1;
                    if (x.regiao > y.regiao)
                        return 1;
                    if (x.talhao < y.talhao)
                        return -1;
                    if (x.talhao > y.talhao)
                        return 1;
                    if (x.parcela < y.parcela)
                        return -1;
                    if (x.parcela > y.parcela)
                        return 1;
                    if (x.desbaste)
                        return -1;
                    else
                        return 1;
            }
        }
        private void processamento()
        {

            /*   double B1_altura = double.Parse(toolStripTextBox1.Text);
               double B2_altura = double.Parse(toolStripTextBox2.Text);
               double B1_dap = double.Parse(toolStripTextBox3.Text);
               double B2_dap = double.Parse(toolStripTextBox4.Text);
               int idade_desbaste = int.Parse(toolStripTextBox5.Text);
               */

            double B1_altura = 5.463964;
            double B2_altura = -0.338041;
            double B1_dap = 6.018007;
            double B2_dap = -1.430330;
            double idade_desbaste = 10;
            double idade_final = 15;
            produtos = new List<Produto>();
            resultados = new List<Resultado>();

            List<Regiao> regioes = new List<Regiao>();
            List<Regiao> regioes_desbaste = new List<Regiao>();
            

            var excel = new XLWorkbook(arquivo2);
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
                Produto aux = new Produto(numero, min, max,l, preco);
                produtos.Add(aux);
            }
            excel = new XLWorkbook(arquivo);
            planilha = excel.Worksheet(1);
            for (int linha = 2; ; linha++)
            {
                string confere = planilha.Cell("A" + linha.ToString()).Value.ToString();
                if (string.IsNullOrEmpty(confere)) break;

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
                
                if (dap == 0 && altura == 0)
                    continue;

                Arvore auxiliar = new Arvore(regiao, talhao, idade, dap, altura, parcela, area_parcela, fila, arv, material_genetico);
                
                foreach (Regiao reg in regioes)
                {
                    if (reg.numero == auxiliar.regiao)
                    {
                        reg.adiciona_arvore(auxiliar);
                        goto aqui1;
                    }
                }

                Regiao nova_regiao = new Regiao(auxiliar.regiao);
                nova_regiao.adiciona_arvore(auxiliar);
                regioes.Add(nova_regiao);
                aqui1:

                dap = simula_dap(ref idade, ref idade_desbaste, ref dap, ref B1_dap, ref B2_dap);

                altura = simula_altura(ref idade, ref idade_desbaste, ref altura, ref B1_altura, ref B2_altura);
                idade = idade_desbaste;

                Arvore auxiliar2 = new Arvore(regiao, talhao, idade, dap, altura, parcela, area_parcela, fila, arv, material_genetico);
                foreach (Regiao reg in regioes_desbaste)
                {
                    if (reg.numero == auxiliar.regiao)
                    {
                        reg.adiciona_arvore(auxiliar2);
                        goto aqui2;
                    }
                }
                Regiao nova_regiao2 = new Regiao(auxiliar2.regiao);
                nova_regiao2.adiciona_arvore(auxiliar2);
                regioes_desbaste.Add(nova_regiao2);
                aqui2: int zero = 0;

            }
            foreach (Regiao reg in regioes)
            {
                reg.set_dados();
            }
            foreach (Regiao reg in regioes_desbaste)
            {
                reg.set_dados();
            }

            desbaste_dap(ref regioes_desbaste, 50);

            foreach (Regiao reg in regioes_desbaste)
            {
                reg.set_dados();
            }
            
            foreach(Regiao reg in regioes_desbaste)
            {
                foreach (Talhao tal in reg.talhoes)
                {
                    foreach (Parcela parc in tal.parcelas)
                    {
                        foreach (Arvore arv in parc.arvores)
                        {
                            arv.dap = simula_dap(ref idade_desbaste, ref idade_final,ref arv.dap,ref B1_dap,ref B1_dap);
                            arv.altura = simula_altura(ref idade_desbaste, ref idade_final, ref arv.altura,ref B1_altura,ref B2_altura);
                        }
                    }
                }
            }
            produto_final(ref regioes_desbaste, 1.319010, 0.289590, 1.000007, 0.251762,false);
            comp qwer = new comp();
            resultados.Sort(0, resultados.Count(), qwer);
            foreach (Resultado res in resultados)
            {
                Console.WriteLine("Regiao: " + res.regiao);
                Console.WriteLine("Talhao: " + res.talhao);
                Console.WriteLine("Parcela: " + res.parcela);
                double lucro;
                foreach (Produto prod in produtos)
                {
                    foreach (Tuple<int,double> aux in res.produtos)
                    {
                        if (aux.Item1 == prod.numero)
                        {
                            Console.WriteLine("Produto: " + aux.Item1);
                            Console.WriteLine("Volume: " + aux.Item2);
                            Console.WriteLine("Lucro: " + aux.Item2 * prod.preco);
                            break;
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
         
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo = excel.FileName;

            dataGridView1.DataSource = arquivo;

        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            processamento();
        }
        private void configuraçõesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {

        }

        private void contextMenuStrip2_Opening(object sender, CancelEventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox3_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripTextBox5_Click(object sender, EventArgs e)
        {

        }

        private void tipoDeDesbasteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog excel = new OpenFileDialog();
            if (excel.ShowDialog() == DialogResult.OK)
                arquivo2 = excel.FileName;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
    }
}