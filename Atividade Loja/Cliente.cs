using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Cliente
    {
        public Estoque estq { get; set; }
        public GerenciadorCliente gC { get; set; }
        public Compra cp { get; set; }

        public Cliente() 
        { 
            estq = new Estoque();
            gC = new GerenciadorCliente();
        }
        public void IniciarMenuCliente()
        {
            //erro aqui abaixo por conta da falta de ação dentro do menu funcionário.
            int acaoSelecionada = -1;
            while (acaoSelecionada != 0)
            {
                ExibirMenuCliente();
                acaoSelecionada = SolicitarAcaoUsuario();
                RealizarAcaoSelecionada(acaoSelecionada);
            }
        }
        public void ExibirMenuCliente()
        {
            Console.WriteLine("Você deseja fazer qual das seguintes opções?" + "\n0 - Fechar o Sistema." + "\n1 - Listar Clientes"  + "\n2 - Adicionar Cliente" + "\n3 - Remover Cliente" + "\n4 - Editar Cliente" + "\n5 - Ver Produtos" + "\n6 - Histórico de Compras.");
        }
        private int SolicitarAcaoUsuario()
        {
            int acao = -1;
            while (acao < 0 || acao > 6)
            {
                Console.WriteLine("Digite a ação que você deseja realizar.");
                acao = int.Parse(Console.ReadLine());

                if (acao > 6 || acao < 0)
                {
                    Console.WriteLine("Número inválido!!\nFavor digite um número válido.");
                }
            }
            return acao;
        }
      
        private void RealizarAcaoSelecionada(int acaoSelecionada)
        {
            switch (acaoSelecionada)
            {
                case 1:
                    //listarclientes();
                    //console.writeline("\n\n");
                    break;

                case 2:
                    //adicionarclientes();
                    //console.writeline("\n\n");
                    break;

                case 3:
                    //removercliente();
                    //console.writeline("\n\n");
                    break;

                case 4:
                    //editar();
                    //console.writeline("\n\n");
                    break;

                case 5:
                    estq.MostrarProdutos();
                    //console.writeline("\n\n");
                    break;

                case 6:
                    //historicocompra();
                   // console.writeline("\n\n");
                    break;

                //case 7:
                    //cp.compra();
                    //break;
            }
        }

        
    }
}
