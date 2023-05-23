using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EncapsulamentoEProperties
{
    public class Produto
    {
        private string _nome { get; set; }
        private double _preco { get; set; }
        private int _quantidade { get; set; }

        public Produto() { }

        public Produto(
            string nome,
            double preco,
            int quantidade) 
        {  
            _nome = nome;
            _preco = preco;
            _quantidade = quantidade;
        }

        public string GetNome()
        {
            return _nome;
        }

        public void SetNome(string nome)
        {
            if (nome != null && nome.Length > 1) {
                _nome += nome; 
            }
        }

        public double GetPreco() 
        { 
            return _preco;
        }

        public int GetQuantidade() 
        { 
            return  _quantidade;
        }

        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }

        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
    }
}
