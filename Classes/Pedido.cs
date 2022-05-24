namespace RevisaoPoo.Classes
{
    public class Pedido
    {
        public Usuario Usuario{get; set;}
        public List <Produto> ListProduto {get; set;}
        public double ValorTotal{get; set;}
        public string Status{get; set;}
        public DateTime Data{get; set;}
    }
    
}