using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Parcela
    {
        public Parcela(int num, int quant_produtos)
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
            vae = 0;
            vet = 0;
            vpl_infinito = 0;
            this.numero = num;
        }
        public void set_dados()
        {
            regiao = arvores[0].regiao;
            talhao = arvores[0].talhao;
            area_parcela = arvores[0].area_parcela;
            num_arvores = arvores.Count();
            idade = arvores[0].idade;
            material_genetico = arvores[0].material_genetico;
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
        public int numero;
        public int regiao;
        public int talhao;
        public int num_arvores;
        public double idade;
        public double dap_medio;
        public double altura_media;
        public double area_basal_total;
        public double area_parcela;
        public double ima;
        public double vpl;
        public double vae;
        public double vpl_infinito;
        public double vet;

        public string material_genetico;
        public List<double> volume;
        public List<double> lucro;

    }
}
