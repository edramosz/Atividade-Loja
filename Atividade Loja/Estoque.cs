using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Estoque
    {
        List<ProdutoFisico> ProdutosF { get; set; } = new List<ProdutoFisico>();
        List<ProdutoDigital> ProdutosD { get; set; } = new List<ProdutoDigital>();
        public int ID { get; set; }
        public string Nome { get; set; }
        public double Preço { get; set; }
        public int Qtnd { get; set; }
        public int TipoProduto { get; set; }
        public Estoque()
        {
            InicializarDadosDigital();
            InicializarDadosFisico();
        }
        public void InicializarDadosFisico()
        {
            ProdutosF.Add(new ProdutoFisico(1, "Jogo Payfire Mídia Físico", 17.20, 52));
            ProdutosF.Add(new ProdutoFisico(1, "Blusa", 17.20, 52));
            ProdutosF.Add(new ProdutoFisico(1, "Jogo God of War Mídia Físico", 17.20, 52));
        }
        public void InicializarDadosDigital()
        {
            ProdutosD.Add(new ProdutoDigital(1, "Youtoba", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(2, "", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(3, "Whatsapp 2", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(4, "Netuflixo", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(5, "Jogo Payfire Mídia Digital", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(6, "", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(7, "", 17.20, 52));
        }
        public void PegaDado()
        {
            Console.WriteLine("Qual o tipo do produto?\n1 - Produto Físico\n2 - Produto Digital");
            TipoProduto = int.Parse(Console.ReadLine());
            Console.WriteLine("Diga o nome do produto.");
            Nome = Console.ReadLine();
            Console.WriteLine("Diga o preço do produto.");
            Preço = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga a quantidade em estoque desse produto.");
            Qtnd = int.Parse(Console.ReadLine());
        }
        public void AdicionarProdutos()
        {
            PegaDado();
            switch (TipoProduto)
            {
                case 1:
                    ProdutosF.Add(new ProdutoFisico(ID,Nome,Preço,Qtnd));
                    break;
            }
        }

        public void ListarProdutosF()
        {
            Console.WriteLine("----------PRODUTOS FÍSICOS----------");
            foreach(ProdutoFisico pf in ProdutosF)
            {
                Console.WriteLine($"{pf.Nome} {pf.Qtnd} ---  {pf.Preço}");
            }
        }

    } 
}
