using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class GerenciadorCliente
    {
        public Estoque estq { get; set; }
        public Usuario user { get; set; }

        public GerenciadorCliente() 
        { 
            estq = new Estoque();
            user = new Usuario(0, string.Empty, 0);
        }
        public void ListarClientes()
        {
            //user.MostrarDetalhes();
        }
        public void AdicionarCliente()
        {

        }
        public void RemoverCliente()
        {

        }
        public void EditarCliente()
        {

        }
       
        public void HistoricoCompra()
        {

        }
    }
}
