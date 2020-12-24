namespace Objetos_como_Argumento17.Classes
{
    public class Produto
    {
        public int Codigo {get; set;}

        public string Nome{get; set;}

        public float Preco {get; set;}

        //Primeiro método Construtor
        public Produto(){

        }

        //Segundo método Construtor
        public Produto (int _codigo, string _nome, float _preco ){
           this.Codigo = _codigo;
           this.Nome = _nome;
           this.Preco = _preco;

        }
    }
}