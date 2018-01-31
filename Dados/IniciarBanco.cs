using System.Linq;
using LojaWebEF.Models;

namespace LojaWebEF.Dados
{
    public class IniciarBanco
    {
        public static void Inicializar(LojaContexto contexto){
            contexto.Database.EnsureCreated();
            if (contexto.Cliente.Any()){
                return;
            }
            
            //var recebe coleção ou objeto simples.
            var cliente = new Cliente(){
                Nome="João",Email="joao@terra.com.br",Idade = 23
            };
            contexto.Cliente.Add(cliente);

            var produto = new Produto(){
                NomeProduto = "Mouse", Descricao="Mouse com laser", Preco = 25.30M, Quantidade = 50
            };

            contexto.Produto.Add(produto);

            var pedido = new Pedido(){
                IdProduto = produto.IdProduto, IdCliente = cliente.IdCliente, Quantidade = 60
            };

            contexto.Pedido.Add(pedido);
            contexto.SaveChanges();
        }
    }
}