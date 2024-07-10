using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    
    public class GerenciadorFuncionario
    {
        private Funcionario funcionarios { get; set; }
        List<Gerente> gerentes = new List<Gerente>();
        List<Caixa> caixas = new List<Caixa>();
        public GerenciadorFuncionario()
        {
          funcionarios = new Funcionario();
        caixas = new List<Caixa>();
            gerentes = new List<Gerente>();
            //InicializarDados();
        }
        private void InicializarDados()
        {
            caixas.Add(new Caixa(1, "Roberto", 39, 1500));
            caixas.Add(new Caixa(2, "Claudio", 38, 1600));
            caixas.Add(new Caixa(3, "Vitor", 21, 2000));

            gerentes.Add(new Gerente(1, "Carla", 35, 10500));
            gerentes.Add(new Gerente(2, "Hugo", 22, 10200));
            gerentes.Add(new Gerente(3, "Pablo", 37, 10600));
        }

        public void ListarFuncionarios() 
        {
            ListaCaixa();
            ListaGerente();
        }
        public void AdicionarFuncionario() 
        {
           
        }
        public void RemoverFuncionario() 
        { 
        
        }
        public void EditarFuncionario () { }
        public void VerificarSalario() { }
        public void CargaHoraria () { }
        public void HistoricoDeVendas() { }

        public void ListaCaixa()
        {
            Console.WriteLine("----Lista Caixa----");
            foreach (Caixa caixa in caixas)
            {
                caixa.ExibirDetalhesFuncionarios();
            }
        }
        public void ListaGerente()
        {
            Console.WriteLine("----Lista Gerente----");
            foreach (Gerente gerente in gerentes)
            {
                gerente.ExibirDetalhesFuncionarios();
            }
        }

    }
}
