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
        List<Produto> carrinho { get; set; } = new List<Produto> { };
        public int TipoProduto { get; set; }
        public Estoque()
        {
            InicializarDadosDigital();
            InicializarDadosFisico();
        }
        public void InicializarDadosFisico()
        {
            ProdutosF.Add(new ProdutoFisico(1, "Mouse Logitech G40", 149.65, 625));
            ProdutosF.Add(new ProdutoFisico(2, "Monitor AOC 144hz", 755.69, 52));
            ProdutosF.Add(new ProdutoFisico(3, "Teclado Redragon", 98.69, 90));
            ProdutosF.Add(new ProdutoFisico(4, "Fonte de Alimentação 550W", 420.50, 63));
            ProdutosF.Add(new ProdutoFisico(5, "Water Cooler ", 199.99, 260));
            ProdutosF.Add(new ProdutoFisico(6, "Processador ryzen7", 1009.20, 104));
        }
        public void InicializarDadosDigital()
        {
            ProdutosD.Add(new ProdutoDigital(1, "Youtoba", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(3, "Whatsapp 2", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(4, "Netuflixo", 17.20, 52));
            ProdutosD.Add(new ProdutoDigital(5, "Jogo Payfire Mídia Digital", 17.20, 52));

        }
       

        private Produto CriarProduto(int id)
        {
            Produto produto = new Produto();
            produto.ID = id;
            Console.WriteLine("Diga o nome do produto.");
            produto.Nome = Console.ReadLine();
            Console.WriteLine("Diga o preço do produto.");
            produto.Preço = double.Parse(Console.ReadLine());
            Console.WriteLine("Diga a quantidade em estoque desse produto.");
            produto.Qtnd = int.Parse(Console.ReadLine());

            return produto;
        }

        public void AdicionarProdutoFisico()
        {
            int id = ProdutosF.Max(x => x.ID) + 1;
            Produto produto = CriarProduto(id);
            ProdutoFisico fisico = new ProdutoFisico(produto.ID, produto.Nome, produto.Preço, produto.Qtnd);
            ProdutosF.Add(fisico);
        }
        public void AdicionarProdutoDigital()
        {
            int id = ProdutosD.Max(x => x.ID) + 1;

            Produto produto = CriarProduto(id);
            ProdutoDigital digital = new ProdutoDigital(produto.ID, produto.Nome, produto.Preço, produto.Qtnd);

            ProdutosD.Add(digital);
        } 
        public void ExcluirProdutoDigital(int id)
        {           
            ProdutoDigital pd = BuscarProdutoDigitalPorID(id);
            ProdutosD.Remove(pd);
        }

        private ProdutoDigital BuscarProdutoDigitalPorID(int id)
        {
            foreach (ProdutoDigital pd in ProdutosD)
            {
                if (pd.ID == id)
                {
                    return pd;
                }
            }

            return null;
        }
        public void ExcluirProdutoFisico(int id)
        {
            ProdutoFisico pd = BuscarProdutoFisicoPorID(id);
            ProdutosF.Remove(pd);
        }

        private ProdutoFisico BuscarProdutoFisicoPorID(int id)
        {
            foreach (ProdutoFisico pd in ProdutosF)
            {
                if (pd.ID == id)
                {
                    return pd;
                }
            }

            return null;
        }

        public void EditarProdutoDigital(int id)
        {
            foreach (ProdutoDigital pd in ProdutosD)
            {
                if (pd.ID == id)
                {
                    Console.WriteLine("Qual campo você deseja alterar?");
                    Console.WriteLine("1 - Nome\n2 - Preço\n3 - Quantidade");
                    int resposta = int.Parse(Console.ReadLine());
                    if(resposta == 1)
                    {
                        Console.WriteLine("Diga o novo valor.");
                        pd.Nome = Console.ReadLine();
                    }
                    else if(resposta == 2)
                    {
                        Console.WriteLine("Diga o novo valor.");
                        pd.Preço = double.Parse(Console.ReadLine());
                    }
                    else if(resposta == 3)
                    {
                        Console.WriteLine("Diga o novo valor.");
                        pd.Qtnd = int.Parse(Console.ReadLine());
                    }                   
                }
            }
        }
        public void EditarProdutoFisico(int id)
        {
            foreach (ProdutoFisico pf in ProdutosF)
            {
                if (pf.ID == id)
                {
                    Console.WriteLine("Qual campo você deseja alterar?");
                    Console.WriteLine("1 - Nome\n2 - Preço\n3 - Quantidade");
                    int resposta = int.Parse(Console.ReadLine());
                    if (resposta == 1)
                    {
                        Console.WriteLine("Diga o novo valor.");
                        pf.Nome = Console.ReadLine();
                    }
                    else if (resposta == 2)
                    {
                        Console.WriteLine("Diga o novo valor.");
                        pf.Preço = double.Parse(Console.ReadLine());
                    }
                    else if (resposta == 3)
                    {
                        Console.WriteLine("Diga o novo valor.");
                        pf.Qtnd = int.Parse(Console.ReadLine());
                    }
                }
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
        public void compraF()
        {
            Console.WriteLine("Quer adicionar qual produto para o carrinho pelo seu id?");
            int id = int.Parse(Console.ReadLine());
            foreach (ProdutoFisico e in ProdutosF)
            {
                carrinho.Add(e);
            }
            foreach (Produto f in carrinho)
                Console.WriteLine(f.Nome);
            Console.WriteLine("Deseja adicionar mais algum?");
        }

        public void MostrarProdutos()
        {
            Console.WriteLine("1 - Deseja ver produtos só fisicos? \n" + "2 - Deseja ver só produtos digitais?\n");
            int acao = int.Parse(Console.ReadLine());
            if (acao == 1)
            {
                ListarProdutosF();
                compraF();

            }

            else if (acao == 2)
            {
                ListarProdutosD();
            }
        }


    } 
}
