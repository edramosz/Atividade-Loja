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
        private GerenciadorFuncionario GerFuncionario { get; set; }
        private Estoque estq { get; set; }

        public Funcionario()
        {
           GerFuncionario = new GerenciadorFuncionario();
            estq= new Estoque();
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
            Console.WriteLine("Você deseja fazer qual das seguintes opções?" + "\n0 - Fechar o Sistema." + "\n1 - Listar Funcionário." + "\n2 - Adicionar Funcionário." + "\n3 - Remover Funcionário." + "\n4 - Editar Funcionário." + "\n5 - Verificar Salário." + "\n6 - Carga Horária." + "\n7 - Adicionar produtos." + "\n8 - Excluir produtos." + "\n9 - Editar produtos." + "\n10 - Histórico de Vendas.");
            
        }
        private void RealizarAcaoSelecionada(int acaoSelecionada)
        {
            switch (acaoSelecionada)
            {
               case 1:
                    GerFuncionario.ListarFuncionarios();
                    Console.WriteLine("\n\n");
                    break;

                case 2:
                    GerFuncionario.AdicionarFuncionario();
                    Console.WriteLine("\n\n");
                    break;

                 case 3:
                    GerFuncionario.RemoverFuncionario();
                    Console.WriteLine("\n\n");
                    break;

               case 4:
                    GerFuncionario.EditarFuncionario();
                    Console.WriteLine("\n\n");
                    break;

                case 5:
                    GerFuncionario.VerificarSalario();
                    Console.WriteLine("\n\n");
                    break;

                case 6:
                    GerFuncionario.CargaHoraria();
                    Console.WriteLine("\n\n");
                    break;

                case 7:
                    Console.WriteLine("Qual o tipo de produto?");
                    Console.WriteLine("1 - Físico    2 - Digital");
                    int resposta = int.Parse(Console.ReadLine());
                    if(resposta == 1)
                    {
                        estq.AdicionarProdutoFisico();
                        Console.WriteLine("\n\n");
                    }
                    else if(resposta == 2)
                    {
                        estq.AdicionarProdutoDigital();
                        Console.WriteLine("\n\n");
                    }
                    else
                    {
                        Console.WriteLine("Número inválido.");
                        RealizarAcaoSelecionada(7);
                    }
                    break;

                    //     case 7:
                    //        estq.Adicionar();
                    //        Console.WriteLine("\n\n");
                    //        break;
            }
        }


        }
    } 
