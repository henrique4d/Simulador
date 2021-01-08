using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*fazer media das idades*/ 

namespace Simulador
{
    class Arvore
    {
        public Arvore(string regiao, string talhao, double area_talhao, string parcela, string material_genetico, double idade, double area_parcela, int fila, int numero, double dap, double altura )
        {
            this.regiao = regiao;
            this.talhao = talhao;
            this.area_talhao = area_talhao;
            this.parcela = parcela;
            this.material_genetico = material_genetico;
            this.idade = idade;
            this.idade_original = idade;
            this.area_parcela = area_parcela;
            this.fila = fila;
            this.numero = numero;
            this.dap = dap;
            this.altura = altura;
            this.area_basal = Math.PI * Math.Pow(dap, 2) / 40000;
        }

        public string regiao;
        public string talhao;
        public double area_talhao;
        public string parcela;
        public double idade;
        public double idade_original;
        public double dap;
        public double altura;
        public double area_basal;
        public double area_parcela;
        public int fila;
        public int numero;
        public string material_genetico;
    }
}
