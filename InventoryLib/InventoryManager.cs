using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryLib
{
    public class InventoryManager
    {
        private List<Produto> _estoque;
        private int _nextId = 1;

        public InventoryManager()
        {
            _estoque = new List<Produto>();
            AdicionarProduto(new Produto(GerarNovoId(), "Blush liquido", 100));
            AdicionarProduto(new Produto(GerarNovoId(), "Primer", 50));
            AdicionarProduto(new Produto(GerarNovoId(), "Perfume", 200));
        }

        
        private int GerarNovoId()
        {
            if (_estoque.Any())
            {
                _nextId = Math.Max(_nextId, _estoque.Max(p => p.Id) + 1);
            }
            return _nextId++;
        }

        /// <param name="produto"
        public void AdicionarProduto(Produto produto)
        {
            if (produto == null)
            {
                throw new ArgumentNullException(nameof(produto), "O produto não pode ser nulo.");
            }

            Produto produtoExistente = _estoque.FirstOrDefault(p => p.Id == produto.Id);

            if (produtoExistente != null)
            {
                produtoExistente.Quantidade += produto.Quantidade;
                Console.WriteLine($"Produto '{produto.Nome}' (ID: {produto.Id}) atualizado. Nova quantidade: {produtoExistente.Quantidade}");
            }
            else
            {
                _estoque.Add(produto);
                Console.WriteLine($"Produto '{produto.Nome}' (ID: {produto.Id}) adicionado ao estoque.");
            }
        }

        /// <param name="produtoId">
        public bool RemoverProduto(int produtoId)
        {
            Produto produtoParaRemover = _estoque.FirstOrDefault(p => p.Id == produtoId);
            if (produtoParaRemover != null)
            {
                _estoque.Remove(produtoParaRemover);
                Console.WriteLine($"Produto '{produtoParaRemover.Nome}' (ID: {produtoParaRemover.Id}) removido do estoque.");
                return true;
            }
            else
            {
                Console.WriteLine($"Produto com ID {produtoId} não encontrado no estoque.");
                return false;
            }
        }

        public List<Produto> ConsultarEstoque()
        {
            return new List<Produto>(_estoque); 
        }
        /// <param name="produtoId">
        public Produto GetProdutoById(int produtoId)
        {
            return _estoque.FirstOrDefault(p => p.Id == produtoId);
        }
    }
}