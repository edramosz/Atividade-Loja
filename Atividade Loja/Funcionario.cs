using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{

    public class Funcionario
    {
    
        List<Funcionario> funcionarios = new List<Funcionario>();
        private GerenciadorFuncionario funcionarios { get; set; }

        public Funcionario()
        {
           funcionarios = new GerenciadorFuncionario();
        }


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

        public void ExibirMenuFuncionario()
        {
            Console.WriteLine("Você deseja fazer qual das seguintes opções?" + "\n0 - Fechar o Sistema." + "\n1 - Listar Funcionário." + "\n2 - Adicionar Funcionário." + "\n3 - Remover Funcionário." + "\n4 - Editar Funcionário." + "\n5 - Verificar Salário." + "\n6 - Carga Horária." + "\n7 - Histórico de Vendas." + "");
            
        }
        private void RealizarAcaoSelecionada(int acaoSelecionada)
        {
            switch (acaoSelecionada)
            {
               case 1:
                    funcionarios.ListarFuncionarios();
                    Console.WriteLine("\n\n");
                    break;

                case 2:
                    funcionarios.AdicionarFuncionario();
                    Console.WriteLine("\n\n");
                    break;

                 case 3:
                    funcionarios.RemoverFuncionario();
                    Console.WriteLine("\n\n");
                    break;

               case 4:
                    funcionarios.EditarFuncionario();
                    Console.WriteLine("\n\n");
                    break;

            //    case 5:
            //        VerificarSalario();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 6:
            //        CargaHoraria();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 7:
            //        HistoricoVenda();
            //        Console.WriteLine("\n\n");
            //        break;
            }
        }


        }
    } 
