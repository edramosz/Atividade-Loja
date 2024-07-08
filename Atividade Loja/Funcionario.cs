﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
   
    public class Funcionario
    {
        public double salario { get; set; }
    
        List<Funcionario> funcionarios = new List<Funcionario>();

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
        private void RealizarAcaoSelecionada(int acaoSelecionada)
        {
            switch (acaoSelecionada)
            {
                case 1:
                    Clientes.IniciarMenuCliente();
                    Console.WriteLine("\n\n");
                    break;

                case 2:
                    Funcionarios.IniciarMenuFuncionario();
                    Console.WriteLine("\n\n");
                    break;
            }
        }
        public void ExibirMenuFuncionario()
        {
            Console.WriteLine("Você deseja fazer qual das seguintes opções?" + "\n0 - Fechar o Sistema." + "\n1 - Listar Funcionário." + "\n2 - Adicionar Funcionário." + "\n3 - Remover Funcionário." + "\n4 - Editar Funcionário." + "\n5 - Verificar Salário." + "\n6 - Carga Horária." + "\n7 - Histórico de Vendas." + "");
        }
        public void listarfuncionarios() 
        {
            foreach (Funcionario fun in funcionarios) 
            {
                Console.WriteLine($"Funcionario: {fun.funcionarios}");
            }
        }
        public void calcularbonificacao()
            bonificacao = salario + (salario * 0.25);
        }

        public void adicionarfuncionario()
        {
            listarfuncionarios();
        }

        private void EditarFuncionario()
        {
            throw new NotImplementedException();
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
            //        ListarFuncionarios();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 2:
            //        AdicionarFuncionário();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 3:
            //        RemoverFuncionario();
            //        Console.WriteLine("\n\n");
            //        break;

            //    case 4:
            //        EditarFuncionario();
            //        Console.WriteLine("\n\n");
            //        break;

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
            //}
        }

        
    }
}
