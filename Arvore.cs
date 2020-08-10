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
        public Arvore(string regiao, string talhao, double idade, double dap, double altura, string parcela, double area_parcela, int fila, int numero, string material_genetico)
        {
            this.regiao = regiao;
            this.talhao = talhao;
            this.idade = idade;
            this.dap = dap;
            this.altura = altura;
            this.area_basal = Math.PI * Math.Pow(dap, 2) / 40000;
            this.parcela = parcela;
            this.area_parcela = area_parcela;
            this.fila = fila;
            this.numero = numero;
            this.material_genetico = material_genetico;
        }

        public string regiao;
        public string talhao;
        public string parcela;
        public double idade;
        public double dap;
        public double altura;
        public double area_basal;
        public double area_parcela;
        public int fila;
        public int numero;
        public string material_genetico;
    }
}
