

namespace InventoryLib
{
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }

        public Produto(int id, string nome, int quantidade)
        {
            Id = id;
            Nome = nome;
            Quantidade = quantidade;
        }

        public override bool Equals(object obj)
        {
            return obj is Produto produto &&
                   Id == produto.Id;
        }

        public override int GetHashCode()
        {
            return HashCode.Combine(Id);
        }

        public override string ToString()
        {
            return $"{Nome} (ID: {Id}) - Quantidade: {Quantidade}";
        }
    }
}