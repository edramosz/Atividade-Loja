using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Caixa
    {
        private GerenciadorFuncionario fun { get; set; }

        public Caixa()
        {
            fun = new GerenciadorFuncionario();
        }

        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        private double BonusAnual { get; set; }

        public Caixa(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
            BonusAnual = (Salario * 0.3);
        }
        private void AplicarBonificaçãoAnual()
        {
            Console.WriteLine("Sua bonificação será: " + BonusAnual);
        }
        private void AvancarProgressaoAnual()
        {
            Salario = Salario + (Salario * 0.20);
            Console.WriteLine("Seu novo salário é " + Salario);
        }

        public void RealizarBalancoAnualFuncionario()
        {
            Console.WriteLine("--------------Balanço Geral-------------");
            Console.WriteLine("Id: " + Id);
            Console.WriteLine("Funcionário: " + Nome);
            AplicarBonificaçãoAnual();
            AvancarProgressaoAnual();
        }
        public void ExibirDetalhesFuncionarios()
        {
            Console.WriteLine($"------ Funcionario {Id}------" +
                              $"\nNome: {Nome}" +
                              $"\nIdade: {Idade}" +
                              $"\nSalário: {Salario}" +
                              $"\n-----------------------------");
        }
        public void AlterarID(int id)
        {
            Id = id;
        }
        public void AumentarSalario()
        {
            Salario = Salario + (Salario * 0.1);
        }
    }
}
