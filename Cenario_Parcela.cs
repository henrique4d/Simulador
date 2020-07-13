using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Cenario_Parcela
    {
        public Cenario_Parcela()
        {
            regiao = new List<double>();
            talhao = new List<double>();
            parcela = new List<double>();
            idade = new List<double>();
            porcentagem = new List<string>();
            media_altura = new List<double>();
            media_dap = new List<double>();
            volumes = new List<List<double>>();
            IMA = new List<double>();
            VPL = new List<double>();
            VAE = new List<double>();
            VPL_infinito = new List<double>();
            VET = new List<double>();
            vpl_sort = 0; ;
        }

        public List<double> regiao;
        public List<double> talhao;
        public List<double> parcela;
        public List<double> idade;
        public List<string> porcentagem;
        public List<double> media_dap;
        public List<double> media_altura;
        public List<List<double>> volumes;
        public List<double> IMA;
        public List<double> VPL;
        public List<double> VAE;
        public List<double> VPL_infinito;
        public List<double> VET;
        public double vpl_sort;
    }

}
