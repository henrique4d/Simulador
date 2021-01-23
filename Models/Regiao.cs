using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Regiao
    {
        public Regiao(string num, int quant_produtos)
        {
            talhoes = new List<Talhao>();
            this.numero = num;
            this.quant_produtos = quant_produtos;
        }
        public void adiciona_arvore( Arvore arvore)
        {
            foreach (Talhao tal in talhoes)
            {
                if (tal.numero == arvore.talhao)
                {
                    tal.adiciona_arvore(ref arvore);
                    return;
                }
            }
            Talhao novo_talhao = new Talhao(arvore.talhao, quant_produtos);
            novo_talhao.adiciona_arvore(ref arvore);
            talhoes.Add(novo_talhao);
        }
        public void set_dados()
        {
            foreach (Talhao tal in talhoes)
            {
                tal.set_dados();
            }
            num_talhoes = talhoes.Count();

            idade = 0;
            foreach (Talhao tal in talhoes)
            {
                idade += tal.idade;
            }
            idade /= num_talhoes;

            dap_medio = 0;
            foreach (Talhao tal in talhoes)
            {
                dap_medio += tal.dap_medio;
            }
            dap_medio /= num_talhoes;

        }
        public List<Talhao> talhoes;
        public int num_talhoes;
        public string numero;
        public double idade;
        public double dap_medio;
        public int quant_produtos;
        // public double idade_original;
    }
}
