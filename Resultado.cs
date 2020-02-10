using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simulador
{
    class Resultado
    {
        public Resultado(int regiao, int talhao, int parcela,ref List<Tuple<int, double>> produtos, bool desbaste)
        {
            this.regiao = regiao;
            this.talhao = talhao;
            this.parcela = parcela;
            this.produtos = produtos;
            this.desbaste = desbaste;
            lucro = 0;
            foreach( Tuple<int,double> x in produtos)
            {
                lucro += x.Item2;
            }
        }
        public int regiao;
        public int talhao;
        public int parcela;
        public List<Tuple<int, double>> produtos = new List<Tuple<int, double>>();
        public bool desbaste;
        public double lucro;
    
    }
}
