using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Usuario
    {
        public Usuario() 
        {
            InicializadorUsuario();
        }
        List<Usuario> usuarios { get; set; } = new List<Usuario>();
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public Usuario(int id, string nome, int idade) 
        { 
            Nome = nome;
            Idade = idade;
        }

        public void InicializadorUsuario()
        {
            usuarios.Add(new Usuario(1, "Edson", 16));
            usuarios.Add(new Usuario(2, "Hugo", 19));
            usuarios.Add(new Usuario(3, "Thulio", 26));
            usuarios.Add(new Usuario(4, "Pedro", 29));
            usuarios.Add(new Usuario(5, "Vinicius", 33));
        }
    }
}
