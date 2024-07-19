using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class GerenciadorCliente
    {
        public Estoque estq { get; set; }
        public void ListarClientes()
        {
            
        }
        public void AdicionarCliente()
        {

        }
        public void RemoverCliente()
        {

        }
        public void EditarCliente()
        {

        }
        public void MostrarProdutos()
        {
            Console.WriteLine("1 - Deseja ver todos produtos? \n" + "2 - Deseja ver só produtos digitais?\n" + "3 - Deseja ver produtos só fisicos?");
            int acao = int.Parse(Console.ReadLine());
            switch (acao)
            {
                case 1:
                estq.ListarProdutosD();
                estq.ListarProdutosF();

                    break;
                case 2:
                    estq.ListarProdutosD();
                    break;

                case 3:
                    estq.ListarProdutosF();
                    break;
            }
            

        }
        public void HistoricoCompra()
        {

        }
    }
}
