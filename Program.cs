using System;
using Objetos_como_Argumento17.Classes;

namespace Objetos_como_Argumento17
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            
            Produto p1 = new Produto(1, "Read Dead Redempition", 499f);
            Produto p2 = new Produto(2, "GTA 5", 56.9f);
            Produto p3 = new Produto(3, "Detroit Become Human", 120.5f);
            Produto p4 = new Produto(4, "Celeste", 22.9f);

            Carrinho carrinho = new Carrinho();
            carrinho.AdicionarProduto(p1);
            carrinho.AdicionarProduto(p2);
            carrinho.AdicionarProduto(p3);
            carrinho.AdicionarProduto(p4);

            carrinho.MostrarProdutos();

            Produto p5 = new Produto(5, "GTA San Andreas", 120f);
            carrinho.AlterarItem(2, p5); 
            carrinho.MostrarProdutos();

            Console.WriteLine("Deseja Remover algum produto?");
            Console.WriteLine("----------------------------------");
            string resposta = Console.ReadLine();

            if (resposta == "s")
            {
                carrinho.RemoverProduto(p3);
            }
             
                if(resposta == "n")
                {
                    Console.WriteLine("Sistema de remoção finalizado!");
                    Console.WriteLine("----------------------------------");
                }
                carrinho.MostrarProdutos();
            
        }
    }
}
