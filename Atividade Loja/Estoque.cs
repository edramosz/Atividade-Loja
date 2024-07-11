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
        public int TipoProduto { get; set; }
        public Estoque()
        {
            InicializarDadosDigital();
            InicializarDadosFisico();
        }
        public void InicializarDadosFisico()
        {
            ProdutosF.Add(new ProdutoFisico(1, "Jogo Payfire Mídia Físico", 17.20, 52));
            ProdutosF.Add(new ProdutoFisico(2, "Blusa", 17.20, 52));
            ProdutosF.Add(new ProdutoFisico(3, "Jogo God of War Mídia Físico", 17.20, 52));
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
        public void AdicionarProdutos(ProdutoFisico pf, ProdutoDigital pd)
        {
            Console.WriteLine("Qual o tipo do produto?\n1 - Produto Físico\n2 - Produto Digital");
            TipoProduto = int.Parse(Console.ReadLine());
            if(TipoProduto == 1)
            {
                pf.ID = IdAutomaticoF();
                Console.WriteLine("Diga o nome do produto.");
                pf.Nome = Console.ReadLine();
                Console.WriteLine("Diga o preço do produto.");
                pf.Preço = double.Parse(Console.ReadLine());
                Console.WriteLine("Diga a quantidade em estoque desse produto.");
                pf.Qtnd = int.Parse(Console.ReadLine());

                ProdutosF.Add(new ProdutoFisico(pf.ID, pf.Nome, pf.Preço, pf.Qtnd));
            }
            else if(TipoProduto == 2)
            {
                pd.ID = IdAutomaticoD();
                Console.WriteLine("Diga o nome do produto.");
                pd.Nome = Console.ReadLine();
                Console.WriteLine("Diga o preço do produto.");
                pd.Preço = double.Parse(Console.ReadLine());
                Console.WriteLine("Diga a quantidade em estoque desse produto.");
                pd.Qtnd = int.Parse(Console.ReadLine());

                ProdutosD.Add(new ProdutoDigital(pd.ID, pd.Nome, pd.Preço, pd.Qtnd));
            }
            
        }
        public void ListarProdutosF()
        {
            Console.WriteLine("----------PRODUTOS FÍSICOS----------");
            foreach(ProdutoFisico pf in ProdutosF)
            {
                Console.WriteLine($"{pf.ID} {pf.Nome} {pf.Qtnd} ---  ${pf.Preço}");
            }
        }
        public void ListarProdutosD()
        {
            Console.WriteLine("----------PRODUTOS DIGITAIS----------");
            foreach (ProdutoDigital pd in ProdutosD)
            {
                Console.WriteLine($"{pd.ID} {pd.Nome} {pd.Qtnd} ---  ${pd.Preço}");
            }
        }
        public int IdAutomaticoF()
        {
            int id = 0;
            foreach(ProdutoFisico pf in ProdutosF)
            {
                id = pf.ID;       
            }
            return id;
        }
        public int IdAutomaticoD()
        {
            int id = 0;
            foreach (ProdutoDigital pd in ProdutosD)
            {
                id = pd.ID;
            }
            return id;
        }

    } 
}
