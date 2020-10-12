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
            regiao = new List<string>();
            talhao = new List<string>();
            parcela = new List<string>();
            idade = new List<double>();
            porcentagem = new List<string>();
            media_altura = new List<double>();
            media_dap = new List<double>();
            volumes = new List<List<double>>();
            IMA = new List<double>();
            VPL = new List<double>();
            VPL2 = new List<double>();

            VAE = new List<double>();
            VAE2 = new List<double>();

            VPL_infinito = new List<double>();
            VPL_infinito2 = new List<double>();

            VET = new List<double>();
            VET2 = new List<double>();

            vpl_sort = 0; ;
        }

        public List<string> regiao;
        public List<string> talhao;
        public List<string> parcela;
        public List<double> idade;
        public List<string> porcentagem;
        public List<double> media_dap;
        public List<double> media_altura;
        public List<List<double>> volumes;
        public List<double> IMA;
        public List<double> VPL;
        public List<double> VPL2;

        public List<double> VAE2;
        public List<double> VAE;
        public List<double> VPL_infinito;
        public List<double> VPL_infinito2;

        public List<double> VET;
        public List<double> VET2;

        public double vpl_sort;
    }

}
