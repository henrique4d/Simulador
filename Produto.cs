using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Produto
    {
        public Produto(int numero, double min, double max, double l, double preco, string nome)
        {
            this.nome = nome;
            this.l = l;
            this.numero = numero;
            this.min = min;
            this.max = max;
            this.preco = preco;
            volume = 0;
        }

        double calcula_lucro()
        {
            lucro_final = volume * preco;
            return volume * preco;
        }
        public double min;
        public double max;
        public int numero;
        public double volume;
        public double l;
        public double preco;
        public double lucro_final;
        public string nome;
    }
}
