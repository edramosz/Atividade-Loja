using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    internal class Gerente
    {
        List<Gerente>gerentes = new List<Gerente>();
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        private double Salario { get; set; }
        private double BonusAnual { get; set; }

        public Gerente(int id, string nome, int idade, double salario)
        {
            Id = id;
            Nome = nome;
            Idade = idade;
            Salario = salario;
            BonusAnual = (Salario * 0.3);
        }


    }
}
