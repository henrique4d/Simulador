using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Talhao
    {
        public Talhao(int num)
        {
            parcelas = new List<Parcela>();
            this.numero = num;
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
            Parcela nova_parcela = new Parcela(arvore.parcela);
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
            
            idade = 0;
            foreach (Parcela parc in parcelas)
            {
                idade += parc.idade;
            }
            idade /= num_parcelas;

            dap_medio = 0;
            foreach (Parcela parc in parcelas)
            {
                dap_medio += parc.dap_medio;
            }
            dap_medio /= num_parcelas;

        }

        public List<Parcela> parcelas;
        public int numero;
        public int regiao;
        public int num_parcelas;
        public double idade;
        public double dap_medio;
        string material_genetico;
    }
}
