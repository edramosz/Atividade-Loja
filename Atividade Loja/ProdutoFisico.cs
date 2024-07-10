using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class ProdutoFisico
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Qtnd { get; set; }
        public ProdutoFisico(int id, string nome, double preço, int qtnd)
        {
            ID = id;
            Nome = nome;
            Preço = preço;
            Qtnd = qtnd;
        }
    }
}
