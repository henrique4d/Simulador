using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Parcela
    {
        public Parcela(string num, int quant_produtos)
        {
            volume = new List<double>();
            lucro = new List<double>();

            for (int i=0; i< quant_produtos; i++)
            {
                volume.Add(0);
                lucro.Add(0);
            }
            arvores = new List<Arvore>();
            ima = 0;
            vpl = 0;
            vpl2 = 0;
            vae = 0;
            vae2 = 0;
            vet = 0;
            vet2 = 0;
            vpl_infinito = 0;
            vpl_infinito2 = 0;
            this.numero = num;
        }
        public void set_dados()
        {
            regiao = arvores[0].regiao;
            talhao = arvores[0].talhao;
            area_parcela = arvores[0].area_parcela;
            num_arvores = arvores.Count();
            idade = arvores[0].idade;
            idade_original = arvores[0].idade_original;
            material_genetico = arvores[0].material_genetico;
            area_talhao = arvores[0].area_talhao;
            dap_medio = 0;
            foreach (Arvore x in arvores)
            {
                dap_medio += x.dap;
            }
            dap_medio /= num_arvores;

            altura_media = 0;
            foreach (Arvore x in arvores)
            {
                altura_media += x.altura;
            }
            altura_media /= num_arvores;

            area_basal_total = 0;
            foreach (Arvore x in arvores)
            {
                area_basal_total += x.area_basal;
            }
        }
        
        public List<Arvore> arvores;
        public string numero;
        public string talhao;
        public string regiao;
        public int num_arvores;
        public double idade;
        public double idade_original;
        public double dap_medio;
        public double altura_media;
        public double area_basal_total;
        public double area_parcela;
        public double area_talhao;
        public double ima;
        public double vpl;
        public double vpl2;
        public double vae;
        public double vae2;
        public double vpl_infinito;
        public double vpl_infinito2;
        public double vet;
        public double vet2;
        public string material_genetico;
        public List<double> volume;
        public List<double> lucro;
    }
}
