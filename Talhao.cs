using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Talhao
    {
        public Talhao(string num, int quant_produtos)
        {
            volume = new List<double>();
            lucro = new List<double>();
            lucro_hectare = new List<double>();

            for (int i = 0; i <= quant_produtos; i++)
            {
                volume.Add(0);
                lucro.Add(0);
            }
            parcelas = new List<Parcela>();
            this.numero = num;
            B0_dap = 0;
            B1_dap = 0;
            B0_altura = 0;
            B1_altura = 0;
        }
        public void adiciona_arvore(ref Arvore arvore)
        {
            foreach (Parcela parc in parcelas)
            {
                if (parc.numero == arvore.parcela)
                {
                    parc.arvores.Add(arvore);
                    return;
                }
            }
            Parcela nova_parcela = new Parcela(arvore.parcela, volume.Count());
            nova_parcela.arvores.Add(arvore);
            parcelas.Add(nova_parcela);
        }

        public void set_dados()
        {
            foreach(Parcela parc in parcelas)
            {
                parc.set_dados();
            }
            regiao = parcelas[0].regiao;
            material_genetico = parcelas[0].material_genetico;
            num_parcelas = parcelas.Count();
            
            idade = parcelas[0].idade;

            altura_media = 0;
            dap_medio = 0;

            for (int i=0; i< volume.Count(); i++)
            {
                volume[i] = 0;
            }
            ima = 0;
            vpl = 0;
            vae = 0;
            vpl_infinito = 0;
            vet = 0;


            foreach (Parcela parc in parcelas)
            {
                for (int i = 0; i < volume.Count(); i++)
                {
                    volume[i] += parc.volume[i];
                }
                altura_media += parc.altura_media;
                dap_medio += parc.dap_medio;
                ima += parc.ima;
                vpl += parc.vpl;
                vae += parc.vae;
                vpl_infinito += parc.vpl_infinito;
                vet += parc.vet;
            }
            
            dap_medio /= parcelas.Count(); ;
            altura_media /= parcelas.Count(); ;
            for (int i = 0; i < volume.Count(); i++)
            {
                volume[i] /= parcelas.Count(); ;
            }
            ima /= parcelas.Count(); ;
            vpl /= parcelas.Count(); ;
            vae /= parcelas.Count(); ;
            vpl_infinito /= parcelas.Count();
            vet /= parcelas.Count();
        }

        public List<Parcela> parcelas;
        public string numero;
        public string regiao;
        public int num_parcelas;
        public double idade;
        public double dap_medio;
        public double altura_media;
        string material_genetico;
        public List<double> volume;
        public List<double> lucro;
        public List<double> lucro_hectare;
        public double ima;
        public double vpl;
        public double vae;
        public double vpl_infinito;
        public double vet;
        public double B0_dap;
        public double B1_dap;
        public double B0_altura;
        public double B1_altura;

    }
}
