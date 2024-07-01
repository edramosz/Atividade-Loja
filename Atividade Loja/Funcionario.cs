using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Funcionario
    {
        public void IniciarMenuFuncionario()
        {
            //erro aqui abaixo por conta da falta de ação dentro do menu funcionário.
            int acaoSelecionada = -1;
            while (acaoSelecionada != 0)
            {
                ExibirMenuFuncionario();
                acaoSelecionada = SolicitarAcaoUsuario();
                RealizarAcaoSelecionada(acaoSelecionada);
            }
        }
        public void ExibirMenuFuncionario()
        {
            Console.WriteLine("Você deseja fazer qual das seguintes opções?" + "\n0 - Fechar o Sistema." + "\n1 - Verificar Salário." + "\n2 - Carga Horária." + "\n3 - Histórico de Vendas." + "");
        }
        private int SolicitarAcaoUsuario()
        {
            int acao = -1;
            while (acao < 0 || acao > 3)
            {
                Console.WriteLine("Digite a ação que você deseja realizar.");
                acao = int.Parse(Console.ReadLine());

                if (acao > 3 || acao < 0)
                {
                    Console.WriteLine("Número inválido!!\nFavor digite um número válido.");
                }
            }
            return acao;
        }
        private void RealizarAcaoSelecionada(int acaoSelecionada)
        {
            //switch (acaoSelecionada)
            //{
            //    case 1:
            //        Gerenciador.ListarFuncionarios();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 2:
            //        CalcularBonificacao();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 3:
            //        AdicionarFuncionario();
            //        Console.WriteLine("\n\n");
            //        break;
            //}
        }
    }
}
