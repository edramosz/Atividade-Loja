using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Loja
{
    public class Estoque
    {
    
       List<ProdutoFisico> ProdutosF { get; set; } = new List<ProdutoFisico>();
        List<ProdutoDigital> ProdutosD { get; set; } = new List<ProdutoDigital>();

        public void InicializarDados()
        {
            ProdutosF.Add(new ProdutoFisico(1,"arroz",17.20, 52)); 
        }

        
    } 
}
