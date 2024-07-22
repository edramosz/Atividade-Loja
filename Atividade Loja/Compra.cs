using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Compra : Estoque
    {
        
        public GerenciadorCliente gc { get; set; }

        public Compra()
        {
            //carrinho = new List<Compra>();
            gc = new GerenciadorCliente();
        }
       
    }
}
