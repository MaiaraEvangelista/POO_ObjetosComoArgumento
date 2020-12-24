using System;
using System.Collections.Generic;

namespace Objetos_como_Argumento17.Classes
{
    public class Carrinho
    {
        public float ValorTotal { get; set; }
        
        List<Produto> carrinho = new List<Produto>();

        public void AdicionarProduto(Produto produto){
            carrinho.Add(produto);
        }

        //Mostrar os produtos do carrinho
        public void MostrarProdutos (){
            if(carrinho != null){
                foreach (Produto item in carrinho)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                    Console.WriteLine($"{item.Codigo}, {item.Nome}, {item.Preco}");
                    Console.ResetColor();
                }
                MostrarTotal();
            }
        }

            //Removendo um produto
            public void RemoverProduto(Produto _produto){
                carrinho.Remove(_produto);
            }

            public void MostrarTotal(){
                ValorTotal=0;
                if (carrinho != null)
                {
                    foreach (var item in carrinho)
                    {
                        ValorTotal += item.Preco;
                    }
                    Console.WriteLine("---------------------------------------");
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"O total do carrinho é: R${ValorTotal}");
                    Console.WriteLine("-----------------------------------------");
                    Console.ResetColor();
                } else{
                    Console.WriteLine("Seu carrinho está vazio!");
                }
            }
                public void AlterarItem(int _codigo, Produto _novoProduto){
                    carrinho.Find(x => x.Codigo == _codigo).Nome = _novoProduto.Nome;
                    carrinho.Find(produto => produto.Codigo == _codigo).Preco = _novoProduto.Preco;
                }
    }
}