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
        public Caixa fun { get; set; }
        public Caixa funG { get; set; }
        public GerenciadorFuncionario()
        {
            funcionarios = new Funcionario();
            caixas = new List<Caixa>();
            gerentes = new List<Gerente>();
            InicializarDados();
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
            Console.WriteLine("-----------------PROFISSÔES---------------------");
            Console.WriteLine("1 - Gerente");
            Console.WriteLine("2 - Caixa");
            Console.WriteLine("Digite qual profissao deseja adicionar");
            int profissaoSelecionada = int.Parse(Console.ReadLine());
            if (profissaoSelecionada == 1)
            {
                CriarGerente();
            }

            else if (profissaoSelecionada == 2)
            {
                CriarGerente();
            }

            else if (profissaoSelecionada > 2 || profissaoSelecionada < 1)
            {
                Console.WriteLine("Erro \nInsira um numero valido");
            }
        }
        public void RemoverFuncionario()
        {
            Console.WriteLine("---------------------PROFISSÕES---------------------");
            Console.WriteLine("1 - Gerente.");
            Console.WriteLine("2 - Caixa.");
            Console.WriteLine("Digite qual profissão deseja alterar.");
            int profissaoSelecionada = int.Parse(Console.ReadLine());
            ListarFuncionariosPorProfissao(profissaoSelecionada);

            Console.WriteLine("Qual id de funcionário você deseja remover");
            int IdFuncionario = int.Parse(Console.ReadLine());

            removerfuncionarios(profissaoSelecionada, IdFuncionario);

        }
        public void EditarFuncionario()
        {
            Console.WriteLine("---------------------PROFISSÕES---------------------");
            Console.WriteLine("1 - Gerente.");
            Console.WriteLine("2 - Caixa.");
            Console.WriteLine("Digite qual profissão deseja alterar.");
            int profissaoSelecionada = int.Parse(Console.ReadLine());
            ListarFuncionariosPorProfissao(profissaoSelecionada);
            Console.WriteLine("Qual id de funcionário você deseja editar");
            int IdFuncionario = int.Parse(Console.ReadLine());

            Console.WriteLine("1 - Nome");
            Console.WriteLine("2 - Idade");
            Console.WriteLine("Qual campo deseja atualizar?");
            int campo = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o novo valor para o campo.");
            string resposta = Console.ReadLine();

            editarFuncionario(profissaoSelecionada, IdFuncionario, campo, resposta);
        }
<<<<<<< HEAD
        public void VerificarSalario()
        {
            Console.WriteLine("digite sua profissao para verificar salario");
            Console.WriteLine("1 - Gerente.");
            Console.WriteLine("2 - Caixa.");
            int acaoselecionada = int.Parse(Console.ReadLine());

            if (acaoselecionada ==1)
            {
                Console.WriteLine("Digite o seu id");
                int id = int.Parse(Console.ReadLine());
                BuscarGerentePorId(id);
                fun.ExibirDetalhesFuncionarios();


            }
            else if (acaoselecionada== 2) 
            {
                Console.WriteLine("Digite o seu id");
                int id = int.Parse(Console.ReadLine());
                BuscarCaixaPorId(id);
                funG.ExibirDetalhesFuncionarios();
            }

        }
=======
        public void VerificarSalario() { }
>>>>>>> cea6144c9c4058b587f6406cc5d82296a3010bc7
        public void CargaHoraria() { }
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
        public void ListarFuncionariosPorProfissao(int profissaoSelecionada)
        {
            if (profissaoSelecionada == 1)
            {
                ListaGerente();
            }
            else if (profissaoSelecionada == 2)
            {
                ListaCaixa();
            }
        }
        public void editarFuncionario(int profissaoSelecionada, int idFuncionario, int campo, string resposta)
        {
            if (profissaoSelecionada == 1)
            {
                Gerente ger = BuscarGerentePorId(idFuncionario);
                if (campo == 1)
                {
                    ger.Nome = resposta;
                }
                else if (campo == 2)
                {
                    ger.Idade = int.Parse(resposta);
                }
            }
            else if (profissaoSelecionada == 2)
            {
                Caixa cax = BuscarCaixaPorId(idFuncionario);
                if (campo == 1)
                {
                    cax.Nome = resposta;
                }
                else if (campo == 2)
                {
                    cax.Idade = int.Parse(resposta);
                }
            }

        }
        public Gerente BuscarGerentePorId(int id)
        {
            foreach (Gerente ger in gerentes)
            {
                if (ger.Id == id)
                {
                    return ger;
                }
            }
            return null;
        }
        public Caixa BuscarCaixaPorId(int id)
        {
            foreach (Caixa cax in caixas)
            {
                if (cax.Id == id)
                {
                    return cax;
                }
            }
            return null;
        }
        public static Caixa CriarCaixa()
        {
            Console.WriteLine("Qual nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do funcionário?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o salário do funcionário?");
            double salario = double.Parse(Console.ReadLine());

            Caixa caixa = new Caixa(1, nome, idade, salario);

            return caixa;
        }

        public static Gerente CriarGerente()
        {
            Console.WriteLine("Qual nome do funcionário?");
            string nome = Console.ReadLine();
            Console.WriteLine("Qual a idade do funcionário?");
            int idade = int.Parse(Console.ReadLine());
            Console.WriteLine("Qual o salário do funcionário?");
            double salario = double.Parse(Console.ReadLine());

            Gerente gerente = new Gerente(1, nome, idade, salario);

            return gerente;
        }
<<<<<<< HEAD
        public void removerfuncionarios(int profissaoSelecionada, int IdFuncionario)
        {
            if (profissaoSelecionada == 1)
            {
                Gerente ger = BuscarGerentePorId(IdFuncionario);
                RemoverGerente(ger);
            }
            else if (profissaoSelecionada == 2)
            {
                Caixa cax = BuscarCaixaPorId(IdFuncionario);
                RemoverCaixa(cax);
            }

        }
        public void RemoverCaixa(Caixa caixa)
        {
            caixas.Remove(caixa);
        }
        public void RemoverGerente(Gerente gerente)
        {
            gerentes.Remove(gerente);
        }


    }
=======
>>>>>>> cea6144c9c4058b587f6406cc5d82296a3010bc7

        public void removerfuncionarios(int profissaoSelecionada, int IdFuncionario)
        {
            if (profissaoSelecionada == 1)
            {
                Gerente ger = BuscarGerentePorId(IdFuncionario);
                RemoverGerente(ger);
            }
            else if (profissaoSelecionada == 2)
            {
                Caixa cax = BuscarCaixaPorId(IdFuncionario);
                RemoverCaixa(cax);
            }

        }

        public void RemoverGerente(Gerente gerente)
        {
            gerentes.Remove(gerente);
        }

        public void RemoverCaixa(Caixa caixa)
        {
            caixas.Remove(caixa);
        }

    }
}
