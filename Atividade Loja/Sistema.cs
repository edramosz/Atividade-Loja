using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Sistema
    {
        private Funcionario Funcionarios { get; set; }
        public void IniciarSistema()
        {
            int acaoSelecionada = -1;
            while (acaoSelecionada != 0)
            {
                ExibirMenu();
                acaoSelecionada = SolicitarAcaoUsuario();
                RealizarAcaoSelecionada(acaoSelecionada);
            }
        }
        private void ExibirMenu()
        {
            Console.WriteLine("SEJA MUITO BEM-VINDO AO NOSSO PROGRAMA DA LOJA THEDS." + "\n\nEscolha a ação a ser feita." + "\n0 - Fechar o sistema." + "\n1 - Entrar como Cliente." + "\n2 - Entrar como Funcionário." + "");
        }
        private int SolicitarAcaoUsuario()
        {
            int acao = -1;
            while (acao < 0 || acao > 2)
            {
                Console.WriteLine("Digite a ação que você deseja realizar.");
                acao = int.Parse(Console.ReadLine());

                if (acao > 2 || acao < 0)
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
                //    case 1:
                //        Gerenciador.ListarFuncionarios();
                //        Console.WriteLine("\n\n");
                //        break;

                case 2:
                    Funcionarios.IniciarMenuFuncionario();
                    //Console.WriteLine("\n\n");
                    break;
            }
        }





    }
}
